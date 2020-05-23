using System.Collections.Generic;
using ToDoApi.Models;

namespace ToDoApi.Data
{
    public interface IToDoApiRepo
    {
        IEnumerable<ToDo> GetAllToDos();
        ToDo GetTodoById(int id);
    }
}