using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PasswordManagementSystem.Class
{
    class Getdata
    {
        #region Get Items
        public DataTable GetItems()
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.ReadItemTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;

            }
        }
        #endregion
    }
}
