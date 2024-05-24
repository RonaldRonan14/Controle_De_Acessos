using ControleDeAcessos.Core.Entities;
using ControleDeAcessos.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ControleDeAcessos.Infrastructure.Data;

public class UserRepository : IUserRepository
{
    private readonly DBAcessos _context;

    public UserRepository()
    {
        _context = new DBAcessos();
    }

    public async Task AddAsync(Users Users)
    {
        _context.Users.Add(Users);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Users>> GetAllAsync()
    {
        return await _context.Users.AsNoTracking().ToListAsync();
    }

    public async Task<Users> GetByIdAsync(int id)
    {
        return await _context.Users.AsNoTracking().FirstOrDefaultAsync(r => r.id == id);
    }

    public async Task RemoveAsync(int id)
    {
        var login = await _context.Users.FindAsync(id);
        _context.Users.Remove(login);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Users Users)
    {
        _context.Entry(Users).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}
