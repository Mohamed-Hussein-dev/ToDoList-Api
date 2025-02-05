using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Contract.Tasks.UpdateTask
{
    public record UpdateTaskRequest(int TaskID, string TaskTitle, string TaskDescription, DateTime CreationDay, int Duration);
}
