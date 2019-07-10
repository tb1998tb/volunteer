using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL.Convert
{
  public class Possible_schedule_for_VolunteerConverter
    {
        public static Possible_schedule_for_VolunteerDTO Possible_Schedule_For_VolunteerDTO(Possible_schedule_for_Volunteer possible_Schedule_For_Volunteer)
        {
            return new Possible_schedule_for_VolunteerDTO
            {
                id = possible_Schedule_For_Volunteer.id,
                weekDay = possible_Schedule_For_Volunteer.weekDay,
                fromHour = possible_Schedule_For_Volunteer.fromHour,
                toHour = possible_Schedule_For_Volunteer.toHour

               


            };
        }
        public static Possible_schedule_for_Volunteer Possible_Schedule_For_Volunteer(Possible_schedule_for_VolunteerDTO possible_Schedule_For_VolunteerDTO)
        {
            return new Possible_schedule_for_Volunteer
            {
                id = possible_Schedule_For_VolunteerDTO.id,
                weekDay = possible_Schedule_For_VolunteerDTO.weekDay,
                fromHour = possible_Schedule_For_VolunteerDTO.fromHour,
                toHour = possible_Schedule_For_VolunteerDTO.toHour
                
            };
        }
    }
}
