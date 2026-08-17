using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velnoxa.Application.DTOs
{
    public class LoginResponseDto
    {
        public string Token { get; set; } = string.Empty;
        public string FristName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
