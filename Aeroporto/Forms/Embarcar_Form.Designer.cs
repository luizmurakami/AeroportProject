namespace Aeroporto
{
    partial class Embarcar_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Embarcar_Form));
            this.cmb_voos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_embarque = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_voos
            // 
            this.cmb_voos.FormattingEnabled = true;
            this.cmb_voos.Location = new System.Drawing.Point(103, 42);
            this.cmb_voos.Name = "cmb_voos";
            this.cmb_voos.Size = new System.Drawing.Size(151, 21);
            this.cmb_voos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voo:";
            // 
            // btn_embarque
            // 
            this.btn_embarque.Location = new System.Drawing.Point(260, 90);
            this.btn_embarque.Name = "btn_embarque";
            this.btn_embarque.Size = new System.Drawing.Size(75, 23);
            this.btn_embarque.TabIndex = 4;
            this.btn_embarque.Text = "Embarcar";
            this.btn_embarque.UseVisualStyleBackColor = true;
            this.btn_embarque.Click += new System.EventHandler(this.btn_embarque_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(179, 90);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Embarcar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 125);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_embarque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_voos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Embarcar_Form";
            this.Text = "Embarcar Passageiros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_voos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_embarque;
        private System.Windows.Forms.Button btn_clear;
    }
}