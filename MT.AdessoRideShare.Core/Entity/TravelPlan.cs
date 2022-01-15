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
            Users = new Collection<User>();
        }
        public int Id { get; set; }

        public string WhereFrom  { get; set; }

        public string ToWhere { get; set; }
        public DateTime TravelTime { get; set; }

        public int NumberOfSeats { get; set; }

        public string Explanation { get; set; }

        public ICollection<User> Users { get; set; }
    }
}

