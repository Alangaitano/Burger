
namespace burguers
{
    partial class IngredientesDesactivados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientesDesactivados));
            this.dgvingredientesdesactivados = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.lblactivado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvingredientesdesactivados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvingredientesdesactivados
            // 
            this.dgvingredientesdesactivados.AllowUserToAddRows = false;
            this.dgvingredientesdesactivados.AllowUserToDeleteRows = false;
            this.dgvingredientesdesactivados.AllowUserToResizeColumns = false;
            this.dgvingredientesdesactivados.AllowUserToResizeRows = false;
            this.dgvingredientesdesactivados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvingredientesdesactivados.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvingredientesdesactivados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvingredientesdesactivados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvingredientesdesactivados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvingredientesdesactivados.EnableHeadersVisualStyles = false;
            this.dgvingredientesdesactivados.Location = new System.Drawing.Point(64, 112);
            this.dgvingredientesdesactivados.Name = "dgvingredientesdesactivados";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvingredientesdesactivados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvingredientesdesactivados.Size = new System.Drawing.Size(635, 210);
            this.dgvingredientesdesactivados.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(229, 372);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 33);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnActivar
            // 
            this.btnActivar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActivar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivar.Location = new System.Drawing.Point(429, 372);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(75, 33);
            this.btnActivar.TabIndex = 2;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = false;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // lblactivado
            // 
            this.lblactivado.AutoSize = true;
            this.lblactivado.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblactivado.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblactivado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblactivado.Location = new System.Drawing.Point(257, 47);
            this.lblactivado.Name = "lblactivado";
            this.lblactivado.Size = new System.Drawing.Size(218, 30);
            this.lblactivado.TabIndex = 4;
            this.lblactivado.Text = "Desactivados";
            // 
            // IngredientesDesactivados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblactivado);
            this.Controls.Add(this.btnActivar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvingredientesdesactivados);
            this.Name = "IngredientesDesactivados";
            this.Text = "IngredientesDesactivados";
            this.Load += new System.EventHandler(this.IngredientesDesactivados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvingredientesdesactivados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvingredientesdesactivados;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Label lblactivado;
    }
}