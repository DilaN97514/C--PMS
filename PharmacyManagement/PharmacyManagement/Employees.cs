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
    public partial class Employees : Form
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

        public void empDetails()
        {
            con.Open();
            string qry = "SELECT * FROM Employee_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(qry, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgvEmployee.ReadOnly = true;
            dgvEmployee.DataSource = ds.Tables[0];
            con.Close();
        }
        public void reset()
        {
            lblEmpId.Text = "00";
            empName.Text = "Employee Name";
            empAddress.Text = "Employee Address";
            empEmail.Text = "Employee E-mail";
            empGender.Text = "Select Gender";
            empPhone.Text = "Employee Phone No";
            empRole.Text = "Employee Role";
            empSalary.Text = "Employee Salary";

            DateTime date = DateTime.Now;
            string lgDate = date.ToLongDateString();
            empBday.Text = lgDate;
        }

        public Employees()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
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
            if(lblEmpId.Text == "00")
            {
                if (empName.Text == "" || empAddress.Text == "" || empEmail.Text == "" || empGender.SelectedItem.ToString() == "Select Gender" || empPhone.Text == "" || empRole.Text == "" || empSalary.Text == "")
                {
                    MessageBox.Show("Missing data! Please fill all the information");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Employee_tbl (EmpName,EmpAddress,EmpEmail,EmpBirthday,EmpGender,EmpPhone,EmpRole,EmpSalary) VALUES ('" + empName.Text + "','" + empAddress.Text + "','" + empEmail.Text + "','" + empBday.Text + "','" + empGender.SelectedItem.ToString() + "','" + empPhone.Text + "','" + empRole.Text + "','" + empSalary.Text + "')", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Employee Successfully Added");
                        con.Close();
                        empDetails();
                        reset();
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
                MessageBox.Show("This employee already registered. You can only update this employee");
            }
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            empDetails();
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblEmpId.Text = dgvEmployee.SelectedRows[0].Cells[0].Value.ToString();
            empName.Text = dgvEmployee.SelectedRows[0].Cells[1].Value.ToString();
            empAddress.Text = dgvEmployee.SelectedRows[0].Cells[2].Value.ToString();
            empEmail.Text = dgvEmployee.SelectedRows[0].Cells[3].Value.ToString();
            empBday.Text = dgvEmployee.SelectedRows[0].Cells[4].Value.ToString();
            empGender.Text = dgvEmployee.SelectedRows[0].Cells[5].Value.ToString();
            empPhone.Text = dgvEmployee.SelectedRows[0].Cells[6].Value.ToString();
            empRole.Text = dgvEmployee.SelectedRows[0].Cells[7].Value.ToString();
            empSalary.Text = dgvEmployee.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lblEmpId.Text == "00")
            {
                MessageBox.Show("You must select a employee from employees table to update");
            }
            else
            {
                con.Open();
                String update = "UPDATE Employee_tbl SET EmpName = '" + empName.Text + "', EmpAddress = '" + empAddress.Text + "', EmpEmail = '" + empEmail.Text + "', EmpBirthday = '" + empBday.Text + "', EmpGender = '" + empGender.SelectedItem.ToString() + "', EmpPhone = '" + empPhone.Text + "', EmpRole = '"+empRole.Text+"', EmpSalary = '"+empSalary.Text+"' WHERE EmpId = '" + lblEmpId.Text + "'";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee update successfully");
                con.Close();
                empDetails();
                reset();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblEmpId.Text == "00")
            {
                MessageBox.Show("You must select a employee from employees table to delete");
            }
            else
            {
                con.Open();
                String delete = "DELETE FROM Employee_tbl WHERE EmpId = '" + lblEmpId.Text + "'";
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee deleted successfully");
                con.Close();
                empDetails();
                reset();
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
