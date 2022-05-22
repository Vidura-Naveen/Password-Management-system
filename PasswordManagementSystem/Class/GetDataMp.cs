using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagementSystem
{
    class GetDataMp
    {
        #region Get Items
        public DataTable GetItems()
        {
            try
            {
                ClassDAL1 objdal1 = new ClassDAL1();
                return objdal1.ReadItemTable1();
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
