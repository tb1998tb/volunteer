using BL.Convert;
using DAL;
using DTO;
using System.Linq;
using System.Web;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BL.Helpers;
using BL.Helper;

namespace BL
{
    public class login
    {

        private static readonly Entities2 DB = new Entities2();
        public static UsersDTO Login(string mail, string password)
        {
            var user = DB.Users.Where(w => w.mail == mail && w.password == password).FirstOrDefault();

            HttpContext.Current.Session["User"] = user;
            if (user == null)
            {
                return null;
            }
            return UsersConverter.UsersDTO(user);
        }

        public static WebResult<UsersDTO> Account(UsersDTO usersDTO)
        {
            var user = UsersConverter.User(usersDTO);
            if (DB.Users.Any(p => p.mail == user.mail))
            {
                return new WebResult<UsersDTO>
                {
                    Success = true,
                    Message = "",
                    Value = UsersConverter.UsersDTO(user) ////פונקצית המרה +לעשות enum
                };
                //להחזיר שגיאה אם יש לך ערך....
            }
            if (user == null)
            {
                HttpContext.Current.Session["User"] = null;
                return null;
            }
            DB.Users.Add(user);
            if (DB.SaveChanges() > 0)
            {

                HttpContext.Current.Session["User"] = user;
                return new WebResult<UsersDTO>
                {
                    Success = true,
                    Message = "",
                    Value = UsersConverter.UsersDTO(user) ////פונקצית המרה +לעשות enum
                }; 
            }
             return new WebResult<UsersDTO>
            {
                Success = false,
                Message = "תקלה...",
                Value = null ////פונקצית המרה +לעשות enum
            }; ;

        }
    }


}
