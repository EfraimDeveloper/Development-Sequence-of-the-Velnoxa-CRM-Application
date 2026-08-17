using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Velnoxa.Application.DTOs;
using Velnoxa.Domain.Entities;

namespace Velnoxa.Application.Interfaces
{
    public interface ICustomerService
    {
        Task<Customer>CreateAsync(CreateCustomerDto dto);

        Task<IEnumerable<Customer>> GetAllAsync();

        Task<Customer> GetByIdAsync(Guid id);
    }
}
