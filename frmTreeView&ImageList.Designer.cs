namespace MyFirstWidowsFormsProject_PIZZA_
{
    partial class frmTreeView_ImageList
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Ahmed", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Zeyad", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Boys", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node4", 1, 1);
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Node5", 1, 1);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Khadija", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Node6", 1, 1);
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Node7", 1, 1);
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("jana", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Girls", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode21});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreeView_ImageList));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.MyTreeAr = new System.Windows.Forms.TreeView();
            this.btnAddAr = new System.Windows.Forms.Button();
            this.btnAddAnotherWay = new System.Windows.Forms.Button();
            this.MyTree2 = new System.Windows.Forms.TreeView();
            this.txtSelectedNodes = new System.Windows.Forms.TextBox();
            this.btnCopySelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(18, 58);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Node0";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Node1";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Node0";
            treeNode4.Name = "Node2";
            treeNode4.Text = "Node2";
            treeNode5.Name = "Node3";
            treeNode5.Text = "Node3";
            treeNode6.Name = "Node1";
            treeNode6.Text = "Node1";
            treeNode7.Name = "Node8";
            treeNode7.Text = "Ahmed";
            treeNode8.Name = "Node4";
            treeNode8.Text = "Node4";
            treeNode9.Name = "Node5";
            treeNode9.Text = "Node5";
            treeNode10.Name = "Node2";
            treeNode10.Text = "Node2";
            treeNode11.Name = "Node6";
            treeNode11.Text = "Node6";
            treeNode12.Name = "Node7";
            treeNode12.Text = "Node7";
            treeNode13.Name = "Node3";
            treeNode13.Text = "Node3";
            treeNode14.Name = "Node9";
            treeNode14.Text = "Zeyad";
            treeNode15.ImageIndex = 0;
            treeNode15.Name = "Node6";
            treeNode15.SelectedImageIndex = 0;
            treeNode15.Text = "Boys";
            treeNode16.ImageIndex = 1;
            treeNode16.Name = "Node4";
            treeNode16.SelectedImageIndex = 1;
            treeNode16.Text = "Node4";
            treeNode17.ImageIndex = 1;
            treeNode17.Name = "Node5";
            treeNode17.SelectedImageIndex = 1;
            treeNode17.Text = "Node5";
            treeNode18.ImageIndex = 1;
            treeNode18.Name = "Node10";
            treeNode18.SelectedImageIndex = 1;
            treeNode18.Text = "Khadija";
            treeNode19.ImageIndex = 1;
            treeNode19.Name = "Node6";
            treeNode19.SelectedImageIndex = 1;
            treeNode19.Text = "Node6";
            treeNode20.ImageIndex = 1;
            treeNode20.Name = "Node7";
            treeNode20.SelectedImageIndex = 1;
            treeNode20.Text = "Node7";
            treeNode21.ImageIndex = 1;
            treeNode21.Name = "Node11";
            treeNode21.SelectedImageIndex = 1;
            treeNode21.Text = "jana";
            treeNode22.ImageIndex = 1;
            treeNode22.Name = "Node5";
            treeNode22.SelectedImageIndex = 1;
            treeNode22.Text = "Girls";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode22});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(369, 444);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Boy2.png");
            this.imageList1.Images.SetKeyName(1, "Girl2.png");
            this.imageList1.Images.SetKeyName(2, "Tic-Tac-Toe-Game-red.ico");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // MyTreeAr
            // 
            this.MyTreeAr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyTreeAr.Location = new System.Drawing.Point(423, 58);
            this.MyTreeAr.Name = "MyTreeAr";
            this.MyTreeAr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MyTreeAr.RightToLeftLayout = true;
            this.MyTreeAr.Size = new System.Drawing.Size(285, 370);
            this.MyTreeAr.TabIndex = 2;
            this.MyTreeAr.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MyTreeAr_AfterSelect);
            // 
            // btnAddAr
            // 
            this.btnAddAr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAddAr.Location = new System.Drawing.Point(423, 444);
            this.btnAddAr.Name = "btnAddAr";
            this.btnAddAr.Size = new System.Drawing.Size(285, 58);
            this.btnAddAr.TabIndex = 3;
            this.btnAddAr.Text = "Add";
            this.btnAddAr.UseVisualStyleBackColor = true;
            this.btnAddAr.Click += new System.EventHandler(this.btnAddAr_Click);
            // 
            // btnAddAnotherWay
            // 
            this.btnAddAnotherWay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAddAnotherWay.Location = new System.Drawing.Point(733, 444);
            this.btnAddAnotherWay.Name = "btnAddAnotherWay";
            this.btnAddAnotherWay.Size = new System.Drawing.Size(285, 58);
            this.btnAddAnotherWay.TabIndex = 5;
            this.btnAddAnotherWay.Text = "Add";
            this.btnAddAnotherWay.UseVisualStyleBackColor = true;
            this.btnAddAnotherWay.Click += new System.EventHandler(this.btnAddAnotherWay_Click);
            // 
            // MyTree2
            // 
            this.MyTree2.CheckBoxes = true;
            this.MyTree2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.MyTree2.Location = new System.Drawing.Point(733, 58);
            this.MyTree2.Name = "MyTree2";
            this.MyTree2.Size = new System.Drawing.Size(285, 370);
            this.MyTree2.TabIndex = 4;
            this.MyTree2.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.MyTree2_AfterCheck);
            this.MyTree2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MyTree2_AfterSelect);
            // 
            // txtSelectedNodes
            // 
            this.txtSelectedNodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtSelectedNodes.Location = new System.Drawing.Point(1130, 58);
            this.txtSelectedNodes.Multiline = true;
            this.txtSelectedNodes.Name = "txtSelectedNodes";
            this.txtSelectedNodes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSelectedNodes.Size = new System.Drawing.Size(311, 370);
            this.txtSelectedNodes.TabIndex = 6;
            // 
            // btnCopySelected
            // 
            this.btnCopySelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCopySelected.Location = new System.Drawing.Point(1033, 210);
            this.btnCopySelected.Name = "btnCopySelected";
            this.btnCopySelected.Size = new System.Drawing.Size(81, 58);
            this.btnCopySelected.TabIndex = 7;
            this.btnCopySelected.Text = ">>";
            this.btnCopySelected.UseVisualStyleBackColor = true;
            this.btnCopySelected.Click += new System.EventHandler(this.btnCopySelected_Click);
            // 
            // frmTreeView_ImageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 512);
            this.Controls.Add(this.btnCopySelected);
            this.Controls.Add(this.txtSelectedNodes);
            this.Controls.Add(this.btnAddAnotherWay);
            this.Controls.Add(this.MyTree2);
            this.Controls.Add(this.btnAddAr);
            this.Controls.Add(this.MyTreeAr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTreeView_ImageList";
            this.Text = "frmTreeView_ImageList";
            this.Load += new System.EventHandler(this.frmTreeView_ImageList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView MyTreeAr;
        private System.Windows.Forms.Button btnAddAr;
        private System.Windows.Forms.Button btnAddAnotherWay;
        private System.Windows.Forms.TreeView MyTree2;
        private System.Windows.Forms.TextBox txtSelectedNodes;
        private System.Windows.Forms.Button btnCopySelected;
    }
}