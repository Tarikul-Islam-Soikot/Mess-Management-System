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
    public partial class Extra : System.Web.UI.Page
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
            conn.Open();
            String query = "insert into Extra(field, amount, date) values('" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + DropDownList1.SelectedValue + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
        }

    }
}