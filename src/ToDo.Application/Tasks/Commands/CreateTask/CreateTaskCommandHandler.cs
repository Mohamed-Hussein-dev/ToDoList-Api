using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Common.Interfaces;
using ToDo.Domain.Entities;

namespace ToDo.Application.Tasks.Commands.CreateTask
{
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, ErrorOr<int>>
    {
        private readonly ITaskRepostory _taskRepostory;

        public CreateTaskCommandHandler(ITaskRepostory taskRepostory)
        {
            _taskRepostory = taskRepostory;
        }
        public async Task<ErrorOr<int>> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var newTask = new TaskItem {
                TaskTitile = request.TaskTitle,
                TaskDescription = request.TaskDescription,
                DueDate = request.DueDate,
                IsCompleted = false,
                Created = DateTime.UtcNow,
            };
           await _taskRepostory.CreateTaskAsync(newTask);

           return newTask.Id;
        }
    }
}
