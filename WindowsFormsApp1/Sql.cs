using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Sql
    {
        public static string ParamConnectionString = @"Data Source=localhost;Initial Catalog=Atlas;Integrated Security=True";

        public static SqlConnection Con = new SqlConnection(ParamConnectionString);

        public static DataTable GetRequete(string ReqSql, string TableName)
        {
            SqlDataAdapter Da = new SqlDataAdapter(ReqSql, Con);
            DataSet DataSet1 = new DataSet();
            Da.Fill(DataSet1, TableName);
            DataTable Dt;
            Dt = DataSet1.Tables[TableName];
            return Dt;
        }
        public static DataTable GetRequete(string ReqSql, DataTable Dt)
        {
            SqlDataAdapter Da = new SqlDataAdapter(ReqSql, Con);
            Da.Fill(Dt);
            return Dt;
        }
        public static DataTable GetRequete(string ReqSql, string TableName, SqlConnection C, SqlTransaction Trans)
        {
            SqlDataAdapter Da = new SqlDataAdapter(ReqSql, C);
            Da.SelectCommand.Transaction = Trans;

            DataSet DataSet1 = new DataSet();
            Da.Fill(DataSet1, TableName);
            DataTable Dt;
            Dt = DataSet1.Tables[TableName];
            return Dt;
        }

        public static void ExcuterCmd(string Requete)
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            SqlCommand Cmd = new SqlCommand(Requete, Con);
            Cmd.ExecuteNonQuery();
            Con.Close();

        }

        public static void ExcuterCmd(string Requete, SqlConnection C, SqlTransaction Trans)
        {
            SqlCommand Cmd = new SqlCommand(Requete, C, Trans);
            Cmd.ExecuteNonQuery();
        }

        public static void RemplirGrid(DataGridView DGV, string ReqSql)
        {
            DataTable Dt;
            Dt = Sql.GetRequete(ReqSql, "Table1");
            DGV.DataSource = Dt;

        }
        public static DataTable GetRequetetrans(string ReqSql, SqlTransaction Trans, DataTable Dt)
        {
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = Con;
            cmd1.Transaction = Trans;
            cmd1.CommandText = ReqSql;
            SqlDataAdapter Da = new SqlDataAdapter(cmd1);
            Da.Fill(Dt);
            return Dt;
        }
        public static void ExcuterCmdTrans(string Requete, SqlTransaction Trans)
        {
            SqlCommand Cmd = new SqlCommand(Requete, Con, Trans);
            Cmd.ExecuteNonQuery();
        }
    }

}

