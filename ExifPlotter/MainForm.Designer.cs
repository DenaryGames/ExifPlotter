namespace ExifPlotter
{
    partial class MainForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFileTypes = new System.Windows.Forms.ListBox();
            this.chkSubfolders = new System.Windows.Forms.CheckBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFound = new System.Windows.Forms.Label();
            this.lblMissing = new System.Windows.Forms.Label();
            this.lblDuplicates = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboField = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboChart = new System.Windows.Forms.ComboBox();
            this.btnPlot = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 317);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(314, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(314, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbFileTypes);
            this.groupBox1.Controls.Add(this.chkSubfolders);
            this.groupBox1.Controls.Add(this.btnSelectFolder);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 274);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Files";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(9, 239);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(123, 23);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Types:";
            // 
            // lbFileTypes
            // 
            this.lbFileTypes.FormattingEnabled = true;
            this.lbFileTypes.Location = new System.Drawing.Point(9, 99);
            this.lbFileTypes.Name = "lbFileTypes";
            this.lbFileTypes.Size = new System.Drawing.Size(120, 134);
            this.lbFileTypes.TabIndex = 2;
            // 
            // chkSubfolders
            // 
            this.chkSubfolders.AutoSize = true;
            this.chkSubfolders.Location = new System.Drawing.Point(7, 49);
            this.chkSubfolders.Name = "chkSubfolders";
            this.chkSubfolders.Size = new System.Drawing.Size(114, 17);
            this.chkSubfolders.TabIndex = 1;
            this.chkSubfolders.Text = "Include Subfolders";
            this.chkSubfolders.UseVisualStyleBackColor = true;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(6, 20);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(123, 23);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDuplicates);
            this.groupBox2.Controls.Add(this.lblMissing);
            this.groupBox2.Controls.Add(this.lblFound);
            this.groupBox2.Location = new System.Drawing.Point(163, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 76);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // lblFound
            // 
            this.lblFound.AutoSize = true;
            this.lblFound.Location = new System.Drawing.Point(7, 20);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(70, 13);
            this.lblFound.TabIndex = 0;
            this.lblFound.Text = "Files found: 0";
            // 
            // lblMissing
            // 
            this.lblMissing.AutoSize = true;
            this.lblMissing.Location = new System.Drawing.Point(7, 37);
            this.lblMissing.Name = "lblMissing";
            this.lblMissing.Size = new System.Drawing.Size(73, 13);
            this.lblMissing.TabIndex = 1;
            this.lblMissing.Text = "Exif missing: 0";
            // 
            // lblDuplicates
            // 
            this.lblDuplicates.AutoSize = true;
            this.lblDuplicates.Location = new System.Drawing.Point(7, 54);
            this.lblDuplicates.Name = "lblDuplicates";
            this.lblDuplicates.Size = new System.Drawing.Size(69, 13);
            this.lblDuplicates.TabIndex = 2;
            this.lblDuplicates.Text = "Duplicates: 0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPlot);
            this.groupBox3.Controls.Add(this.comboChart);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboField);
            this.groupBox3.Location = new System.Drawing.Point(163, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 191);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Plot";
            // 
            // comboField
            // 
            this.comboField.FormattingEnabled = true;
            this.comboField.Location = new System.Drawing.Point(7, 38);
            this.comboField.Name = "comboField";
            this.comboField.Size = new System.Drawing.Size(121, 21);
            this.comboField.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Field:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chart:";
            // 
            // comboChart
            // 
            this.comboChart.FormattingEnabled = true;
            this.comboChart.Location = new System.Drawing.Point(7, 83);
            this.comboChart.Name = "comboChart";
            this.comboChart.Size = new System.Drawing.Size(121, 21);
            this.comboChart.TabIndex = 3;
            // 
            // btnPlot
            // 
            this.btnPlot.Location = new System.Drawing.Point(7, 156);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(121, 23);
            this.btnPlot.TabIndex = 4;
            this.btnPlot.Text = "Plot!";
            this.btnPlot.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 339);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ExifPlotter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbFileTypes;
        private System.Windows.Forms.CheckBox chkSubfolders;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDuplicates;
        private System.Windows.Forms.Label lblMissing;
        private System.Windows.Forms.Label lblFound;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboChart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboField;
        private System.Windows.Forms.Button btnPlot;
    }
}

