using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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

        public async Task DeleteTaskAsync(TaskItem task)
        {
            _dbContext.Tasks.Remove(task);
            await _dbContext.SaveChangesAsync();
            
        }

        public async Task<TaskItem?> GetTaskAsync(int taskId)
        {
            return await _dbContext.Tasks.AsNoTracking().FirstOrDefaultAsync(task => task.Id == taskId);
        }

        public async Task UpdateTaskAsync(TaskItem task)
        {
            _dbContext.Tasks.Update(task);
            await _dbContext.SaveChangesAsync();
        }
    }
}
