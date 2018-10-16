using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using ProfileManagement.Models;

namespace ProfileManagement
{
    public class DataAccess
    {
        private SQLiteConnection sqlite;
        private SQLiteDataAdapter ad;
        private SQLiteCommand cmd;

        public DataAccess()
        {
            sqlite = new SQLiteConnection("Data Source=./ProfileDB.db");
        }

        public List<Users> GetAllUsers()
        {

            DataTable dt = new DataTable();
            sqlite.Open();
            cmd = sqlite.CreateCommand();
            cmd.CommandText = "select * from Users";
            ad = new SQLiteDataAdapter(cmd);
            ad.Fill(dt);
            List<Users> UserList = new List<Users>();
            foreach (DataRow row in dt.Rows)
            {
                Users MyUser = new Users
                {
                    Id = Convert.ToInt32(row["Id"]),
                    FirstName = row["FirstName"].ToString(),
                    LastName = row["LastName"].ToString(),
                    Email = row["Email"].ToString(),
                    Type = row["Type"].ToString(),
                    Gender = row["Gender"].ToString(),
                    DOB = row["DateOfBirth"].ToString(),
                    MaritalStatus = row["MaritalStatus"].ToString(),
                    DOM = row["DateOfMarriage"].ToString()
                };
                UserList.Add(MyUser);
            }
            sqlite.Close();

            return UserList;
        }

        public Users GetCurrentUser(int id)
        {
            DataTable dt = new DataTable();
            sqlite.Open();
            cmd = sqlite.CreateCommand();
            cmd.CommandText = "select * from Users where id=" + id.ToString();
            ad = new SQLiteDataAdapter(cmd);
            ad.Fill(dt);
            Users MyUser = new Users();
            foreach (DataRow row in dt.Rows)
            {
                MyUser.Id = Convert.ToInt32(row["Id"]);
                MyUser.FirstName = row["FirstName"].ToString();
                MyUser.LastName = row["LastName"].ToString();
                MyUser.Email = row["Email"].ToString();
                MyUser.Type = row["Type"].ToString();
                MyUser.Gender = row["Gender"].ToString();
                MyUser.DOB = row["DateOfBirth"].ToString();
                MyUser.MaritalStatus = row["MaritalStatus"].ToString();
                MyUser.DOM = row["DateOfMarriage"].ToString();
            }
            sqlite.Close();

            return MyUser;
        }

        public void SaveUser(NewUser value)
        {
            sqlite.Open();
            cmd = sqlite.CreateCommand();
            cmd.CommandText = "insert into Users (Email, Password, FirstName, Lastname, Type, DateOfBirth, Gender, MaritalStatus, DateOfMarriage) values (@Email, @Password, @FirstName, @Lastname, @Type, @DOB, @Gender, @MaritalStatus, @DOM)";
            SQLiteParameter p1 = new SQLiteParameter("Email", value.Email);
            SQLiteParameter p2 = new SQLiteParameter("Password", value.Password);
            SQLiteParameter p3 = new SQLiteParameter("FirstName", value.FirstName);
            SQLiteParameter p4 = new SQLiteParameter("LastName", value.LastName);
            SQLiteParameter p5 = new SQLiteParameter("Type", value.Type);
            SQLiteParameter p6 = new SQLiteParameter("DOB", value.DOB);
            SQLiteParameter p7 = new SQLiteParameter("Gender", value.Gender);
            SQLiteParameter p8 = new SQLiteParameter("MaritalStatus", value.MaritalStatus);
            SQLiteParameter p9 = new SQLiteParameter("DOM", value.DOM);

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);
            cmd.Parameters.Add(p9);

            cmd.ExecuteNonQuery();
            sqlite.Close();
        }

        public void UpdateUser(int id, Users value)
        {
            sqlite.Open();
            cmd = sqlite.CreateCommand();
            cmd.CommandText = "update Users set Email=@Email, FirstName=@FirstName, Lastname=@Lastname, Type=@Type, DateOfBirth=@DOB, Gender=@Gender, MaritalStatus=@MaritalStatus, DateOfMarriage=@DOM where Id=" + id.ToString();
            SQLiteParameter p1 = new SQLiteParameter("Email", value.Email);
            SQLiteParameter p2 = new SQLiteParameter("FirstName", value.FirstName);
            SQLiteParameter p3 = new SQLiteParameter("LastName", value.LastName);
            SQLiteParameter p4 = new SQLiteParameter("Type", value.Type);
            SQLiteParameter p5 = new SQLiteParameter("DOB", value.DOB);
            SQLiteParameter p6 = new SQLiteParameter("Gender", value.Gender);
            SQLiteParameter p7 = new SQLiteParameter("MaritalStatus", value.MaritalStatus);
            SQLiteParameter p8 = new SQLiteParameter("DOM", value.DOM);

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);


            cmd.ExecuteNonQuery();
            sqlite.Close();
        }

        public void DeleteUser(int id)
        {
            sqlite.Open();
            cmd = sqlite.CreateCommand();
            cmd.CommandText = "delete from Users where Id = " + id.ToString();
            cmd.ExecuteNonQuery();
            sqlite.Close();
        }

        //public string Login(Login info)
        //{
        //    string result = "Invalid Login Credentials";
        //    DataTable dt = new DataTable();
        //    sqlite.Open();
        //    cmd = sqlite.CreateCommand();
        //    cmd.CommandText = "select * from Users where Email=" + info.Username;
        //    ad = new SQLiteDataAdapter(cmd);
        //    ad.Fill(dt);

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        if (info.Password == row["Password"].ToString())
        //        {
        //            result = "Login Successful";
        //        }
        //        else
        //        {
        //            result = "Invalid Login Credentials";
        //        }
        //    }

        //    return result;
        //}
    }
}
