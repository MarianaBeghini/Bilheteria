using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilheteria.Classes
{
    internal class DataAccessLayer
    {
       
        #region PROPRIEDADES
        private bool IsUnitTest { get; set; }
        private SqlConnection Conn { get; set; }
        private SqlDataAdapter DataAdapter { get; set; }
        private SqlTransaction Trans { get; set; }
        #endregion


        public DataAccessLayer(bool isUnitTest = false)
        {
            IsUnitTest = isUnitTest;
            Conn = new SqlConnection("Data Source=DESKTOP-AHF72S6\\SQLEXPRESS;Initial Catalog=Bilheteria;Integrated Security=True");
            DataAdapter = new SqlDataAdapter();
        }

        public void OpenConnection()
        {
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }

        }

        public void CloseConnection()
        {
            Conn.Close();
        }

        private void Commit()
        {
            if (IsUnitTest)
            {
                Trans.Rollback();
            }
            else
            {
                Trans.Commit();
            }
        }

        public void ExecuteNonQuery(string query)
        {
            OpenConnection();
            Trans = Conn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand(query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = Conn;
                cmd.Transaction = Trans;
                cmd.ExecuteNonQuery();
                Commit();
                CloseConnection();
            }
            catch (SqlException erro)
            {
                Trans.Rollback();
                CloseConnection();
                Console.WriteLine("ERRO: " + erro);
            }

        }

        public DataSet ExecuteQueryDataSet(String query, DataSet dataSet, String nomeDataset)
        {
            OpenConnection();
            Trans = Conn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand(query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = Conn;
                cmd.Transaction = Trans;

                DataAdapter.SelectCommand = cmd;
                DataAdapter.Fill(dataSet, nomeDataset);

                Commit();
                CloseConnection();


                return dataSet;
            }
            catch (SqlException erro)
            {
                Trans.Rollback();
                CloseConnection();
                Console.WriteLine("ERRO: " + erro);
            }

            return dataSet;
        }


    }
}
