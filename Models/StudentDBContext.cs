using Microsoft.EntityFrameworkCore;
namespace studentERP.Models;

public class StudentDBContext : DbContext
{
    public StudentDBContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Student> Students { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost,1433;Database=WorkshopDb;User Id=sa;Password=Vai@74269;TrustServerCertificate=True;");
    }
    
}