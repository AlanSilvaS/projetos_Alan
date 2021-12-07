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
    public partial class Formprincipal : Form
    {
        public Formprincipal()
        {
            InitializeComponent();
        }

        private void Formprincipal_Load(object sender, EventArgs e)
        {
            nomesmenu.SetToolTip(botaoprodutos, "Produtos");
            nomesmenu.SetToolTip(botaofornecedor, "Fornecedor");
            nomesmenu.SetToolTip(botaocategorias, "Categorias");
            nomesmenu.SetToolTip(botaoclientes, "Clientes");
            nomesmenu.SetToolTip(botaoususario, "Usuario");
        }



        private void panelicons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botaoprodutos_Click(object sender, EventArgs e)
        {
            //link para telaprodutos 
            telaprodutos telaprodutos = new telaprodutos();
            telaprodutos.Show();
            this.Hide();
        }

        private void botaocategorias_Click(object sender, EventArgs e)
        {

        }

        private void botaofornecedor_Click(object sender, EventArgs e)
        {
            telafornecedor telafornecedor = new telafornecedor();
            telafornecedor.Show();
            this.Hide();


        }
    }
}
