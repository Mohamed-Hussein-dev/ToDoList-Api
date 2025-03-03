using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities;

namespace ToDo.Infrastructure.Common.Persistence
{
    public class ToDoDbContext : DbContext
    {
        public DbSet<TaskItem>  Tasks { get; set; }

        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options) { }
        
    }
}
