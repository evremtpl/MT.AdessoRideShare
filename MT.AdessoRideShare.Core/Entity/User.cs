using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MT.AdessoRideShare.Core.Entity
{
    public class User
    {

        public User()
        {
            TravelPlans = new Collection<TravelPlan>();
        }
        
        public int Id { get; set; }
        public string  Name { get; set; }

        public string SurName { get; set; }

        public ICollection<TravelPlan> TravelPlans { get; set; }
       

    }
}
