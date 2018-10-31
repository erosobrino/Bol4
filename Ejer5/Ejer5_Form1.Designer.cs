namespace Ejer5
{
    partial class Ejer5_Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejer5_Form1));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Yellow = new System.Windows.Forms.RadioButton();
            this.Red = new System.Windows.Forms.RadioButton();
            this.Green = new System.Windows.Forms.RadioButton();
            this.cbHabilitar = new System.Windows.Forms.CheckBox();
            this.cbInvertirColores = new System.Windows.Forms.CheckBox();
            this.btnSecundario = new System.Windows.Forms.Button();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.gbFuente = new System.Windows.Forms.GroupBox();
            this.gbColor.SuspendLayout();
            this.gbFuente.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(147, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Times New Roman";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.CheckedChangedFuente);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(211, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Arial";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.CheckedChangedFuente);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(362, 26);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(127, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Comic Sans MS";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.CheckedChangedFuente);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(498, 55);
            this.textBox1.TabIndex = 3;
            // 
            // Yellow
            // 
            this.Yellow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Yellow.AutoSize = true;
            this.Yellow.Location = new System.Drawing.Point(410, 37);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(79, 21);
            this.Yellow.TabIndex = 6;
            this.Yellow.TabStop = true;
            this.Yellow.Text = "Amarillo";
            this.Yellow.UseVisualStyleBackColor = true;
            this.Yellow.CheckedChanged += new System.EventHandler(this.CheckedChangedColor);
            // 
            // Red
            // 
            this.Red.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Red.AutoSize = true;
            this.Red.Location = new System.Drawing.Point(211, 37);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(58, 21);
            this.Red.TabIndex = 5;
            this.Red.TabStop = true;
            this.Red.Text = "Rojo";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.CheckedChanged += new System.EventHandler(this.CheckedChangedColor);
            // 
            // Green
            // 
            this.Green.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Green.AutoSize = true;
            this.Green.Location = new System.Drawing.Point(6, 37);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(67, 21);
            this.Green.TabIndex = 4;
            this.Green.TabStop = true;
            this.Green.Text = "Verde";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.CheckedChanged += new System.EventHandler(this.CheckedChangedColor);
            // 
            // cbHabilitar
            // 
            this.cbHabilitar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbHabilitar.AutoSize = true;
            this.cbHabilitar.Location = new System.Drawing.Point(154, 208);
            this.cbHabilitar.Name = "cbHabilitar";
            this.cbHabilitar.Size = new System.Drawing.Size(82, 21);
            this.cbHabilitar.TabIndex = 7;
            this.cbHabilitar.Text = "Habilitar";
            this.cbHabilitar.UseVisualStyleBackColor = true;
            // 
            // cbInvertirColores
            // 
            this.cbInvertirColores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbInvertirColores.AutoSize = true;
            this.cbInvertirColores.Location = new System.Drawing.Point(285, 208);
            this.cbInvertirColores.Name = "cbInvertirColores";
            this.cbInvertirColores.Size = new System.Drawing.Size(125, 21);
            this.cbInvertirColores.TabIndex = 8;
            this.cbInvertirColores.Text = "Invertir Colores";
            this.cbInvertirColores.UseVisualStyleBackColor = true;
            // 
            // btnSecundario
            // 
            this.btnSecundario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSecundario.Location = new System.Drawing.Point(231, 251);
            this.btnSecundario.Name = "btnSecundario";
            this.btnSecundario.Size = new System.Drawing.Size(82, 40);
            this.btnSecundario.TabIndex = 9;
            this.btnSecundario.Text = "Modal";
            this.btnSecundario.UseVisualStyleBackColor = true;
            this.btnSecundario.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.Green);
            this.gbColor.Controls.Add(this.Red);
            this.gbColor.Controls.Add(this.Yellow);
            this.gbColor.Location = new System.Drawing.Point(21, 136);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(498, 66);
            this.gbColor.TabIndex = 10;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Color";
            // 
            // gbFuente
            // 
            this.gbFuente.Controls.Add(this.radioButton3);
            this.gbFuente.Controls.Add(this.radioButton1);
            this.gbFuente.Controls.Add(this.radioButton2);
            this.gbFuente.Location = new System.Drawing.Point(21, 12);
            this.gbFuente.Name = "gbFuente";
            this.gbFuente.Size = new System.Drawing.Size(498, 57);
            this.gbFuente.TabIndex = 11;
            this.gbFuente.TabStop = false;
            this.gbFuente.Text = "Fuente";
            // 
            // Ejer5_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 312);
            this.Controls.Add(this.gbFuente);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.btnSecundario);
            this.Controls.Add(this.cbInvertirColores);
            this.Controls.Add(this.cbHabilitar);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ejer5_Form1";
            this.Text = "Ejercicio 5";
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            this.gbFuente.ResumeLayout(false);
            this.gbFuente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton Yellow;
        private System.Windows.Forms.RadioButton Red;
        private System.Windows.Forms.RadioButton Green;
        private System.Windows.Forms.CheckBox cbHabilitar;
        private System.Windows.Forms.CheckBox cbInvertirColores;
        private System.Windows.Forms.Button btnSecundario;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.GroupBox gbFuente;
    }
}

