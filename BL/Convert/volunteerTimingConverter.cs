using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL.Convert
{
    public class volunteerTimingConverter
    {
        public volunteerTimingDTO volunteerTimingDTO(volunteerTiming volunteerTiming)
        {
            return new volunteerTimingDTO
            {
                id=volunteerTiming.id,
                fromHour=volunteerTiming.fromHour,
                toHour=volunteerTiming.toHour,
                groupVolunteerId=volunteerTiming.groupVolunteerId,
                weekday=volunteerTiming.weekday
            };
        }
        public volunteerTiming volunteerTiming(volunteerTimingDTO volunteerTimingDTO)
        {
            return new volunteerTiming
            {
                id = volunteerTimingDTO.id,
                fromHour = volunteerTimingDTO.fromHour,
                toHour = volunteerTimingDTO.toHour,
                groupVolunteerId = volunteerTimingDTO.groupVolunteerId,
                weekday = volunteerTimingDTO.weekday
            };
        }
           
    }
}
