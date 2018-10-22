namespace Bol4
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
            this.btSalir = new System.Windows.Forms.Button();
            this.btColor = new System.Windows.Forms.Button();
            this.tbR = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbImagen = new System.Windows.Forms.TextBox();
            this.btImagen = new System.Windows.Forms.Button();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSalir
            // 
            this.btSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btSalir.Location = new System.Drawing.Point(21, 23);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 34);
            this.btSalir.TabIndex = 0;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            this.btSalir.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btSalir.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // btColor
            // 
            this.btColor.Location = new System.Drawing.Point(594, 24);
            this.btColor.Name = "btColor";
            this.btColor.Size = new System.Drawing.Size(75, 33);
            this.btColor.TabIndex = 1;
            this.btColor.Text = "Color";
            this.btColor.UseVisualStyleBackColor = true;
            this.btColor.Click += new System.EventHandler(this.btColor_Click);
            this.btColor.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btColor.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(155, 27);
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(100, 22);
            this.tbR.TabIndex = 2;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(454, 26);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 22);
            this.tbB.TabIndex = 3;
            // 
            // tbG
            // 
            this.tbG.Location = new System.Drawing.Point(304, 27);
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(100, 22);
            this.tbG.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ruta";
            // 
            // tbImagen
            // 
            this.tbImagen.Location = new System.Drawing.Point(198, 122);
            this.tbImagen.Name = "tbImagen";
            this.tbImagen.Size = new System.Drawing.Size(100, 22);
            this.tbImagen.TabIndex = 9;
            // 
            // btImagen
            // 
            this.btImagen.Location = new System.Drawing.Point(320, 113);
            this.btImagen.Name = "btImagen";
            this.btImagen.Size = new System.Drawing.Size(75, 35);
            this.btImagen.TabIndex = 10;
            this.btImagen.Text = "Imagen";
            this.btImagen.UseVisualStyleBackColor = true;
            this.btImagen.Click += new System.EventHandler(this.btImagen_Click);
            this.btImagen.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btImagen.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(241, 189);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(0, 17);
            this.lblImagen.TabIndex = 11;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(279, 228);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 12;
            // 
            // Form1
            // 
            this.AcceptButton = this.btColor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btSalir;
            this.ClientSize = new System.Drawing.Size(756, 407);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.btImagen);
            this.Controls.Add(this.tbImagen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbG);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.btColor);
            this.Controls.Add(this.btSalir);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btColor;
        private System.Windows.Forms.TextBox tbR;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbImagen;
        private System.Windows.Forms.Button btImagen;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblError;
    }
}

