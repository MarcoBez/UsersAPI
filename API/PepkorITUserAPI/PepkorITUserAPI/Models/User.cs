using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PepkorITUserAPI.Models
{
    /// <summary>  
    /// PepkorIT User API - User object that defines a user
    /// Author: Marco Bezuidenhout September 2020
    /// </summary>
    public class User
    {
        /// <summary>  
        /// Required fields for DB -
        /// name
        /// surname
        /// email
        /// cell_no
        /// </summary>
        string name;
        string surname;
        string email;
        string cell_no;

        /// <summary>  
        /// Additional fields for DB -
        /// title
        /// age
        /// dob
        /// addr_1
        /// addr_2
        /// town
        /// province
        /// p_code
        /// tel_no
        /// </summary>
        string title;
        string age;
        string dob;
        string addr_1;
        string addr_2;
        string town;
        string province;
        string p_code;
        string tell_no;

        /// <summary>  
        /// Name - not null - type string - Name of the user
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>  
        /// Surname - not null - type string - Surname of the user
        /// </summary>
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        /// <summary>  
        /// EmailAddr - not null - type string - unique identifier - User's email address
        /// </summary>
        public string EmailAddr
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>  
        /// CellNo - not null - type string - User's cellphone number
        /// </summary>
        public string CellNo
        {
            get { return cell_no; }
            set { cell_no = value; }
        }

        /// <summary>  
        /// Title - null - type string - Mr, Mrs, Ms, Dr, Prof
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        /// <summary>  
        /// Age - null - type int - Age of the user
        /// </summary>
        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        /// <summary>  
        /// Dob - null - type string (yyyy-MM-dd) - Date of birth of the user
        /// </summary>
        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        /// <summary>  
        /// Addr1 - null - type int - 1st address line
        /// </summary>
        public string Addr1
        {
            get { return addr_1; }
            set { addr_1 = value; }
        }

        /// <summary>  
        /// Addr2 - null - type int - 2nd address line
        /// </summary>
        public string Addr2
        {
            get { return addr_2; }
            set { addr_2 = value; }
        }

        /// <summary>  
        /// Town - null - type int - the Town where the user stays
        /// </summary>
        public string Town
        {
            get { return town; }
            set { town = value; }
        }

        /// <summary>  
        /// Province - null - type int - the Province where the user stays
        /// </summary>
        public string Province
        {
            get { return province; }
            set { province = value; }
        }

        /// <summary>  
        /// Pcode - null - type int - the postal code od the area where the user stays
        /// </summary>
        public string Pcode
        {
            get { return p_code; }
            set { p_code = value; }
        }

        /// <summary>  
        /// TellNo - not null - type string - User's telephone number
        /// </summary>
        public string TellNo
        {
            get { return tell_no; }
            set { tell_no = value; }
        }
    }
}