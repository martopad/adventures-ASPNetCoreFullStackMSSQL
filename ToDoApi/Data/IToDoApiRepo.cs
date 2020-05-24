using System.Collections.Generic;
using ToDoApi.Models;

namespace ToDoApi.Data
{
    public interface IToDoApiRepo
    {
        bool SaveChanges();
        IEnumerable<ToDo> GetAllToDos();
        ToDo GetTodoById(int id);
        void CreateToDo(ToDo td);
    }
}