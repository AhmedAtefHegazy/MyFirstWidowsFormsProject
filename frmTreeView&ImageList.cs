using System;
using System.Windows.Forms;

namespace MyFirstWidowsFormsProject_PIZZA_
{
    public partial class frmTreeView_ImageList : Form
    {
        public frmTreeView_ImageList()
        {
            InitializeComponent();
        }


        private void CheckTreeViewNode(TreeNode node, bool IsChecked)
        {

            if (node.Checked)
            {
                node.SelectedImageIndex = 2;
            }

            else
            {
                node.SelectedImageIndex = node.ImageIndex;
            }

            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = IsChecked;
            }
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            label1.Text = treeView1.SelectedNode.Text.ToString();
        }

        private void MyTreeAr_AfterSelect(object sender, TreeViewEventArgs e)
        {
            label1.Text = MyTreeAr.SelectedNode.Text.ToString();

        }

        private void MyTree2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            label1.Text = MyTree2.SelectedNode.Text.ToString();

        }



        private void btnAddAr_Click(object sender, System.EventArgs e)
        {
            MyTreeAr.Nodes.Add("لغات البرمجة");
            MyTreeAr.Nodes.Add("تصميم الويب");
            MyTreeAr.Nodes.Add("اجهزة الكمبيوتر");

            MyTreeAr.Nodes[0].Nodes.Add("جافا");
            MyTreeAr.Nodes[0].Nodes[0].Nodes.Add("جافا اس اي ");
            MyTreeAr.Nodes[0].Nodes[0].Nodes.Add("جافا اي اي ");
            MyTreeAr.Nodes[0].Nodes.Add("سي شارب");
            MyTreeAr.Nodes[0].Nodes.Add("سي بلس بلس");

            MyTreeAr.Nodes[1].Nodes.Add("اتش تي ام ال");
            MyTreeAr.Nodes[1].Nodes.Add("سي اس اس");
            MyTreeAr.Nodes[1].Nodes.Add("جافا اسكربت");

            MyTreeAr.Nodes[2].Nodes.Add("اتش بي");
            MyTreeAr.Nodes[2].Nodes.Add("ديل");

        }

        private void btnAddAnotherWay_Click(object sender, System.EventArgs e)
        {
            MyTree2.Nodes.Add("Programming Languages").Nodes.Add("Java").Nodes.Add("Java SE").Parent.Nodes.Add("Jave EE").Parent.Parent.Nodes.Add("C#").Parent.Nodes.Add("C++");
            MyTree2.Nodes.Add("Web Design").Nodes.Add("HTML").Parent.Nodes.Add("CSS").Parent.Nodes.Add("Java Script");
            MyTree2.Nodes.Add("Computer Devices").Nodes.Add("HP").Parent.Nodes.Add("DELL").Parent.Nodes.Add("LENOVO");
        }

        private void frmTreeView_ImageList_Load(object sender, System.EventArgs e)
        {

            treeView1.Nodes.Add("Gays");
            treeView1.Nodes[2].SelectedImageIndex = 0;
            treeView1.Nodes[2].ImageIndex = 1;
            treeView1.Nodes[2].Nodes.Add("ss");
            treeView1.Nodes[2].Nodes.Add("aa");
            treeView1.Nodes[2].Nodes.Add("qq");
            treeView1.Nodes[2].Nodes.Add("ee");
            treeView1.Nodes[2].Nodes.Add("ww");
            treeView1.Nodes[2].Nodes[0].SelectedImageIndex = 0;
            treeView1.Nodes[2].Nodes[1].SelectedImageIndex = 0;
            treeView1.Nodes[2].Nodes[2].SelectedImageIndex = 0;
            treeView1.Nodes[2].Nodes[3].SelectedImageIndex = 0;
            treeView1.Nodes[2].Nodes[4].SelectedImageIndex = 0;
            treeView1.Nodes[2].Nodes[0].ImageIndex = 1;
            treeView1.Nodes[2].Nodes[1].ImageIndex = 1;
            treeView1.Nodes[2].Nodes[2].ImageIndex = 1;
            treeView1.Nodes[2].Nodes[3].ImageIndex = 1;
            treeView1.Nodes[2].Nodes[4].ImageIndex = 1;
        }


        private void MyTree2_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckTreeViewNode(e.Node, e.Node.Checked);
        }


        private void RecursiveCopy(TreeNode node, byte NodesCount)
        {
            foreach (TreeNode Node in node.Nodes)
            {
                if (Node.Checked)
                {
                    txtSelectedNodes.Text += "--------- " + Node.Text + Environment.NewLine;
                }

                if (Node.Nodes.Count > 0)
                {
                    RecursiveCopy(Node, (byte)Node.Nodes.Count);
                }
            }
        }

        private void btnCopySelected_Click(object sender, System.EventArgs e)
        {
            txtSelectedNodes.Text = "";

            if (MyTree2.Nodes.Count > 0)
            {

                foreach (TreeNode Node in MyTree2.Nodes)
                {

                    if (Node.Checked)
                    {
                        txtSelectedNodes.Text += "--- " + Node.Text + Environment.NewLine;
                        RecursiveCopy(Node, (byte)Node.Nodes.Count);
                    }

                }


            }
        }
    }
}
