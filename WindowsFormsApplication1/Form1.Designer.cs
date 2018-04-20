namespace WindowsFormsApplication1
{
    partial class frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btntaghsim = new System.Windows.Forms.Button();
            this.btnbackspace = new System.Windows.Forms.Button();
            this.btnclearall = new System.Windows.Forms.Button();
            this.btnclearlast = new System.Windows.Forms.Button();
            this.btnzarb = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btntafrigh = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnsum = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnonoff = new System.Windows.Forms.Button();
            this.txtdisplay = new System.Windows.Forms.TextBox();
            this.lblhistory = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topMostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSBProCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btntaghsim);
            this.panel1.Controls.Add(this.btnbackspace);
            this.panel1.Controls.Add(this.btnclearall);
            this.panel1.Controls.Add(this.btnclearlast);
            this.panel1.Controls.Add(this.btnzarb);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btntafrigh);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btnsum);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btncalculate);
            this.panel1.Controls.Add(this.btnpoint);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btnonoff);
            this.panel1.Location = new System.Drawing.Point(3, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 156);
            this.panel1.TabIndex = 0;
            // 
            // btntaghsim
            // 
            this.btntaghsim.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btntaghsim.Location = new System.Drawing.Point(124, 10);
            this.btntaghsim.Name = "btntaghsim";
            this.btntaghsim.Size = new System.Drawing.Size(36, 26);
            this.btntaghsim.TabIndex = 12;
            this.btntaghsim.Text = "/";
            this.btntaghsim.UseVisualStyleBackColor = true;
            this.btntaghsim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operators);
            // 
            // btnbackspace
            // 
            this.btnbackspace.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnbackspace.Location = new System.Drawing.Point(85, 10);
            this.btnbackspace.Name = "btnbackspace";
            this.btnbackspace.Size = new System.Drawing.Size(36, 26);
            this.btnbackspace.TabIndex = 17;
            this.btnbackspace.Text = "B";
            this.btnbackspace.UseVisualStyleBackColor = true;
            this.btnbackspace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnbackspace_Click);
            // 
            // btnclearall
            // 
            this.btnclearall.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnclearall.Location = new System.Drawing.Point(46, 10);
            this.btnclearall.Name = "btnclearall";
            this.btnclearall.Size = new System.Drawing.Size(36, 26);
            this.btnclearall.TabIndex = 19;
            this.btnclearall.Text = "C";
            this.btnclearall.UseVisualStyleBackColor = true;
            this.btnclearall.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnclearall_Click);
            // 
            // btnclearlast
            // 
            this.btnclearlast.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnclearlast.Location = new System.Drawing.Point(7, 10);
            this.btnclearlast.Name = "btnclearlast";
            this.btnclearlast.Size = new System.Drawing.Size(36, 26);
            this.btnclearlast.TabIndex = 18;
            this.btnclearlast.Text = "&CE";
            this.btnclearlast.UseVisualStyleBackColor = true;
            this.btnclearlast.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnclearlast_Click);
            // 
            // btnzarb
            // 
            this.btnzarb.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnzarb.Location = new System.Drawing.Point(124, 39);
            this.btnzarb.Name = "btnzarb";
            this.btnzarb.Size = new System.Drawing.Size(36, 26);
            this.btnzarb.TabIndex = 13;
            this.btnzarb.Text = "*";
            this.btnzarb.UseVisualStyleBackColor = true;
            this.btnzarb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operators);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn9.Location = new System.Drawing.Point(85, 39);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(36, 26);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn8.Location = new System.Drawing.Point(46, 39);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(36, 26);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn7.Location = new System.Drawing.Point(7, 39);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(36, 26);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btntafrigh
            // 
            this.btntafrigh.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btntafrigh.Location = new System.Drawing.Point(124, 68);
            this.btntafrigh.Name = "btntafrigh";
            this.btntafrigh.Size = new System.Drawing.Size(36, 26);
            this.btntafrigh.TabIndex = 14;
            this.btntafrigh.Text = "-";
            this.btntafrigh.UseVisualStyleBackColor = true;
            this.btntafrigh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operators);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn6.Location = new System.Drawing.Point(85, 68);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(36, 26);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn5.Location = new System.Drawing.Point(46, 68);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(36, 26);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn4.Location = new System.Drawing.Point(7, 68);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(36, 26);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btnsum
            // 
            this.btnsum.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnsum.Location = new System.Drawing.Point(124, 97);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(36, 26);
            this.btnsum.TabIndex = 15;
            this.btnsum.Text = "+";
            this.btnsum.UseVisualStyleBackColor = true;
            this.btnsum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Operators);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn3.Location = new System.Drawing.Point(85, 97);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(36, 26);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn2.Location = new System.Drawing.Point(46, 97);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(36, 26);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn1.Location = new System.Drawing.Point(7, 97);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(36, 26);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btncalculate.Location = new System.Drawing.Point(124, 126);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(36, 26);
            this.btncalculate.TabIndex = 16;
            this.btncalculate.Text = "=";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btncalculate_Click);
            // 
            // btnpoint
            // 
            this.btnpoint.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnpoint.Location = new System.Drawing.Point(85, 126);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(36, 26);
            this.btnpoint.TabIndex = 11;
            this.btnpoint.Text = ".";
            this.btnpoint.UseVisualStyleBackColor = true;
            this.btnpoint.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn0.Location = new System.Drawing.Point(46, 126);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(36, 26);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btnonoff
            // 
            this.btnonoff.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnonoff.Location = new System.Drawing.Point(7, 126);
            this.btnonoff.Name = "btnonoff";
            this.btnonoff.Size = new System.Drawing.Size(36, 26);
            this.btnonoff.TabIndex = 0;
            this.btnonoff.Text = "On";
            this.btnonoff.UseVisualStyleBackColor = true;
            this.btnonoff.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnonoff_Click);
            // 
            // txtdisplay
            // 
            this.txtdisplay.BackColor = System.Drawing.Color.AliceBlue;
            this.txtdisplay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdisplay.Location = new System.Drawing.Point(10, 30);
            this.txtdisplay.Multiline = true;
            this.txtdisplay.Name = "txtdisplay";
            this.txtdisplay.ReadOnly = true;
            this.txtdisplay.Size = new System.Drawing.Size(153, 45);
            this.txtdisplay.TabIndex = 2;
            this.txtdisplay.Click += new System.EventHandler(this.txtdisplay_Click);
            this.txtdisplay.TabIndexChanged += new System.EventHandler(this.txtdisplay_TabIndexChanged);
            this.txtdisplay.TextChanged += new System.EventHandler(this.txtdisplay_TextChanged);
            this.txtdisplay.Enter += new System.EventHandler(this.txtdisplay_Enter);
            // 
            // lblhistory
            // 
            this.lblhistory.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblhistory.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblhistory.Location = new System.Drawing.Point(10, 80);
            this.lblhistory.Name = "lblhistory";
            this.lblhistory.Size = new System.Drawing.Size(153, 35);
            this.lblhistory.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(173, 22);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topMostToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 18);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // topMostToolStripMenuItem
            // 
            this.topMostToolStripMenuItem.Name = "topMostToolStripMenuItem";
            this.topMostToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.topMostToolStripMenuItem.Text = "Top Most";
            this.topMostToolStripMenuItem.Click += new System.EventHandler(this.topMostToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyResultToolStripMenuItem,
            this.copyHistoryToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 18);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyResultToolStripMenuItem
            // 
            this.copyResultToolStripMenuItem.Name = "copyResultToolStripMenuItem";
            this.copyResultToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyResultToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.copyResultToolStripMenuItem.Text = "Copy Result";
            this.copyResultToolStripMenuItem.Click += new System.EventHandler(this.copyResultToolStripMenuItem_Click);
            // 
            // copyHistoryToolStripMenuItem
            // 
            this.copyHistoryToolStripMenuItem.Name = "copyHistoryToolStripMenuItem";
            this.copyHistoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.copyHistoryToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.copyHistoryToolStripMenuItem.Text = "Copy History";
            this.copyHistoryToolStripMenuItem.Click += new System.EventHandler(this.copyHistoryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSBProCalculatorToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 18);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutSBProCalculatorToolStripMenuItem
            // 
            this.aboutSBProCalculatorToolStripMenuItem.Name = "aboutSBProCalculatorToolStripMenuItem";
            this.aboutSBProCalculatorToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.aboutSBProCalculatorToolStripMenuItem.Text = "About SBPro Calculator";
            this.aboutSBProCalculatorToolStripMenuItem.Click += new System.EventHandler(this.aboutSBProCalculatorToolStripMenuItem_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(173, 271);
            this.Controls.Add(this.lblhistory);
            this.Controls.Add(this.txtdisplay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmmain";
            this.Text = "myCalc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmmain_FormClosed);
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmmain_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmmain_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmmain_KeyUp);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btntaghsim;
        private System.Windows.Forms.Button btnbackspace;
        private System.Windows.Forms.Button btnclearall;
        private System.Windows.Forms.Button btnclearlast;
        private System.Windows.Forms.Button btnzarb;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btntafrigh;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnpoint;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnonoff;
        private System.Windows.Forms.TextBox txtdisplay;
        private System.Windows.Forms.Label lblhistory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSBProCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topMostToolStripMenuItem;
    }
}

