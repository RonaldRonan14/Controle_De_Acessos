using ControleDeAcessos.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ControleDeAcessos.Infrastructure;

public class DBAcessos : DbContext
{
    public DbSet<Users> Users { get; set; }
    public DbSet<AccessData> AccessData {  get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Server=localhost; Database=AccessAccount; User=****; Password=****; Port=3306;";

        optionsBuilder.UseMySql(connectionString, MySqlServerVersion.AutoDetect(connectionString));
    }
}
