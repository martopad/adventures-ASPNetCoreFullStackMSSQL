using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDoApi.Data;
using ToDoApi.Models;

namespace ToDoApi.Controllers
{
    // //api/ToDos
    // [Route("api/[controller]")]

    // api/todos
    [Route("api/todos")]
    [ApiController]
    public class ToDosController : ControllerBase
    {
        private readonly IToDoApiRepo _repository;
        //private readonly MockToDoApiRepo _repository = new MockToDoApiRepo();

        public ToDosController(IToDoApiRepo repository)
        {
            _repository = repository;
        }

        //GET api/todos
        [HttpGet]
        public ActionResult <IEnumerable<ToDo>> GetAllToDos()
        {
            var toDoItems = _repository.GetAllToDos();

            return Ok(toDoItems);
        }

        //GET api/todos/{id}
        //for more infor look for "Binding Sources", how id gets mapped from a HTTP request
        [HttpGet("{id}")]
        public ActionResult <ToDo> GetToDoById(int id)
        {
            var toDoItem = _repository.GetTodoById(id);

            return Ok(toDoItem);
        }
    }
}