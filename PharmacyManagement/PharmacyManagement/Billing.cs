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
    public partial class Billing : Form
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

        public void setCombobox()
        {
            string sql = "SELECT * FROM Medicine_tbl";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader sdr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("MedicineName", typeof(string));
                sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                medSelect.ValueMember = "MedicineName";
                medSelect.DataSource = dt;
                con.Close();
            }
            catch
            {
                MessageBox.Show("ComboBox Error!");
            }
        }

        public Billing()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
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

        private void Billing_Load(object sender, EventArgs e)
        {
            setCombobox();
        }
    }
}
