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
    public partial class Transaction : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-75EGOEF\SQLEXPRESS;Initial Catalog=MMS;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            double total_deposit = 0, total_meal = 0, meal_rate = 0;
            double extra_per_person;
            double[] meal = new double[9];
            double[] deposit = new double[9];
            double[] expense = new double[9];
            double[] money = new double[9];

            
            con.Open();
            SqlCommand Sudipto = new SqlCommand("select Sum(meal) from Meal where name = 'Sudipto'", con);
            Label14.Text = Sudipto.ExecuteScalar().ToString();
            meal[0] = Convert.ToDouble (Label14.Text);

            SqlCommand Soikot = new SqlCommand("select Sum(meal) from Meal where name = 'Soikot'", con);
            Label19.Text = Soikot.ExecuteScalar().ToString();
            meal[1] = Convert.ToDouble(Label19.Text);

            SqlCommand Kamrul = new SqlCommand("select Sum(meal) from Meal where name = 'Kamrul'", con);
            Label24.Text = Kamrul.ExecuteScalar().ToString();
            meal[2] = Convert.ToDouble(Label24.Text);

            SqlCommand Tonmoy = new SqlCommand("select Sum(meal) from Meal where name = 'Tonmoy'", con);
            Label29.Text = Tonmoy.ExecuteScalar().ToString();
            meal[3] = Convert.ToDouble(Label29.Text);

            SqlCommand Nayan = new SqlCommand("select Sum(meal) from Meal where name = 'Nayan'", con);
            Label34.Text = Nayan.ExecuteScalar().ToString();
            meal[4] = Convert.ToDouble(Label34.Text);

            SqlCommand Sony = new SqlCommand("select Sum(meal) from Meal where name = 'Sony'", con);
            Label39.Text = Sony.ExecuteScalar().ToString();
            meal[5] = Convert.ToDouble(Label39.Text);

            SqlCommand Parvez = new SqlCommand("select Sum(meal) from Meal where name = 'Parvez'", con);
            Label44.Text = Parvez.ExecuteScalar().ToString();
            meal[6] = Convert.ToDouble(Label44.Text);

            SqlCommand Tuhin = new SqlCommand("select Sum(meal) from Meal where name = 'Tuhin'", con);
            Label49.Text = Tuhin.ExecuteScalar().ToString();
            meal[7] = Convert.ToDouble(Label49.Text);

            SqlCommand Sajib = new SqlCommand("select Sum(meal) from Meal where name = 'Sajib'", con);
            Label54.Text = Sajib.ExecuteScalar().ToString();
            meal[8] = Convert.ToDouble(Label54.Text);

            con.Close();

///////////// Deposit /////////
            con.Open();
            SqlCommand Sudipto_d = new SqlCommand("select Sum(balance) from Deposit where name = 'Sudipto'", con);
            Label15.Text = Sudipto_d.ExecuteScalar().ToString();
            deposit[0] = Convert.ToDouble(Label15.Text);

            SqlCommand Soikot_d = new SqlCommand("select Sum(balance) from Deposit where name = 'Soikot'", con);
            Label20.Text = Soikot_d.ExecuteScalar().ToString();
            deposit[1] = Convert.ToDouble(Label20.Text);

            SqlCommand Kamrul_d = new SqlCommand("select Sum(balance) from Deposit where name = 'Kamrul'", con);
            Label25.Text = Kamrul_d.ExecuteScalar().ToString();
            deposit[2] = Convert.ToDouble(Label25.Text);

            SqlCommand Tonmoy_d = new SqlCommand("select Sum(balance) from Deposit where name = 'Tonmoy'", con);
            Label30.Text = Tonmoy_d.ExecuteScalar().ToString();
            deposit[3] = Convert.ToDouble(Label30.Text);

            SqlCommand Nayan_d = new SqlCommand("select Sum(balance) from Deposit where name = 'Nayan'", con);
            Label35.Text = Nayan_d.ExecuteScalar().ToString();
            deposit[4] = Convert.ToDouble(Label35.Text);

            SqlCommand Sony_d = new SqlCommand("select Sum(balance) from Deposit where name = 'Sony'", con);
            Label40.Text = Sony_d.ExecuteScalar().ToString();
            deposit[5] = Convert.ToDouble(Label40.Text);

            SqlCommand Parvez_d = new SqlCommand("select Sum(balance) from Deposit where name = 'Parvez'", con);
            Label45.Text = Parvez_d.ExecuteScalar().ToString();
            deposit[6] = Convert.ToDouble(Label45.Text);

            SqlCommand Tuhin_d = new SqlCommand("select Sum(balance) from Deposit where name = 'Tuhin'", con);
            Label50.Text = Tuhin_d.ExecuteScalar().ToString();
            deposit[7] = Convert.ToDouble(Label50.Text);

            SqlCommand Sajib_d = new SqlCommand("select Sum(balance) from Deposit where name = 'Sajib'", con);
            Label55.Text = Sajib_d.ExecuteScalar().ToString();
            deposit[8] = Convert.ToDouble(Label15.Text);

            //////Extra///////
            SqlCommand Extra = new SqlCommand("select sum(amount) from Extra", con);
            Label55.Text = Extra.ExecuteScalar().ToString();
            extra_per_person = Convert.ToDouble(Label15.Text)/ 9.0 ;

            for (int i = 0; i < 9; i++)
            {
                total_deposit += deposit[i];
                total_meal += meal[i];
            }
            Label1.Text = Convert.ToString(total_meal);
            Label2.Text = Convert.ToString(total_deposit);

            meal_rate = total_deposit / total_meal;

           for(int i = 0 ; i < 9; i++)
           {
               expense[i] = meal[i] * meal_rate;
               money[i] = (expense[i] + (float)extra_per_person) - deposit[i];
           }

           Label16.Text = Convert.ToString(expense[0]);
           Label21.Text = Convert.ToString(expense[1]);
           Label26.Text = Convert.ToString(expense[2]);
           Label31.Text = Convert.ToString(expense[3]);
           Label36.Text = Convert.ToString(expense[4]);
           Label41.Text = Convert.ToString(expense[5]);
           Label46.Text = Convert.ToString(expense[6]);
           Label51.Text = Convert.ToString(expense[7]);
           Label56.Text = Convert.ToString(expense[8]);

           Label17.Text = Convert.ToString(money[0]);
           Label22.Text = Convert.ToString(money[1] );
           Label27.Text = Convert.ToString(money[2]);
           Label32.Text = Convert.ToString(money[3]);
           Label37.Text = Convert.ToString(money[4]);
           Label42.Text = Convert.ToString(money[5]);
           Label47.Text = Convert.ToString(money[6]);
           Label52.Text = Convert.ToString(money[7]);
           Label57.Text = Convert.ToString(money[8]);


           




        }
            
    }
}