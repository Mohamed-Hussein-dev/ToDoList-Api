using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Contract.Tasks.CreateTask
{
    public record CreateTaskRequest([Required]string TaskTitle, string TaskDescription, DateTime CreationDay , int Duration);
}
