using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MT.AdessoRideShare.API.Dtos
{
    public class RouteDto
    {
        [Required] //FluentValidation Kullanılabilir.
        public string WhereFrom { get; set; }
        [Required]
        public string ToWhere { get; set; }
    }
}
