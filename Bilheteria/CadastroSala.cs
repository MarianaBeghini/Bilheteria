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
    public partial class Cadastro_Sala : Form
    {


        Thread nt2;
        Thread nt3;

        public Cadastro_Sala()
        {
            InitializeComponent();
        }

        public class Sala
        {
            public string sala { get; set; }
            public int lotacao { get; set; }
            public string animacao { get; set; }
            public string climatizado { get; set; }

        }



        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txbSala.Text = " ";
            txbLotacao.Text = "";
            txbAnimacao.Text = " ";
            txbClimatizado.Text = " ";

        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            DataAccessLayer dtAcess = new DataAccessLayer();// Declarando classe de conexão com o banco.
            dtAcess.OpenConnection(); // Abrindo conexão com o banco.

            Sala Salas = new Sala();// Cria o objeto de tratamento dos filmes

            Salas.sala = txbSala.Text.ToString(); // Armaneza e trata os dados da tela de cadastro
           // Salas.lotacao = int;
            Salas.animacao = txbAnimacao.Text.ToString();
            Salas.climatizado = txbClimatizado.Text.ToString();

            //MessageBox.Show(Salas.sala +" - "+ Salas.lotacao.ToString() + " - " + Salas.animacao + " - " + Salas.climatizado);

            dtAcess.ExecuteNonQuery("INSERT INTO CadastroSala VALUES ('" + Salas.sala + "'," + Salas.lotacao + ",'" + Salas.animacao + "','" + Salas.climatizado + "')");
            dtAcess.CloseConnection();

            MessageBox.Show("Informações registradas com sucesso");

            bntLimpar_Click(sender, e);

        }

        private void bntVendasIngressos_Click(object sender, EventArgs e)
        {
            this.Close();
            nt2 = new Thread(Ingressos);
            nt2.SetApartmentState(ApartmentState.STA);
            nt2.Start();
        }

        private void Ingressos()
        {
            Application.Run(new VendasIngressos());
        }



        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt3 = new Thread(CadastroFilmes);
            nt3.SetApartmentState(ApartmentState.STA);
            nt3.Start();
        }

        private void CadastroFilmes()
        {
            Application.Run(new CadastroFilmes());
        }
    }

    

} 