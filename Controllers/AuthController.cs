using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace kubernetes_net_core_noob.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<UserLogin>> GetUserLogins()
        {
            return new UserLogin[] { 
                new UserLogin() { UserName="admin", FirstName="Master", LastName="User", DateOfBirth="fsdfdf " }, 
                new UserLogin() { UserName="asdaa", FirstName="asdasd", LastName="fghghf", DateOfBirth="hgfjg " },
                new UserLogin() { UserName="cvbvcb", FirstName="Magfhsgster", LastName="thfhfgsg", DateOfBirth="dfhddfh " },
                new UserLogin() { UserName="tiuyfdg", FirstName="werewrew", LastName="kjhuk", DateOfBirth="fghgfh " },
                };
        }

        public class UserLogin{
            public string UserName {get;set;}
            public string FirstName {get;set;}
            public string LastName {get;set;}
            public string DateOfBirth {get;set;}

        }
       
    }
}
