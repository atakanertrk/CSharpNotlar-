using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiForReact.Entities;
using ApiForReact.Models;
using Microsoft.AspNetCore.Cors;


namespace ApiForReact.Controllers
{
    
   
    [ApiController]
    public class UserController : ControllerBase
    {
        
        [HttpGet]
        [Route("api/get/getallusers")]
        public List<string> GetAllUsers()
        {
            UserDal userDal = new UserDal();
            return userDal.GetAllUsersName();
        }

        //this one gets usernotes with username and password
        [HttpPost]
        [Route("api/post/getusernotes")]
        public List<string> Post([FromBody] User user)
        {
            UserDal userDal = new UserDal();
            return userDal.GetUserNotes(user.userName, user.userPassword);
        }


        [HttpPost]
        [Route("api/post/isvalid")]
        public bool Post2([FromBody] User user)
        {
            UserDal userDal = new UserDal();
            return userDal.IsUserValid(user.userName,user.userPassword);
        }

        //this one gets usernotes with only using username. Password not required
        [HttpPost]
        [Route("api/post/getusernotesbyname")]
        public List<string> Post3([FromBody] User user)
        {
            UserDal userDal = new UserDal();
            return userDal.GetUserNotesByName(user.userName);
        }


    }
}
