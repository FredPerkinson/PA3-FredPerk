using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class ConnectionString
    {
        public string cs {get; set;}

        public ConnectionString()
        {
            string server = "o2olb7w3xv09alub.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "abwdmv3n1vw8uy4d";
            string port = "3306";
            string userName = "l357kyq3y1t17hmp";
            string password = "cjjmsx76272i89br";

            cs = $@"server = {server}; user = {userName}; database = {database}; port = {port}; password = {password};";
        }
    }
}