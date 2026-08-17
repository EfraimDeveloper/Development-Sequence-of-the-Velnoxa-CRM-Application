using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Velnoxa.Application.DTOs;
using Velnoxa.Application.Interfaces;

namespace Velnoxa.Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task<Company> CreateAsync(CreateCompanyDto dto)
        {
            var company = new Company
            {
                Name = dto.Name,
                Nif = dto.Nif,
                Email = dto.Email,
                Phone = dto.Phone,
                Address = dto.Address
            };

            await _companyRepository.AddAsync(company);
            return company;

        }
        public async Task<IEnumerable<Company>> GetAllAsync()
        {
            return await _companyRepository.GetAllAsync();
        }

        public async Task <Company?> GetByIdAsync(Guid id)
        {
            return await _companyRepository.GetByIdAsync(id);
        }

    }
}
