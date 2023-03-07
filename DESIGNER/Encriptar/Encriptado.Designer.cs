namespace DESIGNER.Encriptar
{
    partial class Encriptado
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
            this.btnencriptar = new System.Windows.Forms.Button();
            this.txtoriginal = new System.Windows.Forms.TextBox();
            this.txtencriptada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnencriptar
            // 
            this.btnencriptar.Location = new System.Drawing.Point(472, 38);
            this.btnencriptar.Name = "btnencriptar";
            this.btnencriptar.Size = new System.Drawing.Size(75, 23);
            this.btnencriptar.TabIndex = 0;
            this.btnencriptar.Text = "Encriptar";
            this.btnencriptar.UseVisualStyleBackColor = true;
            this.btnencriptar.Click += new System.EventHandler(this.btnencriptar_Click);
            // 
            // txtoriginal
            // 
            this.txtoriginal.Location = new System.Drawing.Point(150, 38);
            this.txtoriginal.Name = "txtoriginal";
            this.txtoriginal.Size = new System.Drawing.Size(100, 20);
            this.txtoriginal.TabIndex = 2;
            // 
            // txtencriptada
            // 
            this.txtencriptada.Location = new System.Drawing.Point(150, 115);
            this.txtencriptada.Name = "txtencriptada";
            this.txtencriptada.Size = new System.Drawing.Size(453, 20);
            this.txtencriptada.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clave Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Clave Encriptada";
            // 
            // Encriptado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 173);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtencriptada);
            this.Controls.Add(this.txtoriginal);
            this.Controls.Add(this.btnencriptar);
            this.Name = "Encriptado";
            this.Text = "Encriptado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnencriptar;
        private System.Windows.Forms.TextBox txtoriginal;
        private System.Windows.Forms.TextBox txtencriptada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}