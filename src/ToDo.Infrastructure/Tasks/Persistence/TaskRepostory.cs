using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Common.Interfaces;
using ToDo.Domain.Entities;
using ToDo.Infrastructure.Common.Persistence;

namespace ToDo.Infrastructure.Tasks.Persistence
{
    public class TaskRepostory : ITaskRepostory
    {
        private readonly ToDoDbContext _dbContext;

        public TaskRepostory(ToDoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task CreateTaskAsync(TaskItem task)
        {
            await _dbContext.Tasks.AddAsync(task);
            await _dbContext.SaveChangesAsync();
        }
    }
}
