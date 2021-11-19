namespace ZooApp
{
    partial class frmModificarJaula
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablaEspacios = new System.Windows.Forms.DataGridView();
            this.panelEditar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombreJaula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEspacios = new System.Windows.Forms.ComboBox();
            this.obj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Espacio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaEspacios)).BeginInit();
            this.panelEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaEspacios
            // 
            this.tablaEspacios.AllowUserToAddRows = false;
            this.tablaEspacios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaEspacios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaEspacios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaEspacios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.obj,
            this.id,
            this.nombre,
            this.Espacio,
            this.editar,
            this.eliminar});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaEspacios.DefaultCellStyle = dataGridViewCellStyle5;
            this.tablaEspacios.Location = new System.Drawing.Point(2, 12);
            this.tablaEspacios.MultiSelect = false;
            this.tablaEspacios.Name = "tablaEspacios";
            this.tablaEspacios.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaEspacios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tablaEspacios.Size = new System.Drawing.Size(550, 230);
            this.tablaEspacios.TabIndex = 6;
            this.tablaEspacios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaEspacios_CellClick);
            // 
            // panelEditar
            // 
            this.panelEditar.Controls.Add(this.cmbEspacios);
            this.panelEditar.Controls.Add(this.label3);
            this.panelEditar.Controls.Add(this.label2);
            this.panelEditar.Controls.Add(this.btnGuardar);
            this.panelEditar.Controls.Add(this.txtNombreJaula);
            this.panelEditar.Controls.Add(this.label1);
            this.panelEditar.Location = new System.Drawing.Point(138, 42);
            this.panelEditar.Name = "panelEditar";
            this.panelEditar.Size = new System.Drawing.Size(275, 216);
            this.panelEditar.TabIndex = 7;
            this.panelEditar.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(42, 184);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 29);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombreJaula
            // 
            this.txtNombreJaula.Location = new System.Drawing.Point(42, 42);
            this.txtNombreJaula.Name = "txtNombreJaula";
            this.txtNombreJaula.Size = new System.Drawing.Size(200, 20);
            this.txtNombreJaula.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Espacio:";
            // 
            // cmbEspacios
            // 
            this.cmbEspacios.FormattingEnabled = true;
            this.cmbEspacios.Location = new System.Drawing.Point(42, 99);
            this.cmbEspacios.Name = "cmbEspacios";
            this.cmbEspacios.Size = new System.Drawing.Size(200, 21);
            this.cmbEspacios.TabIndex = 5;
            // 
            // obj
            // 
            this.obj.HeaderText = "objJaula";
            this.obj.Name = "obj";
            this.obj.ReadOnly = true;
            this.obj.Visible = false;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // Espacio
            // 
            this.Espacio.HeaderText = "ESPACIO";
            this.Espacio.Name = "Espacio";
            this.Espacio.ReadOnly = true;
            // 
            // editar
            // 
            this.editar.HeaderText = "EDITAR";
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "ELIMINAR";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            // 
            // frmModificarJaula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 270);
            this.Controls.Add(this.panelEditar);
            this.Controls.Add(this.tablaEspacios);
            this.Name = "frmModificarJaula";
            this.Text = "frmModificarJaula";
            this.Load += new System.EventHandler(this.frmModificarJaula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaEspacios)).EndInit();
            this.panelEditar.ResumeLayout(false);
            this.panelEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView tablaEspacios;
        private System.Windows.Forms.Panel panelEditar;
        private System.Windows.Forms.ComboBox cmbEspacios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombreJaula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn obj;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Espacio;
        private System.Windows.Forms.DataGridViewTextBoxColumn editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn eliminar;
    }
}