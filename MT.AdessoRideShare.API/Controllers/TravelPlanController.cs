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
        private readonly IService<UserTravelPlan> _userTravelPlanService;
        private readonly IMapper _mapper;

        public TravelPlanController(IService<TravelPlan> travelPlanService, IService<UserTravelPlan> userTravelPlanService,IMapper mapper)
        {
            _travelPlanService = travelPlanService;
            _userTravelPlanService = userTravelPlanService;
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
            var travelPlan = _travelPlanService.GetByIdAsync(id).Result;

            if (travelPlan != null) {
                _travelPlanService.Delete(travelPlan);
                return NoContent();
            }
            return BadRequest("Gönderdiğiniz id ye ait seyehat planı bulunmuyor");
            

        }

        [HttpGet]
        public async Task<IActionResult> FromWhereToWhere([FromBody] RouteDto route) // exception mekanizması ele alınmadı.
        {
            var travelPlan = await _travelPlanService.Find(x => x.ToWhere == route.ToWhere && x.FromWhere == route.FromWhere);

            if (travelPlan != null)
            {
                
                return Ok(travelPlan);
            }
            return BadRequest("Gönderdiğiniz rotaya ait seyehat planı bulunmuyor");

        }

      
        [Route("[action]")]
        [HttpPost]
        public async Task<IActionResult> SendJoinRequest(RequestDto requestDto)
        {
            var travelPlan = await _travelPlanService.GetByIdAsync(requestDto.TravelPlanId);

            if (travelPlan == null)
            {

                return BadRequest("Gönderdiğiniz rotaya ait seyehat planı bulunmuyor");
            }
            else if (travelPlan.NumberOfOccupiedSeats < travelPlan.NumberOfSeats)

            {
                travelPlan.NumberOfOccupiedSeats += 1;
               

                var updatedReport = _travelPlanService.Update(travelPlan);
                var newUserTravelPlan = await _userTravelPlanService.AddAsync(_mapper.Map<UserTravelPlan>(requestDto));
                return Ok($"{requestDto.TravelPlanId} li seyehate kaydınız oluşturulmuştur.");
            }
            else
            {
                return Ok($"{requestDto.TravelPlanId} li seyehat için boş koltuk bulunmuyor.");
            }
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<IActionResult> ShowRoute([FromBody] RouteDto route)
        {
            {
                var travelPlan = await _travelPlanService.Find(x => x.Route.Contains( route.FromWhere) && x.Route.Contains(route.ToWhere));

                if (travelPlan != null)
                {

                    return Ok(travelPlan);
                }
                return BadRequest("Gönderdiğiniz rotaya ait seyehat planı bulunmuyor");

            }
        }
    }
}
