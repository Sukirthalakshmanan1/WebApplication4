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
    public partial class WebForm4 : System.Web.UI.Page
    {

        SqlConnection c = new SqlConnection("Data Source=DESKTOP-5GL4B5D\\SQLEXPRESS1;Initial Catalog=School;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void disp()
        {
            SqlCommand cmd = new SqlCommand("select * from subjects", c);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            Display2.Text = "Subject details viewed succesfully !!";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            subjects p = new subjects();
            p.subjects_id = Convert.ToInt32(TextBox1.Text);

            p.subjects_name = TextBox2.Text;
            c.Open();
            SqlCommand cmd = new SqlCommand("insert into subjects values('" + p.subjects_id + "','" + p.subjects_name + "')", c);
            cmd.ExecuteNonQuery();
            Display.Text = "Record inserted succesfully...";
            TextBox1.Text = " ";
            TextBox2.Text = " ";

            disp();
            
            c.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            subjects p = new subjects();
            p.subjects_id = Convert.ToInt32(TextBox1.Text);

            p.subjects_name = TextBox2.Text;


            c.Open();
            SqlCommand cmd = new SqlCommand("update subjects set subjects_name=' " + p.subjects_name + "' where subjects_id=' " + p.subjects_id + "'", c);
            cmd.ExecuteNonQuery();
            Display.Text = "Record updated succesfully !!";

            disp();

            TextBox1.Text = " ";
            TextBox2.Text = " ";

            c.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            subjects p = new subjects();
            p.subjects_id = Convert.ToInt32(TextBox1.Text);
            //p.class_strength = Convert.ToInt32(TextBox2.Text);
            c.Open();
            SqlCommand cmd = new SqlCommand("delete from subjects where subjects_id=' " + p.subjects_id + "'", c); ;
            cmd.ExecuteNonQuery();
            Display.Text = "Record deleted succesfully...";
            disp();

            TextBox1.Text = " ";
            TextBox2.Text = " ";

            c.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            subjects p = new subjects();
            p.subjects_id = Convert.ToInt32(TextBox1.Text);

            SqlCommand cmd = new SqlCommand("select * from subjects where subjects_id=' " + p.subjects_id + "'", c);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();
            Display.Text = "Subject details found ..";
            disp();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            disp();
            Display.Text = "Record viewed succesfully !!";
        }
    }
}