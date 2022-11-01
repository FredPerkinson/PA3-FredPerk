using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Database
{
    public class ReadDriver
    {
        public void readDriver(Driver myDriver)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT id, 
                            firstName, 
                            rating, 
                            dateHired, 
                            deleted
                            FROM drivers";
                            // VALUES(@id, @firstName, @rating, @dateHired, @deleted)";
/////////////my SQL select statments w3 schools
            using var cmd = new MySqlCommand(stm, con);

            // cmd.Parameters.AddWithValue("@id", myDriver.id);
            // cmd.Parameters.AddWithValue("@firstName", myDriver.firstName);
            // cmd.Parameters.AddWithValue("@rating", myDriver.rating);
            // cmd.Parameters.AddWithValue("@dateHired", myDriver.dateHired);
            // cmd.Parameters.AddWithValue("@deleted", myDriver.deleted);

            cmd.Prepare();

            MySqlDataReader  reader = cmd.ExecuteReader();

            List<Driver> drivers = new List<Driver>();

           while (reader.Read()) {
            Driver myDriver = new Driver();
            myDriver.id = reader.GetString("id");
            myDriver.firstName = reader.GetString("firstName");
            myDriver.rating = reader.GetString("rating");
            myDriver.rating = reader.GetString("rating");
            myDriver.deleted = reader.GetString("deleted");
            drivers.Add(myDriver);
           }

           return drivers;
        }
    }
}