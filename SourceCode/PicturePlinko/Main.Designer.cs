namespace PicturePlinko
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabDataInput = new System.Windows.Forms.TabPage();
            this.txtTargetDirectory = new System.Windows.Forms.TextBox();
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.btnSourceDirectory = new System.Windows.Forms.Button();
            this.btnTargetDirectory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.lnkOpenLog = new System.Windows.Forms.LinkLabel();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.folderSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.tabMain.SuspendLayout();
            this.tabDataInput.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabDataInput);
            this.tabMain.Controls.Add(this.tabLog);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1078, 282);
            this.tabMain.TabIndex = 13;
            // 
            // tabDataInput
            // 
            this.tabDataInput.Controls.Add(this.txtTargetDirectory);
            this.tabDataInput.Controls.Add(this.txtSourceDirectory);
            this.tabDataInput.Controls.Add(this.btnSourceDirectory);
            this.tabDataInput.Controls.Add(this.btnTargetDirectory);
            this.tabDataInput.Controls.Add(this.label1);
            this.tabDataInput.Location = new System.Drawing.Point(4, 22);
            this.tabDataInput.Name = "tabDataInput";
            this.tabDataInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabDataInput.Size = new System.Drawing.Size(1070, 256);
            this.tabDataInput.TabIndex = 0;
            this.tabDataInput.Text = "Input";
            this.tabDataInput.UseVisualStyleBackColor = true;
            // 
            // txtTargetDirectory
            // 
            this.txtTargetDirectory.Location = new System.Drawing.Point(62, 115);
            this.txtTargetDirectory.Name = "txtTargetDirectory";
            this.txtTargetDirectory.Size = new System.Drawing.Size(445, 20);
            this.txtTargetDirectory.TabIndex = 4;
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Location = new System.Drawing.Point(62, 68);
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.Size = new System.Drawing.Size(445, 20);
            this.txtSourceDirectory.TabIndex = 3;
            // 
            // btnSourceDirectory
            // 
            this.btnSourceDirectory.Location = new System.Drawing.Point(513, 66);
            this.btnSourceDirectory.Name = "btnSourceDirectory";
            this.btnSourceDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnSourceDirectory.TabIndex = 2;
            this.btnSourceDirectory.Text = "&Source Directory";
            this.btnSourceDirectory.UseVisualStyleBackColor = true;
            this.btnSourceDirectory.Click += new System.EventHandler(this.btnSourceDirectory_Click);
            // 
            // btnTargetDirectory
            // 
            this.btnTargetDirectory.Location = new System.Drawing.Point(513, 115);
            this.btnTargetDirectory.Name = "btnTargetDirectory";
            this.btnTargetDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnTargetDirectory.TabIndex = 1;
            this.btnTargetDirectory.Text = "&Target Directory";
            this.btnTargetDirectory.UseVisualStyleBackColor = true;
            this.btnTargetDirectory.Click += new System.EventHandler(this.btnTargetDirectory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Picture Plinko will copy files from a target directory into a source directory.  " +
    "Files will be reorganized by file date, group by year and quarter.";
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.lnkOpenLog);
            this.tabLog.Controls.Add(this.txtLog);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Size = new System.Drawing.Size(712, 256);
            this.tabLog.TabIndex = 2;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // lnkOpenLog
            // 
            this.lnkOpenLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkOpenLog.AutoSize = true;
            this.lnkOpenLog.Location = new System.Drawing.Point(659, 0);
            this.lnkOpenLog.Name = "lnkOpenLog";
            this.lnkOpenLog.Size = new System.Drawing.Size(44, 13);
            this.lnkOpenLog.TabIndex = 16;
            this.lnkOpenLog.TabStop = true;
            this.lnkOpenLog.Text = "Log File";
            this.lnkOpenLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(3, 16);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(706, 237);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            this.txtLog.WordWrap = false;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(921, 300);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 14;
            this.btnRun.Text = "&Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1002, 300);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1102, 340);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(760, 378);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Plinko";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabMain.ResumeLayout(false);
            this.tabDataInput.ResumeLayout(false);
            this.tabDataInput.PerformLayout();
            this.tabLog.ResumeLayout(false);
            this.tabLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabDataInput;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lnkOpenLog;
        private System.Windows.Forms.TextBox txtTargetDirectory;
        private System.Windows.Forms.TextBox txtSourceDirectory;
        private System.Windows.Forms.Button btnSourceDirectory;
        private System.Windows.Forms.Button btnTargetDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderSelector;


    }
}

