namespace login
{
    partial class listing
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Admin access");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Hotel Access");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Ticket Access");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Access", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Home Delivery Rename");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Add Menu Item Rename");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("View Sales Report Rename");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("All Menu Image", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            this.listing_desc = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // listing_desc
            // 
            this.listing_desc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listing_desc.Location = new System.Drawing.Point(574, 23);
            this.listing_desc.Name = "listing_desc";
            this.listing_desc.Size = new System.Drawing.Size(540, 337);
            this.listing_desc.TabIndex = 1;
            this.listing_desc.Paint += new System.Windows.Forms.PaintEventHandler(this.listing_desc_Paint);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(100, 41);
            this.treeView1.Name = "treeView1";
            treeNode1.Checked = true;
            treeNode1.Name = "Admin_access";
            treeNode1.Text = "Admin access";
            treeNode2.Name = "Hotel_Access";
            treeNode2.Text = "Hotel Access";
            treeNode3.Name = "Ticket_Access";
            treeNode3.Text = "Ticket Access";
            treeNode4.Name = "Access";
            treeNode4.Text = "Access";
            treeNode5.Name = "Node6";
            treeNode5.Text = "Home Delivery Rename";
            treeNode6.Name = "Node11";
            treeNode6.Text = "Add Menu Item Rename";
            treeNode7.Name = "Node13";
            treeNode7.Text = "View Sales Report Rename";
            treeNode8.Name = "Node5";
            treeNode8.Text = "All Menu Image";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(408, 254);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // listing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 801);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listing_desc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listing";
            this.Text = "listing";
            this.Load += new System.EventHandler(this.listing_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel listing_desc;
        private System.Windows.Forms.TreeView treeView1;
    }
}