namespace pryED_Francia_Angela
{
    partial class frmConsultaBD
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
            this.dgvTabla1 = new System.Windows.Forms.DataGridView();
            this.dgvTabla2 = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblConsulta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabla1
            // 
            this.dgvTabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla1.Location = new System.Drawing.Point(26, 47);
            this.dgvTabla1.Name = "dgvTabla1";
            this.dgvTabla1.Size = new System.Drawing.Size(675, 197);
            this.dgvTabla1.TabIndex = 0;
            // 
            // dgvTabla2
            // 
            this.dgvTabla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla2.Location = new System.Drawing.Point(26, 292);
            this.dgvTabla2.Name = "dgvTabla2";
            this.dgvTabla2.Size = new System.Drawing.Size(675, 175);
            this.dgvTabla2.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(608, 250);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(93, 26);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.BackColor = System.Drawing.Color.LightCyan;
            this.lblConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(54, 9);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(123, 18);
            this.lblConsulta.TabIndex = 3;
            this.lblConsulta.Text = "Consulta en SQL";
            // 
            // frmConsultaBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 479);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvTabla2);
            this.Controls.Add(this.dgvTabla1);
            this.Name = "frmConsultaBD";
            this.Text = "frmConsultaBD";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabla1;
        private System.Windows.Forms.DataGridView dgvTabla2;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblConsulta;
    }
}