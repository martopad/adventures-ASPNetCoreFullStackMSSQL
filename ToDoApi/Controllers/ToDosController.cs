using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ToDoApi.Data;
using ToDoApi.Dtos;
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
        private readonly IMapper _mapper;

        //private readonly MockToDoApiRepo _repository = new MockToDoApiRepo();

        public ToDosController(IToDoApiRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/todos
        [HttpGet]
        public ActionResult <IEnumerable<ToDoReadDto>> GetAllToDos()
        {
            var toDoItems = _repository.GetAllToDos();

            return Ok(_mapper.Map<IEnumerable<ToDoReadDto>>(toDoItems));
        }

        //GET api/todos/{id}
        //for more infor look for "Binding Sources", how id gets mapped from a HTTP request
        [HttpGet("{id}", Name="GetToDoById")]
        public ActionResult <ToDoReadDto> GetToDoById(int id)
        {
            var toDoItem = _repository.GetTodoById(id);
            if(toDoItem != null)
            {
                return Ok(_mapper.Map<ToDoReadDto>(toDoItem));
            }
            return NotFound();
        }

        //POST api/todos
        [HttpPost]
        public ActionResult <ToDoReadDto> CreateToDo(ToDoCreateDto toDoCreateDto)
        {
            //do validation first for toDoCreateDto here ....

            var toDoModel = _mapper.Map<ToDo>(toDoCreateDto);
            _repository.CreateToDo(toDoModel);
            _repository.SaveChanges();

            var toDoReadDto = _mapper.Map<ToDoReadDto>(toDoModel);

            return CreatedAtRoute(nameof(GetToDoById), new {Id = toDoReadDto.Id}, toDoReadDto);
            // return Ok(toDoReadDto);
        }
    }
}