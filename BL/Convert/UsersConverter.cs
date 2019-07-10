using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BL.Convert
{
  public  class  UsersConverter
    {
        public static UsersDTO UsersDTO( User user)
        {
            return new UsersDTO
            {
                id = user.id,
                name = user.name,
                password = user.password,
                mail = user.mail,
                phone = user.phone
                
            };
        }
        public static User User(UsersDTO usersDTO)
        {
            return new User
            {
                id = usersDTO.id,
                name = usersDTO.name,
                password = usersDTO.password,
                mail = usersDTO.mail,
                phone = usersDTO.phone

            };
        }
    }
}
