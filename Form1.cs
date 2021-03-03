using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCEP
{
    using CEPService;
    public partial class PachecoCEP : Form
    {
        public PachecoCEP()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ws = new AtendeClienteClient())
            {
                var resposta = ws.consultaCEP(txtCEP.Text);
                txtEnd.Text = resposta.end;
                txtBairro.Text = resposta.bairro + resposta.complemento2;
                txtCidade.Text = resposta.cidade;
            }
        }
    }
}
