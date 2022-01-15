using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MT.AdessoRideShare.API.Dtos
{
    public class UserDto
    {
        [Required]//FluentValidation Kullanılabilir.
        public string Name { get; set; }
        [Required]
        public string SurName { get; set; }
    }
}
