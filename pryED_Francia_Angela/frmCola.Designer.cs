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
            this.grbNvElem = new System.Windows.Forms.GroupBox();
            this.grbElemElim = new System.Windows.Forms.GroupBox();
            this.lblCodigNv = new System.Windows.Forms.Label();
            this.lblNomNv = new System.Windows.Forms.Label();
            this.lblTramiteNv = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCodigNv = new System.Windows.Forms.TextBox();
            this.txtNomNv = new System.Windows.Forms.TextBox();
            this.txtTramiteNv = new System.Windows.Forms.TextBox();
            this.txtCodigElim = new System.Windows.Forms.TextBox();
            this.txtNomElim = new System.Windows.Forms.TextBox();
            this.txtTramiteElim = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigElim = new System.Windows.Forms.Label();
            this.lblNomElim = new System.Windows.Forms.Label();
            this.lblTramiteElim = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.lstListayGrilla = new System.Windows.Forms.ListBox();
            this.grbNvElem.SuspendLayout();
            this.grbElemElim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
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
            this.grbNvElem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNvElem.Location = new System.Drawing.Point(12, 20);
            this.grbNvElem.Name = "grbNvElem";
            this.grbNvElem.Size = new System.Drawing.Size(347, 218);
            this.grbNvElem.TabIndex = 0;
            this.grbNvElem.TabStop = false;
            this.grbNvElem.Text = "Nuevo elemento";
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
            this.grbElemElim.Location = new System.Drawing.Point(384, 20);
            this.grbElemElim.Name = "grbElemElim";
            this.grbElemElim.Size = new System.Drawing.Size(357, 218);
            this.grbElemElim.TabIndex = 1;
            this.grbElemElim.TabStop = false;
            this.grbElemElim.Text = "Elemento a eliminar";
            // 
            // lblCodigNv
            // 
            this.lblCodigNv.AutoSize = true;
            this.lblCodigNv.Location = new System.Drawing.Point(15, 37);
            this.lblCodigNv.Name = "lblCodigNv";
            this.lblCodigNv.Size = new System.Drawing.Size(46, 15);
            this.lblCodigNv.TabIndex = 0;
            this.lblCodigNv.Text = "Código";
            // 
            // lblNomNv
            // 
            this.lblNomNv.AutoSize = true;
            this.lblNomNv.Location = new System.Drawing.Point(15, 88);
            this.lblNomNv.Name = "lblNomNv";
            this.lblNomNv.Size = new System.Drawing.Size(52, 15);
            this.lblNomNv.TabIndex = 1;
            this.lblNomNv.Text = "Nombre";
            // 
            // lblTramiteNv
            // 
            this.lblTramiteNv.AutoSize = true;
            this.lblTramiteNv.Location = new System.Drawing.Point(15, 143);
            this.lblTramiteNv.Name = "lblTramiteNv";
            this.lblTramiteNv.Size = new System.Drawing.Size(49, 15);
            this.lblTramiteNv.TabIndex = 2;
            this.lblTramiteNv.Text = "Tramite";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(238, 185);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtCodigNv
            // 
            this.txtCodigNv.Location = new System.Drawing.Point(107, 34);
            this.txtCodigNv.Name = "txtCodigNv";
            this.txtCodigNv.Size = new System.Drawing.Size(223, 21);
            this.txtCodigNv.TabIndex = 4;
            // 
            // txtNomNv
            // 
            this.txtNomNv.Location = new System.Drawing.Point(107, 88);
            this.txtNomNv.Name = "txtNomNv";
            this.txtNomNv.Size = new System.Drawing.Size(223, 21);
            this.txtNomNv.TabIndex = 5;
            // 
            // txtTramiteNv
            // 
            this.txtTramiteNv.Location = new System.Drawing.Point(107, 143);
            this.txtTramiteNv.Name = "txtTramiteNv";
            this.txtTramiteNv.Size = new System.Drawing.Size(223, 21);
            this.txtTramiteNv.TabIndex = 6;
            // 
            // txtCodigElim
            // 
            this.txtCodigElim.Location = new System.Drawing.Point(129, 37);
            this.txtCodigElim.Name = "txtCodigElim";
            this.txtCodigElim.Size = new System.Drawing.Size(200, 20);
            this.txtCodigElim.TabIndex = 0;
            // 
            // txtNomElim
            // 
            this.txtNomElim.Location = new System.Drawing.Point(129, 88);
            this.txtNomElim.Name = "txtNomElim";
            this.txtNomElim.Size = new System.Drawing.Size(200, 20);
            this.txtNomElim.TabIndex = 1;
            // 
            // txtTramiteElim
            // 
            this.txtTramiteElim.Location = new System.Drawing.Point(129, 143);
            this.txtTramiteElim.Name = "txtTramiteElim";
            this.txtTramiteElim.Size = new System.Drawing.Size(200, 20);
            this.txtTramiteElim.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(244, 185);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 21);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblCodigElim
            // 
            this.lblCodigElim.AutoSize = true;
            this.lblCodigElim.Location = new System.Drawing.Point(25, 37);
            this.lblCodigElim.Name = "lblCodigElim";
            this.lblCodigElim.Size = new System.Drawing.Size(40, 13);
            this.lblCodigElim.TabIndex = 4;
            this.lblCodigElim.Text = "Código";
            // 
            // lblNomElim
            // 
            this.lblNomElim.AutoSize = true;
            this.lblNomElim.Location = new System.Drawing.Point(25, 88);
            this.lblNomElim.Name = "lblNomElim";
            this.lblNomElim.Size = new System.Drawing.Size(44, 13);
            this.lblNomElim.TabIndex = 5;
            this.lblNomElim.Text = "Nombre";
            // 
            // lblTramiteElim
            // 
            this.lblTramiteElim.AutoSize = true;
            this.lblTramiteElim.Location = new System.Drawing.Point(25, 143);
            this.lblTramiteElim.Name = "lblTramiteElim";
            this.lblTramiteElim.Size = new System.Drawing.Size(38, 13);
            this.lblTramiteElim.TabIndex = 6;
            this.lblTramiteElim.Text = "tramite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Listado en una lista y una grilla";
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(341, 281);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(372, 122);
            this.dgvTabla.TabIndex = 4;
            // 
            // lstListayGrilla
            // 
            this.lstListayGrilla.FormattingEnabled = true;
            this.lstListayGrilla.Location = new System.Drawing.Point(12, 304);
            this.lstListayGrilla.Name = "lstListayGrilla";
            this.lstListayGrilla.Size = new System.Drawing.Size(265, 108);
            this.lstListayGrilla.TabIndex = 5;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 424);
            this.Controls.Add(this.lstListayGrilla);
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
        private System.Windows.Forms.ListBox lstListayGrilla;
    }
}