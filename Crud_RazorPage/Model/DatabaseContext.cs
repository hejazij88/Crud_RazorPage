using Microsoft.EntityFrameworkCore;

namespace Crud_RazorPage.Model
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
}
}
