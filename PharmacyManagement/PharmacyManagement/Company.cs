using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace PharmacyManagement
{
    public partial class Company : Form
    {
        //panel move mouse handler start
        public const int WM_NCLBUTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]

        public static extern int SendMessage(IntPtr hwnd, int msg, int wParm, int Iparm);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //panel move mouse handler end

        //Database connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\Pharmacenter_db.mdf;Integrated Security=True;Connect Timeout=30");

        public void Companytbl()
        {
            con.Open();
            string qry = "SELECT * FROM Company_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(qry, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvCompany.ReadOnly = true;
            dgvCompany.DataSource = ds.Tables[0];
            con.Close();
        }
        public void clearInputs()
        {
            lblCompanyId.Text = "00000";
            companyName.Text = "Company Name";
            companyPhone.Text = "Company Phone";
            companyAddress.Text = "Company Address";
            companyEmail.Text = "Company E-mail";
        }

        public Company()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lblCompanyId.Text == "00000")
            {
                if (companyName.Text == "Company Name" || companyPhone.Text == "Company Phone" || companyAddress.Text == "Company Address" || companyEmail.Text == "Company E-mail" || companyName.Text == "" || companyPhone.Text == "" || companyAddress.Text == "" || companyEmail.Text == "")
                {
                    MessageBox.Show("Missing data! Please fill all the information");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Company_tbl (CompanyName,CompanyPhone,CompanyAddress,CompanyEmail) VALUES ('" + companyName.Text + "','" + companyPhone.Text + "','" + companyAddress.Text + "','" + companyEmail.Text + "')", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Company Successfully Registered");
                        con.Close();
                        Companytbl();
                        clearInputs();
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
                MessageBox.Show("This company already registered. You can only update this company");
            }
        }

        private void Company_Load(object sender, EventArgs e)
        {
            Companytbl();
        }

        private void dgvCompany_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCompanyId.Text = dgvCompany.SelectedRows[0].Cells[0].Value.ToString();
            companyName.Text = dgvCompany.SelectedRows[0].Cells[1].Value.ToString();
            companyPhone.Text = dgvCompany.SelectedRows[0].Cells[2].Value.ToString();
            companyAddress.Text = dgvCompany.SelectedRows[0].Cells[3].Value.ToString();
            companyEmail.Text = dgvCompany.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lblCompanyId.Text == "00000")
            {
                MessageBox.Show("You must select a company from company table to update");
            }
            else
            {
                con.Open();
                String update = "UPDATE Company_tbl SET CompanyName = '" + companyName.Text + "', CompanyPhone = '" + companyPhone.Text + "', CompanyAddress = '" + companyAddress.Text + "', CompanyEmail = '" + companyEmail.Text + "' WHERE CompanyID = '" + lblCompanyId.Text + "'";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Company update successfully");
                con.Close();
                Companytbl();
                clearInputs();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblCompanyId.Text == "00000")
            {
                MessageBox.Show("You must select a company from company table to delete");
            }
            else
            {
                con.Open();
                String delete = "DELETE FROM Company_tbl WHERE CompanyID = '" +lblCompanyId.Text + "'";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee deleted successfully");
                con.Close();
                Companytbl();
                clearInputs();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }
    }
}
