namespace Ejercicio1T9
{
    partial class formularioLista
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
            if(disposing && ( components != null ))
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
            this.ordenarComboBox = new System.Windows.Forms.ComboBox();
            this.idiomacomboBox = new System.Windows.Forms.ComboBox();
            this.leidoComboBox = new System.Windows.Forms.ComboBox();
            this.formatoComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Resultadolabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista Libros";
            // 
            // ordenarComboBox
            // 
            this.ordenarComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenarComboBox.FormattingEnabled = true;
            this.ordenarComboBox.Items.AddRange(new object[] {
            "A-Z",
            "Z-A"});
            this.ordenarComboBox.Location = new System.Drawing.Point(59, 71);
            this.ordenarComboBox.Name = "ordenarComboBox";
            this.ordenarComboBox.Size = new System.Drawing.Size(121, 32);
            this.ordenarComboBox.TabIndex = 1;
            // 
            // idiomacomboBox
            // 
            this.idiomacomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idiomacomboBox.FormattingEnabled = true;
            this.idiomacomboBox.Items.AddRange(new object[] {
            "Todos",
            "Castellano",
            "Inglés"});
            this.idiomacomboBox.Location = new System.Drawing.Point(222, 71);
            this.idiomacomboBox.Name = "idiomacomboBox";
            this.idiomacomboBox.Size = new System.Drawing.Size(121, 32);
            this.idiomacomboBox.TabIndex = 2;
            // 
            // leidoComboBox
            // 
            this.leidoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leidoComboBox.FormattingEnabled = true;
            this.leidoComboBox.Items.AddRange(new object[] {
            "Todos",
            "Sí",
            "No"});
            this.leidoComboBox.Location = new System.Drawing.Point(419, 71);
            this.leidoComboBox.Name = "leidoComboBox";
            this.leidoComboBox.Size = new System.Drawing.Size(121, 32);
            this.leidoComboBox.TabIndex = 3;
            // 
            // formatoComboBox
            // 
            this.formatoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatoComboBox.FormattingEnabled = true;
            this.formatoComboBox.Items.AddRange(new object[] {
            "Todos",
            "Fisico ",
            "Digital"});
            this.formatoComboBox.Location = new System.Drawing.Point(601, 71);
            this.formatoComboBox.Name = "formatoComboBox";
            this.formatoComboBox.Size = new System.Drawing.Size(121, 32);
            this.formatoComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ordenar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Idioma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(415, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Leido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(597, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Formato";
            // 
            // Resultadolabel
            // 
            this.Resultadolabel.AutoSize = true;
            this.Resultadolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultadolabel.Location = new System.Drawing.Point(67, 137);
            this.Resultadolabel.Name = "Resultadolabel";
            this.Resultadolabel.Size = new System.Drawing.Size(94, 24);
            this.Resultadolabel.TabIndex = 6;
            this.Resultadolabel.Text = "Resultado";
            this.Resultadolabel.Click += new System.EventHandler(this.Resultadolabel_Click);
            // 
            // formularioLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resultadolabel);
            this.Controls.Add(this.formatoComboBox);
            this.Controls.Add(this.leidoComboBox);
            this.Controls.Add(this.idiomacomboBox);
            this.Controls.Add(this.ordenarComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formularioLista";
            this.Text = "Lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ordenarComboBox;
        private System.Windows.Forms.ComboBox idiomacomboBox;
        private System.Windows.Forms.ComboBox leidoComboBox;
        private System.Windows.Forms.ComboBox formatoComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Resultadolabel;
    }
}