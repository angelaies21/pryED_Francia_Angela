namespace pryED_Francia_Angela
{
    partial class frmDobleEnlanzada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDobleEnlanzada));
            this.lstPila = new System.Windows.Forms.ListBox();
            this.grbElem = new System.Windows.Forms.GroupBox();
            this.lblCodigElim = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCodigElim = new System.Windows.Forms.TextBox();
            this.grbNvElem = new System.Windows.Forms.GroupBox();
            this.txtTramitePila = new System.Windows.Forms.TextBox();
            this.txtNomPila = new System.Windows.Forms.TextBox();
            this.txtCodigPila = new System.Windows.Forms.TextBox();
            this.btnAgregarPila = new System.Windows.Forms.Button();
            this.lblTramiteNv = new System.Windows.Forms.Label();
            this.lblNomNv = new System.Windows.Forms.Label();
            this.lblCodigNv = new System.Windows.Forms.Label();
            this.dgvTablaPila = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbElem.SuspendLayout();
            this.grbNvElem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaPila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPila
            // 
            this.lstPila.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Location = new System.Drawing.Point(12, 264);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(267, 184);
            this.lstPila.TabIndex = 7;
            // 
            // grbElem
            // 
            this.grbElem.Controls.Add(this.lblCodigElim);
            this.grbElem.Controls.Add(this.btnEliminar);
            this.grbElem.Controls.Add(this.txtCodigElim);
            this.grbElem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbElem.Location = new System.Drawing.Point(551, 12);
            this.grbElem.Name = "grbElem";
            this.grbElem.Size = new System.Drawing.Size(283, 218);
            this.grbElem.TabIndex = 9;
            this.grbElem.TabStop = false;
            this.grbElem.Text = "Elemento a eliminar";
            // 
            // lblCodigElim
            // 
            this.lblCodigElim.AutoSize = true;
            this.lblCodigElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigElim.Location = new System.Drawing.Point(18, 91);
            this.lblCodigElim.Name = "lblCodigElim";
            this.lblCodigElim.Size = new System.Drawing.Size(57, 16);
            this.lblCodigElim.TabIndex = 4;
            this.lblCodigElim.Text = "Código";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Bisque;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(6, 171);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(271, 32);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "🗑️​Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // txtCodigElim
            // 
            this.txtCodigElim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCodigElim.Enabled = false;
            this.txtCodigElim.Location = new System.Drawing.Point(88, 88);
            this.txtCodigElim.Name = "txtCodigElim";
            this.txtCodigElim.Size = new System.Drawing.Size(184, 22);
            this.txtCodigElim.TabIndex = 0;
            // 
            // grbNvElem
            // 
            this.grbNvElem.Controls.Add(this.txtTramitePila);
            this.grbNvElem.Controls.Add(this.txtNomPila);
            this.grbNvElem.Controls.Add(this.txtCodigPila);
            this.grbNvElem.Controls.Add(this.btnAgregarPila);
            this.grbNvElem.Controls.Add(this.lblTramiteNv);
            this.grbNvElem.Controls.Add(this.lblNomNv);
            this.grbNvElem.Controls.Add(this.lblCodigNv);
            this.grbNvElem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNvElem.Location = new System.Drawing.Point(258, 12);
            this.grbNvElem.Name = "grbNvElem";
            this.grbNvElem.Size = new System.Drawing.Size(287, 218);
            this.grbNvElem.TabIndex = 8;
            this.grbNvElem.TabStop = false;
            this.grbNvElem.Text = "Nuevo elemento";
            // 
            // txtTramitePila
            // 
            this.txtTramitePila.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTramitePila.Location = new System.Drawing.Point(107, 143);
            this.txtTramitePila.Name = "txtTramitePila";
            this.txtTramitePila.Size = new System.Drawing.Size(176, 22);
            this.txtTramitePila.TabIndex = 6;
            // 
            // txtNomPila
            // 
            this.txtNomPila.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNomPila.Location = new System.Drawing.Point(107, 88);
            this.txtNomPila.Name = "txtNomPila";
            this.txtNomPila.Size = new System.Drawing.Size(176, 22);
            this.txtNomPila.TabIndex = 5;
            // 
            // txtCodigPila
            // 
            this.txtCodigPila.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCodigPila.Location = new System.Drawing.Point(107, 43);
            this.txtCodigPila.Name = "txtCodigPila";
            this.txtCodigPila.Size = new System.Drawing.Size(176, 22);
            this.txtCodigPila.TabIndex = 4;
            // 
            // btnAgregarPila
            // 
            this.btnAgregarPila.BackColor = System.Drawing.Color.Bisque;
            this.btnAgregarPila.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPila.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarPila.Location = new System.Drawing.Point(6, 171);
            this.btnAgregarPila.Name = "btnAgregarPila";
            this.btnAgregarPila.Size = new System.Drawing.Size(281, 32);
            this.btnAgregarPila.TabIndex = 3;
            this.btnAgregarPila.Text = "➡️​Agregar";
            this.btnAgregarPila.UseVisualStyleBackColor = false;
            // 
            // lblTramiteNv
            // 
            this.lblTramiteNv.AutoSize = true;
            this.lblTramiteNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramiteNv.Location = new System.Drawing.Point(15, 143);
            this.lblTramiteNv.Name = "lblTramiteNv";
            this.lblTramiteNv.Size = new System.Drawing.Size(60, 16);
            this.lblTramiteNv.TabIndex = 2;
            this.lblTramiteNv.Text = "Tramite";
            // 
            // lblNomNv
            // 
            this.lblNomNv.AutoSize = true;
            this.lblNomNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomNv.Location = new System.Drawing.Point(15, 88);
            this.lblNomNv.Name = "lblNomNv";
            this.lblNomNv.Size = new System.Drawing.Size(62, 16);
            this.lblNomNv.TabIndex = 1;
            this.lblNomNv.Text = "Nombre";
            // 
            // lblCodigNv
            // 
            this.lblCodigNv.AutoSize = true;
            this.lblCodigNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigNv.Location = new System.Drawing.Point(15, 37);
            this.lblCodigNv.Name = "lblCodigNv";
            this.lblCodigNv.Size = new System.Drawing.Size(57, 16);
            this.lblCodigNv.TabIndex = 0;
            this.lblCodigNv.Text = "Código";
            // 
            // dgvTablaPila
            // 
            this.dgvTablaPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvTablaPila.Location = new System.Drawing.Point(297, 264);
            this.dgvTablaPila.Name = "dgvTablaPila";
            this.dgvTablaPila.Size = new System.Drawing.Size(526, 187);
            this.dgvTablaPila.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 160F;
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.Width = 160;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 160F;
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 160F;
            this.Column3.HeaderText = "Tramite";
            this.Column3.Name = "Column3";
            this.Column3.Width = 160;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmDobleEnlanzada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvTablaPila);
            this.Controls.Add(this.grbElem);
            this.Controls.Add(this.grbNvElem);
            this.Controls.Add(this.lstPila);
            this.Name = "frmDobleEnlanzada";
            this.Text = "frmDobleEnlanzada";
            this.grbElem.ResumeLayout(false);
            this.grbElem.PerformLayout();
            this.grbNvElem.ResumeLayout(false);
            this.grbNvElem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaPila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.GroupBox grbElem;
        private System.Windows.Forms.Label lblCodigElim;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtCodigElim;
        private System.Windows.Forms.GroupBox grbNvElem;
        private System.Windows.Forms.TextBox txtTramitePila;
        private System.Windows.Forms.TextBox txtNomPila;
        private System.Windows.Forms.TextBox txtCodigPila;
        private System.Windows.Forms.Button btnAgregarPila;
        private System.Windows.Forms.Label lblTramiteNv;
        private System.Windows.Forms.Label lblNomNv;
        private System.Windows.Forms.Label lblCodigNv;
        private System.Windows.Forms.DataGridView dgvTablaPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}