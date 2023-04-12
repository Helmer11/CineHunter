namespace CineHunter
{
    partial class PrincipalView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.peliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AgregarPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarPelicula = new System.Windows.Forms.ToolStripMenuItem();
            this.actoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CrearActores = new System.Windows.Forms.ToolStripMenuItem();
            this.DetalleActore = new System.Windows.Forms.ToolStripMenuItem();
            this.generosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CrearGenero = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peliculasToolStripMenuItem,
            this.actoresToolStripMenuItem,
            this.generosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // peliculasToolStripMenuItem
            // 
            this.peliculasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregarPelicula,
            this.EliminarPelicula});
            this.peliculasToolStripMenuItem.Name = "peliculasToolStripMenuItem";
            this.peliculasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.peliculasToolStripMenuItem.Text = "Peliculas";
            // 
            // AgregarPelicula
            // 
            this.AgregarPelicula.Name = "AgregarPelicula";
            this.AgregarPelicula.Size = new System.Drawing.Size(116, 22);
            this.AgregarPelicula.Text = "Agregar";
            this.AgregarPelicula.Click += new System.EventHandler(this.AgregarPelicula_Click);
            // 
            // EliminarPelicula
            // 
            this.EliminarPelicula.Name = "EliminarPelicula";
            this.EliminarPelicula.Size = new System.Drawing.Size(116, 22);
            this.EliminarPelicula.Text = "Detalle";
            this.EliminarPelicula.Click += new System.EventHandler(this.EliminarPelicula_Click);
            // 
            // actoresToolStripMenuItem
            // 
            this.actoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrearActores,
            this.DetalleActore});
            this.actoresToolStripMenuItem.Name = "actoresToolStripMenuItem";
            this.actoresToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actoresToolStripMenuItem.Text = "Actores";
            // 
            // CrearActores
            // 
            this.CrearActores.Name = "CrearActores";
            this.CrearActores.Size = new System.Drawing.Size(110, 22);
            this.CrearActores.Text = "Crear";
            this.CrearActores.Click += new System.EventHandler(this.CrearActores_Click);
            // 
            // DetalleActore
            // 
            this.DetalleActore.Name = "DetalleActore";
            this.DetalleActore.Size = new System.Drawing.Size(110, 22);
            this.DetalleActore.Text = "Detalle";
            this.DetalleActore.Click += new System.EventHandler(this.DetalleActore_Click);
            // 
            // generosToolStripMenuItem
            // 
            this.generosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrearGenero});
            this.generosToolStripMenuItem.Name = "generosToolStripMenuItem";
            this.generosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.generosToolStripMenuItem.Text = "Generos";
            // 
            // CrearGenero
            // 
            this.CrearGenero.Name = "CrearGenero";
            this.CrearGenero.Size = new System.Drawing.Size(180, 22);
            this.CrearGenero.Text = "Crear";
            this.CrearGenero.Click += new System.EventHandler(this.CrearGenero_Click);
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Location = new System.Drawing.Point(19, 174);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.Size = new System.Drawing.Size(714, 177);
            this.dgvPeliculas.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txbBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvPeliculas);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 386);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventana Principal";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(425, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(121, 30);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(289, 20);
            this.txbBuscar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar";
            // 
            // PrincipalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalView";
            this.Text = "Ventana Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peliculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AgregarPelicula;
        private System.Windows.Forms.ToolStripMenuItem EliminarPelicula;
        private System.Windows.Forms.ToolStripMenuItem actoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CrearGenero;
        private System.Windows.Forms.ToolStripMenuItem CrearActores;
        private System.Windows.Forms.ToolStripMenuItem DetalleActore;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.Label label1;
    }
}

