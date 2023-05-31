namespace pryArmanini_NeptunoBD
{
    partial class frmBDTablas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBDTablas));
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBaseDatos = new System.Windows.Forms.Label();
            this.lblTabla = new System.Windows.Forms.Label();
            this.cmbTabla = new System.Windows.Forms.ComboBox();
            this.btnBaseDatos = new System.Windows.Forms.Button();
            this.txtBDNombre = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(830, 448);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 34);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(13, 114);
            this.dgvTabla.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.Size = new System.Drawing.Size(809, 311);
            this.dgvTabla.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(389, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(163, 29);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Bienvenido!!";
            // 
            // lblBaseDatos
            // 
            this.lblBaseDatos.AutoSize = true;
            this.lblBaseDatos.Location = new System.Drawing.Point(20, 69);
            this.lblBaseDatos.Name = "lblBaseDatos";
            this.lblBaseDatos.Size = new System.Drawing.Size(207, 16);
            this.lblBaseDatos.TabIndex = 9;
            this.lblBaseDatos.Text = "Ingresaste a la Base de Datos de";
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Location = new System.Drawing.Point(531, 70);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(114, 16);
            this.lblTabla.TabIndex = 11;
            this.lblTabla.Text = "Seleccione Tabla";
            // 
            // cmbTabla
            // 
            this.cmbTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTabla.FormattingEnabled = true;
            this.cmbTabla.Location = new System.Drawing.Point(651, 66);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Size = new System.Drawing.Size(133, 24);
            this.cmbTabla.TabIndex = 12;
            this.cmbTabla.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnBaseDatos
            // 
            this.btnBaseDatos.Location = new System.Drawing.Point(843, 48);
            this.btnBaseDatos.Name = "btnBaseDatos";
            this.btnBaseDatos.Size = new System.Drawing.Size(100, 59);
            this.btnBaseDatos.TabIndex = 13;
            this.btnBaseDatos.Text = "&Base de Datos";
            this.btnBaseDatos.UseVisualStyleBackColor = true;
            this.btnBaseDatos.Click += new System.EventHandler(this.btnBaseDatos_Click);
            // 
            // txtBDNombre
            // 
            this.txtBDNombre.Enabled = false;
            this.txtBDNombre.Location = new System.Drawing.Point(233, 69);
            this.txtBDNombre.Name = "txtBDNombre";
            this.txtBDNombre.Size = new System.Drawing.Size(161, 22);
            this.txtBDNombre.TabIndex = 14;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(843, 215);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 59);
            this.btnFiltrar.TabIndex = 15;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // frmBDTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(968, 495);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtBDNombre);
            this.Controls.Add(this.btnBaseDatos);
            this.Controls.Add(this.cmbTabla);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.lblBaseDatos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBDTablas";
            this.Text = "Bases de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBaseDatos;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.ComboBox cmbTabla;
        private System.Windows.Forms.Button btnBaseDatos;
        private System.Windows.Forms.TextBox txtBDNombre;
        private System.Windows.Forms.Button btnFiltrar;
    }
}