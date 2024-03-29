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
    public class CreateDriver
    {
        public void CreateDriverTable(){
            ConnectionString connectionString = new ConnectionString();
            string cs = connectionString.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"CREATE TABLE drivers(id INTEGER PRIMARY KEY AUTO_INCREMENT, firstName TEXT, rating DOUBLE, dateHired TEXT, deleted BOOL)";
            using var cmd = new MySqlCommand(stm, con);

            cmd.ExecuteNonQuery();
        }
        public void createDriver(Driver myDriver)
        {
            ConnectionString connectionString = new ConnectionString();
            string cs = connectionString.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO drivers(firstName, rating, dateHired, deleted) VALUES(@firstName, @rating, @dateHired, @deleted)";
            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@firstName", myDriver.firstName);
            cmd.Parameters.AddWithValue("@rating", myDriver.rating);
            cmd.Parameters.AddWithValue("@dateHired", myDriver.dateHired);
            cmd.Parameters.AddWithValue("@deleted", myDriver.deleted);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}



//             bool isOpen = connectionString.OpenConnection();

//             if(isOpen){
//                 MySqlConnection conn = connectionString.GetConn();
//                 MySqlCommand cmd = new MySqlCommand();

//                 cmd.Connection = conn;

//                 cmd.CommandText = @"INSERT INTO drivers(id,firstName, rating, dateHired,deleted) VALUES(@id,@firstName,@rating,@dateHired, @deleted)";
//                 cmd.Parameters.AddWithValue("@id",myDriver.id);
//                 cmd.Parameters.AddWithValue("@firstName",myDriver.firstName);
//                 cmd.Parameters.AddWithValue("@rating",myDriver.rating);
//                 cmd.Parameters.AddWithValue("@dateHired",myDriver.dateHired);
//                 cmd.Parameters.AddWithValue("@deleted",myDriver.deleted);
//                 cmd.Prepare();
//                 cmd.ExecuteNonQuery();

//                 db.CloseConnection();
//             }



//             // ConnectionString myConnection = new ConnectionString();
//             // string cs = myConnection.cs;
//             // using var con = new MySqlConnection(cs);
//             // con.Open();

//             // string stm = @"INSERT INTO drivers(id, firstName, rating, dateHired, deleted) VALUES(@id, @FirstName, @rating, @dateHired, @deleted)";

//             // using var cmd = new MySqlCommand(stm, con);

//             // cmd.Parameters.AddWithValue("@id", myDriver.id);
//             // cmd.Parameters.AddWithValue("@firstName", myDriver.firstName);
//             // cmd.Parameters.AddWithValue("@rating", myDriver.rating);
//             // cmd.Parameters.AddWithValue("@dateHired", myDriver.dateHired);
//             // cmd.Parameters.AddWithValue("@deleted", myDriver.deleted);

//             // cmd.Prepare();

//             // cmd.ExecuteNonQuery();
//         }

    
//     public void UpdateDriver(Driver myDriver){
//         DBConnect db = new DBConnect();
//         bool isOpen = db.OpenConnection();

//         if(isOpen){
//             MySqlConnection conn = db.GetConn();
//             MySqlCommand cmd = new MySqlCommand();

//             cmd.Connection = conn;

//             cmd.CommandText = @"UPDATE drivers SET firstName = @firstName, rating = @rating, dateHired = @dateHired, deleted = @deleted WHERE id = @id";
//             cmd.Parameters.AddWithValue("@id",myDriver.id);
//             cmd.Parameters.AddWithValue("@firstName",myDriver.firstName);
//             cmd.Parameters.AddWithValue("@rating",myDriver.rating);
//             cmd.Parameters.AddWithValue("@dateHired",myDriver.dateHired);
//             cmd.Parameters.AddWithValue("@deleted",myDriver.deleted);
//             cmd.Prepare();
//             cmd.ExecuteNonQuery();

//             db.CloseConnection();
//         }
//     }

//     }
// }