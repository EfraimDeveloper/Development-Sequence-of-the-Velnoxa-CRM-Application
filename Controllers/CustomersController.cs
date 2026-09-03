using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Velnoxa.Application.DTOs;
using Velnoxa.Application.Interfaces;

namespace Velnoxa.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService= customerService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCustomerDto dto)
        {
            var customer= await _customerService.CreateAsync(dto);
            return Ok(customer);

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _customerService.GetAllAsync();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var customer = await _customerService.GetByIdAsync(id);

            if(customer==null)
            {
                return NotFound();
            }
            return Ok(customer);
        }
    }
}
