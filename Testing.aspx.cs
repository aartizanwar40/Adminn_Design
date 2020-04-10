using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Admin_Design
{
    public partial class Testing : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
        {



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from admin_login where username='" + t1.Text + "' and password='" + t2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            if ("Usertype" == "Teacher")
            {
                Response.Redirect("Teacher.aspx");
            }
            else
            {
                Response.Redirect("Student.aspx");
            }
            con.Close();
        }
    }
}