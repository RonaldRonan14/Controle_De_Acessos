using ControleDeAcessos.Data.Domain;
using ControleDeAcessos.Data.Domain.Interfaces;
using ControleDeAcessos.Services.Intefaces;
using System.Text;

namespace ControleDeAcessos.Services;

public class AccessDataService : IAccessDataService
{
    private readonly IAccessDataRepository _accessDataRepository;

    public AccessDataService(IAccessDataRepository accessDataRepository)
    {
        _accessDataRepository = accessDataRepository;
    }

    public async Task AddAsync(AccessData accessData)
    {
        await _accessDataRepository.AddAsync(accessData);
    }

    public Task<string> DecryptPassword(string password)
    {
        byte[] decodedBytes = Convert.FromBase64String(password);
        string decodedText = Encoding.UTF8.GetString(decodedBytes);
        return Task.FromResult(decodedText);
    }

    public Task<string> EncryptPassword(string password)
    {
        byte[] textBytes = Encoding.UTF8.GetBytes(password);
        string base64Text = Convert.ToBase64String(textBytes);
        return Task.FromResult(base64Text);
    }

    public async Task<IEnumerable<AccessData>> GetAllAsync(int userId)
    {
        var result = await _accessDataRepository.GetAllASync();
        return result
            .Where(r => r.userId == userId)
            .OrderBy(r => r.username)
            .ToList();
    }

    public async Task<AccessData> GetByIdAsync(int id)
    {
        return await _accessDataRepository.GetByIdAsync(id);
    }

    public async Task RemoveAsync(int id)
    {
        await _accessDataRepository.RemoveAsync(id);
    }

    public async Task UpdateAsync(AccessData accessData)
    {
        await _accessDataRepository.UpdateAsync(accessData);
    }
}
