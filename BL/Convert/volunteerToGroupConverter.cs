using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL.Convert
{
    public class volunteerToGroupConverter
    {
        public volunteerToGroupDTO volunteerToGroupDTO(volunteerToGroup volunteerToGroup)
        {
            return new volunteerToGroupDTO
            {
                id=volunteerToGroup.id,
                idGroup=volunteerToGroup.idGroup,
                idUser=volunteerToGroup.idUser


            };
        }
        public volunteerToGroup volunteerToGroup(volunteerToGroupDTO volunteerToGroupDTO)
        {
            return new volunteerToGroup
            {
                id = volunteerToGroupDTO.id,
                idGroup = volunteerToGroupDTO.idGroup,
                idUser = volunteerToGroupDTO.idUser




            };
        }

    }
}
