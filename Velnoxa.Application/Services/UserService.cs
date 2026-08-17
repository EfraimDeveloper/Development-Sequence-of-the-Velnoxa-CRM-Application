using Velnoxa.Application.DTOs;
using Velnoxa.Application.Interfaces;
using Velnoxa.Domain.Entities;
using BCrypt.Net;

namespace Velnoxa.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly ITokenService _tokenService;

    public UserService(IUserRepository userRepository, ITokenService tokenService   )
    {
        _userRepository = userRepository;
        _tokenService = tokenService;
    }

    public async Task<User> RegisterAsync(RegisterUserDtos dto)
    {
        var existingUser = await _userRepository.GetByEmailAsync(dto.Email);

        if (existingUser != null)
            throw new Exception("Email already exists.");

        var user = new User
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Email = dto.Email,
            PasswordHash =BCrypt.Net.BCrypt.HashPassword(dto.Password), 
            IsActive = true
        };

        await _userRepository.AddAsync(user);

        return user;
    }
    public async Task <string> LoginAsync(LoginUserDtos dto)
    {
       var user= await _userRepository.GetByEmailAsync(dto.Email);

        if (user == null)
            return null;

        if (!BCrypt.Net.BCrypt.Verify(dto.Password, user.PasswordHash))
            return null;

        return _tokenService.GenerateToken(user);

    }


}