using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.AdessoRideShare.Core.Entity
{
    public class UserTravelPlan
    {

            public int UserId { get; set; }
            public User User { get; set; }

        public int TravelPlanId { get; set; }
            public TravelPlan TravelPlan { get; set; }

    }
}
