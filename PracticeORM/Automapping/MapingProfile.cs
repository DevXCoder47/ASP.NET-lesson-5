using AutoMapper;
using PracticeORM.DTOs;
using PracticeORM.Models;

namespace PracticeORM.Automapping
{
    public class MapingProfile : Profile
    {
        public MapingProfile()
        {
            CreateMap<Driver, DriverDTO>().ReverseMap();
        }
    }
}
