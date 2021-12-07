using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlanSS
{
    public partial class pesquisaproduto : Form
    {
        public pesquisaproduto()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            buscacodigo.Visible = true;
            buscanome.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            buscacodigo.Visible = false;
            buscanome.Visible = true;
        }

        private void buscanome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            telaprodutos telaprodutos = new telaprodutos();
            telaprodutos.Show();
            this.Hide();


        }
    }
}
