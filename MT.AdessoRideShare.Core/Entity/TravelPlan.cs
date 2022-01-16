using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.AdessoRideShare.Core.Entity
{
   public class TravelPlan
    {
        public TravelPlan()
        {
            UserTravelPlans = new Collection<UserTravelPlan>();
        }
        public int Id { get; set; }

        public string FromWhere  { get; set; }

        public string ToWhere { get; set; }
        public DateTime TravelTime { get; set; }

        public int NumberOfSeats { get; set; }

        public int NumberOfOccupiedSeats { get; set; }

        public string Explanation { get; set; }

        public string Route { get; set; }

        public ICollection<UserTravelPlan> UserTravelPlans { get; set; }
    }
}

