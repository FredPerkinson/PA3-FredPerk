using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Database
{
    public class DeleteDriver
    {
        public void RemoveDriver(Driver myDriver)
        {
            DBConnect db = new DBConnect();
            bool isOpen = db.OpenConnection();

            if(isOpen){
                MySqlConnection conn = db.GetConn();
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = @"DELETE FROM drivers WHERE id=@id";
                cmd.Parameters.AddWithValue("@id",id);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }




//             ConnectionString myConnection = new ConnectionString();
//             string cs = myConnection.cs;
//             using var con = new MySqlConnection(cs);
//             con.Open();

//             string stm = @" drivers(id, firstName, rating, dateHired, deleted) VALUES(@id, @firstName, @rating, @dateHired, @deleted)";


// ////////////sql update statements
//             using var cmd = new MySqlCommand(stm, con);

//             cmd.Parameters.AddWithValue("@id", myDriver.id);
//             cmd.Parameters.AddWithValue("@firstName", myDriver.firstName);
//             cmd.Parameters.AddWithValue("@rating", myDriver.rating);
//             cmd.Parameters.AddWithValue("@dateHired", myDriver.dateHired);
//             cmd.Parameters.AddWithValue("@deleted", myDriver.deleted);

//             cmd.Prepare();

//             cmd.ExecuteNonQuery();
//         }

//         public static void DropDriverTable()
//         {
//         ConnectionString myConnection = new ConnectionString();
//         string cs = myConnection.cs;

//         using var con = new MySqlConnection(cs);
//         con.Open();

//         string stm = @"DROP TABLE IF EXISTS drivers";

//         using var cmd = new MySqlCommand(stm, con);

//         cmd.ExecuteNonQuery();
        }
    }
}