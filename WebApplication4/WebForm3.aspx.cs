using School;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection c = new SqlConnection("Data Source=DESKTOP-5GL4B5D\\SQLEXPRESS1;Initial Catalog=School;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void disp()
        {
            SqlCommand cmd = new SqlCommand("select * from student", c);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            Display2.Text = "Record viewed succesfully !!";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
           student p = new student();
            p.student_id = Convert.ToInt32(TextBox1.Text);
            p.student_name = TextBox2.Text;
            p.student_class = Convert.ToInt32(TextBox3.Text);
            c.Open();
            SqlCommand cmd = new SqlCommand("insert into student values('" + p.student_id + "','" + p.student_name + "','" + p.student_class + "')", c);

            cmd.ExecuteNonQuery();
            Display.Text = "Record inserted succesfully...";
            TextBox1.Text = " ";
            TextBox2.Text = " ";
            TextBox3.Text = " ";
            disp();
            c.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            student p = new student();
            p.student_id = Convert.ToInt32(TextBox1.Text);
            p.student_name = TextBox2.Text;
            p.student_class = Convert.ToInt32(TextBox3.Text);
            c.Open();
            SqlCommand cmd = new SqlCommand("update student set student_name=' " + p.student_name + "',student_class='" + p.student_class + "' where student_id=' " + p.student_id + "'", c);
            cmd.ExecuteNonQuery();
            Display.Text = "Record updated succesfully !!";

            disp();

            TextBox1.Text = " ";
            TextBox2.Text = " ";
            TextBox3.Text = " ";
            c.Close();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            student p = new student();
            p.student_id = Convert.ToInt32(TextBox1.Text);


            c.Open();
            SqlCommand cmd = new SqlCommand("delete from student where student_id=' " + p.student_id + "'", c); ;
            cmd.ExecuteNonQuery();
            Display.Text = "Record deleted succesfully...";
            disp();

            TextBox1.Text = " ";
            TextBox2.Text = " ";
            TextBox3.Text = " ";
            c.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            student p = new student();
            p.student_id = Convert.ToInt32(TextBox1.Text);
            SqlCommand cmd = new SqlCommand("select * from student where student_id=' " + p.student_id + "'", c);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();
            Display.Text = "student details found ..";
            disp();


        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            disp();
            Display.Text = "Record viewed succesfully !!";
        }
    }
}