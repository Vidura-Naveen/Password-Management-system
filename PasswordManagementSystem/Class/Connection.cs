using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagementSystem.Class
{
    class Connection
    {
        #region DB CONNECTION
        public SqlConnection connect = new SqlConnection("Data Source=DESKTOP-5S3IPA9\\SQLEXPRESS;Initial Catalog=PwdManagerSyDB;Integrated Security=True");

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
        #endregion
    }

}
