namespace MyFirstWidowsFormsProject_PIZZA_
{
    partial class frmMain
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
            this.btnShowPart1 = new System.Windows.Forms.Button();
            this.btnShowDialog = new System.Windows.Forms.Button();
            this.btnMessageBoxForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowPart1
            // 
            this.btnShowPart1.Location = new System.Drawing.Point(9, 10);
            this.btnShowPart1.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowPart1.Name = "btnShowPart1";
            this.btnShowPart1.Size = new System.Drawing.Size(582, 74);
            this.btnShowPart1.TabIndex = 0;
            this.btnShowPart1.Text = "Show Form";
            this.btnShowPart1.UseVisualStyleBackColor = true;
            this.btnShowPart1.Click += new System.EventHandler(this.btnShowPart1_Click);
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.Location = new System.Drawing.Point(9, 89);
            this.btnShowDialog.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Size = new System.Drawing.Size(582, 74);
            this.btnShowDialog.TabIndex = 1;
            this.btnShowDialog.Text = "Show Form as dialog";
            this.btnShowDialog.UseVisualStyleBackColor = true;
            this.btnShowDialog.Click += new System.EventHandler(this.btnShowDialog_Click);
            // 
            // btnMessageBoxForm
            // 
            this.btnMessageBoxForm.Location = new System.Drawing.Point(9, 167);
            this.btnMessageBoxForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnMessageBoxForm.Name = "btnMessageBoxForm";
            this.btnMessageBoxForm.Size = new System.Drawing.Size(582, 74);
            this.btnMessageBoxForm.TabIndex = 2;
            this.btnMessageBoxForm.Text = "Show Message Box Form";
            this.btnMessageBoxForm.UseVisualStyleBackColor = true;
            this.btnMessageBoxForm.Click += new System.EventHandler(this.btnMessageBoxForm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(582, 74);
            this.button1.TabIndex = 3;
            this.button1.Text = "CheckBox/Radio/Group";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 325);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(582, 74);
            this.button2.TabIndex = 4;
            this.button2.Text = "More About Text Boxes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 403);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(582, 74);
            this.button3.TabIndex = 5;
            this.button3.Text = "Picture Box";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 481);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(582, 74);
            this.button4.TabIndex = 6;
            this.button4.Text = "Picture Box Excercise";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(9, 559);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(582, 74);
            this.button5.TabIndex = 7;
            this.button5.Text = "Draw Line , ellipse , and rectangle.";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 637);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(582, 74);
            this.button6.TabIndex = 8;
            this.button6.Text = "Masked Text Box";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 718);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMessageBoxForm);
            this.Controls.Add(this.btnShowDialog);
            this.Controls.Add(this.btnShowPart1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "frm Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowPart1;
        private System.Windows.Forms.Button btnShowDialog;
        private System.Windows.Forms.Button btnMessageBoxForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}