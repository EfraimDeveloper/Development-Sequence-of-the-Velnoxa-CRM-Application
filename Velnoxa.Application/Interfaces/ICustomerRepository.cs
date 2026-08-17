using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Velnoxa.Domain.Entities;

namespace Velnoxa.Application.Interfaces
{
    public interface ICustomerRepository
    {
        Task AddAsync(Customer customer);

        Task<IEnumerable<Customer>> GetAllAsync();

        Task<Customer?> GetByIdAsync(Guid id);

    }
}
