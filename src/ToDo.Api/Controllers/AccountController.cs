using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using ToDo.Application.Accounts.Register;
using ToDo.Contract.Account;

namespace ToDo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            this._mediator = mediator;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterRequestDto request)
        {
            var command = new UserRegisterCommand(request.FristName,request.LastName,request.Email,request.Password);

            var result = await _mediator.Send(command);   

            if(result.IsError)
            {
                var erroe = result.FirstError;
                return BadRequest(new {Erroe = erroe});
            }

            return CreatedAtAction(nameof(Register) , new {Token = result.Value});
        }
    }
}
