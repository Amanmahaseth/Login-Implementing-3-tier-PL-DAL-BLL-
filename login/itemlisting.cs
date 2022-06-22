using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace login
{
    public partial class itemlisting : Form
    {
        public itemlisting()
        {
            InitializeComponent();
        }
    
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Name == "Admin_access")
            {

                
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
                
            }

            if (treeView1.SelectedNode.Name == "Hotel_Access")
            {
               
                panel1.Visible = false;
                panel2.Visible = true;
                
            }
            if (treeView1.SelectedNode.Name == "Ticket_Access")
            {

                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = true;


            }
            if (treeView1.SelectedNode.Name == "Access")
            {
                panel1.Controls.Clear();
                panel1.Visible = false;
                panel2.Visible = false;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
       

        private void itemlisting_Load(object sender, EventArgs e)
        {

            panel2.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

        


    
