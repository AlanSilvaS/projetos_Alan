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
    public partial class formlogin : Form
    {
        public formlogin()
        {
            InitializeComponent();
        }
        
         
       
        private void Form1_Load(object sender, EventArgs e)
        {
            painellogin.Location = new Point(this.Width / 2 - (312 / 2), this.Height / 2 - (355 / 2));
        }

            //chamar login
            private void chamarlogin()
            {
                if (textusuario.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("Preencha corretamente os dados", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textusuario.Focus();
                    return;
                }
                if (textsenha.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("Preencha corretamente a senha", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textusuario.Focus();
                    return;
                }
            //código para realizar o login

            //link para a tela princial
            Formprincipal telaprincipal = new Formprincipal();
            telaprincipal.Show();
            this.Hide();

           
               
                //limpar dados login
                limpar();
            }
            private void limpar()
            {
                textusuario.Text = "";
                textsenha.Text = "";
                textusuario.Focus();
            }

             //executar login precionando ENTER
            private void buttonlogin_Click(object sender, EventArgs e)
            {
                chamarlogin();
            }
        
            private void inicial_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    chamarlogin();
                }
            }

        private void painellogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

