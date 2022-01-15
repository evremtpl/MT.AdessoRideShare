using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MT.AdessoRideShare.Core.Entity
{
    public class User
    {

        public User()
        {
            ContactInfos = new Collection<TravelPlan>();
        }
        public int id { get; set; }
        public string  Name { get; set; }

        public string SurName { get; set; }

        public ICollection<TravelPlan> ContactInfos { get; set; }
    }
}
