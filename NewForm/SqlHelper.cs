using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

namespace NewForm
{
    public class SqlHelper
    {
        private static SqlHelper _instance = null;
        private string _connectString = "";
        private SqlConnection _conn = null;

        private SqlHelper() {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringsSection section = config.ConnectionStrings;
            ConnectionStringSettings connection = section.ConnectionStrings["LocalSqlserver"];
            _connectString = connection.ConnectionString;
        }

        public static SqlHelper Instance
        {
            get
            {
                if (_instance ==null)
                {
                    _instance = new SqlHelper();
                }
                return _instance;
            }
        }

        public void Open()
        {
            _conn = new SqlConnection(_connectString);
            _conn.Open();
        }

        public void Close()
        {
            if (_conn!=null&&_conn.State!=System.Data.ConnectionState.Closed)
            {
                _conn.Close();
            }
        }


    }
}

