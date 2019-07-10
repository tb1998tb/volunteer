using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class groupVolunteeryDTO
    {
      
        public int id { get; set; }

        public string nameGroup { get; set; }
        public  int? sum_hour_in_night { get; set; }
        public int? sum_hour_volunteering_for_week { get; set; }
        public int? managerId { get; set; }
        public TimeSpan? from_hour_in_night { get; set; }
        public TimeSpan? to_hour_in_night { get; set; }

    }
}

