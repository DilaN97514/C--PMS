using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmacyManagement
{
    public partial class Medicine : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\Pharmacenter_db.mdf;Integrated Security=True;Connect Timeout=30");

        public void populate()
        {
            con.Open();
            string qry = "SELECT * FROM Medicine_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(qry, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvMedicine.ReadOnly = true;
            dgvMedicine.DataSource = ds.Tables[0];
            con.Close();
        }
        public Medicine()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(inputMedName.Text == "" || inputBprice.Text == "" || inputSprice.Text == "" || inputQty.Text == "" || inputCompany.SelectedItem.ToString() == "Select Company")
            {
                MessageBox.Show("Missing data! Please fill all the information.");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Medicine_tbl (MedicineName,Bprice,Sprice,Qty,ExpDate,Company) VALUES ('" + inputMedName.Text + "','" + inputBprice.Text + "','" + inputSprice.Text + "','" + inputQty.Text + "','" + inputExpDate.Text + "','" + inputCompany.SelectedItem.ToString() + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Medicine Successfully Added");
                    con.Close();
                    populate();

                    inputMedName.Text = "Medicine Name";
                    inputBprice.Text = "Buying Price";
                    inputSprice.Text = "Selling Price";
                    inputQty.Text = "Quantity";
                    inputCompany.Text = "Select Company";

                    DateTime date = DateTime.Now;
                    string longDate = date.ToLongDateString();
                    inputExpDate.Text = longDate;
                }
                else
                {
                    MessageBox.Show("Error!");
                    con.Close();
                }
            }
            
        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
