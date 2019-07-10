using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class volunteerScheduleDTO
    {
        public int id { get; set; }
        public int? weekDay { get; set; }
        public TimeSpan? FromHour { get; set; }
        public TimeSpan? toHour { get; set; }
        public int? volunteerToGroupId { get; set; }
        public string comment { get; set; }

        
    }
}
