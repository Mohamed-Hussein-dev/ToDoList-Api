using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities;

namespace ToDo.Application.Tasks.Commands.UpdateTask
{
    public record UpdateTaskCommand(TaskItem Task) : IRequest<ErrorOr<Updated>>;
}
