namespace ListViewProgram
{
    partial class frmListView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListView));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LVIName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LVIID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.btnFillRandom = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbList = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbTile = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbView = new System.Windows.Forms.GroupBox();
            this.rbDetails = new System.Windows.Forms.RadioButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.gbView.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Boy2.png");
            this.imageList1.Images.SetKeyName(1, "Girl2.png");
            // 
            // LVIName
            // 
            this.LVIName.Text = "Name";
            this.LVIName.Width = 76;
            // 
            // LVIID
            // 
            this.LVIID.Text = "ID";
            this.LVIID.Width = 75;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LVIID,
            this.LVIName});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(55, 160);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(966, 335);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(226, 112);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(74, 20);
            this.rbFemale.TabIndex = 4;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(106, 112);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 20);
            this.rbMale.TabIndex = 3;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // btnFillRandom
            // 
            this.btnFillRandom.Location = new System.Drawing.Point(586, 43);
            this.btnFillRandom.Name = "btnFillRandom";
            this.btnFillRandom.Size = new System.Drawing.Size(129, 45);
            this.btnFillRandom.TabIndex = 7;
            this.btnFillRandom.Text = "Fill Random";
            this.btnFillRandom.UseVisualStyleBackColor = true;
            this.btnFillRandom.Click += new System.EventHandler(this.btnFillRandom_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(453, 43);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(129, 45);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 22);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name:";
            // 
            // rbList
            // 
            this.rbList.AutoSize = true;
            this.rbList.Location = new System.Drawing.Point(166, 50);
            this.rbList.Name = "rbList";
            this.rbList.Size = new System.Drawing.Size(48, 20);
            this.rbList.TabIndex = 11;
            this.rbList.Text = "List";
            this.rbList.UseVisualStyleBackColor = true;
            this.rbList.CheckedChanged += new System.EventHandler(this.rbList_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(166, 24);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(91, 20);
            this.rbLarge.TabIndex = 9;
            this.rbLarge.Text = "Large Icon";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbTile
            // 
            this.rbTile.AutoSize = true;
            this.rbTile.Location = new System.Drawing.Point(18, 76);
            this.rbTile.Name = "rbTile";
            this.rbTile.Size = new System.Drawing.Size(51, 20);
            this.rbTile.TabIndex = 12;
            this.rbTile.Text = "Tile";
            this.rbTile.UseVisualStyleBackColor = true;
            this.rbTile.CheckedChanged += new System.EventHandler(this.rbTile_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(18, 50);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(90, 20);
            this.rbSmall.TabIndex = 10;
            this.rbSmall.Text = "Small Icon";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbView
            // 
            this.gbView.Controls.Add(this.rbList);
            this.gbView.Controls.Add(this.rbLarge);
            this.gbView.Controls.Add(this.rbTile);
            this.gbView.Controls.Add(this.rbSmall);
            this.gbView.Controls.Add(this.rbDetails);
            this.gbView.Location = new System.Drawing.Point(740, 27);
            this.gbView.Name = "gbView";
            this.gbView.Size = new System.Drawing.Size(281, 105);
            this.gbView.TabIndex = 12;
            this.gbView.TabStop = false;
            this.gbView.Text = "View";
            // 
            // rbDetails
            // 
            this.rbDetails.AutoSize = true;
            this.rbDetails.Checked = true;
            this.rbDetails.Location = new System.Drawing.Point(18, 24);
            this.rbDetails.Name = "rbDetails";
            this.rbDetails.Size = new System.Drawing.Size(70, 20);
            this.rbDetails.TabIndex = 8;
            this.rbDetails.TabStop = true;
            this.rbDetails.Text = "Details";
            this.rbDetails.UseVisualStyleBackColor = true;
            this.rbDetails.CheckedChanged += new System.EventHandler(this.rbDetails_CheckedChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(105, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(318, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 45);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID:";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Boy2.png");
            this.imageList2.Images.SetKeyName(1, "Girl2.png");
            // 
            // frmListView
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 539);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.btnFillRandom);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbView);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "frmListView";
            this.Text = "frmListView";
            this.gbView.ResumeLayout(false);
            this.gbView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader LVIName;
        private System.Windows.Forms.ColumnHeader LVIID;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Button btnFillRandom;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbList;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbTile;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbView;
        private System.Windows.Forms.RadioButton rbDetails;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList2;
    }
}