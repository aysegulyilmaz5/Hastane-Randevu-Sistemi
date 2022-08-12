using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectHospital
{
    class SQLConnection
    {
        public SqlConnection connected()
        {
            SqlConnection connectionn = new SqlConnection("Data Source=DESKTOP-IP4RS08;Initial Catalog=Hospital Project;Integrated Security=True");
            connectionn.Open();
            return connectionn;
        }
    }
}
