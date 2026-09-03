using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Velnoxa.Application.Interfaces;
using Velnoxa.Domain.Entities;
using Velnoxa.Infrastructure.Persistence;

namespace Velnoxa.Infrastructure.Repositories
{
    public class WhatsAppAccountRepository:IWhatsAppAccountRepository
    {
        private readonly ApplicationDbContext _context;

        public WhatsAppAccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(WhatsAppccount account)
        {
            await _context.WhatsAppccounts.AddAsync(account);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<WhatsAppccount>> GetAllAsync()
        {
           return await _context.WhatsAppccounts.ToListAsync();
        }

        public async Task<WhatsAppccount?> GetByIdAsync(Guid id)
        {
            return await _context.WhatsAppccounts.FirstOrDefaultAsync(x=> x.Id==id);
        }
    }
}
