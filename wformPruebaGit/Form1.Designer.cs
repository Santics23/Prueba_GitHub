﻿namespace wformPruebaGit
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 180);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hola Mundo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(835, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(385, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(571, 338);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

