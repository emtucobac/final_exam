﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SqlClient;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using Microsoft.VisualBasic.ApplicationServices;

namespace final_exam
{
    public partial class stafflog : Form
    {
        SqlConnection cn;

        SqlDataAdapter data;

        SqlCommand cm;
        DataTable tb;
        SqlDataReader dr;
        int s = 0;
        int count = 0;
        public stafflog()
        {
            InitializeComponent();
        }

        private void xemkho_Click(object sender, EventArgs e)
        {
            kho_reload();
        }
        public void kho_reload()
        {
            string s = "select * from category";
            data = new SqlDataAdapter(s, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd1.DataSource = tb;

        }

            private void taophieu_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(999999);
            khungtaophieu.Enabled = true;
            BindData1();
            phieukhoidtxt.Text = "PN00" + num + "";
            phieukhoidtxt.Enabled = false;
            htPhieu();

            s = 0;
            chucnangbox.Enabled = false;
        }

        private void done_Click(object sender, EventArgs e)
        {
            
            cn.Open();

            grd2.Rows.Add(producttxt.Text, amounts.Text);

            // Chuyển giá trị mới từ string sang int q
            int newQuantity = int.Parse(amounts.Text);

            // Lưu giá trị mới vào cơ sở dữ liệu 
            SqlCommand cmdUpdate = new SqlCommand("UPDATE category SET Category_Quantity = (@newQuantity + Category_Quantity) WHERE Category_Name = @categoryname", cn);
           
            cmdUpdate.Parameters.AddWithValue("@newQuantity", newQuantity);
            cmdUpdate.Parameters.AddWithValue("@categoryname", producttxt.Text);

            // Lưu giá trị mới vào cơ sở dữ liệu 
            /*SqlCommand cmdtbill = new SqlCommand("INSERT INTO bill_xuat VALUES('@billid', '@productname',  @newQuantity);", cn);
            cmdtbill.Parameters.AddWithValue("@billid", phieukhoidtxt.Text);
            cmdtbill.Parameters.AddWithValue("@productname", producttxt.Text);
            cmdtbill.Parameters.AddWithValue("@newQuantity", newQuantity);
            cmdtbill.ExecuteNonQuery();*/


            string sa = "insert into bill_xuat values ('" + phieukhoidtxt.Text + "', '" + producttxt.Text + "', " + newQuantity + ")";

            cm = new SqlCommand(sa, cn);

            cm.ExecuteNonQuery();

            cmdUpdate.ExecuteNonQuery();


            // Lấy giá trị hiện tại của Category_price từ cơ sở dữ liệu
            SqlCommand cmdSelect = new SqlCommand("SELECT Category_Price FROM category WHERE Category_Name = @categoryname", cn);
            cmdSelect.Parameters.AddWithValue("@categoryname", producttxt.Text);
            int productprice = (int)cmdSelect.ExecuteScalar();
            s = s + (productprice * newQuantity);
            total.Text = s + "$";

            kho_reload();
            cn.Close();

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

            producttxt.Enabled = true;
            cn.Close();
        }
        public void BindData2()
        {

            cn.Open();
            string tensanpham = "select distinct billxuat_id from bill_xuat";
            SqlCommand cmd = new SqlCommand(tensanpham, cn);
            SqlDataAdapter da = new SqlDataAdapter(tensanpham, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();

            phieutxt.DisplayMember = "billxuat_id";
            phieutxt.ValueMember = "billxuat_id";
            phieutxt.DataSource = ds.Tables[0];



            cn.Close();

        }


            public void htPhieu()
        {
            grd2.ColumnCount = 2;
            grd2.Columns[0].Name = "Product Name";
            grd2.Columns[1].Name = "Quantity";

            grd2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grd2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void stafflog_Load(object sender, EventArgs e)
        {

            string sql = "initial catalog = final; data source = DESKTOP-EJDOIL8\\SQLEXPRESS; integrated security = true";
            cn = new SqlConnection(sql);
            cn.Open();


            string s = "select * from category";
            data = new SqlDataAdapter(s, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd1.DataSource = tb;
            khungtaophieu.Enabled = false;
            total.Enabled = false;
            xemP.Enabled = false;
            xemphieuxuat.Enabled = false;
            tendaily.Enabled=false;
            cn.Close();
            inphieu.Enabled = false;

        }

        private void inphieu_Click(object sender, EventArgs e)
        {
            if (grd2.Rows.Count - 1 > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {


                            PdfPTable pdfTable = new PdfPTable(grd2.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            //add column
                            foreach (DataGridViewColumn column in grd2.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            //add value
                            for (int i = 0; i < grd2.Rows.Count - 1; ++i)
                            {
                                for (int j = 0; j < grd2.Columns.Count; ++j)
                                {
                                    // string s = grd.Rows[i].Cells[j].Value.ToString();
                                    pdfTable.AddCell(grd2.Rows[i].Cells[j].Value.ToString());

                                }
                            }

                            /*
                            foreach (DataGridViewRow row in grd.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }
                            */
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {


                                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(new Paragraph("Phieu xuat kho"));
                                pdfDoc.Add(new Paragraph("So phieu: " + phieuxuattxt.Text + ""));
                                pdfDoc.Add(new Paragraph("Ten Dai ly: " + tendaily.Text + ""));
                                pdfDoc.Add(new Paragraph("\n"));
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Add(new Paragraph("Tong tien chi tra: " + total.Text + ""));
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                            inphieu.Enabled = false;
                            // Application.Run(sfd.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            khungtaophieu.Enabled = false;
            grd2.Rows.Clear();
            phieukhoidtxt.Clear();
            chucnangbox.Enabled = true;
        }

        private void phieukhoidtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void producttxt_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xemP.Enabled = true;
            BindData2();
            chucnangbox.Enabled = false;
        }

        private void xem_phieu_Click(object sender, EventArgs e)
        {

                string s = "select product_name,product_quantity from bill_xuat where billxuat_id = '" + phieutxt.Text + "'";
                data = new SqlDataAdapter(s, cn);
                tb = new DataTable();
                data.Fill(tb);
                grd2.DataSource = tb;

        }

        private void xongP_Click(object sender, EventArgs e)
        {
            xemP.Enabled = false;
            chucnangbox.Enabled = true;
        }

        private void phieutxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void grd2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            xemphieuxuat.Enabled = true;
            BindData3();
            chucnangbox.Enabled = false;
            inphieu.Enabled= true;
        }
        public void BindData3()
        {

            cn.Open();
            string tensanpham = "select distinct maphieumua from phieumua";
            SqlCommand cmd = new SqlCommand(tensanpham, cn);
            SqlDataAdapter da = new SqlDataAdapter(tensanpham, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();

            phieuxuattxt.DisplayMember = "maphieumua";
            phieuxuattxt.ValueMember = "maphieumua";
            phieuxuattxt.DataSource = ds.Tables[0];



            cn.Close();

        }

        private void xongxuat_Click(object sender, EventArgs e)
        {
            xemphieuxuat.Enabled = false;
            chucnangbox.Enabled = true;
        }

        private void xemxuat_Click(object sender, EventArgs e)
        {
            cn.Open();
            string s = "select product_name,product_quantity from phieumua where maphieumua = '" + phieuxuattxt.Text + "'";
            data = new SqlDataAdapter(s, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd2.DataSource = tb;



            string query = "SELECT tenkhachhang FROM phieumua WHERE maphieumua = '"+ phieuxuattxt.Text + "'";
            SqlCommand command = new SqlCommand(query, cn);
            SqlDataReader reader = command.ExecuteReader();

            // Đọc giá trị từ SqlDataReader
            if (reader.Read())
            {
                string value = reader.GetString(0);

                // Đưa giá trị lên TextBox
                tendaily.Text = value;
            }
            reader.Close();
            cn.Close();
        }
    }
}
