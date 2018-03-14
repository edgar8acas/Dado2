namespace Dado2
{
    partial class Form1
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
            this.btnLanzar1 = new System.Windows.Forms.Button();
            this.btnLanzar100 = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.txtSimulacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLanzar1
            // 
            this.btnLanzar1.Location = new System.Drawing.Point(25, 26);
            this.btnLanzar1.Name = "btnLanzar1";
            this.btnLanzar1.Size = new System.Drawing.Size(75, 23);
            this.btnLanzar1.TabIndex = 0;
            this.btnLanzar1.Text = "Lanzar 1";
            this.btnLanzar1.UseVisualStyleBackColor = true;
            this.btnLanzar1.Click += new System.EventHandler(this.btnLanzar1_Click);
            // 
            // btnLanzar100
            // 
            this.btnLanzar100.Location = new System.Drawing.Point(25, 55);
            this.btnLanzar100.Name = "btnLanzar100";
            this.btnLanzar100.Size = new System.Drawing.Size(75, 23);
            this.btnLanzar100.TabIndex = 1;
            this.btnLanzar100.Text = "Lanzar 100";
            this.btnLanzar100.UseVisualStyleBackColor = true;
            this.btnLanzar100.Click += new System.EventHandler(this.btnLanzar100_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(25, 84);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 2;
            this.btnSuma.Text = "1*2*100 L";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // txtSimulacion
            // 
            this.txtSimulacion.Location = new System.Drawing.Point(134, 26);
            this.txtSimulacion.Multiline = true;
            this.txtSimulacion.Name = "txtSimulacion";
            this.txtSimulacion.Size = new System.Drawing.Size(100, 584);
            this.txtSimulacion.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 622);
            this.Controls.Add(this.txtSimulacion);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnLanzar100);
            this.Controls.Add(this.btnLanzar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLanzar1;
        private System.Windows.Forms.Button btnLanzar100;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.TextBox txtSimulacion;
    }
}

