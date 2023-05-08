using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace final_exam
{
    public partial class username : Form
    {
        public username()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dataToPass = user.Text;
            cuslog nextForm = new cuslog(user.Text);


            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
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
