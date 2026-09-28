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
    public class DocumentRepository : IDocumentRepository
    {
        private readonly ApplicationDbContext _context;

        public DocumentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Document document)
        {
            await _context.Documents.AddAsync(document);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Document>> GetByCompanyIdAsync(Guid companyId)
        {
            return await _context.Documents.Where(d => d.CompanyId == companyId)
                                           .OrderByDescending(d => d.CreatedAt).ToListAsync();
        }

        public async Task<Document?> GetByIdAsync(Guid documentId)
        {
            return await _context.Documents.FirstOrDefaultAsync(d => d.Id == documentId);
        }

        public async Task DeleteAsync(Document document)
        {
            _context.Documents.Remove(document);
            await _context.SaveChangesAsync();
        }
    }
}