using MediatR;
using Microsoft.AspNetCore.Mvc;
using ToDo.Application.Tasks.Commands.CreateTask;
using ToDo.Contract.Tasks.CreateTask;
using ToDo.Domain.Entities;

namespace ToDo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TasksController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> CreateTask(CreateTaskRequestDto request)
        {
          
            var command = new CreateTaskCommand(request.TaskTitile , request.TaskDescription , request.DueDate);
            var result = await _mediator.Send(command);

            if (result.IsError)
            {
                var error = result.FirstError;
                return BadRequest(new { error = error.Description });
            }

            return CreatedAtAction(nameof(CreateTask), new { id = result.Value }, result.Value);
        }
    }
}
