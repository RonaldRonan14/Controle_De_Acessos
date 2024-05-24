using ControleDeAcessos.Core.Entities;

namespace ControleDeAcessos.Services.Intefaces;

public interface IAccessDataService
{
    Task<IEnumerable<AccessData>> GetAllAsync(int userId);
    Task<AccessData> GetByIdAsync(int id);
    Task AddAsync(AccessData accessData);
    Task UpdateAsync(AccessData accessData);
    Task RemoveAsync(int id);
    Task<string> EncryptPassword(string password);
    Task<string> DecryptPassword(string password);
}
