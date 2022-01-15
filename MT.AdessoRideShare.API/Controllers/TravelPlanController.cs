using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MT.AdessoRideShare.API.Dtos;
using MT.AdessoRideShare.Core.Entity;
using MT.AdessoRideShare.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MT.AdessoRideShare.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelPlanController : ControllerBase
    {

        private readonly IService<TravelPlan> _travelPlanService;
        private readonly IMapper _mapper;

        public TravelPlanController(IService<TravelPlan> travelPlanService, IMapper mapper)
        {
            _travelPlanService = travelPlanService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTravelPlan(TravelPlanDto travelPlanDto)
        {
            var newPlan = await _travelPlanService.AddAsync(_mapper.Map<TravelPlan>(travelPlanDto));
            return Created(string.Empty, _mapper.Map<TravelPlanDto>(newPlan));

        }

        [HttpDelete]
        public IActionResult RemoveTravelPlan(int id) // exception mekanizması ele alınmadı.
        {
            var _travelPlan = _travelPlanService.GetByIdAsync(id).Result;
            _travelPlanService.Delete(_travelPlan);
            return NoContent();

        }
    }
}
