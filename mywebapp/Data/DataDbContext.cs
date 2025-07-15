using Microsoft.EntityFrameworkCore;
using mywebapp.Models;

/// <summary>
/// The Entity Framework Core database context for the application.
/// </summary>
public class DataDbContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DataDbContext"/> class.
    /// </summary>
    public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
    {
    }

    /// <summary>
    /// Gets or sets the Customers table.
    /// </summary>
    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Additional model configuration can go here
    }
}
