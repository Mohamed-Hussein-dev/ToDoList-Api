using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Application.Accounts.Register
{
    public record UserRegisterCommand(string FirstName , string LastName , string Email , string Password) : IRequest<ErrorOr<string>>;
    
    
}
