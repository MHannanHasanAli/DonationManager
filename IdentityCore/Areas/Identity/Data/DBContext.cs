using IdentityCore.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Test.Entities;

namespace IdentityCore.Areas.Identity.Data;

public class DBContext : IdentityDbContext<User>
{
    public DBContext() { }
    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }
    public DbSet<Customer> customers { get; set; }
    public DbSet<Donation> donations { get; set; }
    public DbSet<Project> projects { get; set; }
    public DbSet<Balance> balances { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string connectionString = "Data Source=sql.bsite.net\\MSSQL2016;Integrated Security=False;initial catalog=donationsystem_db;User ID=donationsystem_db;Password=Mubix$4545;Connect Timeout=90;Encrypt=False;Packet Size=4096";
            //"Data Source=sql.bsite.net\\MSSQL2016;Integrated Security=False;initial catalog=donationsystem_db;User ID=donationsystem_db;Password=Mubix$4545;Connect Timeout=90;Encrypt=False;Packet Size=4096";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Project>()
            .Property(e => e._Countries)
            .HasConversion(
                v => string.Join(',', v), // Convert List<string> to a comma-separated string
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList() // Convert the string back to List<string>
            );
    }
}
