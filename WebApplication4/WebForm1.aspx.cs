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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection c = new SqlConnection("Data Source=DESKTOP-5GL4B5D\\SQLEXPRESS1;Initial Catalog=School;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 p = new Class1();
            p.Room_no= Convert.ToInt32(TextBox1.Text);
           
            p.class_strength = Convert.ToInt32(TextBox2.Text);
            c.Open();
            SqlCommand cmd = new SqlCommand("insert into Class1 values('" + p.Room_no+ "','" + p.class_strength + "')", c);
            cmd.ExecuteNonQuery();
            Display.Text = "Record inserted succesfully...";
            TextBox1.Text = " ";
            TextBox2.Text = " ";
            
            disp();
            c.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Class1 p = new Class1();
            p.Room_no = Convert.ToInt32(TextBox1.Text);

            p.class_strength = Convert.ToInt32(TextBox2.Text);
            c.Open();
            SqlCommand cmd = new SqlCommand("update Class1 set class_strength=' " + p.class_strength  + "' where Room_no=' " + p.Room_no + "'", c);
            cmd.ExecuteNonQuery();
            Display.Text = "Record updated succesfully !!";

            disp();

            TextBox1.Text = " ";
            TextBox2.Text = " ";
           
            c.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Class1 p = new Class1();
            p.Room_no = Convert.ToInt32(TextBox1.Text);

            //p.class_strength = Convert.ToInt32(TextBox2.Text);
            c.Open();
            SqlCommand cmd = new SqlCommand("delete from Class1 where Room_no=' " + p.Room_no + "'", c); ;
            cmd.ExecuteNonQuery();
            Display.Text = "Record deleted succesfully...";
            disp();

            TextBox1.Text = " ";
            TextBox2.Text = " ";
            
            c.Close();
        }

        public void disp()
        {
            SqlCommand cmd = new SqlCommand("select * from Class1", c);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            Display2.Text = "Record viewed succesfully !!";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Class1 p = new Class1();
            p.Room_no = Convert.ToInt32(TextBox1.Text);
            SqlCommand cmd = new SqlCommand("select * from Class1 where Room_no=' " + p.Room_no + "'", c);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();
            Display.Text = "Class Room number found ..";
            disp();

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            disp();
            Display.Text = "Record viewed succesfully !!";
        }
    }
}