using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PA3_Fredp.API.Database
{
    public static void DropDriverTable()
    {
        ConnectionString myConnection = new ConnectionString();
        string cs = myConnection.cs;

        using var con = new MySqlConnection(cs);
        con.Open();

        string stm = @"DROP TABLE IF EXISTS drivers";

        using var cmd = new MySqlCommand(stm, con);

        cmd.ExecuteNonQuery();
    }

    void IDeleteDriver.DeleteDriver(int id)
    {
        throw new System.NotImplementedException();
    }
}