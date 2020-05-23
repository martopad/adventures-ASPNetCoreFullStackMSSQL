using System.Collections.Generic;
using ToDoApi.Models;

namespace ToDoApi.Data
{
    public class MockToDoApiRepo : IToDoApiRepo
    {
        public IEnumerable<ToDo> GetAllToDos()
        {
            var toDos = new List<ToDo>
            {
                new ToDo{Id=69, Name="WEWEWEWEW", IsDone=false},
                new ToDo{Id=562, Name="WAWAWAWWAA", IsDone=true},
                new ToDo{Id=900, Name="YYYEEEEWWWWHAHAWHHW", IsDone=true},
                new ToDo{Id=679, Name="uashdfabkjshbdkasbjkdb", IsDone=false}
            };

            return toDos;
        }

        public ToDo GetTodoById(int id)
        {
            return new ToDo{Id=999, Name="QQQQQQQQQQQQQQQQ", IsDone=false};
        }
    }
}