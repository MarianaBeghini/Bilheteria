using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

//Tela inicial 

namespace Bilheteria
{
    public partial class BILHETERIA : Form

    {
        Thread nt1;
        Thread nt2;
        Thread nt3;

        public BILHETERIA()
        {
            
            InitializeComponent();
        }

        
        private void CadastroFilmes()
        {
            Application.Run(new CadastroFilmes());
        }

        private void cadastrofilme_Click(object sender, EventArgs e)
        {
            this.Close();
            nt1 = new Thread(CadastroFilmes);
            nt1.SetApartmentState(ApartmentState.STA);
            nt1.Start();
        }

        private void cadastrosala_Click(object sender, EventArgs e)
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

        private void cadastroingressos_Click(object sender, EventArgs e)
        {
            this.Close();
            nt3 = new Thread(Ingressos);
            nt3.SetApartmentState(ApartmentState.STA);
            nt3.Start();
        }
        private void Ingressos()
        {
            Application.Run(new VendasIngressos());
        }
    }
}
