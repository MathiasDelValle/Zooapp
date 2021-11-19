namespace ZooApp
{
    partial class frmAltaEspacio
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEspacio = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del espacio:";
            // 
            // txtEspacio
            // 
            this.txtEspacio.Location = new System.Drawing.Point(24, 38);
            this.txtEspacio.Name = "txtEspacio";
            this.txtEspacio.Size = new System.Drawing.Size(220, 20);
            this.txtEspacio.TabIndex = 1;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(24, 83);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(220, 40);
            this.btnAlta.TabIndex = 2;
            this.btnAlta.Text = "Guardar";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // frmAltaEspacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 146);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.txtEspacio);
            this.Controls.Add(this.label1);
            this.Name = "frmAltaEspacio";
            this.Text = "frmAltaEspacio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEspacio;
        private System.Windows.Forms.Button btnAlta;
    }
}