using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Velnoxa.Domain.Entities;


namespace Velnoxa.Application.Interfaces
{
    public interface ICompanyRepository
    {
        Task AddAsync(Company company);

        Task<Company?> GetByIdAsync(Guid id);

        Task<IEnumerable<Company>> GetAllAsync();

        Task UpdateAsync(Company company);

        Task DeleteAsync(Company company);
    }
}
