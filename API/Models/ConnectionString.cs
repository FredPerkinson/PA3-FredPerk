using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace API.Models
{
    public string cs {get; set;}

    private MySqlConnection connection;
    public class ConnectionString
    {
       Initialize();
    }
        public Initialize()
        {
            string server = "o2olb7w3xv09alub.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "abwdmv3n1vw8uy4d";
            string port = "3306";
            string userName = "l357kyq3y1t17hmp";
            string password = "cjjmsx76272i89br";

            cs = $@"server = {server}; user = {userName}; database = {database}; port = {port}; password = {password};";
            connection = new MySqlConnection(cs);
        }

        public bool OpenConnection(){
            try{
                ConnectionString.Open();
                return true;
            }
            catch(MySqlException ex){
                if(ex.Number == 0){
                    System.Console.WriteLine("ex.Message");
                    System.Console.WriteLine("Cannot Connect");
                }
                else{
                    if(ex.Number == 1045){
                        System.Console.WriteLine("Invalid username/password");
                    }
                }
            }

            return false;
        }

        public bool CloseConnection(){
            try{
                ConnectionString.Close();
                return true;
            }
            catch(MySqlException ex){
                System.Console.WriteLine(ex.Message);
            }

            return false;
        }
}