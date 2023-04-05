
namespace burguers
{
    partial class DetalleHamburguesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleHamburguesa));
            this.dgvDetalleHamburguesa = new System.Windows.Forms.DataGridView();
            this.Nombre_Hamburguesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_ingrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_hamburguesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ingrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lbldetalle = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblIngrediente = new System.Windows.Forms.Label();
            this.btnmas = new System.Windows.Forms.Button();
            this.btnmenos = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cbxIngrediente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleHamburguesa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalleHamburguesa
            // 
            this.dgvDetalleHamburguesa.AllowUserToAddRows = false;
            this.dgvDetalleHamburguesa.AllowUserToDeleteRows = false;
            this.dgvDetalleHamburguesa.AllowUserToResizeColumns = false;
            this.dgvDetalleHamburguesa.AllowUserToResizeRows = false;
            this.dgvDetalleHamburguesa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleHamburguesa.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleHamburguesa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleHamburguesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleHamburguesa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Hamburguesa,
            this.Nombre_ingrediente,
            this.Cantidad,
            this.id_hamburguesa,
            this.id_ingrediente});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleHamburguesa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleHamburguesa.EnableHeadersVisualStyles = false;
            this.dgvDetalleHamburguesa.Location = new System.Drawing.Point(123, 157);
            this.dgvDetalleHamburguesa.Name = "dgvDetalleHamburguesa";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleHamburguesa.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleHamburguesa.Size = new System.Drawing.Size(514, 212);
            this.dgvDetalleHamburguesa.TabIndex = 0;
            this.dgvDetalleHamburguesa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetallehamburguesa_cellClick);
            // 
            // Nombre_Hamburguesa
            // 
            this.Nombre_Hamburguesa.HeaderText = "Nombre Hamburguesa";
            this.Nombre_Hamburguesa.Name = "Nombre_Hamburguesa";
            this.Nombre_Hamburguesa.ReadOnly = true;
            // 
            // Nombre_ingrediente
            // 
            this.Nombre_ingrediente.HeaderText = "Nombre Ingrediente";
            this.Nombre_ingrediente.Name = "Nombre_ingrediente";
            this.Nombre_ingrediente.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // id_hamburguesa
            // 
            this.id_hamburguesa.HeaderText = "id_hamburguesa";
            this.id_hamburguesa.Name = "id_hamburguesa";
            this.id_hamburguesa.Visible = false;
            // 
            // id_ingrediente
            // 
            this.id_ingrediente.HeaderText = "id_ingrediente";
            this.id_ingrediente.Name = "id_ingrediente";
            this.id_ingrediente.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(497, 103);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(77, 38);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar/ modificar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(472, 375);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 39);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lbldetalle
            // 
            this.lbldetalle.AutoSize = true;
            this.lbldetalle.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbldetalle.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetalle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldetalle.Location = new System.Drawing.Point(320, 45);
            this.lbldetalle.Name = "lbldetalle";
            this.lbldetalle.Size = new System.Drawing.Size(136, 30);
            this.lbldetalle.TabIndex = 4;
            this.lbldetalle.Text = "Detalle";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(231, 375);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 39);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblCantidad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCantidad.Location = new System.Drawing.Point(387, 95);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 14);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblIngrediente
            // 
            this.lblIngrediente.AutoSize = true;
            this.lblIngrediente.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblIngrediente.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIngrediente.Location = new System.Drawing.Point(242, 95);
            this.lblIngrediente.Name = "lblIngrediente";
            this.lblIngrediente.Size = new System.Drawing.Size(71, 14);
            this.lblIngrediente.TabIndex = 10;
            this.lblIngrediente.Text = "Ingrediente";
            // 
            // btnmas
            // 
            this.btnmas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmas.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmas.Location = new System.Drawing.Point(430, 112);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(26, 23);
            this.btnmas.TabIndex = 9;
            this.btnmas.Text = "+";
            this.btnmas.UseVisualStyleBackColor = false;
            this.btnmas.Click += new System.EventHandler(this.btnmas_Click);
            // 
            // btnmenos
            // 
            this.btnmenos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmenos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenos.Location = new System.Drawing.Point(372, 112);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(26, 23);
            this.btnmenos.TabIndex = 8;
            this.btnmenos.Text = "-";
            this.btnmenos.UseVisualStyleBackColor = false;
            this.btnmenos.Click += new System.EventHandler(this.btnmenos_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(404, 114);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(20, 20);
            this.txtCantidad.TabIndex = 7;
            // 
            // cbxIngrediente
            // 
            this.cbxIngrediente.FormattingEnabled = true;
            this.cbxIngrediente.Location = new System.Drawing.Point(214, 112);
            this.cbxIngrediente.Name = "cbxIngrediente";
            this.cbxIngrediente.Size = new System.Drawing.Size(121, 21);
            this.cbxIngrediente.TabIndex = 6;
            // 
            // DetalleHamburguesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblIngrediente);
            this.Controls.Add(this.btnmas);
            this.Controls.Add(this.btnmenos);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cbxIngrediente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lbldetalle);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvDetalleHamburguesa);
            this.Name = "DetalleHamburguesa";
            this.Text = "DetalleHamburguesa";
            this.Load += new System.EventHandler(this.DetalleHamburguesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleHamburguesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalleHamburguesa;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Hamburguesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_ingrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_hamburguesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ingrediente;
        private System.Windows.Forms.Label lbldetalle;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblIngrediente;
        private System.Windows.Forms.Button btnmas;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cbxIngrediente;
    }
}