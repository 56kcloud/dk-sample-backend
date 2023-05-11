using AutoMapper;
using TodoApi.Models;

namespace TodoApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TodoItem, TodoDynamo>().ReverseMap();
        }
    }
}
