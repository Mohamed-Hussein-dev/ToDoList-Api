using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Contract.Tasks.CheckTask
{
    public record CheckTaskResponse(bool isChecked , bool CurentStatus);
}
