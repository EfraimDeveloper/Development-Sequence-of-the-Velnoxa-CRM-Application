using Velnoxa.Application.DTOs;
using Velnoxa.Application.Interfaces;
using Velnoxa.Domain.Entities;

namespace Velnoxa.Application.Services
{
    public class WhatsAppAccountService : IWhatsAppAccountService
    {
        private readonly IWhatsAppAccountRepository _repository;

        public WhatsAppAccountService(IWhatsAppAccountRepository whatsAppAccountRepository)
        {
            _repository = whatsAppAccountRepository;
        }
        public async Task<WhatsAppccount> CreateAsync(CreateWhatsAppAccountDto dto)
        {
            var account = new WhatsAppccount
            {
                CompanyId = dto.CompanyId,
                PhoneNumber = dto.PhoneNumber,
                phoneNumberId = dto.PhoneNumberId,
                businessAccountId = dto.BusinessAccoundId
            };

            await _repository.AddAsync(account);

            return account;
        }
        public async Task<IEnumerable<WhatsAppccount>> GetAllAsync()
        {
            return await _repository.GetAllAsync();

        }

        public async Task<WhatsAppccount?> GetByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
