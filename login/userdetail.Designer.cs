namespace login
{
    partial class userdetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_userid = new System.Windows.Forms.ComboBox();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.label = new System.Windows.Forms.Label();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.txt_userdetail = new System.Windows.Forms.ComboBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_fullname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.txt_userid);
            this.panel1.Controls.Add(this.rbfemale);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.rbmale);
            this.panel1.Controls.Add(this.txt_userdetail);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.txt_fullname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(136, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 508);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_userid
            // 
            this.txt_userid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_userid.FormattingEnabled = true;
            this.txt_userid.Location = new System.Drawing.Point(77, 449);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(312, 29);
            this.txt_userid.TabIndex = 10;
            this.txt_userid.Text = "id";
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(220, 308);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(74, 20);
            this.rbfemale.TabIndex = 12;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(109, 269);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(196, 36);
            this.label.TabIndex = 11;
            this.label.Text = "SelectGender";
            this.label.Click += new System.EventHandler(this.label2_Click);
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(124, 308);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(58, 20);
            this.rbmale.TabIndex = 10;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // txt_userdetail
            // 
            this.txt_userdetail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userdetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_userdetail.FormattingEnabled = true;
            this.txt_userdetail.Location = new System.Drawing.Point(124, 148);
            this.txt_userdetail.Name = "txt_userdetail";
            this.txt_userdetail.Size = new System.Drawing.Size(312, 29);
            this.txt_userdetail.TabIndex = 9;
            this.txt_userdetail.Text = "userid";
            this.txt_userdetail.SelectedIndexChanged += new System.EventHandler(this.txt_userdetail_SelectedIndexChanged);
            this.txt_userdetail.Click += new System.EventHandler(this.txt_userdetail_SelectedIndexChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Blue;
            this.btn_submit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_submit.Location = new System.Drawing.Point(159, 356);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(146, 54);
            this.btn_submit.TabIndex = 6;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_fullname
            // 
            this.txt_fullname.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_fullname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_fullname.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_fullname.BorderThickness = 3;
            this.txt_fullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_fullname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_fullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_fullname.isPassword = false;
            this.txt_fullname.Location = new System.Drawing.Point(124, 202);
            this.txt_fullname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(312, 44);
            this.txt_fullname.TabIndex = 2;
            this.txt_fullname.Text = "Fullname";
            this.txt_fullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_fullname.OnValueChanged += new System.EventHandler(this.txt_fullname_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(150, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserDetail";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_fullname,
            this.col_gender});
            this.DGV.Location = new System.Drawing.Point(73, 649);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(892, 150);
            this.DGV.TabIndex = 2;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick_1);
            this.DGV.SelectionChanged += new System.EventHandler(this.DGV_SelectionChanged);
            // 
            // col_id
            // 
            this.col_id.HeaderText = "id";
            this.col_id.MinimumWidth = 6;
            this.col_id.Name = "col_id";
            this.col_id.Width = 125;
            // 
            // col_fullname
            // 
            this.col_fullname.HeaderText = "Fullname";
            this.col_fullname.MinimumWidth = 6;
            this.col_fullname.Name = "col_fullname";
            this.col_fullname.Width = 125;
            // 
            // col_gender
            // 
            this.col_gender.HeaderText = "Gender";
            this.col_gender.MinimumWidth = 6;
            this.col_gender.Name = "col_gender";
            this.col_gender.Width = 125;
            // 
            // userdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 828);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userdetail";
            this.Text = "userdetail";
            this.Load += new System.EventHandler(this.userdetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txt_userdetail;
        private System.Windows.Forms.Button btn_submit;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_fullname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gender;
        private System.Windows.Forms.ComboBox txt_userid;
    }
}