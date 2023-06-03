namespace Ejercicio3T9
{
    partial class Libros
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
            if(disposing && ( components != null ))
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.primeroButton = new System.Windows.Forms.Button();
            this.anteriorButton = new System.Windows.Forms.Button();
            this.siguienteButton = new System.Windows.Forms.Button();
            this.ultimoButton = new System.Windows.Forms.Button();
            this.anadirButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.registroLabel = new System.Windows.Forms.Label();
            this.actualizarButton = new System.Windows.Forms.Button();
            this.listaGeneralButton = new System.Windows.Forms.Button();
            this.buscarTituloButton = new System.Windows.Forms.Button();
            this.leidoComboBox = new System.Windows.Forms.ComboBox();
            this.formatoComboBox = new System.Windows.Forms.ComboBox();
            this.idiomaComboBox = new System.Windows.Forms.ComboBox();
            this.buscarAutorbutton = new System.Windows.Forms.Button();
            this.guardarbutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Formato:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Idioma:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(443, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Leído:";
            // 
            // autorTextBox
            // 
            this.autorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.autorTextBox.Location = new System.Drawing.Point(143, 155);
            this.autorTextBox.MaxLength = 50;
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(274, 29);
            this.autorTextBox.TabIndex = 2;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tituloTextBox.Location = new System.Drawing.Point(143, 109);
            this.tituloTextBox.MaxLength = 50;
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(581, 29);
            this.tituloTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(12, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Navegar";
            // 
            // primeroButton
            // 
            this.primeroButton.BackColor = System.Drawing.Color.Honeydew;
            this.primeroButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.primeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.primeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primeroButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.primeroButton.Location = new System.Drawing.Point(39, 318);
            this.primeroButton.Name = "primeroButton";
            this.primeroButton.Size = new System.Drawing.Size(155, 49);
            this.primeroButton.TabIndex = 6;
            this.primeroButton.Text = "Primero";
            this.primeroButton.UseVisualStyleBackColor = false;
            this.primeroButton.Click += new System.EventHandler(this.primeroButton_Click);
            // 
            // anteriorButton
            // 
            this.anteriorButton.BackColor = System.Drawing.Color.Honeydew;
            this.anteriorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anteriorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anteriorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anteriorButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.anteriorButton.Location = new System.Drawing.Point(215, 318);
            this.anteriorButton.Name = "anteriorButton";
            this.anteriorButton.Size = new System.Drawing.Size(155, 49);
            this.anteriorButton.TabIndex = 7;
            this.anteriorButton.Text = "Anterior";
            this.anteriorButton.UseVisualStyleBackColor = false;
            this.anteriorButton.Click += new System.EventHandler(this.anteriorButton_Click);
            // 
            // siguienteButton
            // 
            this.siguienteButton.BackColor = System.Drawing.Color.Honeydew;
            this.siguienteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siguienteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siguienteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siguienteButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.siguienteButton.Location = new System.Drawing.Point(388, 318);
            this.siguienteButton.Name = "siguienteButton";
            this.siguienteButton.Size = new System.Drawing.Size(155, 49);
            this.siguienteButton.TabIndex = 8;
            this.siguienteButton.Text = "Siguiente";
            this.siguienteButton.UseVisualStyleBackColor = false;
            this.siguienteButton.Click += new System.EventHandler(this.siguienteButton_Click);
            // 
            // ultimoButton
            // 
            this.ultimoButton.BackColor = System.Drawing.Color.Honeydew;
            this.ultimoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultimoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ultimoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimoButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ultimoButton.Location = new System.Drawing.Point(565, 318);
            this.ultimoButton.Name = "ultimoButton";
            this.ultimoButton.Size = new System.Drawing.Size(155, 49);
            this.ultimoButton.TabIndex = 9;
            this.ultimoButton.Text = "Último";
            this.ultimoButton.UseVisualStyleBackColor = false;
            this.ultimoButton.Click += new System.EventHandler(this.ultimoButton_Click);
            // 
            // anadirButton
            // 
            this.anadirButton.BackColor = System.Drawing.Color.Honeydew;
            this.anadirButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anadirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anadirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anadirButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.anadirButton.Location = new System.Drawing.Point(36, 387);
            this.anadirButton.Name = "anadirButton";
            this.anadirButton.Size = new System.Drawing.Size(158, 40);
            this.anadirButton.TabIndex = 10;
            this.anadirButton.Text = "Añadir";
            this.anadirButton.UseVisualStyleBackColor = false;
            this.anadirButton.Click += new System.EventHandler(this.anadirButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.BackColor = System.Drawing.Color.Honeydew;
            this.eliminarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.eliminarButton.Location = new System.Drawing.Point(585, 387);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(158, 40);
            this.eliminarButton.TabIndex = 13;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = false;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // registroLabel
            // 
            this.registroLabel.AutoSize = true;
            this.registroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroLabel.Location = new System.Drawing.Point(311, 9);
            this.registroLabel.Name = "registroLabel";
            this.registroLabel.Size = new System.Drawing.Size(88, 31);
            this.registroLabel.TabIndex = 19;
            this.registroLabel.Text = "Libros";
            // 
            // actualizarButton
            // 
            this.actualizarButton.BackColor = System.Drawing.Color.Honeydew;
            this.actualizarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actualizarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualizarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizarButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.actualizarButton.Location = new System.Drawing.Point(394, 387);
            this.actualizarButton.Name = "actualizarButton";
            this.actualizarButton.Size = new System.Drawing.Size(158, 40);
            this.actualizarButton.TabIndex = 12;
            this.actualizarButton.Text = "Actualizar";
            this.actualizarButton.UseVisualStyleBackColor = false;
            this.actualizarButton.Click += new System.EventHandler(this.actualizarButton_Click);
            // 
            // listaGeneralButton
            // 
            this.listaGeneralButton.BackColor = System.Drawing.Color.Honeydew;
            this.listaGeneralButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listaGeneralButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listaGeneralButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaGeneralButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listaGeneralButton.Location = new System.Drawing.Point(215, 521);
            this.listaGeneralButton.Name = "listaGeneralButton";
            this.listaGeneralButton.Size = new System.Drawing.Size(337, 46);
            this.listaGeneralButton.TabIndex = 16;
            this.listaGeneralButton.Text = "Ver todos los libros";
            this.listaGeneralButton.UseVisualStyleBackColor = false;
            this.listaGeneralButton.Click += new System.EventHandler(this.listaGeneralButton_Click);
            // 
            // buscarTituloButton
            // 
            this.buscarTituloButton.BackColor = System.Drawing.Color.Honeydew;
            this.buscarTituloButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarTituloButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarTituloButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarTituloButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buscarTituloButton.Location = new System.Drawing.Point(165, 445);
            this.buscarTituloButton.Name = "buscarTituloButton";
            this.buscarTituloButton.Size = new System.Drawing.Size(211, 48);
            this.buscarTituloButton.TabIndex = 14;
            this.buscarTituloButton.Text = "Buscar por titulo";
            this.buscarTituloButton.UseVisualStyleBackColor = false;
            this.buscarTituloButton.Click += new System.EventHandler(this.buscarTituloButton_Click);
            // 
            // leidoComboBox
            // 
            this.leidoComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leidoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leidoComboBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.leidoComboBox.FormattingEnabled = true;
            this.leidoComboBox.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.leidoComboBox.Location = new System.Drawing.Point(530, 235);
            this.leidoComboBox.MaxDropDownItems = 2;
            this.leidoComboBox.MaxLength = 2;
            this.leidoComboBox.Name = "leidoComboBox";
            this.leidoComboBox.Size = new System.Drawing.Size(121, 32);
            this.leidoComboBox.TabIndex = 5;
            // 
            // formatoComboBox
            // 
            this.formatoComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.formatoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatoComboBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.formatoComboBox.Items.AddRange(new object[] {
            "Físico",
            "Digital"});
            this.formatoComboBox.Location = new System.Drawing.Point(152, 206);
            this.formatoComboBox.MaxDropDownItems = 2;
            this.formatoComboBox.MaxLength = 7;
            this.formatoComboBox.Name = "formatoComboBox";
            this.formatoComboBox.Size = new System.Drawing.Size(177, 32);
            this.formatoComboBox.TabIndex = 3;
            // 
            // idiomaComboBox
            // 
            this.idiomaComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idiomaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idiomaComboBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.idiomaComboBox.FormattingEnabled = true;
            this.idiomaComboBox.ItemHeight = 24;
            this.idiomaComboBox.Items.AddRange(new object[] {
            "Castellano",
            "Inglés"});
            this.idiomaComboBox.Location = new System.Drawing.Point(152, 259);
            this.idiomaComboBox.MaxDropDownItems = 2;
            this.idiomaComboBox.MaxLength = 10;
            this.idiomaComboBox.Name = "idiomaComboBox";
            this.idiomaComboBox.Size = new System.Drawing.Size(177, 32);
            this.idiomaComboBox.TabIndex = 4;
            // 
            // buscarAutorbutton
            // 
            this.buscarAutorbutton.BackColor = System.Drawing.Color.Honeydew;
            this.buscarAutorbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarAutorbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarAutorbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarAutorbutton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buscarAutorbutton.Location = new System.Drawing.Point(439, 448);
            this.buscarAutorbutton.Name = "buscarAutorbutton";
            this.buscarAutorbutton.Size = new System.Drawing.Size(195, 45);
            this.buscarAutorbutton.TabIndex = 15;
            this.buscarAutorbutton.Text = "Buscar por autor";
            this.buscarAutorbutton.UseVisualStyleBackColor = false;
            this.buscarAutorbutton.Click += new System.EventHandler(this.buscarAutorButton_Click);
            // 
            // guardarbutton
            // 
            this.guardarbutton.BackColor = System.Drawing.Color.Honeydew;
            this.guardarbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarbutton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.guardarbutton.Location = new System.Drawing.Point(215, 387);
            this.guardarbutton.Name = "guardarbutton";
            this.guardarbutton.Size = new System.Drawing.Size(155, 40);
            this.guardarbutton.TabIndex = 11;
            this.guardarbutton.Text = "Guardar";
            this.guardarbutton.UseVisualStyleBackColor = false;
            this.guardarbutton.Click += new System.EventHandler(this.guardarbutton_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Identificador:";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(143, 63);
            this.idTextBox.MaxLength = 10;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(196, 29);
            this.idTextBox.TabIndex = 0;
            // 
            // Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(778, 575);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guardarbutton);
            this.Controls.Add(this.buscarAutorbutton);
            this.Controls.Add(this.idiomaComboBox);
            this.Controls.Add(this.formatoComboBox);
            this.Controls.Add(this.leidoComboBox);
            this.Controls.Add(this.buscarTituloButton);
            this.Controls.Add(this.listaGeneralButton);
            this.Controls.Add(this.actualizarButton);
            this.Controls.Add(this.registroLabel);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.anadirButton);
            this.Controls.Add(this.ultimoButton);
            this.Controls.Add(this.siguienteButton);
            this.Controls.Add(this.anteriorButton);
            this.Controls.Add(this.primeroButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(this.autorTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Libros";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button primeroButton;
        private System.Windows.Forms.Button anteriorButton;
        private System.Windows.Forms.Button siguienteButton;
        private System.Windows.Forms.Button ultimoButton;
        private System.Windows.Forms.Button anadirButton;
        //private System.Windows.Forms.Button guardarNuevoButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Label registroLabel;
        private System.Windows.Forms.Button actualizarButton;
        private System.Windows.Forms.Button listaGeneralButton;
        private System.Windows.Forms.Button buscarTituloButton;
        private System.Windows.Forms.ComboBox leidoComboBox;
        private System.Windows.Forms.ComboBox formatoComboBox;
        private System.Windows.Forms.ComboBox idiomaComboBox;
        private System.Windows.Forms.Button buscarAutorbutton;
        private System.Windows.Forms.Button guardarbutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idTextBox;
        //private System.Windows.Forms.Button guardarNuevoButton;
    }
}

