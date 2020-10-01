using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PepkorITUserAPI.Models;
using PepkorITUserAPI.Logic;

namespace PepkorITUserAPI.Controllers
{
    /// <summary>  
    /// PepkorIT User API - Create, Retrieve, Update Delete
    /// Author: Marco Bezuidenhout September 2020
    /// </summary>
    public class UserController : ApiController
    {
        //Globals
        Methods meth = new Methods();
        BaseUserRetObj ret_obj = new BaseUserRetObj();

        /// <summary>  
        /// Retrieves all the users
        /// </summary>
        [Route("api/user/get_all/")]
        public BaseUserRetObj GetAllUsers()
        {
            //API and DB
            ret_obj = meth.GetAllUsers();
            return ret_obj;
        }

        /// <summary>  
        /// Gets a user based on email address 
        /// </summary>
        /// <param name="emailAddr">The email address (string) is the unique identifier of a user.</param>
        [Route("api/user/get/")]
        public BaseUserRetObj GetUser(string emailAddr)
        {
            // API and DB
            ret_obj = meth.GetUser(emailAddr);
            return ret_obj;
        }

        /// <summary>  
        /// Adds a new user
        /// </summary>
        /// <param name="usr">This is the user object required to add a new current user.</param>
        [Route("api/user/add/")]
        public BaseUserRetObj AddUser(User usr)
        {
            //API and DB
            ret_obj = meth.AddUser(usr);
            return ret_obj;
        }

        /// <summary>  
        /// Updates the data of a user 
        /// </summary>
        /// <param name="usr">This is the user object required to update the current user.</param>
        [Route("api/user/update/")]
        public BaseUserRetObj UpdateUser(User usr)
        {
            //API and DB
            ret_obj = meth.UpdateUser(usr);
            return ret_obj;
        }

        /// <summary>  
        /// Deletes a user based on email address 
        /// </summary>
        /// <param name="emailAddr">The email address (string) is the unique identifier of a user.</param>
        [Route("api/user/delete/")]
        public BaseUserRetObj DeleteUser(string emailAddr)
        {
            // API and DB
            ret_obj = meth.DeleteUser(emailAddr);
            return ret_obj;
        }

        /// <summary>  
        /// Deletes all users based from the db
        /// </summary>
        [Route("api/user/delete_all/")]
        public BaseUserRetObj DeleteAllUsers()
        {
            //API and DB
            ret_obj = meth.DeleteAllUsers();
            return ret_obj;
        }
    }
}
