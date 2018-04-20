using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sbpro.ir");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = button1;
        }
    }
}
