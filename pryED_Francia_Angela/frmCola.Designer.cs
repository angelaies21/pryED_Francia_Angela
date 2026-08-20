namespace pryED_Francia_Angela
{
    partial class frmCola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCola));
            this.grbNvElem = new System.Windows.Forms.GroupBox();
            this.txtTramiteNv = new System.Windows.Forms.TextBox();
            this.txtNomNv = new System.Windows.Forms.TextBox();
            this.txtCodigNv = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramiteNv = new System.Windows.Forms.Label();
            this.lblNomNv = new System.Windows.Forms.Label();
            this.lblCodigNv = new System.Windows.Forms.Label();
            this.grbElemElim = new System.Windows.Forms.GroupBox();
            this.lblTramiteElim = new System.Windows.Forms.Label();
            this.lblNomElim = new System.Windows.Forms.Label();
            this.lblCodigElim = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtTramiteElim = new System.Windows.Forms.TextBox();
            this.txtNomElim = new System.Windows.Forms.TextBox();
            this.txtCodigElim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstListado = new System.Windows.Forms.ListBox();
            this.grbNvElem.SuspendLayout();
            this.grbElemElim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbNvElem
            // 
            this.grbNvElem.Controls.Add(this.txtTramiteNv);
            this.grbNvElem.Controls.Add(this.txtNomNv);
            this.grbNvElem.Controls.Add(this.txtCodigNv);
            this.grbNvElem.Controls.Add(this.btnAgregar);
            this.grbNvElem.Controls.Add(this.lblTramiteNv);
            this.grbNvElem.Controls.Add(this.lblNomNv);
            this.grbNvElem.Controls.Add(this.lblCodigNv);
            this.grbNvElem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNvElem.Location = new System.Drawing.Point(12, 20);
            this.grbNvElem.Name = "grbNvElem";
            this.grbNvElem.Size = new System.Drawing.Size(301, 218);
            this.grbNvElem.TabIndex = 0;
            this.grbNvElem.TabStop = false;
            this.grbNvElem.Text = "Nuevo elemento";
            // 
            // txtTramiteNv
            // 
            this.txtTramiteNv.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTramiteNv.Location = new System.Drawing.Point(107, 143);
            this.txtTramiteNv.Name = "txtTramiteNv";
            this.txtTramiteNv.Size = new System.Drawing.Size(176, 22);
            this.txtTramiteNv.TabIndex = 6;
            // 
            // txtNomNv
            // 
            this.txtNomNv.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNomNv.Location = new System.Drawing.Point(107, 88);
            this.txtNomNv.Name = "txtNomNv";
            this.txtNomNv.Size = new System.Drawing.Size(176, 22);
            this.txtNomNv.TabIndex = 5;
            // 
            // txtCodigNv
            // 
            this.txtCodigNv.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCodigNv.Location = new System.Drawing.Point(107, 36);
            this.txtCodigNv.Name = "txtCodigNv";
            this.txtCodigNv.Size = new System.Drawing.Size(176, 22);
            this.txtCodigNv.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(191, 171);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 32);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTramiteNv
            // 
            this.lblTramiteNv.AutoSize = true;
            this.lblTramiteNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramiteNv.Location = new System.Drawing.Point(15, 143);
            this.lblTramiteNv.Name = "lblTramiteNv";
            this.lblTramiteNv.Size = new System.Drawing.Size(53, 16);
            this.lblTramiteNv.TabIndex = 2;
            this.lblTramiteNv.Text = "Tramite";
            // 
            // lblNomNv
            // 
            this.lblNomNv.AutoSize = true;
            this.lblNomNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomNv.Location = new System.Drawing.Point(15, 88);
            this.lblNomNv.Name = "lblNomNv";
            this.lblNomNv.Size = new System.Drawing.Size(56, 16);
            this.lblNomNv.TabIndex = 1;
            this.lblNomNv.Text = "Nombre";
            // 
            // lblCodigNv
            // 
            this.lblCodigNv.AutoSize = true;
            this.lblCodigNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigNv.Location = new System.Drawing.Point(15, 37);
            this.lblCodigNv.Name = "lblCodigNv";
            this.lblCodigNv.Size = new System.Drawing.Size(51, 16);
            this.lblCodigNv.TabIndex = 0;
            this.lblCodigNv.Text = "Código";
            // 
            // grbElemElim
            // 
            this.grbElemElim.Controls.Add(this.lblTramiteElim);
            this.grbElemElim.Controls.Add(this.lblNomElim);
            this.grbElemElim.Controls.Add(this.lblCodigElim);
            this.grbElemElim.Controls.Add(this.btnEliminar);
            this.grbElemElim.Controls.Add(this.txtTramiteElim);
            this.grbElemElim.Controls.Add(this.txtNomElim);
            this.grbElemElim.Controls.Add(this.txtCodigElim);
            this.grbElemElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbElemElim.Location = new System.Drawing.Point(338, 20);
            this.grbElemElim.Name = "grbElemElim";
            this.grbElemElim.Size = new System.Drawing.Size(283, 218);
            this.grbElemElim.TabIndex = 1;
            this.grbElemElim.TabStop = false;
            this.grbElemElim.Text = "Elemento a eliminar";
            this.grbElemElim.Enter += new System.EventHandler(this.grbElemElim_Enter);
            // 
            // lblTramiteElim
            // 
            this.lblTramiteElim.AutoSize = true;
            this.lblTramiteElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramiteElim.Location = new System.Drawing.Point(25, 145);
            this.lblTramiteElim.Name = "lblTramiteElim";
            this.lblTramiteElim.Size = new System.Drawing.Size(47, 16);
            this.lblTramiteElim.TabIndex = 6;
            this.lblTramiteElim.Text = "tramite";
            this.lblTramiteElim.Click += new System.EventHandler(this.lblTramiteElim_Click);
            // 
            // lblNomElim
            // 
            this.lblNomElim.AutoSize = true;
            this.lblNomElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomElim.Location = new System.Drawing.Point(25, 90);
            this.lblNomElim.Name = "lblNomElim";
            this.lblNomElim.Size = new System.Drawing.Size(56, 16);
            this.lblNomElim.TabIndex = 5;
            this.lblNomElim.Text = "Nombre";
            this.lblNomElim.Click += new System.EventHandler(this.lblNomElim_Click);
            // 
            // lblCodigElim
            // 
            this.lblCodigElim.AutoSize = true;
            this.lblCodigElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigElim.Location = new System.Drawing.Point(25, 39);
            this.lblCodigElim.Name = "lblCodigElim";
            this.lblCodigElim.Size = new System.Drawing.Size(51, 16);
            this.lblCodigElim.TabIndex = 4;
            this.lblCodigElim.Text = "Código";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(161, 177);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 26);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtTramiteElim
            // 
            this.txtTramiteElim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTramiteElim.Location = new System.Drawing.Point(89, 139);
            this.txtTramiteElim.Name = "txtTramiteElim";
            this.txtTramiteElim.Size = new System.Drawing.Size(184, 22);
            this.txtTramiteElim.TabIndex = 2;
            // 
            // txtNomElim
            // 
            this.txtNomElim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNomElim.Location = new System.Drawing.Point(89, 90);
            this.txtNomElim.Name = "txtNomElim";
            this.txtNomElim.Size = new System.Drawing.Size(184, 22);
            this.txtNomElim.TabIndex = 1;
            this.txtNomElim.TextChanged += new System.EventHandler(this.txtNomElim_TextChanged);
            // 
            // txtCodigElim
            // 
            this.txtCodigElim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCodigElim.Location = new System.Drawing.Point(89, 37);
            this.txtCodigElim.Name = "txtCodigElim";
            this.txtCodigElim.Size = new System.Drawing.Size(184, 22);
            this.txtCodigElim.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Listado en una lista y una grilla";
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvTabla.Location = new System.Drawing.Point(427, 268);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(555, 189);
            this.dgvTabla.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 170F;
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 170F;
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 170F;
            this.Column3.HeaderText = "Tramite";
            this.Column3.Name = "Column3";
            this.Column3.Width = 170;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(639, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lstListado
            // 
            this.lstListado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstListado.FormattingEnabled = true;
            this.lstListado.Location = new System.Drawing.Point(12, 294);
            this.lstListado.Name = "lstListado";
            this.lstListado.Size = new System.Drawing.Size(396, 158);
            this.lstListado.TabIndex = 5;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 469);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstListado);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grbElemElim);
            this.Controls.Add(this.grbNvElem);
            this.Name = "frmCola";
            this.Text = "frmCola";
            this.grbNvElem.ResumeLayout(false);
            this.grbNvElem.PerformLayout();
            this.grbElemElim.ResumeLayout(false);
            this.grbElemElim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNvElem;
        private System.Windows.Forms.Label lblTramiteNv;
        private System.Windows.Forms.Label lblNomNv;
        private System.Windows.Forms.Label lblCodigNv;
        private System.Windows.Forms.GroupBox grbElemElim;
        private System.Windows.Forms.TextBox txtTramiteNv;
        private System.Windows.Forms.TextBox txtNomNv;
        private System.Windows.Forms.TextBox txtCodigNv;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramiteElim;
        private System.Windows.Forms.Label lblNomElim;
        private System.Windows.Forms.Label lblCodigElim;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtTramiteElim;
        private System.Windows.Forms.TextBox txtNomElim;
        private System.Windows.Forms.TextBox txtCodigElim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstListado;
    }
}