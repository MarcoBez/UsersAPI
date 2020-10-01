using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PepkorITUserAPI.Logic
{
    /// <summary>  
    /// PepkorIT User API - Dbcode class to make connections to the Db
    /// Author: Marco Bezuidenhout September 2020
    /// </summary>
    public class DBCode
    {
        //globals
        OdbcConnection conn = new OdbcConnection();
        string gs_connString;

        public string DbCode()
        {
            //read connection string
            gs_connString = ConfigurationManager.ConnectionStrings["PITConnectionString"].ConnectionString;

            return gs_connString;
        }
        public string OdbcSqlLookupValue(string sql)
        {
            //set connstring
            DbCode();
            string value = "";

            try
            {
                SqlDataReader reader = null;
                using (SqlConnection conn = new SqlConnection(gs_connString))
                {
                    try
                    {
                        conn.Open();

                        using (SqlCommand com = new SqlCommand(sql, conn))
                        {
                            reader = com.ExecuteReader();
                        }

                        while (reader.Read())
                        {
                            value = reader[0].ToString();
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        reader.Close();
                        conn.Close();
                        return "-1";
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                return "-1";
            }
            return value;
        }

        public int OdbcSqlQuery(string sql)
        {
            //set connstring
            DbCode();

            using (var con = new SqlConnection(gs_connString))
            {
                try
                {
                    using (var cmd = new SqlCommand(sql, con))
                    {
                        con.Open();
                        cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    string message = ex.Message.ToString();
                    con.Close();
                    return -1;
                }
                con.Close();
            }
            return 0;           
        }

        public DataTable odbcSQLLookupDT(string sql)
        {
            //set connstring
            DbCode();

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(gs_connString))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                        {
                            adapter.Fill(dt);
                            conn.Close();
                        }
                        return dt;
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return dt;
                    }
                }
            }
            catch (Exception)
            {
                return dt;
            }

        }
    }
}