using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MT.AdessoRideShare.Core.Entity
{
    public class User
    {

        public User()
        {
            UserTravelPlans = new Collection<UserTravelPlan>();
        }
        
        public int Id { get; set; }
        public string  Name { get; set; }

        public string SurName { get; set; }

        public ICollection<UserTravelPlan> UserTravelPlans { get; set; }
       

    }
}
