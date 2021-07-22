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
        
        int x,unitp;
        public void availableStocks()
        {
            con.Open();
            string mySql = "SELECT * FROM Medicine_tbl WHERE MedicineName = '" + medSelect.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(mySql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                x = Convert.ToInt32(dr["Qty"].ToString());
                unitp = Convert.ToInt32(dr["Sprice"].ToString());
                lblStocks.Text = "Available Stocks : "+dr["Qty"].ToString();
                lblStocks.Visible = true;
            }
            con.Close();
        }
        public void updateMedicine()
        {
            con.Open();
            int newQty = x - Convert.ToInt32(inputQty.Text);
            String update = "UPDATE Medicine_tbl SET Qty = '" + newQty + "' WHERE MedicineName = '" + medSelect.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(update, con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Medicine update successfully");
            con.Close();
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

        private void medSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            availableStocks();
        }

        Bitmap bitmap;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        int GrdTotal = 0;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            if(newQtyInput.Text == inputQty.Text)
            {
                int n = 0;
                if (newQtyInput.Text == "" || Convert.ToInt32(newQtyInput.Text) > x)
                {
                    MessageBox.Show("No enough stocks. Please check available stocks");
                }
                else
                {
                    int total = Convert.ToInt32(newQtyInput.Text) * unitp;
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dgvBilling);
                    newRow.Cells[0].Value = n + 1;
                    newRow.Cells[1].Value = medSelect.SelectedValue.ToString();
                    newRow.Cells[2].Value = newQtyInput.Text;
                    newRow.Cells[3].Value = unitp;
                    newRow.Cells[4].Value = unitp * Convert.ToInt32(newQtyInput.Text);
                    dgvBilling.Rows.Add(newRow);
                    GrdTotal = GrdTotal + total;
                    lblTotalAmount.Text = "Rs " + GrdTotal;

                    newQtyInput.Text = "Quantity";
                    inputQty.Text = "Re enter quantity";
                    updateMedicine();
                }
            }
            else
            {
                MessageBox.Show("Quantity and re enter quantity must be same.");
            }
            
        }

        private void medSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code
        }
    }
}
