using Microsoft.AspNetCore.Mvc;
using Velnoxa.Application.DTOs;
using Velnoxa.Application.Interfaces;


namespace Velnoxa.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompaniesController: ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompaniesController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCompanyDto dto)
        {
            var company= await _companyService.CreateAsync(dto);

            return Ok(company);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var companies = await _companyService.GetAllAsync();
            return Ok(companies);
        }

        [HttpGet("{id}")]
        public  async Task<IActionResult>GetById(Guid id)
        {
            var campany = await _companyService.GetByIdAsync(id);
            if(campany == null)
                return NotFound();

            return Ok(campany);
        }

    }
}
