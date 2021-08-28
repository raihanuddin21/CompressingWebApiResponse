using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CompressResponse.Filters;
using CompressResponse.Models;

namespace CompressResponse.Controllers
{
    public class UserController : ApiController
    {
        [GzipCompression]
        public IHttpActionResult Get()
        {
            List<UserModel> users = new List<UserModel>();
            for (int i = 0; i < 100; i++)
            {
                var user = new UserModel()
                {
                    Id = new Guid().ToString(),
                    Name = new Guid().ToString(),
                    Address = new Guid().ToString()
                };
                users.Add(user);
            }
            return Ok(users);
        }
    }
}
