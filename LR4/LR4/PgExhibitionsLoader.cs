using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4
{
    public class PgExhibitionsLoader
    {
        private string connectionString = "Host=192.168.1.48;Username=st53-7;Password=537;Database=museum_exhibitions";

        public List<Exhibition> Load()
        {
            List<Exhibition> allExhibitions = new List<Exhibition>();
            try
            {
                using (var con = new NpgsqlConnection(connectionString))
                {
                    con.Open();
                    var sql = "SELECT place, date_and_time, performer, cost FROM exhibitions ORDER BY date_and_time";
                    var cmd = new NpgsqlCommand(sql, con);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Exhibition exhibition = new Exhibition
                        {
                            Place = reader.GetString(0),
                            DateAndTime = reader.GetDateTime(1),
                            Performer = reader.GetString(2),
                            Cost = reader.GetDecimal(3)
                        };
                        allExhibitions.Add(exhibition);
                    }
                }
                return allExhibitions;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
                return null;
            }
        }

        public bool DeleteExhibition(string place, DateTime dateAndTime)
        {
            try
            {
                using (var con = new NpgsqlConnection(connectionString))
                {
                    con.Open();
                    var sql = @"DELETE FROM exhibitions WHERE place = @place AND date_and_time = @date_and_time";
                    var cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@place", place);
                    cmd.Parameters.AddWithValue("@date_and_time", dateAndTime);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка удаления: {ex.Message}");
                return false;
            }
        }

        public bool AddExhibition(string place, DateTime dateAndTime, string performer, decimal cost)
        {
            try
            {
                using (var con = new NpgsqlConnection(connectionString))
                {
                    con.Open();
                    var sql = @"INSERT INTO exhibitions (place, date_and_time, performer, cost) 
                               VALUES (@place, @date_and_time, @performer, @cost)";
                    var cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@place", place);
                    cmd.Parameters.AddWithValue("@date_and_time", dateAndTime);
                    cmd.Parameters.AddWithValue("@performer", performer);
                    cmd.Parameters.AddWithValue("@cost", cost);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка добавления: {ex.Message}");
                return false;
            }
        }

        public bool UpdateExhibition(Exhibition oldExhibition, Exhibition newExhibition)
        {
            try
            {
                using (var con = new NpgsqlConnection(connectionString))
                {
                    con.Open();
                    var sql = @"UPDATE exhibitions SET place = @new_place, date_and_time = @new_date_and_time, performer = @new_performer, cost = @new_cost 
                                                                                            WHERE place = @old_place AND date_and_time = @old_date_and_time";
                    var cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@new_place", newExhibition.Place);
                    cmd.Parameters.AddWithValue("@new_date_and_time", newExhibition.DateAndTime);
                    cmd.Parameters.AddWithValue("@new_performer", newExhibition.Performer);
                    cmd.Parameters.AddWithValue("@new_cost", newExhibition.Cost);
                    cmd.Parameters.AddWithValue("@old_place", oldExhibition.Place);
                    cmd.Parameters.AddWithValue("@old_date_and_time", oldExhibition.DateAndTime);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Ошибка обновления: {ex.Message}");
                return false;
            }
        }
    }
}
    

