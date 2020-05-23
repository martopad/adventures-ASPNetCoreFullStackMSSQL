using Microsoft.EntityFrameworkCore;
using ToDoApi.Models;

namespace ToDoApi.Data
{
    public class ToDoApiContext : DbContext
    {
        public ToDoApiContext(DbContextOptions<ToDoApiContext> opt) : base(opt)
        {

        }

        public DbSet<ToDo> ToDos { get; set; }
    }
}