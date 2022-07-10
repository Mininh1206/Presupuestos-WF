
namespace ProyectoFinCurso
{
    partial class SelectorCliente
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
            this.tablaClientes = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.tbBuscador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaClientes
            // 
            this.tablaClientes.AllowUserToAddRows = false;
            this.tablaClientes.AllowUserToDeleteRows = false;
            this.tablaClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.DNI,
            this.Nombre,
            this.Apellidos,
            this.Direccion,
            this.CodPostal,
            this.Telefono,
            this.Email});
            this.tablaClientes.Location = new System.Drawing.Point(16, 80);
            this.tablaClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablaClientes.MultiSelect = false;
            this.tablaClientes.Name = "tablaClientes";
            this.tablaClientes.ReadOnly = true;
            this.tablaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaClientes.Size = new System.Drawing.Size(1035, 503);
            this.tablaClientes.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // CodPostal
            // 
            this.CodPostal.HeaderText = "CP";
            this.CodPostal.Name = "CodPostal";
            this.CodPostal.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // aceptar
            // 
            this.aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aceptar.Location = new System.Drawing.Point(803, 625);
            this.aceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(100, 35);
            this.aceptar.TabIndex = 1;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelar.Location = new System.Drawing.Point(951, 625);
            this.cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(100, 35);
            this.cancelar.TabIndex = 2;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // tbBuscador
            // 
            this.tbBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscador.Location = new System.Drawing.Point(803, 40);
            this.tbBuscador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBuscador.Name = "tbBuscador";
            this.tbBuscador.Size = new System.Drawing.Size(247, 26);
            this.tbBuscador.TabIndex = 6;
            this.tbBuscador.TextChanged += new System.EventHandler(this.tbBuscador_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(725, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscador";
            // 
            // SelectorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.tbBuscador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.tablaClientes);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SelectorCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selector de Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaClientes;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.TextBox tbBuscador;
        private System.Windows.Forms.Label label1;
    }
}