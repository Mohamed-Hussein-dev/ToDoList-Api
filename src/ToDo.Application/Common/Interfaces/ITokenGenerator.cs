using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities;

namespace ToDo.Application.Common.Interfaces
{
    public interface ITokenGenerator
    {
        Task<string> GenerateTokenAsync(AppUser user , UserManager<AppUser> userManager);
    }
}
