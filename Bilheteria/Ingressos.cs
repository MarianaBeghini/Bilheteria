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
using System.Threading;

namespace Bilheteria
{
    public partial class VendasIngressos : Form
    {
        Thread nt2;
        public class Ingressos
        {
            public string IdFilmesfk { get; set; }

            public string IdSalafk { get; set; }

            public string QuantidadeIngressoss { get; set; }

            public string IdHorariofk { get; set; }

        }

        public VendasIngressos()
        {
            InitializeComponent();

            DataAccessLayer dtAcess = new DataAccessLayer();
            DataSet ds = dtAcess.ExecuteQueryDataSet("select * from Filmes", new DataSet(), "TabelaFilmes");
            DataSet ds2 = dtAcess.ExecuteQueryDataSet("select * from CadastroSala", new DataSet(), "TabelaCadastroSala");
            DataSet ds3 = dtAcess.ExecuteQueryDataSet("select * from Filmes" , new DataSet(), "TabelaFilmes");
            Ingressos Ingresso = new Ingressos();
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
            foreach (DataRow RowFilmes in ds3.Tables["TabelaFilmes"].Rows)
            {
                cbHorario.Items.Add(RowFilmes["Horario"].ToString());
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccessLayer dtAcess = new DataAccessLayer();
            DataSet ds = dtAcess.ExecuteQueryDataSet("select * from Filmes where NomeFilme ='"+cbFilme.Text.ToString()+"'" , new DataSet(), "TabelaFilmes");
            DataSet ds2 = dtAcess.ExecuteQueryDataSet("select * from CadastroSala where Sala ='"+cbSala.Text.ToString()+"'", new DataSet(), "TabelaCadastroSala");
            DataSet ds3 = dtAcess.ExecuteQueryDataSet("select * from Filmes where Horario ='" +cbHorario.Text.ToString() + "'", new DataSet(), "TabelaFilmes");
            Ingressos Ingresso = new Ingressos();



            foreach (DataRow RowFilmes in ds.Tables["TabelaFilmes"].Rows)
            {
                Ingresso.IdFilmesfk = RowFilmes["IdFilme"].ToString();
            }

            foreach (DataRow RowFilmes in ds2.Tables["TabelaCadastroSala"].Rows)
            {
                Ingresso.IdSalafk = RowFilmes["IdSala"].ToString();
            }

            foreach (DataRow RowFilmes in ds3.Tables["TabelaFilmes"].Rows)
            {
                Ingresso.IdHorariofk = RowFilmes["Horario"].ToString();
            }

            Ingresso.QuantidadeIngressoss = numeQuantidade.Value.ToString();
            Ingresso.IdHorariofk = cbHorario.Text.ToString();


            //dtAcess.ExecuteNonQuery("INSERT INTO INGRESSOS VALUES ('" + Ingresso.IdFilmesfk + "'," + Ingresso.IdSalafk + ",'" + 5 + "','" + "20:00" + "')");
            dtAcess.ExecuteNonQuery("INSERT INTO INGRESSOS VALUES ('" + Ingresso.IdFilmesfk + "'," + Ingresso.IdSalafk + ",'" + Ingresso.QuantidadeIngressoss + "','" + Ingresso.IdHorariofk + " ')");

            dtAcess.CloseConnection();

            MessageBox.Show("Informações registradas com sucesso");

            button2_Click(sender, e);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbFilme.Text = " ";
            cbSala.Text = " ";
            numeQuantidade.Value = 0; 
            cbHorario.Text = " ";

        }


        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt2 = new Thread(CadastroSala);
            nt2.SetApartmentState(ApartmentState.STA);
            nt2.Start();
        }
        private void CadastroSala()
        {
            Application.Run(new Cadastro_Sala());
        }
    }
}
