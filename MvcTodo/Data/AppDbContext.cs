using Microsoft.EntityFrameworkCore;

namespace MvcTodo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base(options) { }

        //DbSets Area
    }
}