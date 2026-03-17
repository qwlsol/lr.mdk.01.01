using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLTest
{
    public class PgUsersLoader
    {
        List<User> allusers = new List<User>();
        public List<User> Load()
        {
            var cs = "Host=192.168.1.48;Username=st50-12;Password=5012;Database=P-30_Student";

            var con = new NpgsqlConnection(cs);
            con.Open();
            var sql = "SELECT login,password,age,name FROM users";
            var cmd = new NpgsqlCommand(sql, con);
            var reader = cmd.ExecuteReader();
            List<string> login = new List<string>();
            while (reader.Read())
            {

                string log = reader.GetString(0);

                string pass = reader.GetString(1);
                login.Add(log + ":" + pass);


            }
            MessageBox.Show($"Логин : Пароль: {string.Join(", ", login)}");
            return allusers;
            
        }
        
    }
}
