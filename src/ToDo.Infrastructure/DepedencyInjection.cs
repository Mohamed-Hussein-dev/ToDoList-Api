using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Common.Interfaces;
using ToDo.Infrastructure.Common.Persistence;
using ToDo.Infrastructure.Tasks.Persistence;

namespace ToDo.Infrastructure
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            return services.AddPersistence();

        }
        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddDbContext<ToDoDbContext>(options => options.UseSqlServer(
                "Server=.;Database=ToDoListDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"));

            services.AddScoped<ITaskRepostory, TaskRepostory>();

            return services;
        }
    }
}
