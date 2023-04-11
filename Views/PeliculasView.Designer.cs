namespace CineHunter.Views
{
    partial class PeliculasView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Aceptarbtn = new System.Windows.Forms.Button();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.Cancelarbtn = new System.Windows.Forms.Button();
            this.CbGenero = new System.Windows.Forms.ComboBox();
            this.dtpFechaExtreno = new System.Windows.Forms.DateTimePicker();
            this.dtpAnio = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.BtnCargarImagen = new System.Windows.Forms.Button();
            this.CbActores = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Años";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha_Estreno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Actores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Genero";
            // 
            // Aceptarbtn
            // 
            this.Aceptarbtn.Location = new System.Drawing.Point(18, 436);
            this.Aceptarbtn.Name = "Aceptarbtn";
            this.Aceptarbtn.Size = new System.Drawing.Size(94, 29);
            this.Aceptarbtn.TabIndex = 6;
            this.Aceptarbtn.Text = "Aceptar";
            this.Aceptarbtn.UseVisualStyleBackColor = true;
            this.Aceptarbtn.Click += new System.EventHandler(this.Aceptarbtn_Click);
            // 
            // txbTitulo
            // 
            this.txbTitulo.Location = new System.Drawing.Point(44, 34);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(474, 20);
            this.txbTitulo.TabIndex = 7;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(29, 232);
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(676, 135);
            this.txbDescripcion.TabIndex = 8;
            // 
            // Cancelarbtn
            // 
            this.Cancelarbtn.Location = new System.Drawing.Point(145, 436);
            this.Cancelarbtn.Name = "Cancelarbtn";
            this.Cancelarbtn.Size = new System.Drawing.Size(81, 29);
            this.Cancelarbtn.TabIndex = 13;
            this.Cancelarbtn.Text = "Cancelar";
            this.Cancelarbtn.UseVisualStyleBackColor = true;
            // 
            // CbGenero
            // 
            this.CbGenero.FormattingEnabled = true;
            this.CbGenero.Location = new System.Drawing.Point(624, 28);
            this.CbGenero.Name = "CbGenero";
            this.CbGenero.Size = new System.Drawing.Size(187, 21);
            this.CbGenero.TabIndex = 11;
            // 
            // dtpFechaExtreno
            // 
            this.dtpFechaExtreno.Location = new System.Drawing.Point(111, 155);
            this.dtpFechaExtreno.Name = "dtpFechaExtreno";
            this.dtpFechaExtreno.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaExtreno.TabIndex = 10;
            // 
            // dtpAnio
            // 
            this.dtpAnio.Location = new System.Drawing.Point(533, 99);
            this.dtpAnio.Name = "dtpAnio";
            this.dtpAnio.Size = new System.Drawing.Size(200, 20);
            this.dtpAnio.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbActores);
            this.groupBox1.Controls.Add(this.BtnCargarImagen);
            this.groupBox1.Controls.Add(this.pbFoto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Aceptarbtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cancelarbtn);
            this.groupBox1.Controls.Add(this.CbGenero);
            this.groupBox1.Controls.Add(this.dtpAnio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFechaExtreno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbTitulo);
            this.groupBox1.Controls.Add(this.txbDescripcion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1227, 529);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(840, 19);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(362, 423);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 14;
            this.pbFoto.TabStop = false;
            // 
            // BtnCargarImagen
            // 
            this.BtnCargarImagen.Location = new System.Drawing.Point(858, 460);
            this.BtnCargarImagen.Name = "BtnCargarImagen";
            this.BtnCargarImagen.Size = new System.Drawing.Size(147, 43);
            this.BtnCargarImagen.TabIndex = 15;
            this.BtnCargarImagen.Text = "Cargar Imagen";
            this.BtnCargarImagen.UseVisualStyleBackColor = true;
            this.BtnCargarImagen.Click += new System.EventHandler(this.BtnCargarImagen_Click);
            // 
            // CbActores
            // 
            this.CbActores.FormattingEnabled = true;
            this.CbActores.Location = new System.Drawing.Point(64, 99);
            this.CbActores.Name = "CbActores";
            this.CbActores.Size = new System.Drawing.Size(404, 21);
            this.CbActores.TabIndex = 16;
            // 
            // PeliculasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 559);
            this.Controls.Add(this.groupBox1);
            this.Name = "PeliculasView";
            this.Text = "Peliculas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Aceptarbtn;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.ComboBox CbGenero;
        private System.Windows.Forms.DateTimePicker dtpFechaExtreno;
        private System.Windows.Forms.DateTimePicker dtpAnio;
        private System.Windows.Forms.Button Cancelarbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCargarImagen;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.ComboBox CbActores;
    }
}