using MediatR;
using ErrorOr;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities;

namespace ToDo.Application.Tasks.Queries.GetAllTasks
{
    public record GetAllTasksCommand(string userId) : IRequest<ErrorOr<List<TaskItem>>>;
}
