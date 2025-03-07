using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Common.Interfaces;

namespace ToDo.Application.Tasks.Commands.UpdateTask
{
    public class UpdateTaskHandler : IRequestHandler<UpdateTaskCommand, ErrorOr<Updated>>
    {
        private readonly ITaskRepostory _taskRepostory;

        public UpdateTaskHandler(ITaskRepostory taskRepostory)
        {
            this._taskRepostory = taskRepostory;
        }
        public async Task<ErrorOr<Updated>> Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
        {
            var task = await _taskRepostory.GetTaskAsync(request.Task.Id);

            if (task == null) {
                return Error.NotFound(description: "Not Found Task");
            }

            await _taskRepostory.UpdateTaskAsync(request.Task);

            return Result.Updated;
        }
    }
}
