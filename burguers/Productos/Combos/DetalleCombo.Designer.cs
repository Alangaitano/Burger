
namespace burguers
{
    partial class DetalleCombo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleCombo));
            this.dgvDetalleCombo = new System.Windows.Forms.DataGridView();
            this.iddetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acompañamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hamburguesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbldetalle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCombo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalleCombo
            // 
            this.dgvDetalleCombo.AllowUserToAddRows = false;
            this.dgvDetalleCombo.AllowUserToDeleteRows = false;
            this.dgvDetalleCombo.AllowUserToResizeColumns = false;
            this.dgvDetalleCombo.AllowUserToResizeRows = false;
            this.dgvDetalleCombo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleCombo.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleCombo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCombo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddetalle,
            this.Bebida,
            this.Acompañamiento,
            this.Hamburguesa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleCombo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleCombo.EnableHeadersVisualStyles = false;
            this.dgvDetalleCombo.Location = new System.Drawing.Point(25, 113);
            this.dgvDetalleCombo.Name = "dgvDetalleCombo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleCombo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleCombo.Size = new System.Drawing.Size(537, 187);
            this.dgvDetalleCombo.TabIndex = 0;
            // 
            // iddetalle
            // 
            this.iddetalle.HeaderText = "id_detalle";
            this.iddetalle.Name = "iddetalle";
            // 
            // Bebida
            // 
            this.Bebida.HeaderText = "Bebida";
            this.Bebida.Name = "Bebida";
            // 
            // Acompañamiento
            // 
            this.Acompañamiento.HeaderText = "Acompañamiento";
            this.Acompañamiento.Name = "Acompañamiento";
            // 
            // Hamburguesa
            // 
            this.Hamburguesa.HeaderText = "Hamburguesa";
            this.Hamburguesa.Name = "Hamburguesa";
            // 
            // lbldetalle
            // 
            this.lbldetalle.AutoSize = true;
            this.lbldetalle.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbldetalle.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetalle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldetalle.Location = new System.Drawing.Point(186, 43);
            this.lbldetalle.Name = "lbldetalle";
            this.lbldetalle.Size = new System.Drawing.Size(236, 30);
            this.lbldetalle.TabIndex = 1;
            this.lbldetalle.Text = "Detalle combo";
            // 
            // DetalleCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(605, 360);
            this.Controls.Add(this.lbldetalle);
            this.Controls.Add(this.dgvDetalleCombo);
            this.Name = "DetalleCombo";
            this.Text = "DetalleCombo";
            this.Load += new System.EventHandler(this.DetalleCombo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCombo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalleCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acompañamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hamburguesa;
        private System.Windows.Forms.Label lbldetalle;
    }
}