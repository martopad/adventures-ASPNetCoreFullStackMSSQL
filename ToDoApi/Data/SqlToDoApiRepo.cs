using System;
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

        public void CreateToDo(ToDo td)
        {
            if(td == null)
            {
                throw new ArgumentNullException(nameof(td));
            }

            _context.ToDos.Add(td);
        }

        public IEnumerable<ToDo> GetAllToDos()
        {
            return _context.ToDos.ToList();
        }

        public ToDo GetTodoById(int id)
        {
            return _context.ToDos.FirstOrDefault( p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateToDo(ToDo td)
        {
            //Nothing
        }
    }
}