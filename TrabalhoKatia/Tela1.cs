using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoKatia
{
    public partial class Tela1 : Form
    {
        public Tela1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            TelaFornecedor telaFornecedor = new TelaFornecedor();
            telaFornecedor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            TelaProduto telaProduto = new TelaProduto();
            telaProduto.Show();
        }
    }
}
