using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        details de = new details();
        SqlConnection Con = new SqlConnection(@"Data Source =.; Initial Catalog=Login; Integrated Security = True");

        int id;     
        public void fillcombobox()
        {
            DataTable dt = de.dropdown_username(id,txt_username.Text,txt_password.Text);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.NewRow();
                
            

                txt_username.DataSource = dt;
                
                txt_username.ValueMember = "username";
               
            }




            /*string sql = "select * from login1";
            SqlCommand cmd = new SqlCommand(sql,Con);
            SqlDataReader myreader;
            try
            {
                Con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string username = myreader.GetString(1);
                    txt_username.Items.Add(username);
                }

                Con.Close();
            }
            catch
            {

            }
            */
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
        public void show_in_datagridview()
        {
            DataTable dt = de.getdata();
            if (dt.Rows.Count > 0)
            {
                DGV.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DGV.Rows.Add();
                    DGV.Rows[i].Cells["col_id"].Value = dt.Rows[i]["id"].ToString();
                    DGV.Rows[i].Cells["col_username"].Value = dt.Rows[i]["username"].ToString();
                    DGV.Rows[i].Cells["col_password"].Value = dt.Rows[i]["password"].ToString();
                }
            }
            DGV.ClearSelection();
        }
        int save;
        private void button1_Click(object sender, EventArgs e)
        {

            save = de.add_category(txt_username.Text, txt_password.Text);
            MessageBox.Show("user added");
            Form1_Load(this, null);

            /*Con.Open();
            string query = "insert into login(username,password) values(txt_usern)";
            SqlCommand cmd = new SqlCommand(query,Con);
            cmd.ExecuteNonQuery();
            
            Con.Close();*/
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            DataTable dt = de.getdata();
           
           // populatecombo();
            if (dt.Rows.Count > 0)
            {
                DGV.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DGV.Rows.Add();
                    DGV.Rows[i].Cells["col_id"].Value = dt.Rows[i]["id"].ToString();
                    DGV.Rows[i].Cells["col_username"].Value = dt.Rows[i]["username"].ToString();
                    DGV.Rows[i].Cells["col_password"].Value = dt.Rows[i]["password"].ToString();

                }

            }
            DGV.ClearSelection();
            fillcombobox();




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //  save = de.update_category(txt_username.Text, txt_password.Text);
            //int update;
            int id = Convert.ToInt32(DGV.CurrentRow.Cells["col_id"].Value);
            //update = de.update_category(id, txt_username.Text, txt_password.Text);
            save = de.update_category(id, txt_username.Text, txt_password.Text);
            //MessageBox.Show("user updated");
            //Form1_Load(this, null);
            DataTable dt1 = de.getdataid(id);

            if (txt_username.Text == "")
            {
                MessageBox.Show("Please Enter username");
            }
            else
            {
                if (dt1.Rows.Count == 0)
                {
                    int update;
                    id = Convert.ToInt32(DGV.CurrentRow.Cells["col_id"].Value);
                    DataTable dt = de.getdataid(id);
                    
                    update = de.update_category(id, txt_username.Text, txt_password.Text);
                   


                }
                MessageBox.Show("Successfully updated");
                show_in_datagridview();



            }

        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow dr in DGV.SelectedRows)
                {
                    int id = Convert.ToInt32(dr.Cells["col_id"].Value);
                    if (id > 0)
                    {

                        int delete_category = de.delete_category(id);

                        if (delete_category > 0)
                        {
                            MessageBox.Show("Successfully Deleted");

                        }
                        DGV.Rows.RemoveAt(DGV.CurrentRow.Index);
                    }
                }
                DGV.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please Select A Row");
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // col_username.HeaderText=DGV.SelectedRows[0].Cells[0].Value.ToString();
            //Col_password.HeaderText = DGV.SelectedRows[0].Cells[1].Value.ToString();
            txt_username.Text = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_password.Text = DGV.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            FillValue();
        }
        void FillValue()
        {
            

            if (DGV.SelectedRows.Count > 0)
            {

                btn_update.Enabled = true;
                DataGridViewRow dr = DGV.SelectedRows[0] ;
                if (dr != null)
                {
                    int id = Convert.ToInt32(dr.Cells["col_id"].Value);
                    DataTable dt = de.getdataid(id);
                    if (dt.Rows.Count > 0)
                    {
                        txt_username.Text = dt.Rows[0]["Username"].ToString();
                        txt_password.Text = dt.Rows[0]["Password"].ToString();

                        id = Convert.ToInt32(dt.Rows[0]["id"].ToString());

                    }
                }
                    
            }
        }
        private void DGV_SelectionChanged(object sender, EventArgs e)
        {
            FillValue();

            
        }

        private void txt_username_SelectionChangeCommitted(object sender, EventArgs e)
        {
           // fetchpassword();
        }

        private void txt_username_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = de.dropdown_password( txt_username.Text);
            

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.NewRow();
               // txt_username.Text = dt.Rows[0]["Username"].ToString();
               txt_password.Text = dt.Rows[0]["Password"].ToString();



                // txt_username.DataSource = dt;

                // txt_username.ValueMember = "username";

                //txt_password.Text = "password";
            }
            /*string sql = "select * from login1 where username ='"+txt_username.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader myreader;
            try
            {
                Con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string username = myreader.GetInt32(0).ToString();
                    string password = myreader.GetString(2);
                    txt_username.Text= username;
                    txt_password.Text = password;


                }
                Con.Close();
            }
            catch
            {

            }*/
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_userdetail_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
          
        }
    }
}