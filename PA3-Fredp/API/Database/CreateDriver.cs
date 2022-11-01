using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; ////////////////////

namespace PA3_Fredp.API.Database
{
    public class CreateDriver
    {
        public void createDriver(Driver myDriver)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSET INTO drivers(title, authors) VALUES(@title, @author)"; ////////////////////////////////fix names

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@title", myDriver.Title);
            cmd.Parameters.AddWithValue("@author", myDriver.Author);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
    }
}