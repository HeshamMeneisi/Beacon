namespace Beacon
{
    partial class mainFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.broad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ssidT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keyT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.halt = new System.Windows.Forms.Button();
            this.hoe_cb = new System.Windows.Forms.CheckBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.notiIco = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContMen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.broadContMen = new System.Windows.Forms.ToolStripMenuItem();
            this.haltContMen = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayContMen.SuspendLayout();
            this.SuspendLayout();
            // 
            // broad
            // 
            this.broad.Location = new System.Drawing.Point(21, 82);
            this.broad.Name = "broad";
            this.broad.Size = new System.Drawing.Size(75, 23);
            this.broad.TabIndex = 0;
            this.broad.Text = "Broadcast";
            this.broad.UseVisualStyleBackColor = true;
            this.broad.Click += new System.EventHandler(this.broad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SSID";
            // 
            // ssidT
            // 
            this.ssidT.Location = new System.Drawing.Point(50, 6);
            this.ssidT.Name = "ssidT";
            this.ssidT.Size = new System.Drawing.Size(138, 20);
            this.ssidT.TabIndex = 2;
            this.ssidT.Text = "Beacon";
            this.ssidT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ssidT_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key";
            // 
            // keyT
            // 
            this.keyT.Location = new System.Drawing.Point(50, 31);
            this.keyT.Name = "keyT";
            this.keyT.Size = new System.Drawing.Size(138, 20);
            this.keyT.TabIndex = 2;
            this.keyT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ssidT_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "8 to 64 ASCI letters.";
            // 
            // halt
            // 
            this.halt.Enabled = false;
            this.halt.Location = new System.Drawing.Point(102, 82);
            this.halt.Name = "halt";
            this.halt.Size = new System.Drawing.Size(75, 23);
            this.halt.TabIndex = 0;
            this.halt.Text = "Halt";
            this.halt.UseVisualStyleBackColor = true;
            this.halt.Click += new System.EventHandler(this.halt_Click);
            // 
            // hoe_cb
            // 
            this.hoe_cb.AutoSize = true;
            this.hoe_cb.Location = new System.Drawing.Point(12, 115);
            this.hoe_cb.Name = "hoe_cb";
            this.hoe_cb.Size = new System.Drawing.Size(79, 17);
            this.hoe_cb.TabIndex = 3;
            this.hoe_cb.Text = "Halt on exit";
            this.hoe_cb.UseVisualStyleBackColor = true;
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(161, 115);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(34, 21);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // notiIco
            // 
            this.notiIco.ContextMenuStrip = this.trayContMen;
            this.notiIco.Icon = ((System.Drawing.Icon)(resources.GetObject("notiIco.Icon")));
            this.notiIco.Text = "Beacon";
            this.notiIco.Visible = true;
            this.notiIco.BalloonTipClicked += new System.EventHandler(this.notiIco_BalloonTipClicked);
            this.notiIco.Click += new System.EventHandler(this.notiIco_Click);
            this.notiIco.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notiIco_MouseDown);
            // 
            // trayContMen
            // 
            this.trayContMen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.broadContMen,
            this.haltContMen,
            this.exitToolStripMenuItem});
            this.trayContMen.Name = "trayContMen";
            this.trayContMen.ShowImageMargin = false;
            this.trayContMen.Size = new System.Drawing.Size(102, 70);
            // 
            // broadContMen
            // 
            this.broadContMen.Name = "broadContMen";
            this.broadContMen.Size = new System.Drawing.Size(101, 22);
            this.broadContMen.Text = "Broadcast";
            this.broadContMen.Click += new System.EventHandler(this.broad_Click);
            // 
            // haltContMen
            // 
            this.haltContMen.Enabled = false;
            this.haltContMen.Name = "haltContMen";
            this.haltContMen.Size = new System.Drawing.Size(101, 22);
            this.haltContMen.Text = "Halt";
            this.haltContMen.Click += new System.EventHandler(this.halt_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 138);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.hoe_cb);
            this.Controls.Add(this.keyT);
            this.Controls.Add(this.ssidT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.halt);
            this.Controls.Add(this.broad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beacon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.trayContMen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button broad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ssidT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button halt;
        private System.Windows.Forms.CheckBox hoe_cb;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.NotifyIcon notiIco;
        private System.Windows.Forms.ContextMenuStrip trayContMen;
        private System.Windows.Forms.ToolStripMenuItem broadContMen;
        private System.Windows.Forms.ToolStripMenuItem haltContMen;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

