using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Velnoxa.Application.DTOs;
using Velnoxa.Application.Interfaces;
using Velnoxa.Domain.Entities;

namespace Velnoxa.Application.Services
{
    public class CustomerService:ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerReposity)
        {
            _customerRepository = customerReposity;
        }
        public async Task<Customer>CreateAsync(CreateCustomerDto dto)
        {
            var customer = new Customer
            {
               CompanyId= dto.CompanyId,
               FirstName = dto.FirstName,   
               LastName= dto.LastName,
               Email = dto.Email,
               Phone= dto.Phone,
               Address = dto.Address
            };

            await _customerRepository.AddAsync(customer);
            return customer;
        }
        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _customerRepository.GetAllAsync();
        }

        public async Task <Customer?>GetByIdAsync(Guid id)
        {
            return await _customerRepository.GetByIdAsync(id);  
        }
    }
}
