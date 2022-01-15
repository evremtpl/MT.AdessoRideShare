using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MT.AdessoRideShare.API.Dtos
{
    public class RequestDto
    {
        [Required] //FluentValidation Kullanılabilir.
        public int UserId { get; set; }

        [Required]
        public int TravelPlanId { get; set; }
    
    }
}
