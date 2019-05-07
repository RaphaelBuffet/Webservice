using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using BLL;
using DTO;

namespace REST.Controllers
{
    [System.Web.Http.RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        [System.Web.Http.Route("{username:string}")]
        [System.Web.Http.HttpGet]
        public User getUserAccount(string username)
        {
            return BLL.UserManager.getUserAccount(username);
        }

        [System.Web.Http.HttpPut]
        public IHttpActionResult addCHFByUserName([FromBody]string userName, decimal chf)
        {
            int udResult = UserManager.addCHFByUserName(userName, chf);

            if (udResult == null)
            {
                return NotFound();
            }

            return Ok(udResult);
        }

        [System.Web.Http.HttpPut]
        public IHttpActionResult addCHFByUID([FromBody]int UID, decimal chf)
        {
            int udResult = UserManager.addCHFByUID(UID, chf);

            return Ok(udResult);

        }
    }
}