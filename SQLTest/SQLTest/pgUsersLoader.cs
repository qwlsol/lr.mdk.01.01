using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace SQLTest
{
    public class PgUsersLoader
    {

        public List<User> Load()
        {
            List<User> allusers = new List<User>();
            try
            {
                var cs = "Host=192.168.1.48;Username=st56-7;Password=567;Database=p-30_user";

                var con = new NpgsqlConnection(cs);
                con.Open();
                var sql = "SELECT login,password,age,name FROM users";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User
                    {
                        Login = reader.GetString(0),
                        Password = reader.GetString(1),
                        Age = reader.GetInt32(2),
                        Name = reader.GetString(3),
                    };
                    allusers.Add(user);
                }
                return allusers;
            }
            catch (Exception ex) 
            {
                MessageBox.Show($" Ошибка: {ex.Message}");
                return null;
            }
        }
        public bool DeleteUser(string login)
        {
            try
            {
                var cs = "Host=192.168.1.48;Username=st56-7;Password=567;Database=p-30_user";
                var con = new NpgsqlConnection(cs);
                con.Open();
                var sql = @"DELETE FROM users WHERE login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", login);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch(NpgsqlException ex) 
            {
                MessageBox.Show($" Ошибка: {ex.Message}");
                return false;
            }
            
            

        }
        public bool AddUser(string login, string password, int age,string name)
        {
            try
            {
                var cs = "Host=192.168.1.48;Username=st56-7;Password=567;Database=p-30_user";
                var con = new NpgsqlConnection(cs);
                con.Open();
                var sql = @"INSERT INTO users (login, password, age, name) VALUES (@login, @password, @age, @name)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@name", name);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                return false;
            }
            
        }
    }
}
