using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

///////////add mysql using statements

namespace API.Database
{
    public class DeleteDriver
    {
        public static void DeleteDriverTable(){
            ConnectionString connectionString = new ConnectionString();
            string cs = connectionString.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"DROP TABLE IF EXISTS drivers";
            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery();
        }

        public void DeleteMyDriver(int id){
            ConnectionString connectionString = new ConnectionString();
            string cs = connectionString.cs;
            using var con = new MySqlConnection(cs);
            con.Open();
            Boolean deleted = true;

            string stm = @"UPDATE drivers SET delted = @delted WHERE id = @id";

            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@deleted", deleted);
            cmd.Prepare();

            // string stm2 = @"SELECT * FROM ORDER BY dateHired DESC";
            // cmd = MySqlCommand(stm2, cmd);
            // cmd.ExecuteNonQuery();
        }

//         public void RemoveDriver(Driver myDriver)
//         {
//             ConnectionString connectionString = new ConnectionString();
//             bool isOpen = connectionString.OpenConnection();

//             if(isOpen){
//                 MySqlConnection conn = connectionString.GetConn();
//                 MySqlCommand cmd = new MySqlCommand();

//                 cmd.Connection = conn;

//                 cmd.CommandText = @"DELETE FROM drivers WHERE id=@id";
//                 cmd.Parameters.AddWithValue("@id",id);
//                 cmd.Prepare();
//                 cmd.ExecuteNonQuery();
//             }




// //             ConnectionString myConnection = new ConnectionString();
// //             string cs = myConnection.cs;
// //             using var con = new MySqlConnection(cs);
// //             con.Open();

// //             string stm = @" drivers(id, firstName, rating, dateHired, deleted) VALUES(@id, @firstName, @rating, @dateHired, @deleted)";


// // ////////////sql update statements
// //             using var cmd = new MySqlCommand(stm, con);

// //             cmd.Parameters.AddWithValue("@id", myDriver.id);
// //             cmd.Parameters.AddWithValue("@firstName", myDriver.firstName);
// //             cmd.Parameters.AddWithValue("@rating", myDriver.rating);
// //             cmd.Parameters.AddWithValue("@dateHired", myDriver.dateHired);
// //             cmd.Parameters.AddWithValue("@deleted", myDriver.deleted);

// //             cmd.Prepare();

// //             cmd.ExecuteNonQuery();
// //         }

// //         public static void DropDriverTable()
// //         {
// //         ConnectionString myConnection = new ConnectionString();
// //         string cs = myConnection.cs;

// //         using var con = new MySqlConnection(cs);
// //         con.Open();

// //         string stm = @"DROP TABLE IF EXISTS drivers";

// //         using var cmd = new MySqlCommand(stm, con);

// //         cmd.ExecuteNonQuery();
//         }
    }
}