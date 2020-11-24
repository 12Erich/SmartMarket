using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SmartMarket.DAL
{
    public class Connection
    {
        public static string Con()
        {
            string connectionStr = @"Data Source = ITLNB108\SQL2017; Initial Catalog = DB_SMARTMARKET; Integrated Security = True;";

            return connectionStr;
        }
    }
}
