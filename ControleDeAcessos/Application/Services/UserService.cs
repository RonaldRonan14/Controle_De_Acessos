using ControleDeAcessos.Core.Entities;
using ControleDeAcessos.Core.Interfaces;
using ControleDeAcessos.Services.Intefaces;
using Microsoft.AspNetCore.Identity;

namespace ControleDeAcessos.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task AddAsync(Users user)
    {
        await _userRepository.AddAsync(user);
    }

    public async Task<IEnumerable<Users>> GetAllAsync()
    {
        return await _userRepository.GetAllAsync();
    }

    public async Task<Users> GetByIdAsync(int id)
    {
        return await _userRepository.GetByIdAsync(id);
    }

    public async Task RemoveAsync(int id)
    {
        await _userRepository.RemoveAsync(id);
    }

    public async Task UpdateAsync(Users user)
    {
        await _userRepository.UpdateAsync(user);
    }

    public string EncryptPassword(string password)
    {
        var hasherPassword = new PasswordHasher<Users>();
        return hasherPassword.HashPassword(null, password);
    }
}
