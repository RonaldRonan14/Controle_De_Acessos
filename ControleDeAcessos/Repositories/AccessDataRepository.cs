﻿using ControleDeAcessos.Data;
using ControleDeAcessos.Data.Domain;
using ControleDeAcessos.Data.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAcessos.Repositories;

public class AccessDataRepository : IAccessDataRepository
{
    private readonly DBAcessos _context;

    public AccessDataRepository()
    {
        _context = new DBAcessos();
    }

    public async Task AddAsync(AccessData accessData)
    {
        _context.AddAsync(accessData);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<AccessData>> GetAllASync()
    {
        return await _context.AccessData.AsNoTracking().ToListAsync();
    }

    public async Task<AccessData> GetByIdAsync(int id)
    {
        return await _context.AccessData.AsNoTracking().FirstOrDefaultAsync(r => r.id == id);
    }

    public async Task RemoveAsync(int id)
    {
        var result = await _context.AccessData.FindAsync(id);
        _context.AccessData.Remove(result);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(AccessData accessData)
    {
        _context.Entry(accessData).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}
