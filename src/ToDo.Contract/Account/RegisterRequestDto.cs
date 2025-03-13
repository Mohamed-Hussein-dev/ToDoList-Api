using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Contract.Account
{
    public record RegisterRequestDto([Required] string FristName,
                                  [Required] string LastName,
                                  [Required] string Email,
                                  [Required] string Password);
    
}
