namespace Aeroporto
{
    partial class CreateVoo_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateVoo_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_nome = new System.Windows.Forms.TextBox();
            this.txtb_destino = new System.Windows.Forms.TextBox();
            this.txtb_num = new System.Windows.Forms.TextBox();
            this.cmb_capc = new System.Windows.Forms.ComboBox();
            this.btn_criar = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txtb_origem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtb_nome
            // 
            resources.ApplyResources(this.txtb_nome, "txtb_nome");
            this.txtb_nome.Name = "txtb_nome";
            // 
            // txtb_destino
            // 
            resources.ApplyResources(this.txtb_destino, "txtb_destino");
            this.txtb_destino.Name = "txtb_destino";
            // 
            // txtb_num
            // 
            resources.ApplyResources(this.txtb_num, "txtb_num");
            this.txtb_num.Name = "txtb_num";
            // 
            // cmb_capc
            // 
            resources.ApplyResources(this.cmb_capc, "cmb_capc");
            this.cmb_capc.Name = "cmb_capc";
            // 
            // btn_criar
            // 
            resources.ApplyResources(this.btn_criar, "btn_criar");
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.UseVisualStyleBackColor = true;
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // btn_clear
            // 
            resources.ApplyResources(this.btn_clear, "btn_clear");
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txtb_origem
            // 
            resources.ApplyResources(this.txtb_origem, "txtb_origem");
            this.txtb_origem.Name = "txtb_origem";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // CreateVoo_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtb_origem);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.cmb_capc);
            this.Controls.Add(this.txtb_num);
            this.Controls.Add(this.txtb_destino);
            this.Controls.Add(this.txtb_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateVoo_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_nome;
        private System.Windows.Forms.TextBox txtb_destino;
        private System.Windows.Forms.TextBox txtb_num;
        private System.Windows.Forms.ComboBox cmb_capc;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txtb_origem;
        private System.Windows.Forms.Label label6;
    }
}