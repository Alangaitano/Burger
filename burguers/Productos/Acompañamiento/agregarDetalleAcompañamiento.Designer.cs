
namespace burguers
{
    partial class agregarDetalleAcompañamiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarDetalleAcompañamiento));
            this.cbxIngredientes = new System.Windows.Forms.ComboBox();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvdetalleacompañamiento = new System.Windows.Forms.DataGridView();
            this.Nombre_Acompañamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Ingrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_acompañamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_ingrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalleacompañamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxIngredientes
            // 
            this.cbxIngredientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxIngredientes.FormattingEnabled = true;
            this.cbxIngredientes.Location = new System.Drawing.Point(138, 93);
            this.cbxIngredientes.Name = "cbxIngredientes";
            this.cbxIngredientes.Size = new System.Drawing.Size(161, 21);
            this.cbxIngredientes.TabIndex = 0;
            // 
            // btnMenos
            // 
            this.btnMenos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenos.Location = new System.Drawing.Point(355, 92);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(25, 23);
            this.btnMenos.TabIndex = 1;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMas
            // 
            this.btnMas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMas.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.Location = new System.Drawing.Point(415, 92);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(25, 23);
            this.btnMas.TabIndex = 2;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = false;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.Location = new System.Drawing.Point(386, 94);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(23, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblIngredientes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIngredientes.Location = new System.Drawing.Point(144, 64);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(78, 14);
            this.lblIngredientes.TabIndex = 4;
            this.lblIngredientes.Text = "Ingredientes";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblCantidad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCantidad.Location = new System.Drawing.Point(372, 65);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 14);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(222, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 31);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(507, 85);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 39);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Agregar/ Modificar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvdetalleacompañamiento
            // 
            this.dgvdetalleacompañamiento.AllowUserToAddRows = false;
            this.dgvdetalleacompañamiento.AllowUserToDeleteRows = false;
            this.dgvdetalleacompañamiento.AllowUserToResizeColumns = false;
            this.dgvdetalleacompañamiento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvdetalleacompañamiento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdetalleacompañamiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvdetalleacompañamiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdetalleacompañamiento.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdetalleacompañamiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdetalleacompañamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalleacompañamiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Acompañamiento,
            this.Nombre_Ingrediente,
            this.Cantidad,
            this.Id_acompañamiento,
            this.Id_ingrediente});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdetalleacompañamiento.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdetalleacompañamiento.EnableHeadersVisualStyles = false;
            this.dgvdetalleacompañamiento.Location = new System.Drawing.Point(95, 153);
            this.dgvdetalleacompañamiento.Name = "dgvdetalleacompañamiento";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdetalleacompañamiento.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdetalleacompañamiento.Size = new System.Drawing.Size(527, 150);
            this.dgvdetalleacompañamiento.TabIndex = 8;
            this.dgvdetalleacompañamiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetalleacompañamiento_CellClick);
            // 
            // Nombre_Acompañamiento
            // 
            this.Nombre_Acompañamiento.HeaderText = "Nombre_Acompañamiento";
            this.Nombre_Acompañamiento.Name = "Nombre_Acompañamiento";
            // 
            // Nombre_Ingrediente
            // 
            this.Nombre_Ingrediente.HeaderText = "Nombre_Ingrediente";
            this.Nombre_Ingrediente.Name = "Nombre_Ingrediente";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Id_acompañamiento
            // 
            this.Id_acompañamiento.HeaderText = "Id_acompañamiento";
            this.Id_acompañamiento.Name = "Id_acompañamiento";
            this.Id_acompañamiento.ReadOnly = true;
            this.Id_acompañamiento.Visible = false;
            // 
            // Id_ingrediente
            // 
            this.Id_ingrediente.HeaderText = "Id_ingrediente";
            this.Id_ingrediente.Name = "Id_ingrediente";
            this.Id_ingrediente.ReadOnly = true;
            this.Id_ingrediente.Visible = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBorrar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(406, 350);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 31);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbltitulo.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltitulo.Location = new System.Drawing.Point(283, 23);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(136, 30);
            this.lbltitulo.TabIndex = 10;
            this.lbltitulo.Text = "Detalle";
            // 
            // agregarDetalleAcompañamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(724, 409);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dgvdetalleacompañamiento);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblIngredientes);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.cbxIngredientes);
            this.Name = "agregarDetalleAcompañamiento";
            this.Text = "agregarDetalleAcompañamiento";
            this.Load += new System.EventHandler(this.agregarDetalleAcompañamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalleacompañamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxIngredientes;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblIngredientes;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvdetalleacompañamiento;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Acompañamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Ingrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_acompañamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ingrediente;
        private System.Windows.Forms.Label lbltitulo;
    }
}