

using Microsoft.EntityFrameworkCore;

namespace GestionDeReservasFIT.Shared;

public partial class ReservasGestionContext : DbContext
{
    public ReservasGestionContext()
    {
    }

    public ReservasGestionContext(DbContextOptions<ReservasGestionContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("User");
        modelBuilder.Entity<Role>().ToTable("Role");
        base.OnModelCreating(modelBuilder);
    }

    /** protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     {
         IConfiguration configuration = new ConfigurationBuilder()
             .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
             .AddJsonFile("appsettings.json")
             .Build();
         optionsBuilder.UseSqlServer(configuration.GetConnectionString("LocalSqlServer"));
     }*/

}
