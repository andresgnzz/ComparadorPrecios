namespace ComparadorPrecios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.producto = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            this.pGaia = new System.Windows.Forms.ListBox();
            this.pDico = new System.Windows.Forms.ListBox();
            this.pGarza = new System.Windows.Forms.ListBox();
            this.placencia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.desGaia = new System.Windows.Forms.TextBox();
            this.precioGaia = new System.Windows.Forms.TextBox();
            this.desDico = new System.Windows.Forms.TextBox();
            this.precioDico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.desGarza = new System.Windows.Forms.TextBox();
            this.precioGarza = new System.Windows.Forms.TextBox();
            this.nombreProductos = new System.Windows.Forms.ListBox();
            this.precioProductos = new System.Windows.Forms.ListBox();
            this.COMPARADOR = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.prodMenorPrecio = new System.Windows.Forms.TextBox();
            this.menorPrecio = new System.Windows.Forms.TextBox();
            this.buscarMenor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // producto
            // 
            this.producto.Location = new System.Drawing.Point(671, 22);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(100, 22);
            this.producto.TabIndex = 0;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(671, 66);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(100, 23);
            this.buscar.TabIndex = 1;
            this.buscar.Text = "BUSCAR";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // pGaia
            // 
            this.pGaia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pGaia.FormattingEnabled = true;
            this.pGaia.ItemHeight = 16;
            this.pGaia.Location = new System.Drawing.Point(12, 207);
            this.pGaia.Name = "pGaia";
            this.pGaia.Size = new System.Drawing.Size(249, 144);
            this.pGaia.TabIndex = 2;
            this.pGaia.SelectedIndexChanged += new System.EventHandler(this.pPlacencia_SelectedIndexChanged);
            // 
            // pDico
            // 
            this.pDico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pDico.FormattingEnabled = true;
            this.pDico.ItemHeight = 16;
            this.pDico.Location = new System.Drawing.Point(383, 207);
            this.pDico.Name = "pDico";
            this.pDico.Size = new System.Drawing.Size(249, 144);
            this.pDico.TabIndex = 2;
            this.pDico.SelectedIndexChanged += new System.EventHandler(this.pDico_SelectedIndexChanged);
            // 
            // pGarza
            // 
            this.pGarza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pGarza.FormattingEnabled = true;
            this.pGarza.ItemHeight = 16;
            this.pGarza.Location = new System.Drawing.Point(756, 207);
            this.pGarza.Name = "pGarza";
            this.pGarza.Size = new System.Drawing.Size(249, 144);
            this.pGarza.TabIndex = 2;
            this.pGarza.SelectedIndexChanged += new System.EventHandler(this.pGarza_SelectedIndexChanged);
            // 
            // placencia
            // 
            this.placencia.AutoSize = true;
            this.placencia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.placencia.Location = new System.Drawing.Point(9, 188);
            this.placencia.Name = "placencia";
            this.placencia.Size = new System.Drawing.Size(118, 16);
            this.placencia.TabIndex = 4;
            this.placencia.Text = "MUEBLERIA GAIA";
            this.placencia.Click += new System.EventHandler(this.placencia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(380, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "MUEBLERIA DICO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(753, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "MUEBLERIA GARZA";
            // 
            // desGaia
            // 
            this.desGaia.BackColor = System.Drawing.SystemColors.Window;
            this.desGaia.Location = new System.Drawing.Point(12, 388);
            this.desGaia.Multiline = true;
            this.desGaia.Name = "desGaia";
            this.desGaia.ReadOnly = true;
            this.desGaia.Size = new System.Drawing.Size(249, 356);
            this.desGaia.TabIndex = 5;
            // 
            // precioGaia
            // 
            this.precioGaia.BackColor = System.Drawing.SystemColors.Window;
            this.precioGaia.Location = new System.Drawing.Point(267, 270);
            this.precioGaia.Name = "precioGaia";
            this.precioGaia.ReadOnly = true;
            this.precioGaia.Size = new System.Drawing.Size(96, 22);
            this.precioGaia.TabIndex = 6;
            // 
            // desDico
            // 
            this.desDico.BackColor = System.Drawing.SystemColors.Window;
            this.desDico.Location = new System.Drawing.Point(383, 388);
            this.desDico.Multiline = true;
            this.desDico.Name = "desDico";
            this.desDico.ReadOnly = true;
            this.desDico.Size = new System.Drawing.Size(249, 356);
            this.desDico.TabIndex = 7;
            // 
            // precioDico
            // 
            this.precioDico.BackColor = System.Drawing.SystemColors.Window;
            this.precioDico.Location = new System.Drawing.Point(638, 270);
            this.precioDico.Name = "precioDico";
            this.precioDico.ReadOnly = true;
            this.precioDico.Size = new System.Drawing.Size(96, 22);
            this.precioDico.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Descripcion del Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descripcion del Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(753, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descripcion del Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(638, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1008, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Precio";
            // 
            // desGarza
            // 
            this.desGarza.BackColor = System.Drawing.SystemColors.Window;
            this.desGarza.Location = new System.Drawing.Point(756, 388);
            this.desGarza.Multiline = true;
            this.desGarza.Name = "desGarza";
            this.desGarza.ReadOnly = true;
            this.desGarza.Size = new System.Drawing.Size(249, 356);
            this.desGarza.TabIndex = 11;
            // 
            // precioGarza
            // 
            this.precioGarza.BackColor = System.Drawing.SystemColors.Window;
            this.precioGarza.Location = new System.Drawing.Point(1011, 270);
            this.precioGarza.Name = "precioGarza";
            this.precioGarza.ReadOnly = true;
            this.precioGarza.Size = new System.Drawing.Size(100, 22);
            this.precioGarza.TabIndex = 12;
            // 
            // nombreProductos
            // 
            this.nombreProductos.FormattingEnabled = true;
            this.nombreProductos.ItemHeight = 16;
            this.nombreProductos.Location = new System.Drawing.Point(1143, 207);
            this.nombreProductos.Name = "nombreProductos";
            this.nombreProductos.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.nombreProductos.Size = new System.Drawing.Size(203, 276);
            this.nombreProductos.TabIndex = 13;
            // 
            // precioProductos
            // 
            this.precioProductos.FormattingEnabled = true;
            this.precioProductos.ItemHeight = 16;
            this.precioProductos.Location = new System.Drawing.Point(1384, 207);
            this.precioProductos.Name = "precioProductos";
            this.precioProductos.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.precioProductos.Size = new System.Drawing.Size(203, 276);
            this.precioProductos.TabIndex = 13;
            // 
            // COMPARADOR
            // 
            this.COMPARADOR.AutoSize = true;
            this.COMPARADOR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.COMPARADOR.ForeColor = System.Drawing.SystemColors.InfoText;
            this.COMPARADOR.Location = new System.Drawing.Point(1140, 188);
            this.COMPARADOR.Name = "COMPARADOR";
            this.COMPARADOR.Size = new System.Drawing.Size(188, 16);
            this.COMPARADOR.TabIndex = 14;
            this.COMPARADOR.Text = "COMPARADOR DE PRECIOS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(1140, 560);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "PRODUCTO MAS ECONOMICO";
            // 
            // prodMenorPrecio
            // 
            this.prodMenorPrecio.Location = new System.Drawing.Point(1143, 618);
            this.prodMenorPrecio.Name = "prodMenorPrecio";
            this.prodMenorPrecio.Size = new System.Drawing.Size(203, 22);
            this.prodMenorPrecio.TabIndex = 16;
            // 
            // menorPrecio
            // 
            this.menorPrecio.Location = new System.Drawing.Point(1384, 618);
            this.menorPrecio.Name = "menorPrecio";
            this.menorPrecio.Size = new System.Drawing.Size(203, 22);
            this.menorPrecio.TabIndex = 16;
            // 
            // buscarMenor
            // 
            this.buscarMenor.Location = new System.Drawing.Point(1437, 557);
            this.buscarMenor.Name = "buscarMenor";
            this.buscarMenor.Size = new System.Drawing.Size(97, 23);
            this.buscarMenor.TabIndex = 17;
            this.buscarMenor.Text = "BUSCAR";
            this.buscarMenor.UseVisualStyleBackColor = true;
            this.buscarMenor.Click += new System.EventHandler(this.buscarMenor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1623, 756);
            this.Controls.Add(this.buscarMenor);
            this.Controls.Add(this.menorPrecio);
            this.Controls.Add(this.prodMenorPrecio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.COMPARADOR);
            this.Controls.Add(this.precioProductos);
            this.Controls.Add(this.nombreProductos);
            this.Controls.Add(this.precioGarza);
            this.Controls.Add(this.desGarza);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.precioDico);
            this.Controls.Add(this.desDico);
            this.Controls.Add(this.precioGaia);
            this.Controls.Add(this.desGaia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.placencia);
            this.Controls.Add(this.pGarza);
            this.Controls.Add(this.pDico);
            this.Controls.Add(this.pGaia);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.producto);
            this.Name = "Form1";
            this.Text = "Comparador Precios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox producto;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.ListBox pGaia;
        private System.Windows.Forms.ListBox pDico;
        private System.Windows.Forms.ListBox pGarza;
        private System.Windows.Forms.Label placencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox desGaia;
        private System.Windows.Forms.TextBox precioGaia;
        private System.Windows.Forms.TextBox desDico;
        private System.Windows.Forms.TextBox precioDico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox desGarza;
        private System.Windows.Forms.TextBox precioGarza;
        private System.Windows.Forms.ListBox nombreProductos;
        private System.Windows.Forms.ListBox precioProductos;
        private System.Windows.Forms.Label COMPARADOR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox prodMenorPrecio;
        private System.Windows.Forms.TextBox menorPrecio;
        private System.Windows.Forms.Button buscarMenor;
    }
}

