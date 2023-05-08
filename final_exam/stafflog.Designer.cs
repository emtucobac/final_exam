namespace final_exam
{
    partial class stafflog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.khungtaophieu = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.phieukhoidtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amounts = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.producttxt = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inphieu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grd2 = new System.Windows.Forms.DataGridView();
            this.grd1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.xemkho = new System.Windows.Forms.Button();
            this.taophieu = new System.Windows.Forms.Button();
            this.xemP = new System.Windows.Forms.GroupBox();
            this.xongP = new System.Windows.Forms.Button();
            this.xem_phieu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.phieutxt = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.khungtaophieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amounts)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.xemP.SuspendLayout();
            this.SuspendLayout();
            // 
            // khungtaophieu
            // 
            this.khungtaophieu.Controls.Add(this.button1);
            this.khungtaophieu.Controls.Add(this.add);
            this.khungtaophieu.Controls.Add(this.phieukhoidtxt);
            this.khungtaophieu.Controls.Add(this.label3);
            this.khungtaophieu.Controls.Add(this.amounts);
            this.khungtaophieu.Controls.Add(this.label2);
            this.khungtaophieu.Controls.Add(this.label1);
            this.khungtaophieu.Controls.Add(this.producttxt);
            this.khungtaophieu.Location = new System.Drawing.Point(410, 2);
            this.khungtaophieu.Name = "khungtaophieu";
            this.khungtaophieu.Size = new System.Drawing.Size(592, 132);
            this.khungtaophieu.TabIndex = 5;
            this.khungtaophieu.TabStop = false;
            this.khungtaophieu.Text = "Tao Phieu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "xong";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(462, 22);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(95, 37);
            this.add.TabIndex = 6;
            this.add.Text = "Them";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.done_Click);
            // 
            // phieukhoidtxt
            // 
            this.phieukhoidtxt.Location = new System.Drawing.Point(192, 30);
            this.phieukhoidtxt.Name = "phieukhoidtxt";
            this.phieukhoidtxt.Size = new System.Drawing.Size(100, 23);
            this.phieukhoidtxt.TabIndex = 5;
            this.phieukhoidtxt.TextChanged += new System.EventHandler(this.phieukhoidtxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ma phieu nhap kho:";
            // 
            // amounts
            // 
            this.amounts.Location = new System.Drawing.Point(192, 91);
            this.amounts.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.amounts.Name = "amounts";
            this.amounts.Size = new System.Drawing.Size(120, 23);
            this.amounts.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "So luong:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chon san pham:";
            // 
            // producttxt
            // 
            this.producttxt.FormattingEnabled = true;
            this.producttxt.Location = new System.Drawing.Point(192, 59);
            this.producttxt.Name = "producttxt";
            this.producttxt.Size = new System.Drawing.Size(218, 23);
            this.producttxt.TabIndex = 0;
            this.producttxt.SelectedIndexChanged += new System.EventHandler(this.producttxt_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.total);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.inphieu);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.grd2);
            this.groupBox2.Controls.Add(this.grd1);
            this.groupBox2.Location = new System.Drawing.Point(29, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(973, 420);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "bang thong tin";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(671, 372);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(109, 23);
            this.total.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(671, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tong tien nhap kho";
            // 
            // inphieu
            // 
            this.inphieu.Location = new System.Drawing.Point(843, 367);
            this.inphieu.Name = "inphieu";
            this.inphieu.Size = new System.Drawing.Size(95, 30);
            this.inphieu.TabIndex = 7;
            this.inphieu.Text = "in phieu";
            this.inphieu.UseVisualStyleBackColor = true;
            this.inphieu.Click += new System.EventHandler(this.inphieu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phieu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kho";
            // 
            // grd2
            // 
            this.grd2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd2.Location = new System.Drawing.Point(620, 32);
            this.grd2.Name = "grd2";
            this.grd2.RowTemplate.Height = 25;
            this.grd2.Size = new System.Drawing.Size(318, 310);
            this.grd2.TabIndex = 1;
            // 
            // grd1
            // 
            this.grd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd1.Location = new System.Drawing.Point(40, 28);
            this.grd1.Name = "grd1";
            this.grd1.RowTemplate.Height = 25;
            this.grd1.Size = new System.Drawing.Size(531, 379);
            this.grd1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.xemkho);
            this.groupBox1.Controls.Add(this.taophieu);
            this.groupBox1.Location = new System.Drawing.Point(29, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 200);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staff ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xem phieu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // xemkho
            // 
            this.xemkho.Location = new System.Drawing.Point(39, 83);
            this.xemkho.Name = "xemkho";
            this.xemkho.Size = new System.Drawing.Size(280, 49);
            this.xemkho.TabIndex = 1;
            this.xemkho.Text = "Xem kho";
            this.xemkho.UseVisualStyleBackColor = true;
            this.xemkho.Click += new System.EventHandler(this.xemkho_Click);
            // 
            // taophieu
            // 
            this.taophieu.Location = new System.Drawing.Point(39, 28);
            this.taophieu.Name = "taophieu";
            this.taophieu.Size = new System.Drawing.Size(280, 49);
            this.taophieu.TabIndex = 0;
            this.taophieu.Text = "Tao phieu nhap kho";
            this.taophieu.UseVisualStyleBackColor = true;
            this.taophieu.Click += new System.EventHandler(this.taophieu_Click);
            // 
            // xemP
            // 
            this.xemP.Controls.Add(this.xongP);
            this.xemP.Controls.Add(this.xem_phieu);
            this.xemP.Controls.Add(this.label7);
            this.xemP.Controls.Add(this.phieutxt);
            this.xemP.Location = new System.Drawing.Point(410, 140);
            this.xemP.Name = "xemP";
            this.xemP.Size = new System.Drawing.Size(592, 62);
            this.xemP.TabIndex = 6;
            this.xemP.TabStop = false;
            this.xemP.Text = "Xem phieu";
            // 
            // xongP
            // 
            this.xongP.Location = new System.Drawing.Point(488, 14);
            this.xongP.Name = "xongP";
            this.xongP.Size = new System.Drawing.Size(69, 37);
            this.xongP.TabIndex = 9;
            this.xongP.Text = "xong";
            this.xongP.UseVisualStyleBackColor = true;
            this.xongP.Click += new System.EventHandler(this.xongP_Click);
            // 
            // xem_phieu
            // 
            this.xem_phieu.Location = new System.Drawing.Point(412, 14);
            this.xem_phieu.Name = "xem_phieu";
            this.xem_phieu.Size = new System.Drawing.Size(69, 37);
            this.xem_phieu.TabIndex = 8;
            this.xem_phieu.Text = "xem";
            this.xem_phieu.UseVisualStyleBackColor = true;
            this.xem_phieu.Click += new System.EventHandler(this.xem_phieu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Chon phieu:";
            // 
            // phieutxt
            // 
            this.phieutxt.FormattingEnabled = true;
            this.phieutxt.Location = new System.Drawing.Point(94, 22);
            this.phieutxt.Name = "phieutxt";
            this.phieutxt.Size = new System.Drawing.Size(290, 23);
            this.phieutxt.TabIndex = 2;
            this.phieutxt.SelectedIndexChanged += new System.EventHandler(this.phieutxt_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1008, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1008, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "QUIT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // stafflog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 633);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.xemP);
            this.Controls.Add(this.khungtaophieu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stafflog";
            this.Text = "stafflog";
            this.Load += new System.EventHandler(this.stafflog_Load);
            this.khungtaophieu.ResumeLayout(false);
            this.khungtaophieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amounts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.xemP.ResumeLayout(false);
            this.xemP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox khungtaophieu;
        private TextBox phieukhoidtxt;
        private Label label3;
        private NumericUpDown amounts;
        private Label label2;
        private Label label1;
        private ComboBox producttxt;
        private GroupBox groupBox2;
        private DataGridView grd1;
        private GroupBox groupBox1;
        private Button xemkho;
        private Button taophieu;
        private Button add;
        private Button inphieu;
        private Button button1;
        private Label label6;
        private Label label5;
        private DataGridView grd2;
        private TextBox total;
        private Label label4;
        private Button button2;
        private GroupBox xemP;
        private Label label7;
        private ComboBox phieutxt;
        private Button xem_phieu;
        private Button xongP;
        private Button button3;
        private Button button4;
    }
}