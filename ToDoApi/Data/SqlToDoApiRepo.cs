using System.Collections.Generic;
using System.Linq;
using ToDoApi.Models;

namespace ToDoApi.Data
{
    public class SqlToDoApiRepo : IToDoApiRepo
    {
        private readonly ToDoApiContext _context;

        public SqlToDoApiRepo(ToDoApiContext context)
        {
            _context = context;
        }

        public IEnumerable<ToDo> GetAllToDos()
        {
            return _context.ToDos.ToList();
        }

        public ToDo GetTodoById(int id)
        {
            return _context.ToDos.FirstOrDefault( p => p.Id == id);
        }
    }
}