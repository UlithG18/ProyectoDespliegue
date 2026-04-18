using Microsoft.EntityFrameworkCore;
using ProyectoDespliegueUlith.Models;

namespace ProyectoDespliegueUlith.Data;

public class MysqlDbContext : DbContext
{
    public MysqlDbContext(DbContextOptions<MysqlDbContext> options) : base(options)
    {
    }

    public DbSet<User> users { get; set; }
}