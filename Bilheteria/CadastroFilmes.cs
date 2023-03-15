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
 
    public partial class CadastroFilmes : Form
    {
        Thread nt;
        

        public class Filme
        {
            public string nomeFilme { get; set; }

            public int classificacao { get; set; }

            public string Categoria { get; set; }

            public int Duracao { get; set; }

            public string Resenha { get; set; }

            public Filme()
            {
                classificacao = 18 ;

            }

        }

        public CadastroFilmes()
        {
            InitializeComponent();
        }



        private void bntSalvar_Click(object sender, EventArgs e)
        {

            DataAccessLayer dtAcess = new DataAccessLayer();// Declarando classe de conexão com o banco.
            dtAcess.OpenConnection(); // Abrindo conexão com o banco.

            Filme Filmes = new Filme();// Cria o objeto de tratamento dos filmes

            Filmes.nomeFilme = txbNomeFilme.Text.ToString(); // Armaneza e trata os dados da tela de cadastro
            Filmes.classificacao = Int32.Parse(txbClassificacao.Text);
            Filmes.Categoria =  txbCategoria.Text.ToString();
            Filmes.Duracao = Int32.Parse(txbDuracao.Text);
            Filmes.Resenha = txbResenha.Text.ToString();

            //string insert = "INSERT INTO FILMES VALUES (" + Filmes.nomeFilme + "," + Filmes.classificacao + "," + Filmes.Categoria + "," + Filmes.Duracao + "," + Filmes.Resenha + ")";
            dtAcess.ExecuteNonQuery("INSERT INTO FILMES VALUES ('"+Filmes.nomeFilme+"',"+Filmes.classificacao+",'"+Filmes.Categoria+"',"+Filmes.Duracao+",'"+Filmes.Resenha+"')");
            dtAcess.CloseConnection();

            MessageBox.Show("Informações registradas com sucesso");
            
               btnLimpar_Click(sender,e);// Está linha chama a função do outro metodo, o que foi necessario era passar os paramentro de object e EventArgs
                
            

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNomeFilme.Text = "";
            txbClassificacao.Text = "";
            txbCategoria.Text = "";
            txbDuracao.Text = "";
            txbResenha.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(CadastroSala);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void CadastroSala()
        {
            Application.Run(new Cadastro_Sala());
        }

        private void CadastroFilmes_Load(object sender, EventArgs e)
        {

        }
    }


}
