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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Resultadolabel = new System.Windows.Forms.Label();
            this.todosButton = new System.Windows.Forms.Button();
            this.castellanoButton = new System.Windows.Forms.Button();
            this.inglesButton = new System.Windows.Forms.Button();
            this.siButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.fisicoButton = new System.Windows.Forms.Button();
            this.digitalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista Libros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Idioma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(504, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Leido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(689, 41);
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
            // 
            // todosButton
            // 
            this.todosButton.BackColor = System.Drawing.Color.Honeydew;
            this.todosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.todosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todosButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.todosButton.Location = new System.Drawing.Point(45, 43);
            this.todosButton.Name = "todosButton";
            this.todosButton.Size = new System.Drawing.Size(167, 59);
            this.todosButton.TabIndex = 7;
            this.todosButton.Text = "Todos";
            this.todosButton.UseVisualStyleBackColor = false;
            this.todosButton.Click += new System.EventHandler(this.todosButton_Click);
            // 
            // castellanoButton
            // 
            this.castellanoButton.BackColor = System.Drawing.Color.Honeydew;
            this.castellanoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.castellanoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.castellanoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castellanoButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.castellanoButton.Location = new System.Drawing.Point(237, 68);
            this.castellanoButton.Name = "castellanoButton";
            this.castellanoButton.Size = new System.Drawing.Size(107, 34);
            this.castellanoButton.TabIndex = 8;
            this.castellanoButton.Text = "Castellano";
            this.castellanoButton.UseVisualStyleBackColor = false;
            this.castellanoButton.Click += new System.EventHandler(this.castellanoButton_Click);
            // 
            // inglesButton
            // 
            this.inglesButton.BackColor = System.Drawing.Color.Honeydew;
            this.inglesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inglesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inglesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inglesButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.inglesButton.Location = new System.Drawing.Point(350, 70);
            this.inglesButton.Name = "inglesButton";
            this.inglesButton.Size = new System.Drawing.Size(74, 34);
            this.inglesButton.TabIndex = 9;
            this.inglesButton.Text = "Inglés";
            this.inglesButton.UseVisualStyleBackColor = false;
            this.inglesButton.Click += new System.EventHandler(this.inglesButton_Click);
            // 
            // siButton
            // 
            this.siButton.BackColor = System.Drawing.Color.Honeydew;
            this.siButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.siButton.Location = new System.Drawing.Point(444, 70);
            this.siButton.Name = "siButton";
            this.siButton.Size = new System.Drawing.Size(74, 34);
            this.siButton.TabIndex = 10;
            this.siButton.Text = "Sí";
            this.siButton.UseVisualStyleBackColor = false;
            this.siButton.Click += new System.EventHandler(this.siButton_Click);
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.Color.Honeydew;
            this.noButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.noButton.Location = new System.Drawing.Point(547, 68);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(74, 34);
            this.noButton.TabIndex = 11;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // fisicoButton
            // 
            this.fisicoButton.BackColor = System.Drawing.Color.Honeydew;
            this.fisicoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fisicoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fisicoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fisicoButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.fisicoButton.Location = new System.Drawing.Point(639, 68);
            this.fisicoButton.Name = "fisicoButton";
            this.fisicoButton.Size = new System.Drawing.Size(74, 34);
            this.fisicoButton.TabIndex = 12;
            this.fisicoButton.Text = "Físico";
            this.fisicoButton.UseVisualStyleBackColor = false;
            this.fisicoButton.Click += new System.EventHandler(this.fisicoButton_Click);
            // 
            // digitalButton
            // 
            this.digitalButton.BackColor = System.Drawing.Color.Honeydew;
            this.digitalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.digitalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digitalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitalButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.digitalButton.Location = new System.Drawing.Point(733, 68);
            this.digitalButton.Name = "digitalButton";
            this.digitalButton.Size = new System.Drawing.Size(74, 34);
            this.digitalButton.TabIndex = 13;
            this.digitalButton.Text = "Digital";
            this.digitalButton.UseVisualStyleBackColor = false;
            this.digitalButton.Click += new System.EventHandler(this.digitalButton_Click);
            // 
            // formularioLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(902, 577);
            this.Controls.Add(this.digitalButton);
            this.Controls.Add(this.fisicoButton);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.siButton);
            this.Controls.Add(this.inglesButton);
            this.Controls.Add(this.castellanoButton);
            this.Controls.Add(this.todosButton);
            this.Controls.Add(this.Resultadolabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Name = "formularioLista";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.formularioLista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Resultadolabel;
        private System.Windows.Forms.Button todosButton;
        private System.Windows.Forms.Button castellanoButton;
        private System.Windows.Forms.Button inglesButton;
        private System.Windows.Forms.Button siButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button fisicoButton;
        private System.Windows.Forms.Button digitalButton;
    }
}