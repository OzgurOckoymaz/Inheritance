﻿
namespace Inheritance
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnRecPerimeter = new System.Windows.Forms.Button();
            this.btnRecArea = new System.Windows.Forms.Button();
            this.btnSquPerimeter = new System.Windows.Forms.Button();
            this.btnSquArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 61);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rectangle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Short Edge :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Long Edge:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Square";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edge :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(408, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 20);
            this.textBox3.TabIndex = 7;
            // 
            // btnRecPerimeter
            // 
            this.btnRecPerimeter.Location = new System.Drawing.Point(132, 169);
            this.btnRecPerimeter.Name = "btnRecPerimeter";
            this.btnRecPerimeter.Size = new System.Drawing.Size(75, 23);
            this.btnRecPerimeter.TabIndex = 8;
            this.btnRecPerimeter.Text = "Perimeter";
            this.btnRecPerimeter.UseVisualStyleBackColor = true;
            this.btnRecPerimeter.Click += new System.EventHandler(this.btnRecPerimeter_Click);
            // 
            // btnRecArea
            // 
            this.btnRecArea.Location = new System.Drawing.Point(213, 169);
            this.btnRecArea.Name = "btnRecArea";
            this.btnRecArea.Size = new System.Drawing.Size(75, 23);
            this.btnRecArea.TabIndex = 9;
            this.btnRecArea.Text = "Area";
            this.btnRecArea.UseVisualStyleBackColor = true;
            this.btnRecArea.Click += new System.EventHandler(this.btnRecArea_Click);
            // 
            // btnSquPerimeter
            // 
            this.btnSquPerimeter.Location = new System.Drawing.Point(408, 169);
            this.btnSquPerimeter.Name = "btnSquPerimeter";
            this.btnSquPerimeter.Size = new System.Drawing.Size(75, 23);
            this.btnSquPerimeter.TabIndex = 10;
            this.btnSquPerimeter.Text = "Perimeter";
            this.btnSquPerimeter.UseVisualStyleBackColor = true;
            this.btnSquPerimeter.Click += new System.EventHandler(this.btnSquPerimeter_Click);
            // 
            // btnSquArea
            // 
            this.btnSquArea.Location = new System.Drawing.Point(489, 169);
            this.btnSquArea.Name = "btnSquArea";
            this.btnSquArea.Size = new System.Drawing.Size(75, 23);
            this.btnSquArea.TabIndex = 11;
            this.btnSquArea.Text = "Area";
            this.btnSquArea.UseVisualStyleBackColor = true;
            this.btnSquArea.Click += new System.EventHandler(this.btnSquArea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSquArea);
            this.Controls.Add(this.btnSquPerimeter);
            this.Controls.Add(this.btnRecArea);
            this.Controls.Add(this.btnRecPerimeter);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnRecPerimeter;
        private System.Windows.Forms.Button btnRecArea;
        private System.Windows.Forms.Button btnSquPerimeter;
        private System.Windows.Forms.Button btnSquArea;
    }
}

