using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoginForm
{
    class DBConnect
    {
        private DBConnect()
        {

        }

        private string databaseName = string.Empty;
        public string DatabaseName { get { return databaseName; } set { databaseName = value; } }

        public string Password { get; set; }
       

    }
}
