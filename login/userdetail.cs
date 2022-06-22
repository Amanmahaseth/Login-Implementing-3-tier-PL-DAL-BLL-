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
    public partial class userdetail : Form
    {
        public userdetail()
        {
            InitializeComponent();
        }
        details de = new details();
        SqlConnection Con = new SqlConnection(@"Data Source =.; Initial Catalog=Login; Integrated Security = True");
        public void fillcombobox()
        {
            DataTable dt = de.dropdown_userdetail();
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.NewRow();
                txt_userdetail.DataSource = dt;
                txt_userid.DataSource = dt;
                txt_userdetail.ValueMember = "username";
                txt_userid.ValueMember = "id";
            }
        }

        void FillValue()
        {
            if (DGV.SelectedRows.Count > 0)
            {


                DataGridViewRow dr = DGV.SelectedRows[0];
                if (dr != null)
                {
                    int id = Convert.ToInt32(dr.Cells["col_id"].Value);
                    DataTable dt = de.get_id(id);
                    if (dt.Rows.Count > 0)
                    {
                        //txt_userdetail.Text = dt.Rows[0]["Username"].ToString();
                       // txt_fullname.Text = dt.Rows[0]["fullname"].ToString();
                       // Gender = (Label)dt.Rows[0]["gender"];
                        // txt_userid.Text = dt.Rows[0]["id"].ToString();


                        id = Convert.ToInt32(dt.Rows[0]["id"].ToString());

                    }
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_userdetail_SelectedIndexChanged(object sender, EventArgs e)

        {

            DataTable dt = de.get_id(id);


            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.NewRow();
                txt_userid.Text = dt.Rows[0]["id"].ToString();


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void userdetail_Load(object sender, EventArgs e)
        {
            DataTable dt = de.getuserdata();
           
           
            if (dt.Rows.Count > 0)
            {
                DGV.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DGV.Rows.Add();
                    DGV.Rows[i].Cells["col_id"].Value = dt.Rows[i]["id"].ToString();
                    DGV.Rows[i].Cells["col_fullname"].Value = dt.Rows[i]["fullname"].ToString();
                    DGV.Rows[i].Cells["col_gender"].Value = dt.Rows[i]["gender"].ToString();

                }

            }
            DGV.ClearSelection();
            fillcombobox();
            
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_fullname.Text = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void txt_fullname_OnValueChanged(object sender, EventArgs e)
        {

        }
       

        private void DGV_SelectionChanged(object sender, EventArgs e)
        {
         FillValue();
        }
        int save;
        int id;
        string gender= string.Empty;

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (rbmale.Checked)
            {
                gender = "M";
            }
            else if (rbfemale.Checked)
            {
                gender = "F";
            }
            
            save = de.add_details(txt_fullname.Text, gender, Convert.ToInt32(txt_userid.Text));
            MessageBox.Show("user details added");
            userdetail_Load(this, null);
            
        }

        private void DGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           // txt_userdetail.Text = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_fullname.Text = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            

        }
    }
}
