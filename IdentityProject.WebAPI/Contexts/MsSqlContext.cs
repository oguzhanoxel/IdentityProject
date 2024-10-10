using IdentityProject.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityProject.WebAPI.Contexts;

public class MsSqlContext : DbContext
{
    public MsSqlContext(DbContextOptions opt): base(opt)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433; Database = identity_db; User=sa; Password=123456789; TrustServerCertificate=True;");
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
}