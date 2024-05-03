namespace ControleDeAcessos.Data.Domain.Interfaces;

public interface IAccessDataRepository
{
    Task<IEnumerable<AccessData>> GetAllASync();
    Task<AccessData> GetByIdAsync(int id);
    Task AddAsync(AccessData accessData);
    Task UpdateAsync(AccessData accessData);
    Task RemoveAsync(int id);
} 
