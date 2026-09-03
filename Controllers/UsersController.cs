using Microsoft.AspNetCore.Mvc;
using Velnoxa.Application.DTOs;
using Velnoxa.Application.Interfaces;
using Velnoxa.Domain.Entities;

namespace Velnoxa.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterUserDtos dto)
    {
        var result = await _userService.RegisterAsync(dto);
        return Ok(result);
    }
    [HttpPost("login")]
    public async Task <IActionResult> lOGIN(LoginUserDtos dto)
    {
        var user=await _userService.LoginAsync(dto);

        if(user==null)
            return Unauthorized("Invalid email or password.");

        return Ok(new {Token=user});
    }
}