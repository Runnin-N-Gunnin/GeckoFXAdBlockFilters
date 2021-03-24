namespace GeckoAdBlock
{
    partial class GeckoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeckoForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.btnFwd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtUrl = new System.Windows.Forms.ToolStripTextBox();
            this.btnNavigate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblNumOfDomains = new System.Windows.Forms.ToolStripLabel();
            this.lblNumOfFltLists = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panelWB = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTxtBoxConsole = new System.Windows.Forms.RichTextBox();
            this.grpBoxBlocked = new System.Windows.Forms.GroupBox();
            this.lstViewBlocked = new System.Windows.Forms.ListView();
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListAB = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpBoxBlocked.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnFwd,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.txtUrl,
            this.btnNavigate,
            this.toolStripSeparator3,
            this.lblNumOfDomains,
            this.toolStripSeparator1,
            this.lblNumOfFltLists,
            this.toolStripLabel5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1208, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = false;
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack.Image = global::GeckoAdBlock.Properties.Resources.back;
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 22);
            this.btnBack.Text = "toolStripButton2";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFwd
            // 
            this.btnFwd.AutoSize = false;
            this.btnFwd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFwd.Image = global::GeckoAdBlock.Properties.Resources.fwd;
            this.btnFwd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFwd.Name = "btnFwd";
            this.btnFwd.Size = new System.Drawing.Size(29, 22);
            this.btnFwd.Text = "toolStripButton3";
            this.btnFwd.Click += new System.EventHandler(this.btnFwd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel1.Text = "URL:";
            // 
            // txtUrl
            // 
            this.txtUrl.AutoSize = false;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(220, 25);
            this.txtUrl.Text = "https://adblock-tester.com/";
            // 
            // btnNavigate
            // 
            this.btnNavigate.AutoSize = false;
            this.btnNavigate.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnNavigate.Image = global::GeckoAdBlock.Properties.Resources.nav;
            this.btnNavigate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNavigate.Name = "btnNavigate";
            this.btnNavigate.Size = new System.Drawing.Size(54, 22);
            this.btnNavigate.Text = "Go";
            this.btnNavigate.Click += new System.EventHandler(this.btnNavigate_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(32, 25);
            // 
            // lblNumOfDomains
            // 
            this.lblNumOfDomains.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblNumOfDomains.AutoSize = false;
            this.lblNumOfDomains.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNumOfDomains.Name = "lblNumOfDomains";
            this.lblNumOfDomains.Size = new System.Drawing.Size(84, 22);
            this.lblNumOfDomains.Text = "Domains: 0";
            // 
            // lblNumOfFltLists
            // 
            this.lblNumOfFltLists.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblNumOfFltLists.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNumOfFltLists.Name = "lblNumOfFltLists";
            this.lblNumOfFltLists.Size = new System.Drawing.Size(41, 22);
            this.lblNumOfFltLists.Text = "Lists: 0";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.AutoSize = false;
            this.toolStripLabel5.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Underline);
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabel5.Text = "Filters";
            this.toolStripLabel5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1208, 742);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GeckoFX v60.0.54.0";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 16);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panelWB);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(1202, 723);
            this.splitContainer2.SplitterDistance = 575;
            this.splitContainer2.TabIndex = 10;
            // 
            // panelWB
            // 
            this.panelWB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWB.Location = new System.Drawing.Point(0, 0);
            this.panelWB.Name = "panelWB";
            this.panelWB.Size = new System.Drawing.Size(1202, 575);
            this.panelWB.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpBoxBlocked);
            this.splitContainer1.Size = new System.Drawing.Size(1202, 144);
            this.splitContainer1.SplitterDistance = 525;
            this.splitContainer1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTxtBoxConsole);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 144);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Console";
            // 
            // richTxtBoxConsole
            // 
            this.richTxtBoxConsole.BackColor = System.Drawing.Color.Black;
            this.richTxtBoxConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTxtBoxConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtBoxConsole.ForeColor = System.Drawing.SystemColors.Info;
            this.richTxtBoxConsole.Location = new System.Drawing.Point(3, 16);
            this.richTxtBoxConsole.Name = "richTxtBoxConsole";
            this.richTxtBoxConsole.Size = new System.Drawing.Size(519, 125);
            this.richTxtBoxConsole.TabIndex = 0;
            this.richTxtBoxConsole.Text = "";
            this.richTxtBoxConsole.WordWrap = false;
            // 
            // grpBoxBlocked
            // 
            this.grpBoxBlocked.Controls.Add(this.lstViewBlocked);
            this.grpBoxBlocked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxBlocked.Location = new System.Drawing.Point(0, 0);
            this.grpBoxBlocked.Name = "grpBoxBlocked";
            this.grpBoxBlocked.Size = new System.Drawing.Size(673, 144);
            this.grpBoxBlocked.TabIndex = 0;
            this.grpBoxBlocked.TabStop = false;
            this.grpBoxBlocked.Text = "Blocked Domain(s): 0";
            // 
            // lstViewBlocked
            // 
            this.lstViewBlocked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstViewBlocked.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader});
            this.lstViewBlocked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewBlocked.GridLines = true;
            this.lstViewBlocked.HideSelection = false;
            this.lstViewBlocked.LabelWrap = false;
            this.lstViewBlocked.Location = new System.Drawing.Point(3, 16);
            this.lstViewBlocked.MultiSelect = false;
            this.lstViewBlocked.Name = "lstViewBlocked";
            this.lstViewBlocked.Size = new System.Drawing.Size(667, 125);
            this.lstViewBlocked.SmallImageList = this.imageListAB;
            this.lstViewBlocked.TabIndex = 0;
            this.lstViewBlocked.UseCompatibleStateImageBehavior = false;
            this.lstViewBlocked.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "URL";
            this.columnHeader.Width = 638;
            // 
            // imageListAB
            // 
            this.imageListAB.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAB.ImageStream")));
            this.imageListAB.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAB.Images.SetKeyName(0, "ip_block.png");
            // 
            // GeckoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 767);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "GeckoForm";
            this.Text = "GeckoAdBlock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeckoForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grpBoxBlocked.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtUrl;
        private System.Windows.Forms.ToolStripButton btnNavigate;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripButton btnFwd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lblNumOfFltLists;
        private System.Windows.Forms.ToolStripLabel lblNumOfDomains;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTxtBoxConsole;
        private System.Windows.Forms.Panel panelWB;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpBoxBlocked;
        private System.Windows.Forms.ListView lstViewBlocked;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.ImageList imageListAB;
    }
}

