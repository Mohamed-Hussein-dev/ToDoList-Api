using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities;

namespace ToDo.Application.Common.Interfaces
{
    public interface ITaskRepostory
    {
        Task CreateTaskAsync(TaskItem task);
        Task DeleteTaskAsync(TaskItem task);
        Task UpdateTaskAsync(TaskItem task);
        Task<TaskItem?> GetTaskAsync(int taskId);

    }
}
