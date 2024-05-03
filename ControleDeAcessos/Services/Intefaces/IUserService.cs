using ControleDeAcessos.Data.Domain;

namespace ControleDeAcessos.Services.Intefaces;

public interface IUserService
{
    Task<IEnumerable<Users>> GetAllAsync();
    Task<Users> GetByIdAsync(int id);
    Task AddAsync(Users user);
    Task UpdateAsync(Users user);
    Task RemoveAsync(int id);
    string EncryptPassword(string password);
}
