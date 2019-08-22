namespace Aeroporto
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.btn_createPassageiro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_criarvoo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbx_fila = new System.Windows.Forms.ListBox();
            this.lbx_voos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_createPassageiro
            // 
            this.btn_createPassageiro.Location = new System.Drawing.Point(31, 281);
            this.btn_createPassageiro.Name = "btn_createPassageiro";
            this.btn_createPassageiro.Size = new System.Drawing.Size(103, 43);
            this.btn_createPassageiro.TabIndex = 0;
            this.btn_createPassageiro.Text = "Criar Passageiro";
            this.btn_createPassageiro.UseVisualStyleBackColor = true;
            this.btn_createPassageiro.Click += new System.EventHandler(this.btn_createPassageiro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fila de Passageiros";
            // 
            // btn_criarvoo
            // 
            this.btn_criarvoo.Location = new System.Drawing.Point(382, 281);
            this.btn_criarvoo.Name = "btn_criarvoo";
            this.btn_criarvoo.Size = new System.Drawing.Size(103, 43);
            this.btn_criarvoo.TabIndex = 4;
            this.btn_criarvoo.Text = "Criar Voo";
            this.btn_criarvoo.UseVisualStyleBackColor = true;
            this.btn_criarvoo.Click += new System.EventHandler(this.btn_criarvoo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista de Voo";
            // 
            // lbx_fila
            // 
            this.lbx_fila.FormattingEnabled = true;
            this.lbx_fila.Location = new System.Drawing.Point(12, 28);
            this.lbx_fila.Name = "lbx_fila";
            this.lbx_fila.Size = new System.Drawing.Size(153, 238);
            this.lbx_fila.TabIndex = 10;
            // 
            // lbx_voos
            // 
            this.lbx_voos.FormattingEnabled = true;
            this.lbx_voos.Location = new System.Drawing.Point(356, 28);
            this.lbx_voos.Name = "lbx_voos";
            this.lbx_voos.Size = new System.Drawing.Size(153, 238);
            this.lbx_voos.TabIndex = 11;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::Aeroporto.Properties.Resources.forca_aerea_brasileira_original;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(521, 332);
            this.Controls.Add(this.lbx_voos);
            this.Controls.Add(this.lbx_fila);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_criarvoo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_createPassageiro);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.Text = "Aeroporto";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_createPassageiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_criarvoo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbx_fila;
        private System.Windows.Forms.ListBox lbx_voos;
    }
}

