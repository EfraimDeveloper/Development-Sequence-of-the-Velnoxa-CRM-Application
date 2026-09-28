using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Velnoxa.Domain.Entities;
namespace Velnoxa.Application.Interfaces
{
    public interface IDocumentRepository
    {
        Task AddAsync(Document document);
        Task <IEnumerable<Document>> GetByCompanyIdAsync(Guid companyId);
        Task<Document?> GetByIdAsync(Guid documentId);
        Task DeleteAsync(Document document);
    }
}
