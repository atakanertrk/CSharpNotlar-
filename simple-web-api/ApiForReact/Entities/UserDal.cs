using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Data;


namespace ApiForReact.Entities
{
    public class UserDal
    {
        SqlConnection _connection = new SqlConnection(@"");

        //string _connection = File.ReadAllText("./conStr.txt");
        public bool IsUserValid(string userName, string userPassword)
        {
            _connection.Open();
            //@ kullanıp @userName kısmını ' içine alman gerekebillir
            SqlCommand command = new SqlCommand("select userName,userPassword from dbo.tbl_users where userName=@userName and userPassword=@userPassword", _connection);
            command.Parameters.AddWithValue("@userName",userName);
            command.Parameters.AddWithValue("@userPassword", userPassword);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                _connection.Close();
                return true;
            }
            else
            {
                reader.Close();
                _connection.Close();
                return false;
            }

        }
        public List<string> GetUserNotes(string userName, string userPassword)
        {
            bool isUserValid = IsUserValid(userName,userPassword);
            if (isUserValid == true)
            {
                _connection.Open();
                SqlCommand command = new SqlCommand("select note from dbo.tbl_notes where userName=@userName", _connection);
                command.Parameters.AddWithValue("@userName", userName);
                SqlDataReader reader = command.ExecuteReader();
                List<string> resultslist = new List<string>();
                using (DataTable dataTable = new DataTable())
                {
                    dataTable.Load(reader);
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        resultslist.Add(dataTable.Rows[i][0].ToString());
                    }
                }
                reader.Close();
                _connection.Close();
                return resultslist;
            }
            List<string> result = new List<string>();
            result.Add("notvalid");
            return result;
           
        }


        public List<string> GetAllUsersName()
        {
                _connection.Open();
                SqlCommand command = new SqlCommand("select userName from dbo.tbl_users ", _connection);
                 SqlDataReader reader = command.ExecuteReader();
                List<string> resultslist = new List<string>();
                using (DataTable dataTable = new DataTable())
                {
                    dataTable.Load(reader);
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        resultslist.Add(dataTable.Rows[i][0].ToString());
                    }
                }
                reader.Close();
                _connection.Close();
                return resultslist;

        }


        public List<string> GetUserNotesByName(string userName)
        {
                _connection.Open();
                SqlCommand command = new SqlCommand("select note from dbo.tbl_notes where userName=@userName", _connection);
                command.Parameters.AddWithValue("@userName", userName);
                SqlDataReader reader = command.ExecuteReader();
                List<string> resultslist = new List<string>();
                using (DataTable dataTable = new DataTable())
                {
                    dataTable.Load(reader);
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        resultslist.Add(dataTable.Rows[i][0].ToString());
                    }
                }
                reader.Close();
                _connection.Close();
                return resultslist;
           }


    }
}
