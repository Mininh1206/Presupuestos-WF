
namespace ProyectoFinCurso
{
    partial class Presupuestos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clonarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tablaPresupuestos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBuscador = new System.Windows.Forms.TextBox();
            this.pbActualizarPresupuestos = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPresupuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizarPresupuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.clonarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Image = global::ProyectoFinCurso.Properties.Resources.agregar_presupuesto;
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Image = global::ProyectoFinCurso.Properties.Resources.eliminar_presupuesto;
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.bajaToolStripMenuItem.Text = "Baja";
            this.bajaToolStripMenuItem.Click += new System.EventHandler(this.bajaToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Image = global::ProyectoFinCurso.Properties.Resources.modificar_presupuesto;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // clonarToolStripMenuItem
            // 
            this.clonarToolStripMenuItem.Image = global::ProyectoFinCurso.Properties.Resources.clonar_presupuesto;
            this.clonarToolStripMenuItem.Name = "clonarToolStripMenuItem";
            this.clonarToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clonarToolStripMenuItem.Text = "Clonar";
            this.clonarToolStripMenuItem.Click += new System.EventHandler(this.clonarToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 667);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1067, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(72, 20);
            this.toolStripStatusLabel1.Text = "DocarGest";
            // 
            // tablaPresupuestos
            // 
            this.tablaPresupuestos.AllowUserToAddRows = false;
            this.tablaPresupuestos.AllowUserToDeleteRows = false;
            this.tablaPresupuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaPresupuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaPresupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPresupuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Fecha,
            this.FormaPago,
            this.Total,
            this.Cliente});
            this.tablaPresupuestos.Location = new System.Drawing.Point(13, 91);
            this.tablaPresupuestos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablaPresupuestos.Name = "tablaPresupuestos";
            this.tablaPresupuestos.ReadOnly = true;
            this.tablaPresupuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPresupuestos.Size = new System.Drawing.Size(1041, 571);
            this.tablaPresupuestos.TabIndex = 2;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // FormaPago
            // 
            this.FormaPago.HeaderText = "Forma de pago";
            this.FormaPago.Name = "FormaPago";
            this.FormaPago.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(725, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscador";
            // 
            // tbBuscador
            // 
            this.tbBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscador.Location = new System.Drawing.Point(803, 55);
            this.tbBuscador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBuscador.Name = "tbBuscador";
            this.tbBuscador.Size = new System.Drawing.Size(247, 26);
            this.tbBuscador.TabIndex = 4;
            this.tbBuscador.TextChanged += new System.EventHandler(this.tbBuscador_TextChanged);
            // 
            // pbActualizarPresupuestos
            // 
            this.pbActualizarPresupuestos.Image = global::ProyectoFinCurso.Properties.Resources.actualizar;
            this.pbActualizarPresupuestos.Location = new System.Drawing.Point(33, 58);
            this.pbActualizarPresupuestos.Name = "pbActualizarPresupuestos";
            this.pbActualizarPresupuestos.Size = new System.Drawing.Size(25, 25);
            this.pbActualizarPresupuestos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbActualizarPresupuestos.TabIndex = 5;
            this.pbActualizarPresupuestos.TabStop = false;
            this.pbActualizarPresupuestos.Click += new System.EventHandler(this.pbActualizarPresupuestos_Click);
            // 
            // Presupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.pbActualizarPresupuestos);
            this.Controls.Add(this.tbBuscador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaPresupuestos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Presupuestos";
            this.Text = "DocarGest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPresupuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizarPresupuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView tablaPresupuestos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBuscador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.ToolStripMenuItem clonarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbActualizarPresupuestos;
    }
}