using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataA
{
   public abstract class ConnectioToSql { 
    private readonly string connectionString;
       public ConnectioToSql()
    {
        connectionString = "SERVER=LAPTOP-P0M0UI21; DataBase= Evaluacion; Integrated security = True";
    }
    protected SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
    }
}
