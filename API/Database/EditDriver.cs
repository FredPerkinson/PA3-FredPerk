using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace API.Database
{
    public class EditDriver
    {
        public void UpdateDriver(Driver drivers)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE drivers(id, firstName, rating, dateHired, deleted) VALUES(@id, @firstName, @rating, @dateHired, @deleted)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@id", drivers.id);
            cmd.Parameters.AddWithValue("@firstName", drivers.firstName);
            cmd.Parameters.AddWithValue("@rating", drivers.rating);
            cmd.Parameters.AddWithValue("@dateHired", drivers.dateHired);
            cmd.Parameters.AddWithValue("@deleted", drivers.deleted);

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            // string stm2 = @"SELECT * FROM drivers ORDER BY dateHired DESC";
            // cmd = MySqlCommand(stm2, cmd);
            // cmd.ExecuteNonQuery();
        }
    }
}