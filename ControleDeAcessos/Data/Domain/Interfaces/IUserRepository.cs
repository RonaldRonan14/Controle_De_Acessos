namespace ControleDeAcessos.Data.Domain.Interfaces;

public interface IUserRepository
{
    Task<IEnumerable<Users>> GetAllAsync();
    Task<Users> GetByIdAsync(int id);
    Task AddAsync(Users tb_Logins);
    Task UpdateAsync(Users tb_Logins);
    Task RemoveAsync(int id);
}
