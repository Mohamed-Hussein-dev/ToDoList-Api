using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string? TaskDescription { get; set; }
        public string TaskTitile { get; set; }
        public DateTime? Created { get; set; } = DateTime.Now;
        public bool IsCompleted { get; set; }
        public DateTime? DueDate { get; set; } = null;

    }
}
