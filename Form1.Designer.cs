﻿namespace MyFirstWidowsFormsProject_PIZZA_
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(450, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(304, 22);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Copy In Mouse Click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "Copy  In Mouse Enter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(180, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 57);
            this.button3.TabIndex = 4;
            this.button3.Text = "Disable Textbox (1)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(180, 383);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 57);
            this.button4.TabIndex = 8;
            this.button4.Text = "Enable Textbox (1)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(354, 320);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 57);
            this.button5.TabIndex = 5;
            this.button5.Text = "Hide Textbox (1)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(354, 383);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 57);
            this.button6.TabIndex = 9;
            this.button6.Text = "Show Textbox (1)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 320);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(168, 57);
            this.button7.TabIndex = 3;
            this.button7.Text = "Text  (1) To Red";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 383);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(168, 57);
            this.button8.TabIndex = 7;
            this.button8.Text = "Text  (1) To White";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(528, 320);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(168, 57);
            this.button9.TabIndex = 6;
            this.button9.Text = "Change Form Title";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(905, 77);
            this.label1.TabIndex = 11;
            this.label1.Text = "this is a practice project";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(528, 383);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(168, 57);
            this.button10.TabIndex = 10;
            this.button10.Text = "Change Label1";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(528, 194);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(168, 57);
            this.button11.TabIndex = 11;
            this.button11.Text = "STYLE BUTTON";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(897, 409);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 31);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "this is the initial title";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnClose;
    }
}

