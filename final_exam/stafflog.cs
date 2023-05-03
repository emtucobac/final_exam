using System;
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
            

        }

        private void done_Click(object sender, EventArgs e)
        {
            
            cn.Open();

            grd2.Rows.Add(producttxt.Text, amounts.Text);

            // Chuyển giá trị mới từ string sang int
            int newQuantity = int.Parse(amounts.Text);

            // Lưu giá trị mới vào cơ sở dữ liệu 
            SqlCommand cmdUpdate = new SqlCommand("UPDATE category SET Category_Quantity = (@newQuantity + Category_Quantity) WHERE Category_Name = @categoryname", cn);
           
            cmdUpdate.Parameters.AddWithValue("@newQuantity", newQuantity);
            cmdUpdate.Parameters.AddWithValue("@categoryname", producttxt.Text);
            cmdUpdate.ExecuteNonQuery();
            

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
            cn.Close();

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
                                pdfDoc.Add(new Paragraph("Phieu Nhap kho Hang Hoa"));
                                pdfDoc.Add(new Paragraph("So phieu + '" + phieukhoidtxt.Text + "'"));
                                pdfDoc.Add(new Paragraph("\n"));
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
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
        }

        private void phieukhoidtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void producttxt_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
