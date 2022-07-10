
namespace ProyectoFinCurso
{
    partial class FormularioPresupuesto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.a1 = new System.Windows.Forms.Label();
            this.pbBuscarcliente = new System.Windows.Forms.PictureBox();
            this.lCodPostal = new System.Windows.Forms.Label();
            this.lDNI = new System.Windows.Forms.Label();
            this.lTelefono = new System.Windows.Forms.Label();
            this.lDireccion = new System.Windows.Forms.Label();
            this.lCorreo = new System.Windows.Forms.Label();
            this.lApellidos = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tablaArticulos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.a3 = new System.Windows.Forms.Label();
            this.a2 = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbFormaPago = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCodPresupuesto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.pbEliminarArticulo = new System.Windows.Forms.PictureBox();
            this.pbAgregarArticulo = new System.Windows.Forms.PictureBox();
            this.error = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarcliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaArticulos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(16, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(509, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la empresa";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.a1);
            this.groupBox2.Controls.Add(this.pbBuscarcliente);
            this.groupBox2.Controls.Add(this.lCodPostal);
            this.groupBox2.Controls.Add(this.lDNI);
            this.groupBox2.Controls.Add(this.lTelefono);
            this.groupBox2.Controls.Add(this.lDireccion);
            this.groupBox2.Controls.Add(this.lCorreo);
            this.groupBox2.Controls.Add(this.lApellidos);
            this.groupBox2.Controls.Add(this.lNombre);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbCodigo);
            this.groupBox2.Location = new System.Drawing.Point(541, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(509, 285);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del cliente";
            // 
            // a1
            // 
            this.a1.AutoSize = true;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.ForeColor = System.Drawing.Color.Red;
            this.a1.Location = new System.Drawing.Point(268, 58);
            this.a1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(15, 20);
            this.a1.TabIndex = 22;
            this.a1.Text = "*";
            this.a1.Visible = false;
            // 
            // pbBuscarcliente
            // 
            this.pbBuscarcliente.Image = global::ProyectoFinCurso.Properties.Resources.buscar_usuario;
            this.pbBuscarcliente.Location = new System.Drawing.Point(230, 53);
            this.pbBuscarcliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbBuscarcliente.Name = "pbBuscarcliente";
            this.pbBuscarcliente.Size = new System.Drawing.Size(30, 30);
            this.pbBuscarcliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscarcliente.TabIndex = 17;
            this.pbBuscarcliente.TabStop = false;
            this.pbBuscarcliente.Click += new System.EventHandler(this.pbBuscarcliente_Click);
            // 
            // lCodPostal
            // 
            this.lCodPostal.AutoSize = true;
            this.lCodPostal.Location = new System.Drawing.Point(355, 231);
            this.lCodPostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCodPostal.Name = "lCodPostal";
            this.lCodPostal.Size = new System.Drawing.Size(0, 20);
            this.lCodPostal.TabIndex = 16;
            // 
            // lDNI
            // 
            this.lDNI.AutoSize = true;
            this.lDNI.Location = new System.Drawing.Point(355, 151);
            this.lDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDNI.Name = "lDNI";
            this.lDNI.Size = new System.Drawing.Size(0, 20);
            this.lDNI.TabIndex = 15;
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Location = new System.Drawing.Point(355, 111);
            this.lTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(0, 20);
            this.lTelefono.TabIndex = 14;
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.Location = new System.Drawing.Point(103, 231);
            this.lDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(0, 20);
            this.lDireccion.TabIndex = 13;
            // 
            // lCorreo
            // 
            this.lCorreo.AutoSize = true;
            this.lCorreo.Location = new System.Drawing.Point(157, 191);
            this.lCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCorreo.Name = "lCorreo";
            this.lCorreo.Size = new System.Drawing.Size(0, 20);
            this.lCorreo.TabIndex = 12;
            // 
            // lApellidos
            // 
            this.lApellidos.AutoSize = true;
            this.lApellidos.Location = new System.Drawing.Point(95, 151);
            this.lApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lApellidos.Name = "lApellidos";
            this.lApellidos.Size = new System.Drawing.Size(0, 20);
            this.lApellidos.TabIndex = 11;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(92, 111);
            this.lNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(0, 20);
            this.lNombre.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 231);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "CP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Correo electrónico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(86, 55);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(132, 26);
            this.tbCodigo.TabIndex = 0;
            this.tbCodigo.TextChanged += new System.EventHandler(this.tbCodigo_TextChanged);
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
            this.Cantidad,
            this.Precio,
            this.Subtotal});
            this.tablaArticulos.Location = new System.Drawing.Point(16, 409);
            this.tablaArticulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablaArticulos.Name = "tablaArticulos";
            this.tablaArticulos.ReadOnly = true;
            this.tablaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaArticulos.Size = new System.Drawing.Size(1035, 203);
            this.tablaArticulos.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.a3);
            this.groupBox3.Controls.Add(this.a2);
            this.groupBox3.Controls.Add(this.lTotal);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cbFormaPago);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbCodPresupuesto);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(16, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1034, 77);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del presupuesto";
            // 
            // a3
            // 
            this.a3.AutoSize = true;
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3.ForeColor = System.Drawing.Color.Red;
            this.a3.Location = new System.Drawing.Point(689, 38);
            this.a3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(15, 20);
            this.a3.TabIndex = 21;
            this.a3.Text = "*";
            this.a3.Visible = false;
            // 
            // a2
            // 
            this.a2.AutoSize = true;
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2.ForeColor = System.Drawing.Color.Red;
            this.a2.Location = new System.Drawing.Point(326, 38);
            this.a2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(15, 20);
            this.a2.TabIndex = 20;
            this.a2.Text = "*";
            this.a2.Visible = false;
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Location = new System.Drawing.Point(873, 38);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(23, 20);
            this.lTotal.TabIndex = 5;
            this.lTotal.Text = "0€";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(826, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Total:";
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPago.FormattingEnabled = true;
            this.cbFormaPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Bizum",
            "Transferencia",
            "Cheque"});
            this.cbFormaPago.Location = new System.Drawing.Point(536, 35);
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(146, 28);
            this.cbFormaPago.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tipo de pago:";
            // 
            // tbCodPresupuesto
            // 
            this.tbCodPresupuesto.Location = new System.Drawing.Point(184, 35);
            this.tbCodPresupuesto.Name = "tbCodPresupuesto";
            this.tbCodPresupuesto.Size = new System.Drawing.Size(135, 26);
            this.tbCodPresupuesto.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Código del presupuesto:";
            // 
            // cancelar
            // 
            this.cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelar.Location = new System.Drawing.Point(951, 635);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(100, 35);
            this.cancelar.TabIndex = 4;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(813, 635);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(99, 35);
            this.borrar.TabIndex = 5;
            this.borrar.Text = "Borrar";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(673, 635);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(99, 35);
            this.aceptar.TabIndex = 6;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // pbEliminarArticulo
            // 
            this.pbEliminarArticulo.Image = global::ProyectoFinCurso.Properties.Resources.eliminar_articulo_presupuesto;
            this.pbEliminarArticulo.Location = new System.Drawing.Point(83, 622);
            this.pbEliminarArticulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbEliminarArticulo.Name = "pbEliminarArticulo";
            this.pbEliminarArticulo.Size = new System.Drawing.Size(30, 30);
            this.pbEliminarArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEliminarArticulo.TabIndex = 19;
            this.pbEliminarArticulo.TabStop = false;
            this.pbEliminarArticulo.Click += new System.EventHandler(this.pbEliminarArticulo_Click);
            // 
            // pbAgregarArticulo
            // 
            this.pbAgregarArticulo.Image = global::ProyectoFinCurso.Properties.Resources.agregar_articulo_presupuesto;
            this.pbAgregarArticulo.Location = new System.Drawing.Point(31, 622);
            this.pbAgregarArticulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbAgregarArticulo.Name = "pbAgregarArticulo";
            this.pbAgregarArticulo.Size = new System.Drawing.Size(30, 30);
            this.pbAgregarArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAgregarArticulo.TabIndex = 18;
            this.pbAgregarArticulo.TabStop = false;
            this.pbAgregarArticulo.Click += new System.EventHandler(this.pbAgregarArticulo_Click);
            // 
            // error
            // 
            this.error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(254, 642);
            this.error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(377, 20);
            this.error.TabIndex = 23;
            this.error.Text = "Rellena los campos obligatorios y añade al menos un artículo";
            this.error.Visible = false;
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
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // FormularioPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.error);
            this.Controls.Add(this.pbEliminarArticulo);
            this.Controls.Add(this.pbAgregarArticulo);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tablaArticulos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormularioPresupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Presupuestos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscarcliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaArticulos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbBuscarcliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button aceptar;
        public System.Windows.Forms.Label lTotal;
        public System.Windows.Forms.ComboBox cbFormaPago;
        public System.Windows.Forms.DataGridView tablaArticulos;
        public System.Windows.Forms.Label lCodPostal;
        public System.Windows.Forms.Label lDNI;
        public System.Windows.Forms.Label lTelefono;
        public System.Windows.Forms.Label lDireccion;
        public System.Windows.Forms.Label lCorreo;
        public System.Windows.Forms.Label lApellidos;
        public System.Windows.Forms.Label lNombre;
        public System.Windows.Forms.TextBox tbCodigo;
        public System.Windows.Forms.TextBox tbCodPresupuesto;
        private System.Windows.Forms.PictureBox pbAgregarArticulo;
        private System.Windows.Forms.PictureBox pbEliminarArticulo;
        private System.Windows.Forms.Label a1;
        private System.Windows.Forms.Label a3;
        private System.Windows.Forms.Label a2;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}