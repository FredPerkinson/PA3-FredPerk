using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Database
{
    public class EditDriver
    {
        public void createDriver(Driver myDriver)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE drivers(id, firstName, rating, dateHired, deleted) VALUES(@id, @firstName, @rating, @dateHired, @deleted)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@id", myDriver.id);
            cmd.Parameters.AddWithValue("@firstName", myDriver.firstName);
            cmd.Parameters.AddWithValue("@rating", myDriver.rating);
            cmd.Parameters.AddWithValue("@dateHired", myDriver.dateHired);
            cmd.Parameters.AddWithValue("@deleted", myDriver.deleted);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
    }
}