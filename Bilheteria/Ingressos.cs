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

            DataAccessLayer dtAcess = new DataAccessLayer();
            DataSet ds = dtAcess.ExecuteQueryDataSet("select * from Filmes", new DataSet(), "TabelaFilmes");
            DataSet ds2 = dtAcess.ExecuteQueryDataSet("select * from CadastroSala", new DataSet(), "TabelaCadastroSala");
            //string resultado = null;
            foreach (DataRow RowFilmes in ds.Tables["TabelaFilmes"].Rows)
            {
                //resultado = resultado + "NomeFilme: " + RowFilmes["nomeFilme"].ToString();
                cbFilme.Items.Add(RowFilmes["nomeFilme"].ToString());
            }
            foreach (DataRow RowSalas in ds2.Tables["TabelaCadastroSala"].Rows)
            {

                cbSala.Items.Add(RowSalas["Sala"].ToString());
            }
        }



    }
}
