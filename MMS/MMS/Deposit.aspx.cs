using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace MMS
{
    public partial class Deposit : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-75EGOEF\SQLEXPRESS;Initial Catalog=MMS;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                DropDownList1.Items.Add(i.ToString());
                DropDownList2.Items.Add(i.ToString());
                DropDownList3.Items.Add(i.ToString());
                DropDownList4.Items.Add(i.ToString());
                DropDownList5.Items.Add(i.ToString());
                DropDownList6.Items.Add(i.ToString());
                DropDownList7.Items.Add(i.ToString());
                DropDownList8.Items.Add(i.ToString());
                DropDownList9.Items.Add(i.ToString());          
            }

        }
       
      

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("Insert into Deposit(name, balance, date) values (@name, @balance, @date)", conn))
            {

                conn.Open();
               
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@name", Label1.Text);
                    cmd.Parameters.AddWithValue("@balance", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@date", DropDownList1.SelectedValue);

                    cmd.ExecuteNonQuery();
               
                conn.Close();
            }
            GridView1.Rows[0].Cells[1].Text = "Soikot";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("Insert into Deposit(name, balance, date) values (@name, @balance, @date)", conn))
            {

                conn.Open();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", Label2.Text);
                cmd.Parameters.AddWithValue("@balance", TextBox2.Text);
                cmd.Parameters.AddWithValue("@date", DropDownList2.SelectedValue);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("Insert into Deposit(name, balance, date) values (@name, @balance, @date)", conn))
            {

                conn.Open();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", Label9.Text);
                cmd.Parameters.AddWithValue("@balance", TextBox9.Text);
                cmd.Parameters.AddWithValue("@date", DropDownList9.SelectedValue);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("Insert into Deposit(name, balance, date) values (@name, @balance, @date)", conn))
            {

                conn.Open();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", Label3.Text);
                cmd.Parameters.AddWithValue("@balance", TextBox3.Text);
                cmd.Parameters.AddWithValue("@date", DropDownList3.SelectedValue);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("Insert into Deposit(name, balance, date) values (@name, @balance, @date)", conn))
            {

                conn.Open();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", Label4.Text);
                cmd.Parameters.AddWithValue("@balance", TextBox4.Text);
                cmd.Parameters.AddWithValue("@date", DropDownList4.SelectedValue);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("Insert into Deposit(name, balance, date) values (@name, @balance, @date)", conn))
            {

                conn.Open();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", Label5.Text);
                cmd.Parameters.AddWithValue("@balance", TextBox5.Text);
                cmd.Parameters.AddWithValue("@date", DropDownList5.SelectedValue);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("Insert into Deposit(name, balance, date) values (@name, @balance, @date)", conn))
            {

                conn.Open();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", Label6.Text);
                cmd.Parameters.AddWithValue("@balance", TextBox6.Text);
                cmd.Parameters.AddWithValue("@date", DropDownList6.SelectedValue);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("Insert into Deposit(name, balance, date) values (@name, @balance, @date)", conn))
            {

                conn.Open();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", Label7.Text);
                cmd.Parameters.AddWithValue("@balance", TextBox7.Text);
                cmd.Parameters.AddWithValue("@date", DropDownList7.SelectedValue);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("Insert into Deposit(name, balance, date) values (@name, @balance, @date)", conn))
            {

                conn.Open();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", Label8.Text);
                cmd.Parameters.AddWithValue("@balance", TextBox8.Text);
                cmd.Parameters.AddWithValue("@date", DropDownList8.SelectedValue);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

    }
}