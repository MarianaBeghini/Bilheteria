using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bilheteria.Classes;

namespace Bilheteria
{
    public partial class VendasIngressos : Form
    {
        public VendasIngressos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccessLayer dtAcess = new DataAccessLayer();
            DataSet ds = dtAcess.ExecuteQueryDataSet("select * from Filmes", new DataSet(), "TabelaFilmes");

            string resultado = null;
            foreach (DataRow RowFilmes in ds.Tables["TabelaFilmes"].Rows)
            {

               
                resultado = resultado + "NomeFilme: " + RowFilmes["nomeFilme"].ToString();
               
            }
            MessageBox.Show(resultado);

        }
    }
}
