using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.AdessoRideShare.Core.Entity
{
   public class TravelPlan
    {
        public int Id { get; set; }

        public string WhereFrom  { get; set; }

        public string ToWhere { get; set; }
        public DateTime TravelTime { get; set; }

        public int NumberOfSeats { get; set; }

        public string Explanation { get; set; }

    }
}

