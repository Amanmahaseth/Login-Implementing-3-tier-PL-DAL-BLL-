using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class listing : Form
    {
        public listing()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
            {
           
            
            
        }

       
        private void listing_desc_Paint(object sender, PaintEventArgs e)
        {
           
            

        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }
        private Form f;

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            switch (node.Text)
            {
                case "Admin access":
                    {
                        f.Dispose();
                        f = new adminaccess();
                        f.TopLevel = false;
                       // this.listing_desc.Controls.Clear();
                        this.listing_desc.Controls.Add(f);
                        f.Dock = DockStyle.Fill;
                        f.Show();

                        break;
                    }

                case "Hotel Access":
                    {
                        f.Dispose();
                        f = new hotelaccess();
                        f.TopLevel = false;
                        // this.listing_desc.Controls.Clear();
                        this.listing_desc.Controls.Add(f);
                        f.Dock = DockStyle.Fill;
                        f.Show();

                        break;

                    }
                case "Ticket Access":
                    {
                        f.Dispose();
                        f = new ticketaccess();
                        f.TopLevel = false;
                        // this.listing_desc.Controls.Clear();
                        this.listing_desc.Controls.Add(f);
                        f.Dock = DockStyle.Fill;
                        f.Show();

                        break;

                    }
                case "All Menu Image":
                    {
                        f.Dispose();
                        f = new allmenuimage();
                        f.TopLevel = false;
                        // this.listing_desc.Controls.Clear();
                        this.listing_desc.Controls.Add(f);
                        f.Dock = DockStyle.Fill;
                        f.Show();

                        break;

                    }
                case "Home Delivery Rename":
                    {
                        f.Dispose();
                        f = new homedeliveryrename();
                        f.TopLevel = false;
                        // this.listing_desc.Controls.Clear();
                        this.listing_desc.Controls.Add(f);
                        f.Dock = DockStyle.Fill;
                        f.Show();

                        break;

                    }
                case "Add Menu Item Rename":
                    {
                        f.Dispose();
                        f = new addmenuitemrename();
                        f.TopLevel = false;
                        // this.listing_desc.Controls.Clear();
                        this.listing_desc.Controls.Add(f);
                        f.Dock = DockStyle.Fill;
                        f.Show();

                        break;

                    }
                case "View Sales Report Rename":
                    {
                        f.Dispose();
                        f = new viewsalesreportrename();
                        f.TopLevel = false;
                        // this.listing_desc.Controls.Clear();
                        this.listing_desc.Controls.Add(f);
                        f.Dock = DockStyle.Fill;
                        f.Show();

                        break;

                    }

            }
        }

        private void listing_Load(object sender, EventArgs e)
        {
            this.treeView1.Nodes[0].ExpandAll();
            f = new adminaccess();
            f.TopLevel = false;
            this.listing_desc.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show(); 

        }

        private void treeView1_MouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
          //  listing_desc.Text = e.Node.Text;
        }
    }
}
