using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Application.Tasks.Commands.CheckTask
{
    public record CheckTaskCommand(int taskId, string userId) : IRequest<ErrorOr<Updated>>;
}
