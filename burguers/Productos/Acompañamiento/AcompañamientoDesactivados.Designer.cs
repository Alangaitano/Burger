
namespace burguers
{
    partial class AcompañamientoDesactivados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcompañamientoDesactivados));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.dgvDesactivados = new System.Windows.Forms.DataGridView();
            this.lblDesactivados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesactivados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(168, 324);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActivar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivar.Location = new System.Drawing.Point(353, 324);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(75, 30);
            this.btnActivar.TabIndex = 1;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = false;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // dgvDesactivados
            // 
            this.dgvDesactivados.AllowUserToAddRows = false;
            this.dgvDesactivados.AllowUserToDeleteRows = false;
            this.dgvDesactivados.AllowUserToResizeColumns = false;
            this.dgvDesactivados.AllowUserToResizeRows = false;
            this.dgvDesactivados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDesactivados.BackgroundColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDesactivados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDesactivados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDesactivados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDesactivados.EnableHeadersVisualStyles = false;
            this.dgvDesactivados.Location = new System.Drawing.Point(44, 101);
            this.dgvDesactivados.Name = "dgvDesactivados";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDesactivados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgvDesactivados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDesactivados.Size = new System.Drawing.Size(520, 196);
            this.dgvDesactivados.TabIndex = 2;
            // 
            // lblDesactivados
            // 
            this.lblDesactivados.AutoSize = true;
            this.lblDesactivados.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblDesactivados.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDesactivados.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesactivados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDesactivados.Location = new System.Drawing.Point(200, 27);
            this.lblDesactivados.Name = "lblDesactivados";
            this.lblDesactivados.Size = new System.Drawing.Size(218, 30);
            this.lblDesactivados.TabIndex = 3;
            this.lblDesactivados.Text = "Desactivados";
            // 
            // AcompañamientoDesactivados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 391);
            this.Controls.Add(this.lblDesactivados);
            this.Controls.Add(this.dgvDesactivados);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "AcompañamientoDesactivados";
            this.Text = "AcompañamientoDesactivados";
            this.Load += new System.EventHandler(this.AcompañamientoDesactivados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesactivados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.DataGridView dgvDesactivados;
        private System.Windows.Forms.Label lblDesactivados;
    }
}