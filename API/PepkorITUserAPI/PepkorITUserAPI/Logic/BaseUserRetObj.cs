using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PepkorITUserAPI.Models;

namespace PepkorITUserAPI.Logic
{
    /// <summary>  
    /// PepkorIT User API - base return object for functions
    /// Author: Marco Bezuidenhout September 2020
    /// </summary>
    public class BaseUserRetObj
    {
        //properties
        public int status { get; set; }
        public string message { get; set; }
        public List<User> users { get; set; }

        public BaseUserRetObj()
        {
            //
            // TODO: Add constructor logic here
            //

            users = new List<User>();
        }
    }
}