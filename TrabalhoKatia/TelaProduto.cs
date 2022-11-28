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
    public partial class TelaProduto : Form
    {
        public TelaProduto()
        {
            InitializeComponent();
        }

        private void bt_prodVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Tela1 tela1 = new Tela1();  
            tela1.Show();
        }
    }
}
