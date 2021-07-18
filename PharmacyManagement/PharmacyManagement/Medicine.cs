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
using System.Runtime.InteropServices;

namespace PharmacyManagement
{
    public partial class Medicine : Form
    {
        //panel move mouse handler start
        public const int WM_NCLBUTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]

        public static extern int SendMessage(IntPtr hwnd, int msg, int wParm, int Iparm);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //panel move mouse handler end

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
        public void clear()
        {
            inputMedName.Text = "Medicine Name";
            inputBprice.Text = "Buying Price";
            inputSprice.Text = "Selling Price";
            inputQty.Text = "Quantity";
            inputCompany.Text = "Select Company";

            DateTime date = DateTime.Now;
            string longDate = date.ToLongDateString();
            inputExpDate.Text = longDate;
            lblMedId.Text = "Medicine ID";
        }
        public Medicine()
        {
            InitializeComponent();
            lblMedId.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(lblMedId.Text == "Medicine ID")
            {
                if (inputMedName.Text == "" || inputBprice.Text == "" || inputSprice.Text == "" || inputQty.Text == "" || inputCompany.SelectedItem.ToString() == "Select Company")
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
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("This medicine already added. You can only update this medicine.");
            }
           
            
        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dgvMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMedId.Text = dgvMedicine.SelectedRows[0].Cells[0].Value.ToString();
            inputMedName.Text = dgvMedicine.SelectedRows[0].Cells[1].Value.ToString();
            inputBprice.Text = dgvMedicine.SelectedRows[0].Cells[2].Value.ToString();
            inputSprice.Text = dgvMedicine.SelectedRows[0].Cells[3].Value.ToString();
            inputQty.Text = dgvMedicine.SelectedRows[0].Cells[4].Value.ToString();
            inputExpDate.Text = dgvMedicine.SelectedRows[0].Cells[5].Value.ToString();
            inputCompany.Text = dgvMedicine.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(lblMedId.Text == "Medicine ID")
            {
                MessageBox.Show("You must select a medicine from medicine table to update");
            }
            else
            {
                con.Open();
                String update = "UPDATE Medicine_tbl SET MedicineName = '" + inputMedName.Text + "', Bprice = '" + inputBprice.Text + "', Sprice = '" + inputSprice.Text + "', Qty = '" + inputQty.Text + "', ExpDate = '" + inputExpDate.Text + "', Company = '" + inputCompany.SelectedItem.ToString() + "' WHERE MedicineID = '" + lblMedId.Text + "'";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine update successfully");
                con.Close();
                populate();
                clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lblMedId.Text == "Medicine ID")
            {
                MessageBox.Show("You must select a medicine from medicine table to delete");
            }
            else
            {
                con.Open();
                String delete = "DELETE FROM Medicine_tbl WHERE MedicineID = '" + lblMedId.Text + "'";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine deleted successfully");
                con.Close();
                populate();
                clear();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTONDOWN, HT_CAPTION,0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
