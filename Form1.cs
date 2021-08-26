using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidRepo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private static string myConnection = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        SqlConnection con = new SqlConnection(myConnection);

        private void button1_Click(object sender, EventArgs e) 
        {
            string first = Convert.ToString(FirstName.Text);
            string last = Convert.ToString(LastName.Text);
            string gender = Convert.ToString(Gender.Text);
            string province = Convert.ToString(Province.Text);

            string insertQuery = "Insert Into CovidRegistration Values (@ID, @First, @Last, @Gender, @Province)";

            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@ID", ID.Text);
            cmd.Parameters.AddWithValue("@First", FirstName.Text);
            cmd.Parameters.AddWithValue("@Last", LastName.Text);
            cmd.Parameters.AddWithValue("@Gender", Gender.Text);
            cmd.Parameters.AddWithValue("@Province", Province.Text);
            
           
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            //comment
            //if ((first != "") & (first != "First Name")) {
            //    if ((last != "") & (last != "Last Name")) {
            //        if ((gender != "") & (gender != "Gender")) {
            //            if ((province != "") & (province != "Province")) {

            //            }
            //            else {
            //                MessageBox.Show("Please enter a province");
            //            }
            //        }
            //        else {
            //            MessageBox.Show("Please enter a gender");
            //        }
            //    }
            //    else {
            //        MessageBox.Show("Please enter a last name");
            //    }
            //}
            //else {
            //    MessageBox.Show("Please enter a first name");
            //}
        }
    }
}
