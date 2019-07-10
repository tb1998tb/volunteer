using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using DTO;

namespace API.Controllers
{
    [RoutePrefix("api/Group")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class GrouController : ApiController
    {

        [HttpPost]
        [Route("addGroup")]
        public IHttpActionResult addGroup([FromBody]DTO.groupVolunteeryDTO groupVolunteeryDTO)
        {

            return Ok(BL.groupVolunteer.AddNewGroup(groupVolunteeryDTO));

        }
    }
}
///////
/// [EnableCors(origins:"*",headers:"*",methods:"*")]
//[RoutePrefix("api/user")]
//public class UserController : ApiController
//{
//    [Route("getall")]
//    [HttpGet]
//    public IHttpActionResult getSubjectJob()
//    {
//        return Ok(BLL.UserLogic.getUsers());
//    }
//    [Route("CheckUser")]
//    [HttpGet]
//    public IHttpActionResult CheckUser()
//    {
//        return Ok(BLL.UserLogic.CheckUser());
//    }


//    [Route("getAlboms")]
//    [HttpPost]
//    public IHttpActionResult getaAlbums(int UserId)
//    {
//        return Ok(BLL.UserLogic.getAlbums(UserId));
//    }

//}