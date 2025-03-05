using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Common.Interfaces;
using ToDo.Domain.Entities;

namespace ToDo.Application.Tasks.Queries.GetTask
{
    public class GetTaskHandler : IRequestHandler<GetTaskCommand, ErrorOr<TaskItem>>
    {
        
        private readonly ITaskRepostory _taskRepostory;

        public GetTaskHandler(ITaskRepostory taskRepostory) {
            _taskRepostory = taskRepostory;
        }
        public async Task<ErrorOr<TaskItem>> Handle(GetTaskCommand request, CancellationToken cancellationToken)
        {
            var task = await _taskRepostory.GetTaskAsync(request.taskId);
            if (task == null) {
                return Error.NotFound(description: "Task Not Found");
            }
            return task;
        }
    }
}
