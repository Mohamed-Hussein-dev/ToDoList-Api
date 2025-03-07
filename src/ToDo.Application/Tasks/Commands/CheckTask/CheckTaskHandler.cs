using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Common.Interfaces;

namespace ToDo.Application.Tasks.Commands.CheckTask
{
    public class CheckTaskHandler : IRequestHandler<CheckTaskCommand, ErrorOr<Updated>>
    {
        public readonly ITaskRepostory _taskRepostory;

        public CheckTaskHandler(ITaskRepostory taskRepostory)
        {
            _taskRepostory = taskRepostory;
        }

        public async Task<ErrorOr<Updated>> Handle(CheckTaskCommand request, CancellationToken cancellationToken)
        {
            var task = await _taskRepostory.GetTaskAsync(request.taskId);

            if(task is null)
            {
                return Error.NotFound(description :  "Task not found");
            }

            task.IsCompleted = !task.IsCompleted;

            await _taskRepostory.UpdateTaskAsync(task);

            return Result.Updated;
        }
    }
}
