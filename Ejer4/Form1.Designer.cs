namespace Ejer4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.lbIcono = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.rbSuma = new System.Windows.Forms.RadioButton();
            this.rbResta = new System.Windows.Forms.RadioButton();
            this.rbMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rbDivision = new System.Windows.Forms.RadioButton();
            this.lbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(146, 63);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(100, 22);
            this.tbNum1.TabIndex = 0;
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(274, 63);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(100, 22);
            this.tbNum2.TabIndex = 2;
            // 
            // lbIcono
            // 
            this.lbIcono.AutoSize = true;
            this.lbIcono.Location = new System.Drawing.Point(252, 66);
            this.lbIcono.Name = "lbIcono";
            this.lbIcono.Size = new System.Drawing.Size(16, 17);
            this.lbIcono.TabIndex = 1;
            this.lbIcono.Text = "+";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(396, 68);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(0, 17);
            this.lbResultado.TabIndex = 3;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(367, 121);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(99, 55);
            this.btCalcular.TabIndex = 8;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // rbSuma
            // 
            this.rbSuma.AutoSize = true;
            this.rbSuma.Location = new System.Drawing.Point(146, 121);
            this.rbSuma.Name = "rbSuma";
            this.rbSuma.Size = new System.Drawing.Size(65, 21);
            this.rbSuma.TabIndex = 4;
            this.rbSuma.TabStop = true;
            this.rbSuma.Tag = "+";
            this.rbSuma.Text = "Suma";
            this.rbSuma.UseVisualStyleBackColor = true;
            this.rbSuma.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbResta
            // 
            this.rbResta.AutoSize = true;
            this.rbResta.Location = new System.Drawing.Point(269, 121);
            this.rbResta.Name = "rbResta";
            this.rbResta.Size = new System.Drawing.Size(66, 21);
            this.rbResta.TabIndex = 5;
            this.rbResta.TabStop = true;
            this.rbResta.Tag = "-";
            this.rbResta.Text = "Resta";
            this.rbResta.UseVisualStyleBackColor = true;
            this.rbResta.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbMultiplicacion
            // 
            this.rbMultiplicacion.AutoSize = true;
            this.rbMultiplicacion.Location = new System.Drawing.Point(146, 171);
            this.rbMultiplicacion.Name = "rbMultiplicacion";
            this.rbMultiplicacion.Size = new System.Drawing.Size(113, 21);
            this.rbMultiplicacion.TabIndex = 6;
            this.rbMultiplicacion.TabStop = true;
            this.rbMultiplicacion.Tag = "*";
            this.rbMultiplicacion.Text = "Multiplicacion";
            this.rbMultiplicacion.UseVisualStyleBackColor = true;
            this.rbMultiplicacion.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rbDivision
            // 
            this.rbDivision.AutoSize = true;
            this.rbDivision.Location = new System.Drawing.Point(269, 171);
            this.rbDivision.Name = "rbDivision";
            this.rbDivision.Size = new System.Drawing.Size(78, 21);
            this.rbDivision.TabIndex = 7;
            this.rbDivision.TabStop = true;
            this.rbDivision.Tag = "/";
            this.rbDivision.Text = "Division";
            this.rbDivision.UseVisualStyleBackColor = true;
            this.rbDivision.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(200, 221);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 17);
            this.lbError.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.rbDivision);
            this.Controls.Add(this.rbMultiplicacion);
            this.Controls.Add(this.rbResta);
            this.Controls.Add(this.rbSuma);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbIcono);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbNum1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.Label lbIcono;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.RadioButton rbSuma;
        private System.Windows.Forms.RadioButton rbResta;
        private System.Windows.Forms.RadioButton rbMultiplicacion;
        private System.Windows.Forms.RadioButton rbDivision;
        private System.Windows.Forms.Label lbError;
    }
}

