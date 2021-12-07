
namespace AlanSS
{
    partial class formlogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formlogin));
            this.painellogin = new System.Windows.Forms.Panel();
            this.textsenha = new System.Windows.Forms.TextBox();
            this.textusuario = new System.Windows.Forms.TextBox();
            this.buttonentrar = new System.Windows.Forms.Button();
            this.painellogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // painellogin
            // 
            this.painellogin.BackColor = System.Drawing.Color.Transparent;
            this.painellogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("painellogin.BackgroundImage")));
            this.painellogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.painellogin.Controls.Add(this.textsenha);
            this.painellogin.Controls.Add(this.textusuario);
            this.painellogin.Location = new System.Drawing.Point(499, 169);
            this.painellogin.Margin = new System.Windows.Forms.Padding(4);
            this.painellogin.Name = "painellogin";
            this.painellogin.Size = new System.Drawing.Size(341, 410);
            this.painellogin.TabIndex = 1;
            this.painellogin.Paint += new System.Windows.Forms.PaintEventHandler(this.painellogin_Paint);
            // 
            // textsenha
            // 
            this.textsenha.BackColor = System.Drawing.Color.Silver;
            this.textsenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsenha.Location = new System.Drawing.Point(23, 341);
            this.textsenha.Margin = new System.Windows.Forms.Padding(4);
            this.textsenha.Multiline = true;
            this.textsenha.Name = "textsenha";
            this.textsenha.PasswordChar = '*';
            this.textsenha.Size = new System.Drawing.Size(294, 50);
            this.textsenha.TabIndex = 1;
            // 
            // textusuario
            // 
            this.textusuario.BackColor = System.Drawing.Color.Silver;
            this.textusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textusuario.Location = new System.Drawing.Point(23, 258);
            this.textusuario.Margin = new System.Windows.Forms.Padding(4);
            this.textusuario.Multiline = true;
            this.textusuario.Name = "textusuario";
            this.textusuario.Size = new System.Drawing.Size(294, 50);
            this.textusuario.TabIndex = 0;
            // 
            // buttonentrar
            // 
            this.buttonentrar.AutoSize = true;
            this.buttonentrar.BackColor = System.Drawing.Color.White;
            this.buttonentrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonentrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonentrar.FlatAppearance.BorderSize = 0;
            this.buttonentrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonentrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonentrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonentrar.ForeColor = System.Drawing.Color.Black;
            this.buttonentrar.Location = new System.Drawing.Point(601, 579);
            this.buttonentrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonentrar.Name = "buttonentrar";
            this.buttonentrar.Size = new System.Drawing.Size(152, 45);
            this.buttonentrar.TabIndex = 2;
            this.buttonentrar.Text = "ENTRAR";
            this.buttonentrar.UseVisualStyleBackColor = false;
            this.buttonentrar.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1103, 637);
            this.Controls.Add(this.painellogin);
            this.Controls.Add(this.buttonentrar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formlogin";
            this.RightToLeftLayout = true;
            this.Text = "AlanSS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inicial_KeyDown);
            this.painellogin.ResumeLayout(false);
            this.painellogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel painellogin;
        private System.Windows.Forms.Button buttonentrar;
        private System.Windows.Forms.TextBox textusuario;
        private System.Windows.Forms.TextBox textsenha;
    }
}

