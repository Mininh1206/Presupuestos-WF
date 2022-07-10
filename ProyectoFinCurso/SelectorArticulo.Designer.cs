
namespace ProyectoFinCurso
{
    partial class SelectorArticulo
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
            this.tablaArticulos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.tbBuscador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorCantidad = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.guardar = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Label();
            this.a2 = new System.Windows.Forms.Label();
            this.a3 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.tbUnidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaArticulos
            // 
            this.tablaArticulos.AllowUserToAddRows = false;
            this.tablaArticulos.AllowUserToDeleteRows = false;
            this.tablaArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Precio});
            this.tablaArticulos.Location = new System.Drawing.Point(516, 80);
            this.tablaArticulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablaArticulos.MultiSelect = false;
            this.tablaArticulos.Name = "tablaArticulos";
            this.tablaArticulos.ReadOnly = true;
            this.tablaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaArticulos.Size = new System.Drawing.Size(535, 505);
            this.tablaArticulos.TabIndex = 0;
            this.tablaArticulos.CurrentCellChanged += new System.EventHandler(this.tablaArticulos_CurrentCellChanged);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cantidad:";
            // 
            // errorCantidad
            // 
            this.errorCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.errorCantidad.AutoSize = true;
            this.errorCantidad.ForeColor = System.Drawing.Color.Red;
            this.errorCantidad.Location = new System.Drawing.Point(61, 396);
            this.errorCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorCantidad.Name = "errorCantidad";
            this.errorCantidad.Size = new System.Drawing.Size(110, 20);
            this.errorCantidad.TabIndex = 17;
            this.errorCantidad.Text = "Cantidad inválida";
            this.errorCantidad.Visible = false;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(132, 367);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(100, 26);
            this.tbCantidad.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Codigo";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(61, 148);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(156, 26);
            this.tbCodigo.TabIndex = 20;
            this.tbCodigo.TextChanged += new System.EventHandler(this.tbCodigo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Descripción";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(61, 264);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(361, 26);
            this.tbDescripcion.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Precio";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(261, 148);
            this.tbPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(161, 26);
            this.tbPrecio.TabIndex = 24;
            // 
            // guardar
            // 
            this.guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guardar.Enabled = false;
            this.guardar.Location = new System.Drawing.Point(345, 363);
            this.guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(100, 35);
            this.guardar.TabIndex = 26;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // a1
            // 
            this.a1.AutoSize = true;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.ForeColor = System.Drawing.Color.Red;
            this.a1.Location = new System.Drawing.Point(225, 151);
            this.a1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(15, 20);
            this.a1.TabIndex = 27;
            this.a1.Text = "*";
            this.a1.Visible = false;
            // 
            // a2
            // 
            this.a2.AutoSize = true;
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2.ForeColor = System.Drawing.Color.Red;
            this.a2.Location = new System.Drawing.Point(430, 151);
            this.a2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(15, 20);
            this.a2.TabIndex = 28;
            this.a2.Text = "*";
            this.a2.Visible = false;
            // 
            // a3
            // 
            this.a3.AutoSize = true;
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3.ForeColor = System.Drawing.Color.Red;
            this.a3.Location = new System.Drawing.Point(430, 267);
            this.a3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(15, 20);
            this.a3.TabIndex = 29;
            this.a3.Text = "*";
            this.a3.Visible = false;
            // 
            // error
            // 
            this.error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(243, 403);
            this.error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(202, 20);
            this.error.TabIndex = 30;
            this.error.Text = "Rellena los campos obligatorios";
            this.error.Visible = false;
            // 
            // tbUnidad
            // 
            this.tbUnidad.Enabled = false;
            this.tbUnidad.Location = new System.Drawing.Point(238, 367);
            this.tbUnidad.Name = "tbUnidad";
            this.tbUnidad.Size = new System.Drawing.Size(71, 26);
            this.tbUnidad.TabIndex = 31;
            // 
            // SelectorArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.tbUnidad);
            this.Controls.Add(this.error);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.errorCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBuscador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.tablaArticulos);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SelectorArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selector de Artículo";
            ((System.ComponentModel.ISupportInitialize)(this.tablaArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaArticulos;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.TextBox tbBuscador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errorCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        public System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Label a1;
        private System.Windows.Forms.Label a2;
        private System.Windows.Forms.Label a3;
        private System.Windows.Forms.Label error;
        public System.Windows.Forms.TextBox tbUnidad;
    }
}