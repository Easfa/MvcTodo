using Microsoft.EntityFrameworkCore;
using MvcTodo.Models;

namespace MvcTodo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base(options) { }

        //DbSets Area
        public DbSet<Todo> Todos { get; set; }
    }
}