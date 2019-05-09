using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using BLL;
using DTO;

namespace REST.Controllers
{
    [System.Web.Http.RoutePrefix("api/user")]
    public class UsersController : ApiController
    {
        [System.Web.Http.Route("username/{username}")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult getUserAccount(string username)
        {
            User tempUser = BLL.UserManager.getUserAccount(username);

            string userString = "UserId: \t" + tempUser.userId + "\n" +
                                "userName: \t" + tempUser.userName + "\n" +
                                "CHF:\t\t" + tempUser.CHF + "\n" +
                                "cardId:\t\t" + tempUser.cardId + "\n";

            return Ok(userString);
        }
        
        [System.Web.Http.Route("addCHFbyUsername")]
        [System.Web.Http.HttpPut]
        public IHttpActionResult addCHFByUserName([FromBody]User user)
        {
            UserManager.addCHFByUserName(user.userName, user.CHF);

            if(user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [System.Web.Http.Route("addCHFByUID")]
        [System.Web.Http.HttpPut]
        public IHttpActionResult addCHFByUID([FromBody]User user)
        {
            UserManager.addCHFByUID(user.userId, user.CHF);

            return Ok(user);

        }

        [System.Web.Http.Route("userId/{UID}")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult getUsernameByUserID([FromBody]int UID)
        {
            string username = CardManager.getUsernameByUserID(UID);

            return Ok(username);
        }

    }
}