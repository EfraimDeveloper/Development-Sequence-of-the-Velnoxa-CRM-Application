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
    public class WhatsAppAccountRepository:IwhatsAppAccountRepository
    {
        private readonly ApplicationDbContext _context;

        public WhatsAppAccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync (WhatsAppccount account)
        {
            await _context.whatsAppccounts.AddAsync(account);
            await _context.SaveChangesAsync();
        }
    }
}
