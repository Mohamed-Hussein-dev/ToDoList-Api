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

namespace ToDo.Application.Accounts.Register
{
    
    public class RegisterCommandHandler : IRequestHandler<UserRegisterCommand , ErrorOr<string>>
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ITokenGenerator _tokenGenerator;

        public RegisterCommandHandler(UserManager<AppUser> userManager , ITokenGenerator tokenGenerator ) 
        {
            _userManager = userManager;
            this._tokenGenerator = tokenGenerator;
        }

        public async Task<ErrorOr<string>> Handle(UserRegisterCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync( request.Email );

            if( user != null ) {

                return Error.Conflict(code: "User.DuplicateEmail", description: "Email has been registered already!");
            }

            var newUser = new AppUser { 
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                UserName = request.Email
            };

            var CreateNewUserResult = await _userManager.CreateAsync(newUser, request.Password);

            if(!CreateNewUserResult.Succeeded) {

                return Error.Failure(code: "Failed to Create new User");
            }

            
            await _userManager.AddToRoleAsync(newUser, "User");
            

            var Token = await _tokenGenerator.GenerateTokenAsync(newUser, _userManager);

            if( Token != null )
                return Token;

            return Error.Failure(code: "JWT.Faliure", description: "Can't Generate Token");
        }
    }
}
