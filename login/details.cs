using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    internal class details
    {
        public DataTable getdata()
        {
            return DBConnect.getuser("Select * from login1 order by id Asc", null);
        }
        
        public DataTable getuserdata()
        {
            return DBConnect.getuser("Select * from tbl_userdetail order by id Asc", null);
        }
        public DataTable getdataid(int id)
        {
            SqlParameter[] parm = new SqlParameter[]
         {
                new SqlParameter("@id", id),

         };
            return DBConnect.getuser("Select * from login1 where id=@id", parm);
        }
        public int add_category(string username, string password)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password),
            };

            return DBConnect.IDU("Insert into login1(username,password) values(@username,@password)", parm);

        }


        public int update_category(int id, string username, string password)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter("@id", id),
                new SqlParameter("@username", username),
                new SqlParameter("@password", password),

            };
            return DBConnect.IDU("Update login1 set username = @username, password = @password where id=@id", parm);
        }
        public int delete_category(int id)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter("@id", id),

            };
            return DBConnect.IDU("Delete from login1 where id=@id", parm);

        }
        public DataTable dropdown_username(int id, string username, string password)
        {
            SqlParameter[] parm = new SqlParameter[]
         {
                new SqlParameter("@id", id),
                new SqlParameter("@username", username),
                new SqlParameter("@password", password),

         };
            return DBConnect.getuser("Select * from login1 ", parm);
        }

       
        public DataTable dropdown_password(string username)
        {
            SqlParameter[] parm = new SqlParameter[]
         {
               new SqlParameter("@username", username),


         };
            return DBConnect.getuser("Select * from login1 where username=@username ", parm);
        }
        public int add_details(string Fullname, string Gender, int id)
        {
            SqlParameter[] parm = new SqlParameter[]
            {
                new SqlParameter("@Fullname", Fullname),
                new SqlParameter("@Gender", Gender),
                new SqlParameter("@id", id),

            };
            return DBConnect.IDU("Insert into tbl_userdetail(Fullname,Gender,Userid) values(@Fullname,@Gender,@id)", parm);
        }
        public DataTable dropdown_userdetail()
        {
            SqlParameter[] parm = new SqlParameter[]
         {



         };
            return DBConnect.getuser("Select * from login1 ", parm);
        }
        public DataTable get_id(int id)
        {
            SqlParameter[] parm = new SqlParameter[]
         {
               new SqlParameter("@id", id),


         };
            return DBConnect.getuser("Select * from login1 where id=@id  ", parm);

        }

    }
}
