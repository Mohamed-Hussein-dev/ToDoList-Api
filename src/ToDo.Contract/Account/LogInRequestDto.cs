using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Contract.Account
{
    public record LogInRequestDto([Required] string Email , [Required] string Password);
}
