using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Velnoxa.Domain.Entities;

namespace Velnoxa.Application.Interfaces
{
    public interface IwhatsAppAccountRepository
    {
        Task Add111(WhatsAppccount account);
        
        Task<IEnumerable<WhatsAppccount>> GetAllAsync();

        Task<WhatsAppccount?> GetByIdAsync(Guid id);
    }
}
