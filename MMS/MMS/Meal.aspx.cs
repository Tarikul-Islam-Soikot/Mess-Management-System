using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace MMS
{
    public partial class Meal : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-75EGOEF\SQLEXPRESS;Initial Catalog=MMS;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            
            for (int i = 1; i <= 31; i++)
            {
                DropDownList1.Items.Add(i.ToString());

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("Insert into Meal(name, meal, date) values (@name, @meal, @date)", conn))
            {

                conn.Open();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", Label1.Text);
                cmd.Parameters.AddWithValue("@meal", TextBox1.Text);
                cmd.Parameters.AddWithValue("@date", DropDownList1.SelectedValue);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", Label3.Text);
                cmd.Parameters.AddWithValue("@meal", TextBox2.Text);
                cmd.Parameters.AddWithValue("@date", DropDownList1.SelectedValue);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", Label4.Text);
                cmd.Parameters.AddWithValue("@meal", TextBox3.Text);
                cmd.Parameters.AddWithValue("@date", DropDownList1.SelectedValue);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", Label5.Text);
                cmd.Parameters.AddWithValue("@meal", TextBox4.Text);
                cmd.Parameters.AddWithValue("@date", DropDownList1.SelectedValue);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", Label6.Text);
                cmd.Parameters.AddWithValue("@meal", TextBox5.Text);
                cmd.Parameters.AddWithValue("@date", DropDownList1.SelectedValue);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", Label7.Text);
                cmd.Parameters.AddWithValue("@meal", TextBox6.Text);
                cmd.Parameters.AddWithValue("@date", DropDownList1.SelectedValue);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", Label8.Text);
                cmd.Parameters.AddWithValue("@meal", TextBox7.Text);
                cmd.Parameters.AddWithValue("@date", DropDownList1.SelectedValue);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", Label9.Text);
                cmd.Parameters.AddWithValue("@meal", TextBox8.Text);
                cmd.Parameters.AddWithValue("@date", DropDownList1.SelectedValue);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", Label10.Text);
                cmd.Parameters.AddWithValue("@meal", TextBox9.Text);
                cmd.Parameters.AddWithValue("@date", DropDownList1.SelectedValue);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
    }
}