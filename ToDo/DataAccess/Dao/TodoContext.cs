using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Dao
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
        public DbSet<ToDoItem> TodoItems { get; set; }
    }

}
