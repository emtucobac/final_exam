using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_exam
{


    public partial class cuslog : Form
    {
        SqlConnection cn;

        SqlDataAdapter data;

        SqlCommand cm;
        DataTable tb;
        SqlDataReader dr;
        int s = 0;
        private string username;
        public cuslog()
        {
            InitializeComponent();
        }
        public cuslog(string username)
        {
            InitializeComponent();
            user.Text = username;
        }

        private void cuslog_Load(object sender, EventArgs e)
        {
            string sql = "initial catalog = final; data source = DESKTOP-EJDOIL8\\SQLEXPRESS; integrated security = true";
            cn = new SqlConnection(sql);

            khungtaophieu.Enabled = false;
            total.Enabled = false;
            user.Enabled = false;
            BindData1();
            s = 0;
        }
        public void BindData1()
        {

            cn.Open();
            string tensanpham = "select Category_Name from category";
            SqlCommand cmd = new SqlCommand(tensanpham, cn);
            SqlDataAdapter da = new SqlDataAdapter(tensanpham, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();

            producttxt.DisplayMember = "Category_Name";
            producttxt.ValueMember = "Category_Name";
            producttxt.DataSource = ds.Tables[0];

            cn.Close();
        }
        private void taophieu_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(999999);
            phieumuatxt.Text = "PX00" + num + "";
            phieumuatxt.Enabled = false;
            khungtaophieu.Enabled = true;
            htPhieu();

        }

        public void htPhieu()
        {
            grd2.ColumnCount = 2;
            grd2.Columns[0].Name = "Product Name";
            grd2.Columns[1].Name = "Quantity";

            grd2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grd2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void done_Click(object sender, EventArgs e)
        {
            phieumuatxt.Clear();
            khungtaophieu.Enabled = false;
            s=0;
        }

        private void add_Click(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmdSelect = new SqlCommand("SELECT Category_Quantity FROM category WHERE Category_Name = @categoryname", cn);
            cmdSelect.Parameters.AddWithValue("@categoryname", producttxt.Text);
            int soluongtrongkho = (int)cmdSelect.ExecuteScalar();
            int a = int.Parse(soluong.Text);
            if (soluongtrongkho >= a)
            {
                grd2.Rows.Add(producttxt.Text, soluong.Text);

                // Lưu giá trị mới vào cơ sở dữ liệu 
                SqlCommand cmdUpdate = new SqlCommand("UPDATE category SET Category_Quantity = (Category_Quantity - @newQuantity) WHERE Category_Name = @categoryname", cn);

                cmdUpdate.Parameters.AddWithValue("@newQuantity", a);
                cmdUpdate.Parameters.AddWithValue("@categoryname", producttxt.Text);
                cmdUpdate.ExecuteNonQuery();
                string themttphieumua = "insert into phieumua values ('" + user.Text + "','" + phieumuatxt.Text + "', '" + producttxt.Text + "', " + a + ")";

                cm = new SqlCommand(themttphieumua, cn);

                cm.ExecuteNonQuery();


                // Lấy giá trị hiện tại của Category_price từ cơ sở dữ liệu
                SqlCommand st = new SqlCommand("SELECT Category_Price FROM category WHERE Category_Name = @categoryname", cn);
                st.Parameters.AddWithValue("@categoryname", producttxt.Text);
                int productprice = (int)cmdSelect.ExecuteScalar();
                s = s + (productprice * int.Parse(soluong.Text));
                total.Text = s + "$";

            }
            else
            {
                MessageBox.Show("The quantity in stock is no longer enough to satisfy");
            }

            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
