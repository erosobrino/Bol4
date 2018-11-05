namespace Ejer5
{
    partial class Informacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informacion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbInicio = new System.Windows.Forms.TextBox();
            this.tbLongitud = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio de seleccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longitud de seleccion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Forzar Seleccion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbInicio
            // 
            this.tbInicio.Location = new System.Drawing.Point(212, 24);
            this.tbInicio.Name = "tbInicio";
            this.tbInicio.Size = new System.Drawing.Size(100, 22);
            this.tbInicio.TabIndex = 3;
            // 
            // tbLongitud
            // 
            this.tbLongitud.Location = new System.Drawing.Point(212, 75);
            this.tbLongitud.Name = "tbLongitud";
            this.tbLongitud.Size = new System.Drawing.Size(100, 22);
            this.tbLongitud.TabIndex = 4;
            // 
            // Informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 176);
            this.Controls.Add(this.tbLongitud);
            this.Controls.Add(this.tbInicio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Informacion";
            this.Text = "Informacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Informacion_FormClosing);
            this.Load += new System.EventHandler(this.Informacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbInicio;
        private System.Windows.Forms.TextBox tbLongitud;
    }
}