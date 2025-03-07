using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities;
using MediatR;
using ErrorOr;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ToDo.Application.Tasks.Commands.CreateTask
{
    public record CreateTaskCommand(string TaskTitle , string ?TaskDescription , DateTime? DueDate) : IRequest<ErrorOr<int>>;
}
