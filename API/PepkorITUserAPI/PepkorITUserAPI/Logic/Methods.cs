using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PepkorITUserAPI.Models;

namespace PepkorITUserAPI.Logic
{
    /// <summary>  
    /// PepkorIT User API - Methods class is used to do the bulk of the logic
    /// Author: Marco Bezuidenhout September 2020
    /// </summary>
    public class Methods
    {
        //globals
        DBCode db = new DBCode();
        BaseUserRetObj ret_obj = new BaseUserRetObj();

        /// <summary>  
        /// constructor
        /// </summary>
        public Methods()
        {
            //constructor
            db.DbCode();
        }

        /// <summary>  
        /// get all users
        /// </summary>
        public BaseUserRetObj GetAllUsers()
        {
            List<User> ls_user = new List<User>();

            //call sp
            string sql_sp = "EXEC dbo.sp_get_all_users";

            //Build User details lists
            DataTable dt_all_users = db.odbcSQLLookupDT(sql_sp);

            //Check DT return 0
            int cnt = dt_all_users.Rows.Count;
            if (cnt == 0)
            {
                //fail               
                ret_obj.status = -1;
                ret_obj.message = "no users found";
                ret_obj.users = null;
                return ret_obj;
            }
            //----------------------------

            foreach (DataRow data_row in dt_all_users.Rows)
            {
                //assign vairables
                User get_usr = new User();
                get_usr.Title = data_row["title"].ToString();
                get_usr.Name = data_row["name"].ToString();
                get_usr.Surname = data_row["surname"].ToString();
                get_usr.EmailAddr = data_row["email"].ToString();
                get_usr.Dob = data_row["dob"].ToString();
                get_usr.Age = data_row["age"].ToString();
                get_usr.Addr1 = data_row["addr_1"].ToString();
                get_usr.Addr2 = data_row["addr_2"].ToString();
                get_usr.Town = data_row["town"].ToString();
                get_usr.Province = data_row["province"].ToString();
                get_usr.Pcode = data_row["p_code"].ToString();
                get_usr.TellNo = data_row["tel_no"].ToString();
                get_usr.CellNo = data_row["cel_no"].ToString();

                ls_user.Add(get_usr);
            }

            //success
            ret_obj.status = 0;
            ret_obj.message = "success";
            ret_obj.users = ls_user;
            return ret_obj;
        }

        /// <summary>  
        /// get a user
        /// </summary>
        public BaseUserRetObj GetUser(string email)
        {
            List<User> ls_user = new List<User>();

            //call sp
            string sql_sp = "EXEC dbo.sp_get_user '" + email + "'";

            //Build User details lists
            DataTable dt_all_users = db.odbcSQLLookupDT(sql_sp);

            //Check DT return 0
            int cnt = dt_all_users.Rows.Count;
            if (cnt == 0)
            {
                //fail               
                ret_obj.status = -1;
                ret_obj.message = "no user found";
                ret_obj.users = null;
                return ret_obj;
            }
            //----------------------------

            foreach (DataRow data_row in dt_all_users.Rows)
            {
                //assign vairables
                User get_usr = new User();
                get_usr.Title = data_row["title"].ToString();
                get_usr.Name = data_row["name"].ToString();
                get_usr.Surname = data_row["surname"].ToString();
                get_usr.EmailAddr = data_row["email"].ToString();
                get_usr.Dob = data_row["dob"].ToString();
                get_usr.Age = data_row["age"].ToString();
                get_usr.Addr1 = data_row["addr_1"].ToString();
                get_usr.Addr2 = data_row["addr_2"].ToString();
                get_usr.Town = data_row["town"].ToString();
                get_usr.Province = data_row["province"].ToString();
                get_usr.Pcode = data_row["p_code"].ToString();
                get_usr.TellNo = data_row["tel_no"].ToString();
                get_usr.CellNo = data_row["cel_no"].ToString();

                ls_user.Add(get_usr);
            }

            //success
            ret_obj.status = 0;
            ret_obj.message = "succesfully retrieved user";
            ret_obj.users = ls_user;
            return ret_obj;
        }


        /// <summary>  
        /// add a user
        /// </summary>
        public BaseUserRetObj AddUser(User usr)
        {
            List<User> ls_user = new List<User>();

            //get title code
            int i_title = UserTitleCode(usr.Title);
            //get province code
            int i_prov = UserProvinceCode(usr.Province);

            //call sp
            string sql_sp = "EXEC dbo.sp_add_user " + i_title + ",'" + usr.Name+ "','" + usr.Surname + "','" + usr.EmailAddr + "','" + usr.Dob + "','" + usr.Age + "','" + usr.Addr1 + "','" + usr.Addr2 + "','" + usr.Town + "'," + i_prov + ",'" + usr.Pcode + "','" + usr.TellNo + "','" + usr.CellNo + "'";

            int result = db.OdbcSqlQuery(sql_sp);

            if (result != 0)
            {
                //fail               
                ret_obj.status = -1;
                ret_obj.message = "User creation failed";
                ret_obj.users = null;
                return ret_obj;
            }

            //ls_user.Add(usr);
            ret_obj = GetUser(usr.EmailAddr);

            if (ret_obj.status != 0)
            {
                //fail               
                ret_obj.status = -2;
                ret_obj.message = "could not retrieve new user";
                ret_obj.users = null;
                return ret_obj;
            }

            //success
            ret_obj.status = 0;
            ret_obj.message = "succesfully added a new user";
            //ret_obj.users = ls_user;
            return ret_obj;
        }

        /// <summary>  
        /// update a user
        /// </summary>
        public BaseUserRetObj UpdateUser(User usr)
        {
            List<User> ls_user = new List<User>();

            //get title code
            int i_title = UserTitleCode(usr.Title);
            //get province code
            int i_prov = UserProvinceCode(usr.Province);

            //call sp
            string sql_sp = "EXEC dbo.sp_update_user " + i_title + ",'" + usr.Name + "','" + usr.Surname + "','" + usr.EmailAddr + "','" + usr.Dob + "','" + usr.Age + "','" + usr.Addr1 + "','" + usr.Addr2 + "','" + usr.Town + "'," + i_prov + ",'" + usr.Pcode + "','" + usr.TellNo + "','" + usr.CellNo + "'";

            int result = db.OdbcSqlQuery(sql_sp);

            if (result != 0)
            {
                //fail               
                ret_obj.status = -1;
                ret_obj.message = "User update failed";
                ret_obj.users = null;
                return ret_obj;
            }

            //ls_user.Add(usr);
            ret_obj = GetUser(usr.EmailAddr);

            if (ret_obj.status != 0)
            {
                //fail               
                ret_obj.status = -2;
                ret_obj.message = "could not retrieve user details";
                ret_obj.users = null;
                return ret_obj;
            }

            //success
            ret_obj.status = 0;
            ret_obj.message = "succesfully updated the user details";
            //ret_obj.users = ls_user;
            return ret_obj;
        }

        /// <summary>  
        /// delete a user
        /// </summary>
        public BaseUserRetObj DeleteUser(string email)
        {
            //call sp
            string sql_sp = "EXEC dbo.sp_delete_user '" + email + "'";

            int result = db.OdbcSqlQuery(sql_sp);

            if (result != 0)
            {
                //fail               
                ret_obj.status = -1;
                ret_obj.message = "User removal failed";
                ret_obj.users = null;
                return ret_obj;
            }

            //success
            ret_obj.status = 0;
            ret_obj.message = "successfully removed user";
            ret_obj.users = null;
            return ret_obj;
        }

        /// <summary>  
        /// delete all users from the db
        /// </summary>
        public BaseUserRetObj DeleteAllUsers()
        {
            //call sp
            string sql_sp = "EXEC dbo.sp_delete_all_users";

            int result = db.OdbcSqlQuery(sql_sp);

            if (result != 0)
            {
                //fail               
                ret_obj.status = -1;
                ret_obj.message = "Users removal failed";
                ret_obj.users = null;
                return ret_obj;
            }

            //success
            ret_obj.status = 0;
            ret_obj.message = "successfully removed all users";
            ret_obj.users = null;
            return ret_obj;
        }


        private int UserTitleCode(string title)
        {
            int i_title = 5; //x

            switch (title)
            {
                case "Ms":
                    i_title = 0;
                    break;

                case "Mr":
                    i_title = 1;
                    break;

                case "Mrs":
                    i_title = 2;
                    break;

                case "Dr":
                    i_title = 3;
                    break;

                case "Prof":
                    i_title = 4;
                    break;

                default:
                    return i_title;
            }

            return i_title;
        }

        private int UserProvinceCode(string province)
        {
            int i_prov = 9; //mielie

            switch (province)
            {
                case "Western Cape":
                    i_prov = 0;
                    break;

                case "Northern Cape":
                    i_prov = 1;
                    break;

                case "Eastern Cape":
                    i_prov = 2;
                    break;

                case "Free State":
                    i_prov = 3;
                    break;

                case "Kwazulu-Natal":
                    i_prov = 4;
                    break;

                case "North West":
                    i_prov = 5;
                    break;

                case "Gauteng":
                    i_prov = 6;
                    break;

                case "Mpumalanga":
                    i_prov = 7;
                    break;

                case "Limpopo":
                    i_prov = 8;
                    break;

                default:
                    return i_prov;
            }

            return i_prov;
        }
    }
}