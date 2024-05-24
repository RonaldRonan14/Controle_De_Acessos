using ControleDeAcessos.Core.Entities;

namespace ControleDeAcessos.Core.Interfaces;

public interface IAccessDataRepository
{
    Task<IEnumerable<AccessData>> GetAllASync();
    Task<AccessData> GetByIdAsync(int id);
    Task AddAsync(AccessData accessData);
    Task UpdateAsync(AccessData accessData);
    Task RemoveAsync(int id);
} 
