using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Application.Accounts.LogIn
{
    public record LogInCommand(string Email , string PassWord) : IRequest<ErrorOr<string>>;
}
