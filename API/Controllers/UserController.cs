using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [RoutePrefix("api/User")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("Login")]
        public IHttpActionResult login(string mail ,string password )
        {
           return Ok(BL.login.Login(mail, password));
        }
        // GET: User
        [HttpPost]
        [Route("account")]
        public IHttpActionResult account([FromBody]DTO.UsersDTO user)
        {
            return Ok(BL.login.Account(user));
        }

        [HttpGet]
        [Route("GetUser")]
        public IHttpActionResult GetUser()
        {
            return Ok(HttpContext.Current.Session["User"]);
        }
        //[HttpPost]
        //[Route("Possible_schedule_for_Volunteer")]
        //public IHttpActionResult Possible_schedule_for_Volunteer([FromBody]DTO.Possible_schedule_for_VolunteerDTO)
        //{
        //    //return Ok(BL.user.)

        //}

    }
}