using LibraryApplication.Models;
using LibraryApplication.Repository;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using static LibraryApplication.Models.UserModel;

namespace LibraryApplication.Controllers
{
    public class UserController : ApiController
    {
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/userLogin")]
        [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
        public IHttpActionResult Login([FromBody] LoginCredentials loginData)
        {
            ConnectionClass cc = new ConnectionClass();
            cc.UserLogin(loginData);
            return Ok();

        }
    }
}
