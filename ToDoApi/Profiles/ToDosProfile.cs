using AutoMapper;
using ToDoApi.Dtos;
using ToDoApi.Models;

namespace ToDoApi.Profiles
{
    public class ToDosProfile : Profile
    {
        public ToDosProfile()
        {
            //CreateMap<Source, Destination>()
            CreateMap<ToDo, ToDoReadDto>();
            CreateMap<ToDoCreateDto, ToDo>();
        }
    }
}