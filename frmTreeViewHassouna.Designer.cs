namespace MyFirstWidowsFormsProject_PIZZA_
{
    partial class frmTreeViewHassouna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreeViewHassouna));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Home", 4, 5);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Person", 8, 9);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Tables", 11, 10);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Cash", 0, 1);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Notes", 7, 6);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Exit", 3, 2);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tvOpenForms = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Cash1.png");
            this.imageList1.Images.SetKeyName(1, "Cash2.png");
            this.imageList1.Images.SetKeyName(2, "Exit1.png");
            this.imageList1.Images.SetKeyName(3, "Exit2.png");
            this.imageList1.Images.SetKeyName(4, "Home1.png");
            this.imageList1.Images.SetKeyName(5, "Home2.png");
            this.imageList1.Images.SetKeyName(6, "Note1.png");
            this.imageList1.Images.SetKeyName(7, "Note2.png");
            this.imageList1.Images.SetKeyName(8, "Person1.png");
            this.imageList1.Images.SetKeyName(9, "Person2.png");
            this.imageList1.Images.SetKeyName(10, "Table1.png");
            this.imageList1.Images.SetKeyName(11, "Table2.png");
            // 
            // tvOpenForms
            // 
            this.tvOpenForms.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvOpenForms.ImageIndex = 0;
            this.tvOpenForms.ImageList = this.imageList1;
            this.tvOpenForms.Location = new System.Drawing.Point(0, 0);
            this.tvOpenForms.Name = "tvOpenForms";
            treeNode1.ImageIndex = 4;
            treeNode1.Name = "Node0";
            treeNode1.SelectedImageIndex = 5;
            treeNode1.Text = "Home";
            treeNode2.ImageIndex = 8;
            treeNode2.Name = "Node1";
            treeNode2.SelectedImageIndex = 9;
            treeNode2.Text = "Person";
            treeNode3.ImageIndex = 11;
            treeNode3.Name = "Node2";
            treeNode3.SelectedImageIndex = 10;
            treeNode3.Text = "Tables";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "Node3";
            treeNode4.SelectedImageIndex = 1;
            treeNode4.Text = "Cash";
            treeNode5.ImageIndex = 7;
            treeNode5.Name = "Node4";
            treeNode5.SelectedImageIndex = 6;
            treeNode5.Text = "Notes";
            treeNode6.ImageIndex = 3;
            treeNode6.Name = "Node5";
            treeNode6.SelectedImageIndex = 2;
            treeNode6.Text = "Exit";
            this.tvOpenForms.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.tvOpenForms.SelectedImageIndex = 0;
            this.tvOpenForms.Size = new System.Drawing.Size(197, 341);
            this.tvOpenForms.TabIndex = 0;
            this.tvOpenForms.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvOpenForms_AfterSelect);
            // 
            // frmTreeViewHassouna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.tvOpenForms);
            this.IsMdiContainer = true;
            this.Name = "frmTreeViewHassouna";
            this.Text = "frmTreeViewHassouna";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView tvOpenForms;
    }
}