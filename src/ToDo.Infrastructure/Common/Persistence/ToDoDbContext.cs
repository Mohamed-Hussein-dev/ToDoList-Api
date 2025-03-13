using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities;
using ToDo.Infrastructure.DataSeeding;

namespace ToDo.Infrastructure.Common.Persistence
{
    public class ToDoDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<TaskItem>  Tasks { get; set; }

        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            SeedDefaultUser.RegisterDefaultUser(builder);

            builder.Entity<TaskItem>()
                   .HasIndex(t => t.UserId);

            builder.Entity<TaskItem>()
                   .HasOne(U => U.User)
                   .WithMany()
                   .HasForeignKey(task => task.UserId);
                   

            base.OnModelCreating(builder);
        }
    }
}
