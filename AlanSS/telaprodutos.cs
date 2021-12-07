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
    public partial class telaprodutos : Form
    {
        
       
       

        private void novofornecedor_Click(object sender, EventArgs e)
        {
            formnovoproduto formnovoproduto = new formnovoproduto();
            formnovoproduto.Show();
            this.Hide();

        }          
        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesquisaproduto pesquisaproduto = new pesquisaproduto();
            pesquisaproduto.Show();
            this.Hide();
        }

        private void telaprodutos_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adicionarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
