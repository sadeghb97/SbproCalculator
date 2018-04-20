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
    public partial class frmmain : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        double x, y, z;
        string op, history;
        Boolean flag, operatorflag,endflag;
        private void Numbers(object sender, MouseEventArgs e)
        {
            if (op == "")
            {
                if (endflag == true)
                {
                    lblhistory.Text = "";
                    txtdisplay.Text = "";
                    txtdisplay.Text += ((Control)sender).Text;
                    endflag = false;
                }
                else
                {
                    txtdisplay.Text += ((Control)sender).Text;
                }
            }
            else
            {
                if (operatorflag == true)
                {
                    flag = true;
                    operatorflag = false;
                    history += op;
                    txtdisplay.Text = "";
                    txtdisplay.Text += ((Control)sender).Text;
                }
                else
                {
                    txtdisplay.Text += ((Control)sender).Text;
                }
            }

            txtdisplay_Enter(null, null);
        }

        private void btnclearlast_Click(object sender, MouseEventArgs e)
        {
            txtdisplay.Text = "";
            txtdisplay_Enter(null, null);
        }

        private void btnbackspace_Click(object sender, MouseEventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text.Substring(0, txtdisplay.Text.Length - 1);
            txtdisplay_Enter(null, null);
        }

        private void txtdisplay_TextChanged(object sender, EventArgs e)
        {
            btnpoint.Enabled = !txtdisplay.Text.Contains(".");
            btnbackspace.Enabled = Convert.ToBoolean(txtdisplay.Text.Length);
            btncalculate.Enabled = flag;
            if (operatorflag == true) btncalculate.Enabled = false;
            if (endflag == true) btnbackspace.Enabled = false;
             
        }

        private void btnonoff_Click(object sender, MouseEventArgs e)
        {
            if (((Control)sender).Text == "On")
            {
                btnclearall_Click(null, null);
                txtdisplay.Enabled = false;
                lblhistory.Enabled = false;
                foreach (Control c in panel1.Controls) if (!c.Equals((Control)sender)) c.Enabled = false;
                ((Control)sender).Text = "Off";
            }
            else
            {
                txtdisplay.Enabled = true;
                lblhistory.Enabled = true;
                foreach (Control c in panel1.Controls) c.Enabled = true;
                ((Control)sender).Text = "On";
                frmmain_Load(null, null);
            }
            txtdisplay_Enter(null, null);
        }

        private void txtdisplay_TabIndexChanged(object sender, EventArgs e)
        {
            txtdisplay.Focus();
            txtdisplay.DeselectAll();
            HideCaret(txtdisplay.Handle);
            MessageBox.Show("Sadegh");
        }

        private void frmmain_KeyPress(object sender, KeyPressEventArgs e)
        {
            Button temp = new Button();
            temp.Text = e.KeyChar.ToString();
            if (e.KeyChar <= '9' & e.KeyChar >= '0') Numbers(temp, null);
            else if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/') Operators(temp, null);
            else if (e.KeyChar == '.' && btnpoint.Enabled) Numbers(temp, null);
            else if (e.KeyChar == '\b' && btnbackspace.Enabled) btnbackspace_Click(null, null);
            else if (e.KeyChar == '=' &&  btncalculate.Enabled) btncalculate_Click(null, null);
        }

        private void frmmain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) btnclearlast_Click(null, null);
        }

        private void frmmain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btncalculate.Enabled) btncalculate_Click(null, null);
        }

        private void txtdisplay_Enter(object sender, EventArgs e)
        {
            if (txtdisplay.SelectionLength <= 0)
            {
                this.ActiveControl = lblhistory;
            }
        }

        private void txtdisplay_Click(object sender, EventArgs e)
        {
            txtdisplay_Enter(null, null);
        }

        private void aboutSBProCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm frmAbout = new aboutForm();
            frmAbout.StartPosition = FormStartPosition.Manual;
            frmAbout.Left = this.Location.X + (this.Size.Width - frmAbout.Size.Width) / 2;
            frmAbout.Top = this.Location.Y + (this.Size.Height - frmAbout.Size.Height) / 2;
            frmAbout.ShowDialog(this);
        }

        private void copyResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text.Length > 0) Clipboard.SetText(txtdisplay.Text);
        }

        private void copyHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblhistory.Text.Length > 0) Clipboard.SetText(lblhistory.Text);
        }

        private void topMostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            topMostToolStripMenuItem.Checked = !topMostToolStripMenuItem.Checked;
            if (topMostToolStripMenuItem.Checked) this.TopMost = true;
            else this.TopMost = false;
        }

        private void frmmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            WindowsFormsApplication1.Properties.Settings.Default.formx = this.Location.X;
            WindowsFormsApplication1.Properties.Settings.Default.formy = this.Location.Y;
            WindowsFormsApplication1.Properties.Settings.Default.topmost = this.TopMost;
            WindowsFormsApplication1.Properties.Settings.Default.Save();
        }

        private void btncalculate_Click(object sender, MouseEventArgs e)
        {
            if (txtdisplay.Text == "" || txtdisplay.Text == ".") y = 0; else y = Convert.ToDouble(txtdisplay.Text);
            switch (op)
            {
                case "+": z = x + y; break;
                case "-": z = x - y; break;
                case "*": z = x * y; break;
                case "/": z = x / y; break;
                case "": z = x; break;
            }
            z = Math.Round(z,6);

            endflag = true;
            txtdisplay.Text = z.ToString();
            lblhistory.Text = history + y.ToString()+ "=" + z.ToString();
            x = 0; y = 0; z = 0;
            op = ""; history = "";
            btncalculate.Enabled = false;
            flag = false; operatorflag = false;

            txtdisplay_Enter(null, null);
        }

        private void btnclearall_Click(object sender, MouseEventArgs e)
        {
            x = 0; y = 0; z = 0;
            op = "";
            txtdisplay.Text = "";
            lblhistory.Text = "";
            flag = false;
            operatorflag = false;
            endflag = false;

            txtdisplay_Enter(null, null);
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            if (WindowsFormsApplication1.Properties.Settings.Default.formx == -1)
                this.DesktopLocation = new Point(Screen.PrimaryScreen.Bounds.Width - 500, 80);
            else
                this.DesktopLocation = new Point(WindowsFormsApplication1.Properties.Settings.Default.formx, WindowsFormsApplication1.Properties.Settings.Default.formy);

            this.TopMost = WindowsFormsApplication1.Properties.Settings.Default.topmost;
            topMostToolStripMenuItem.Checked = this.TopMost;

            btnclearall_Click(null, null);
            txtdisplay_TextChanged(null, null);
            this.ActiveControl = lblhistory;
        }

        private void Operators(object sender, MouseEventArgs e)
        {
            if (flag == false)
            {
                endflag = false;
                if (txtdisplay.Text == "" || txtdisplay.Text == ".")
                {
                    x = 0;
                    txtdisplay.Text = "0";
                }
                else x = Convert.ToDouble(txtdisplay.Text);
                op = ((Control)sender).Text;
                if (operatorflag == false)
                {
                    history = x.ToString();
                    lblhistory.Text = history+op;
                    operatorflag = true;
                }
                else
                {
                    lblhistory.Text = history + op;
                    operatorflag = true;
                }
            }
            else {
                if (operatorflag == false)
                {
                    if (txtdisplay.Text == ".") y = 0; else y = Convert.ToDouble(txtdisplay.Text);
                    switch (op)
                    {
                        case "+": z = x + y; break;
                        case "-": z = x - y; break;
                        case "*": z = x * y; break;
                        case "/": z = x / y; break;
                    }
                    op = ((Control)sender).Text;
                    operatorflag = true;
                    txtdisplay.Text = z.ToString();
                    history = history + y.ToString();
                    lblhistory.Text = history + op;
                    x = z;
                    btnbackspace.Enabled = false;
                }
                else {
                    op = ((Control)sender).Text;
                    txtdisplay.Text = z.ToString();
                    lblhistory.Text = history + op;
                    x = z;
                    btnbackspace.Enabled = false;
                }
            }

            txtdisplay_Enter(null, null);
        }
        public frmmain()
        {
            InitializeComponent();
        }
    }
}
