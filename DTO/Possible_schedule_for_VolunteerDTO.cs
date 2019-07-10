using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Possible_schedule_for_VolunteerDTO
    {
        public int id { get; set; }
        public int? weekDay { get; set; }
        public TimeSpan? fromHour { get; set; }
        public TimeSpan? toHour { get; set; }
        public int? volunteerToGroupId { get; set; }

    }
}
