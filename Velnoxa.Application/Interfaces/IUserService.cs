using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Velnoxa.Application.DTOs;
using Velnoxa.Domain.Entities;

namespace Velnoxa.Application.Interfaces
{
    public interface IUserService
    {
            //Task<User> RegisterAsync(User user);
            Task<User>RegisterAsync(RegisterUserDtos dto);
           Task<string?> LoginAsync(LoginUserDtos dto);
        //Task<RegisterUserDtos?>LoginAsync(LoginUserDtos dto);
    }
}
