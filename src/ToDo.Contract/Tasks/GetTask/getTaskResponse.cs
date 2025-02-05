using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Contract.Tasks.GetTask
{
    public record getTaskResponse(int TaskID, string TaskTitile, string TaskDescription, DateTime CreationTime, bool CurrentStatus);
}
