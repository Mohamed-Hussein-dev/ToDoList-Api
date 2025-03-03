using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Contract.Tasks.CreateTask
{
    public class CreateTaskRequestDto
    {
        public  string TaskTitile { get; set; }
        public string? TaskDescription {  get; set; }
        public DateTime? DueDate { get; set; }

    }
}
