using Microsoft.EntityFrameworkCore;
using ProyectoDespliegue.Models;

namespace ProyectoDespliegue.Data;

public class MysqlDbContext : DbContext
{
    public MysqlDbContext(DbContextOptions<MysqlDbContext> options) : base(options)
    {
    }

    public DbSet<User> users { get; set; }
}