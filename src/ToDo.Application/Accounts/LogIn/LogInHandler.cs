using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Common.Interfaces;
using ToDo.Domain.Entities;

namespace ToDo.Application.Accounts.LogIn
{
    public class LogInHandler : IRequestHandler<LogInCommand, ErrorOr<string>>
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private ITokenGenerator _TokenGenerator;

        public LogInHandler(SignInManager<AppUser> signInManager , UserManager<AppUser> userManager , ITokenGenerator tokenGenerator)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _TokenGenerator = tokenGenerator;
        }

      

        public async Task<ErrorOr<string>> Handle(LogInCommand request, CancellationToken cancellationToken)
        {
            var SignInResult = await _signInManager.PasswordSignInAsync(request.Email, request.PassWord, false , false);

            if(SignInResult.Succeeded)
            {
                var user = await _userManager.FindByEmailAsync(request.Email);
                if (user == null)
                    return Error.NotFound("User.NotFound", $"User with Email {request.Email} , not Found");
                var token = await _TokenGenerator.GenerateTokenAsync(user, _userManager);
                return token;
            }
            return Error.Failure("User.FailuerToLogIn", "Email or Password not Correct");
        }
    }
}
