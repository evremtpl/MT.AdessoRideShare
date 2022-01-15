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
    public class UserController : ControllerBase
    {

        private readonly IService<User> _userService;
        private readonly IMapper _mapper;

        public UserController(IService<User> userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserDto userDto)
        {
            var newUser = await _userService.AddAsync(_mapper.Map<User>(userDto));
            return Created(string.Empty, _mapper.Map<UserDto>(newUser));

        }

        [HttpDelete]
        public IActionResult RemoveUser(int id) 
        {
            var user= _userService.GetByIdAsync(id).Result;

            if (user != null)
            {
                _userService.Delete(user);
                return NoContent();
            }
            return BadRequest("Gönderdiğiniz id ye ait user bulunmuyor");


        }

       
    }
}
