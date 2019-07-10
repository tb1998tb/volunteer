using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class volunteerTimingDTO
    {
        public int id { get; set; }
        public int? groupVolunteerId { get; set; }
        public TimeSpan? fromHour { get; set; }
        public TimeSpan? toHour { get; set; }
        public int? weekday { get; set; }

    }
}
