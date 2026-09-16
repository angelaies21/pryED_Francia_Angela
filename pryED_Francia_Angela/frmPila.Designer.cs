namespace pryED_Francia_Angela
{
    partial class frmPila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPila));
            this.grbNvElem = new System.Windows.Forms.GroupBox();
            this.txtTramitePila = new System.Windows.Forms.TextBox();
            this.txtNomPila = new System.Windows.Forms.TextBox();
            this.txtCodigPila = new System.Windows.Forms.TextBox();
            this.btnAgregarPila = new System.Windows.Forms.Button();
            this.lblTramiteNv = new System.Windows.Forms.Label();
            this.lblNomNv = new System.Windows.Forms.Label();
            this.lblCodigNv = new System.Windows.Forms.Label();
            this.grbElem = new System.Windows.Forms.GroupBox();
            this.lblTramiteElim = new System.Windows.Forms.Label();
            this.lblNomElim = new System.Windows.Forms.Label();
            this.lblCodigElim = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtTram = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCodigElim = new System.Windows.Forms.TextBox();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.dgvTablaPila = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbNvElem.SuspendLayout();
            this.grbElem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaPila)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.grbNvElem.Location = new System.Drawing.Point(313, 12);
            this.grbNvElem.Name = "grbNvElem";
            this.grbNvElem.Size = new System.Drawing.Size(301, 218);
            this.grbNvElem.TabIndex = 1;
            this.grbNvElem.TabStop = false;
            this.grbNvElem.Text = "Nuevo elemento";
            this.grbNvElem.Enter += new System.EventHandler(this.grbNvElem_Enter);
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
            this.txtCodigPila.Location = new System.Drawing.Point(107, 36);
            this.txtCodigPila.Name = "txtCodigPila";
            this.txtCodigPila.Size = new System.Drawing.Size(176, 22);
            this.txtCodigPila.TabIndex = 4;
            // 
            // btnAgregarPila
            // 
            this.btnAgregarPila.BackColor = System.Drawing.Color.Bisque;
            this.btnAgregarPila.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPila.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarPila.Location = new System.Drawing.Point(184, 186);
            this.btnAgregarPila.Name = "btnAgregarPila";
            this.btnAgregarPila.Size = new System.Drawing.Size(99, 32);
            this.btnAgregarPila.TabIndex = 3;
            this.btnAgregarPila.Text = "➡️​Agregar";
            this.btnAgregarPila.UseVisualStyleBackColor = false;
            this.btnAgregarPila.Click += new System.EventHandler(this.btnAgregarPila_Click);
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
            // grbElem
            // 
            this.grbElem.Controls.Add(this.lblTramiteElim);
            this.grbElem.Controls.Add(this.lblNomElim);
            this.grbElem.Controls.Add(this.lblCodigElim);
            this.grbElem.Controls.Add(this.btnEliminar);
            this.grbElem.Controls.Add(this.txtTram);
            this.grbElem.Controls.Add(this.txtNom);
            this.grbElem.Controls.Add(this.txtCodigElim);
            this.grbElem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbElem.Location = new System.Drawing.Point(629, 12);
            this.grbElem.Name = "grbElem";
            this.grbElem.Size = new System.Drawing.Size(283, 218);
            this.grbElem.TabIndex = 2;
            this.grbElem.TabStop = false;
            this.grbElem.Text = "Elemento a eliminar";
            // 
            // lblTramiteElim
            // 
            this.lblTramiteElim.AutoSize = true;
            this.lblTramiteElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramiteElim.Location = new System.Drawing.Point(16, 149);
            this.lblTramiteElim.Name = "lblTramiteElim";
            this.lblTramiteElim.Size = new System.Drawing.Size(54, 16);
            this.lblTramiteElim.TabIndex = 6;
            this.lblTramiteElim.Text = "tramite";
            // 
            // lblNomElim
            // 
            this.lblNomElim.AutoSize = true;
            this.lblNomElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomElim.Location = new System.Drawing.Point(16, 94);
            this.lblNomElim.Name = "lblNomElim";
            this.lblNomElim.Size = new System.Drawing.Size(62, 16);
            this.lblNomElim.TabIndex = 5;
            this.lblNomElim.Text = "Nombre";
            // 
            // lblCodigElim
            // 
            this.lblCodigElim.AutoSize = true;
            this.lblCodigElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigElim.Location = new System.Drawing.Point(16, 43);
            this.lblCodigElim.Name = "lblCodigElim";
            this.lblCodigElim.Size = new System.Drawing.Size(57, 16);
            this.lblCodigElim.TabIndex = 4;
            this.lblCodigElim.Text = "Código";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Bisque;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(160, 186);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 32);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "🗑️​Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtTram
            // 
            this.txtTram.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTram.Enabled = false;
            this.txtTram.Location = new System.Drawing.Point(89, 139);
            this.txtTram.Name = "txtTram";
            this.txtTram.Size = new System.Drawing.Size(184, 22);
            this.txtTram.TabIndex = 2;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNom.Enabled = false;
            this.txtNom.Location = new System.Drawing.Point(89, 90);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(184, 22);
            this.txtNom.TabIndex = 1;
            // 
            // txtCodigElim
            // 
            this.txtCodigElim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCodigElim.Enabled = false;
            this.txtCodigElim.Location = new System.Drawing.Point(89, 37);
            this.txtCodigElim.Name = "txtCodigElim";
            this.txtCodigElim.Size = new System.Drawing.Size(184, 22);
            this.txtCodigElim.TabIndex = 0;
            // 
            // lstPila
            // 
            this.lstPila.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Location = new System.Drawing.Point(6, 19);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(343, 184);
            this.lstPila.TabIndex = 6;
            // 
            // dgvTablaPila
            // 
            this.dgvTablaPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvTablaPila.Location = new System.Drawing.Point(368, 19);
            this.dgvTablaPila.Name = "dgvTablaPila";
            this.dgvTablaPila.Size = new System.Drawing.Size(526, 187);
            this.dgvTablaPila.TabIndex = 7;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTablaPila);
            this.groupBox1.Controls.Add(this.lstPila);
            this.groupBox1.Location = new System.Drawing.Point(20, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 212);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado en una Lista y una Grilla";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(924, 452);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbElem);
            this.Controls.Add(this.grbNvElem);
            this.Name = "frmPila";
            this.Text = "Estructura de datos lineal: Pila";
            this.grbNvElem.ResumeLayout(false);
            this.grbNvElem.PerformLayout();
            this.grbElem.ResumeLayout(false);
            this.grbElem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaPila)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNvElem;
        private System.Windows.Forms.TextBox txtTramitePila;
        private System.Windows.Forms.TextBox txtNomPila;
        private System.Windows.Forms.TextBox txtCodigPila;
        private System.Windows.Forms.Button btnAgregarPila;
        private System.Windows.Forms.Label lblTramiteNv;
        private System.Windows.Forms.Label lblNomNv;
        private System.Windows.Forms.Label lblCodigNv;
        private System.Windows.Forms.GroupBox grbElem;
        private System.Windows.Forms.Label lblTramiteElim;
        private System.Windows.Forms.Label lblNomElim;
        private System.Windows.Forms.Label lblCodigElim;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtTram;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCodigElim;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.DataGridView dgvTablaPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}