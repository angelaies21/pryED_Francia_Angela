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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvTabladedatos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCodigos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnElim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LstDeDatos = new System.Windows.Forms.ListBox();
            this.grbElem.SuspendLayout();
            this.grbNvElem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaPila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabladedatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 176);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // dgvTabladedatos
            // 
            this.dgvTabladedatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabladedatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvTabladedatos.Location = new System.Drawing.Point(296, 264);
            this.dgvTabladedatos.Name = "dgvTabladedatos";
            this.dgvTabladedatos.Size = new System.Drawing.Size(526, 187);
            this.dgvTabladedatos.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 160F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 160;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 160F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 160;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 160F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Tramite";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 160;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCodigos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnElim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(550, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 218);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elemento a eliminar";
            // 
            // cmbCodigos
            // 
            this.cmbCodigos.FormattingEnabled = true;
            this.cmbCodigos.Location = new System.Drawing.Point(96, 92);
            this.cmbCodigos.Name = "cmbCodigos";
            this.cmbCodigos.Size = new System.Drawing.Size(175, 24);
            this.cmbCodigos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código";
            // 
            // btnElim
            // 
            this.btnElim.BackColor = System.Drawing.Color.Bisque;
            this.btnElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElim.Location = new System.Drawing.Point(6, 171);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(271, 32);
            this.btnElim.TabIndex = 3;
            this.btnElim.Text = "🗑️​Eliminar";
            this.btnElim.UseVisualStyleBackColor = false;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTramite);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtCode);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(257, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 218);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTramite.Location = new System.Drawing.Point(105, 137);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(176, 22);
            this.txtTramite.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtName.Location = new System.Drawing.Point(107, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCode.Location = new System.Drawing.Point(107, 43);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(176, 22);
            this.txtCode.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Bisque;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(6, 171);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(281, 32);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "➡️​Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tramite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código";
            // 
            // LstDeDatos
            // 
            this.LstDeDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LstDeDatos.FormattingEnabled = true;
            this.LstDeDatos.Location = new System.Drawing.Point(11, 264);
            this.LstDeDatos.Name = "LstDeDatos";
            this.LstDeDatos.Size = new System.Drawing.Size(267, 184);
            this.LstDeDatos.TabIndex = 12;
            // 
            // frmDobleEnlanzada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 462);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvTabladedatos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LstDeDatos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvTablaPila);
            this.Controls.Add(this.grbElem);
            this.Controls.Add(this.grbNvElem);
            this.Controls.Add(this.lstPila);
            this.Name = "frmDobleEnlanzada";
            this.Text = "frmDobleEnlanzada";
            this.Load += new System.EventHandler(this.frmDobleEnlanzada_Load);
            this.grbElem.ResumeLayout(false);
            this.grbElem.PerformLayout();
            this.grbNvElem.ResumeLayout(false);
            this.grbNvElem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaPila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabladedatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvTabladedatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LstDeDatos;
        private System.Windows.Forms.ComboBox cmbCodigos;
    }
}