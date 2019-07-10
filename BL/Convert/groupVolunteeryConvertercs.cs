using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL.Convert
{
   public class groupVolunteeryConvertercs
    {
        public static groupVolunteeryDTO groupVolunteeryDTO(groupVolunteery groupVolunteery)
        {
            return new groupVolunteeryDTO
            {id=groupVolunteery.id,
            managerId=groupVolunteery.managerId,
            nameGroup=groupVolunteery.nameGroup,
            sum_hour_in_night=groupVolunteery.sum_hour_in_night,
            sum_hour_volunteering_for_week=groupVolunteery.sum_hour_volunteering_for_week,
            from_hour_in_night=groupVolunteery.from_hour_in_night,
            to_hour_in_night=groupVolunteery.to_hour_in_night
            
            
           

            };
        }
        public static groupVolunteery groupVolunteery(groupVolunteeryDTO groupVolunteeryDTO)
        {
            return new groupVolunteery {
                id=groupVolunteeryDTO.id,
                managerId=groupVolunteeryDTO.managerId,
                nameGroup=groupVolunteeryDTO.nameGroup,
                sum_hour_volunteering_for_week=groupVolunteeryDTO.sum_hour_volunteering_for_week,
                sum_hour_in_night=groupVolunteeryDTO.sum_hour_in_night,
                from_hour_in_night=groupVolunteeryDTO.from_hour_in_night,
                to_hour_in_night=groupVolunteeryDTO.to_hour_in_night
                

                
                
            


            };
            
        }
    }
}
