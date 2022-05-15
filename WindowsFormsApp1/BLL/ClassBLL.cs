using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    class ClassBLL
    {

        #region Get Items
        public DataTable GetItems()
        {
            try
            {
                ClassDAL objdal = new ClassDAL(); //data access layer class object to access functions
                return objdal.ReadItemsTable();
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