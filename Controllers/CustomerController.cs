using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Velnoxa.Application.Interfaces;

namespace Velnoxa.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService= customerService;
        }
    }
}
