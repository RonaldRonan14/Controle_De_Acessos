using ControleDeAcessos.Data.Domain;
using Microsoft.EntityFrameworkCore;

namespace ControleDeAcessos.Data;

public class DBAcessos : DbContext
{
    public DbSet<Users> Users { get; set; }
    public DbSet<AccessData> AccessData {  get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost; Database=AccessAccount; User=usuario; Password=senha; TrustServerCertificate=True;");
    }
}
