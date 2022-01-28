namespace DataFeatures
{
    partial class Form1
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
            this.HomeSC = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControlSC = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.ucRead1 = new DataFeatures.ucRead();
            this.ucCalculate1 = new DataFeatures.ucCalculate();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.HomeSC)).BeginInit();
            this.HomeSC.Panel1.SuspendLayout();
            this.HomeSC.Panel2.SuspendLayout();
            this.HomeSC.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlSC)).BeginInit();
            this.TabControlSC.Panel1.SuspendLayout();
            this.TabControlSC.Panel2.SuspendLayout();
            this.TabControlSC.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeSC
            // 
            this.HomeSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeSC.Location = new System.Drawing.Point(0, 0);
            this.HomeSC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HomeSC.Name = "HomeSC";
            this.HomeSC.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // HomeSC.Panel1
            // 
            this.HomeSC.Panel1.Controls.Add(this.menuStrip1);
            // 
            // HomeSC.Panel2
            // 
            this.HomeSC.Panel2.Controls.Add(this.TabControlSC);
            this.HomeSC.Size = new System.Drawing.Size(1344, 661);
            this.HomeSC.SplitterDistance = 30;
            this.HomeSC.SplitterWidth = 5;
            this.HomeSC.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.schedulerToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1344, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // schedulerToolStripMenuItem
            // 
            this.schedulerToolStripMenuItem.Name = "schedulerToolStripMenuItem";
            this.schedulerToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.schedulerToolStripMenuItem.Text = "Scheduler";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // TabControlSC
            // 
            this.TabControlSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlSC.Location = new System.Drawing.Point(0, 0);
            this.TabControlSC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabControlSC.Name = "TabControlSC";
            this.TabControlSC.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // TabControlSC.Panel1
            // 
            this.TabControlSC.Panel1.Controls.Add(this.tabControl1);
            // 
            // TabControlSC.Panel2
            // 
            this.TabControlSC.Panel2.Controls.Add(this.button1);
            this.TabControlSC.Size = new System.Drawing.Size(1344, 626);
            this.TabControlSC.SplitterDistance = 556;
            this.TabControlSC.SplitterWidth = 5;
            this.TabControlSC.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1344, 556);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucRead1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1336, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Read";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucCalculate1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1336, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calculate";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1228, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucRead1
            // 
            this.ucRead1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRead1.Location = new System.Drawing.Point(4, 4);
            this.ucRead1.Margin = new System.Windows.Forms.Padding(5);
            this.ucRead1.MinimumSize = new System.Drawing.Size(133, 62);
            this.ucRead1.Name = "ucRead1";
            this.ucRead1.Size = new System.Drawing.Size(1328, 519);
            this.ucRead1.TabIndex = 0;
            // 
            // ucCalculate1
            // 
            this.ucCalculate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCalculate1.Location = new System.Drawing.Point(4, 4);
            this.ucCalculate1.Margin = new System.Windows.Forms.Padding(5);
            this.ucCalculate1.MinimumSize = new System.Drawing.Size(133, 62);
            this.ucCalculate1.Name = "ucCalculate1";
            this.ucCalculate1.Size = new System.Drawing.Size(1328, 519);
            this.ucCalculate1.TabIndex = 0;
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 661);
            this.Controls.Add(this.HomeSC);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(661, 358);
            this.Name = "Form1";
            this.Text = "Data Deatures";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.HomeSC.Panel1.ResumeLayout(false);
            this.HomeSC.Panel1.PerformLayout();
            this.HomeSC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeSC)).EndInit();
            this.HomeSC.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabControlSC.Panel1.ResumeLayout(false);
            this.TabControlSC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabControlSC)).EndInit();
            this.TabControlSC.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer HomeSC;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer TabControlSC;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private ucRead ucRead1;
        private ucCalculate ucCalculate1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

