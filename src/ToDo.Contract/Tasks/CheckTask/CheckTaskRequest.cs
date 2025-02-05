using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Contract.Tasks.CheckTask
{
    public record CheckTaskRequest([Required]int TaskID);
}
