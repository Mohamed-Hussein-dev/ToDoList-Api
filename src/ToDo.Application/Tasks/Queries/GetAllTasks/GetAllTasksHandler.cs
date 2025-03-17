using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Common.Interfaces;
using ToDo.Domain.Entities;

namespace ToDo.Application.Tasks.Queries.GetAllTasks
{
    public class GetAllTasksHandler : IRequestHandler<GetAllTasksCommand, ErrorOr<List<TaskItem>>>
    {
        private readonly ITaskRepostory _taskRepostory;

        public GetAllTasksHandler(ITaskRepostory taskRepostory)
        {
            this._taskRepostory = taskRepostory;
        }

        public async Task<ErrorOr<List<TaskItem>>> Handle(GetAllTasksCommand request, CancellationToken cancellationToken)
        {
            var result = await _taskRepostory.GetAllTasksAsync(request.userId); 
            return result;
        }
    }
}

