using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BL.Convert;

namespace BL
{
   public class user
    {
        public static readonly Entities2 DB = new Entities2();
        //public static Possible_schedule_for_VolunteerDTO Possible_Schedule_For_Volunteer (Possible_schedule_for_VolunteerDTO possible_Schedule_For_VolunteerDTO)
        //{
        //    Possible_schedule_for_Volunteer possible_Schedule_For_Volunteer = BL.Convert.Possible_schedule_for_VolunteerConverter.Possible_Schedule_For_Volunteer(possible_Schedule_For_VolunteerDTO);
        //    return DB.Possible_schedule_for_Volunteer.Where(p=>p.id==possible_Schedule_For_Volunteer.id.ToString().Where(q=>q.))
        //}

    }
}
