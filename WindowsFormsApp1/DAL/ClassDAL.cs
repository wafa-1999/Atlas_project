using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    class ClassDAL
    {
        #region Read Itens Table

        public DataTable ReadItemsTable()
        {
            if (Sql.Con.State == ConnectionState.Open)
                Sql.Con.Close();
            Sql.Con.ConnectionString = Sql.ParamConnectionString;
            Sql.Con.Open();

            //query to select all records fron table -> (Table_Items)
            string query = @"select image_jeux, nom_jeux, prix from jeux where nbre_jeux = 1 ";
            SqlCommand cmd = new SqlCommand(query, Sql.Con);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt); //save all records coning from database in data table.
                    return dt; // return data table.
                }
            }
            catch
            {
                throw;
            }
            #endregion

        }
    }
}
