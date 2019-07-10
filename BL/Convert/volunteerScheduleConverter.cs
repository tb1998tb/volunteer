using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL.Convert
{
    public class volunteerScheduleConverter
    {
        public volunteerScheduleDTO volunteerScheduleDTO(volunteerSchedule volunteerSchedule)
        {
            return new volunteerScheduleDTO
            {
                id = volunteerSchedule.id,
                comment = volunteerSchedule.comment,
                FromHour = volunteerSchedule.fromHour,
                toHour = volunteerSchedule.toHour,
                volunteerToGroupId = volunteerSchedule.volunteerToGroupId,
                weekDay = volunteerSchedule.weekDay
            };
        }
        public volunteerSchedule volunteerSchedule(volunteerScheduleDTO volunteerScheduleDTO)
        {
            return new volunteerSchedule
            {
                id = volunteerScheduleDTO.id,
                comment = volunteerScheduleDTO.comment,
                fromHour = volunteerScheduleDTO.FromHour,
                toHour = volunteerScheduleDTO.toHour,
                volunteerToGroupId = volunteerScheduleDTO.volunteerToGroupId,
                weekDay = volunteerScheduleDTO.weekDay
            };
        }
    }
}
