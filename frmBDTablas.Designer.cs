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
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBaseDatos = new System.Windows.Forms.Label();
            this.lblBDNombre = new System.Windows.Forms.Label();
            this.lblTabla = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(707, 463);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 34);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(23, 125);
            this.dgvTabla.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.Size = new System.Drawing.Size(809, 311);
            this.dgvTabla.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(327, 8);
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
            // lblBDNombre
            // 
            this.lblBDNombre.AutoSize = true;
            this.lblBDNombre.Location = new System.Drawing.Point(233, 69);
            this.lblBDNombre.Name = "lblBDNombre";
            this.lblBDNombre.Size = new System.Drawing.Size(10, 16);
            this.lblBDNombre.TabIndex = 10;
            this.lblBDNombre.Text = ".";
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Location = new System.Drawing.Point(451, 69);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(114, 16);
            this.lblTabla.TabIndex = 11;
            this.lblTabla.Text = "Seleccione Tabla";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(571, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(732, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 59);
            this.button1.TabIndex = 13;
            this.button1.Text = "Base de Datos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmBDTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.lblBDNombre);
            this.Controls.Add(this.lblBaseDatos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmBDTablas";
            this.Text = "frmBDTablas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBaseDatos;
        private System.Windows.Forms.Label lblBDNombre;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}