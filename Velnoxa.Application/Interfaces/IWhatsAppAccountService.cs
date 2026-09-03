using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Velnoxa.Domain.Entities;
using Velnoxa.Application.DTOs;

namespace Velnoxa.Application.Interfaces
{
    public interface IWhatsAppAccountService
    {
        Task<WhatsAppccount>CreateAsync(CreateWhatsAppAccountDto dto);

        Task<IEnumerable<WhatsAppccount>> GetAllAsync();

        Task<WhatsAppccount?> GetByIdAsync(Guid id);
    }
}
