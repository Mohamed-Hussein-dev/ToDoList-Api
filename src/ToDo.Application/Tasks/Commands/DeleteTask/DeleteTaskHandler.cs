using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Common.Interfaces;

namespace ToDo.Application.Tasks.Commands.DeleteTask
{
    public class DeleteTaskHandler : IRequestHandler<DeleteTaskCommand, ErrorOr<Deleted>>
    {
        private readonly ITaskRepostory _taskRepostory;

        public DeleteTaskHandler(ITaskRepostory taskRepostory)
        {
            _taskRepostory = taskRepostory;
        }
        public async Task<ErrorOr<Deleted>> Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
        {
            var task = await _taskRepostory.GetTaskAsync(request.taskId);
            if(task == null)
            {
                return Error.NotFound(description: "Task Not Found");
            }
            await _taskRepostory.DeleteTaskAsync(task);

            return Result.Deleted;
        }
    }
}
