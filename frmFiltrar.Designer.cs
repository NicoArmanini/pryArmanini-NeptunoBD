namespace pryArmanini_NeptunoBD
{
    partial class frmFiltrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltrar));
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.mrcFiltros = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Compania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo_Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(142, 36);
            this.cmbPais.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(160, 24);
            this.cmbPais.TabIndex = 18;
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(404, 36);
            this.cmbCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(160, 24);
            this.cmbCiudad.TabIndex = 17;
            this.cmbCiudad.SelectedIndexChanged += new System.EventHandler(this.cmbCiudad_SelectedIndexChanged);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(92, 39);
            this.lblPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(37, 16);
            this.lblPais.TabIndex = 16;
            this.lblPais.Text = "País:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(339, 39);
            this.lblCiudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(53, 16);
            this.lblCiudad.TabIndex = 15;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Modern No. 20", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(337, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(322, 38);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Listado de Clientes";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(32, 474);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(144, 43);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "&Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(721, 89);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(132, 61);
            this.btnListar.TabIndex = 21;
            this.btnListar.Text = "&Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // mrcFiltros
            // 
            this.mrcFiltros.Controls.Add(this.cmbPais);
            this.mrcFiltros.Controls.Add(this.cmbCiudad);
            this.mrcFiltros.Controls.Add(this.lblPais);
            this.mrcFiltros.Controls.Add(this.lblCiudad);
            this.mrcFiltros.Enabled = false;
            this.mrcFiltros.Location = new System.Drawing.Point(35, 72);
            this.mrcFiltros.Name = "mrcFiltros";
            this.mrcFiltros.Size = new System.Drawing.Size(612, 68);
            this.mrcFiltros.TabIndex = 22;
            this.mrcFiltros.TabStop = false;
            this.mrcFiltros.Text = "&Filtrar";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.Nombre_Compania,
            this.Nombre_Contacto,
            this.Cargo_Contacto,
            this.Direccion,
            this.Ciudad,
            this.Region,
            this.Codigo_Postal,
            this.Pais,
            this.Telefono,
            this.Fax});
            this.dgvClientes.Location = new System.Drawing.Point(32, 157);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.Size = new System.Drawing.Size(932, 310);
            this.dgvClientes.TabIndex = 23;
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "Id. de Cliente";
            this.idCliente.MinimumWidth = 6;
            this.idCliente.Name = "idCliente";
            this.idCliente.Width = 104;
            // 
            // Nombre_Compania
            // 
            this.Nombre_Compania.HeaderText = "Nombre de compañia";
            this.Nombre_Compania.MinimumWidth = 6;
            this.Nombre_Compania.Name = "Nombre_Compania";
            this.Nombre_Compania.Width = 153;
            // 
            // Nombre_Contacto
            // 
            this.Nombre_Contacto.HeaderText = "Nombre del contacto";
            this.Nombre_Contacto.MinimumWidth = 6;
            this.Nombre_Contacto.Name = "Nombre_Contacto";
            this.Nombre_Contacto.Width = 147;
            // 
            // Cargo_Contacto
            // 
            this.Cargo_Contacto.HeaderText = "Cargo del contacto";
            this.Cargo_Contacto.MinimumWidth = 6;
            this.Cargo_Contacto.Name = "Cargo_Contacto";
            this.Cargo_Contacto.Width = 137;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 93;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.MinimumWidth = 6;
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Width = 79;
            // 
            // Region
            // 
            this.Region.HeaderText = "Region";
            this.Region.MinimumWidth = 6;
            this.Region.Name = "Region";
            this.Region.Width = 80;
            // 
            // Codigo_Postal
            // 
            this.Codigo_Postal.HeaderText = "Código Postal";
            this.Codigo_Postal.MinimumWidth = 6;
            this.Codigo_Postal.Name = "Codigo_Postal";
            this.Codigo_Postal.Width = 111;
            // 
            // Pais
            // 
            this.Pais.HeaderText = "País";
            this.Pais.MinimumWidth = 6;
            this.Pais.Name = "Pais";
            this.Pais.Width = 63;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 90;
            // 
            // Fax
            // 
            this.Fax.HeaderText = "Fax";
            this.Fax.MinimumWidth = 6;
            this.Fax.Name = "Fax";
            this.Fax.Width = 58;
            // 
            // frmFiltrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(986, 529);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.mrcFiltros);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFiltrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtrar Clientes";
            this.Load += new System.EventHandler(this.frmFiltrar_Load);
            this.mrcFiltros.ResumeLayout(false);
            this.mrcFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox mrcFiltros;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Compania;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo_Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
    }
}