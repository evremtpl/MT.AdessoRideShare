using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MT.AdessoRideShare.API.Dtos
{
    public class TravelPlanDto
    {
        [Required] //FluentValidation Kullanılabilir.
        public string FromWhere { get; set; }
        [Required]
        public string ToWhere { get; set; }
        [Required]
        public DateTime TravelTime { get; set; }
        [Required]
        public int NumberOfSeats { get; set; }
        [Required]
        public string Explanation { get; set; }

        [Required]
        public string Route { get; set; }

    }
}
