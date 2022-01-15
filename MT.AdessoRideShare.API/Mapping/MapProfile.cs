using AutoMapper;
using MT.AdessoRideShare.API.Dtos;
using MT.AdessoRideShare.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MT.AdessoRideShare.API.Mapping
{
    public class MapProfile : Profile
    {

        public MapProfile()
        {
            CreateMap<TravelPlan, TravelPlanDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserTravelPlan, RequestDto>().ReverseMap();
        }
    }
}
