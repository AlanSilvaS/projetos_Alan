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
    public partial class telafornecedor : Form      
    {
        public telafornecedor()
        {
            InitializeComponent();
            toolTip1.SetToolTip(novofornecedor, "Adicionar Novo Fornecedor");
            toolTip1.SetToolTip(pesquisarfornecedor, "Procurar Fornecedor");
        }

        private void panelicons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botaoprodutos_Click(object sender, EventArgs e)
        {

        }

        private void novofornecedor_Click(object sender, EventArgs e)
        {
            
        }

        private void botaofornecedor_Click(object sender, EventArgs e)
        {

        }
    }
}
