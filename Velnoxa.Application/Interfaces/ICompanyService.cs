using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Velnoxa.Application.DTOs;

namespace Velnoxa.Application.Interfaces
{
    public interface ICompanyService
    {
        Task<Company> CreateAsync(CreateCompanyDto dto);

        Task<IEnumerable<Company>> GetAllAsync();

        Task<Company?> GetByIdAsync(Guid id);
    }
}
