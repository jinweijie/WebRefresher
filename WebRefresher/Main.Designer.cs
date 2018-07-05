namespace WebRefresher
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lUrl = new System.Windows.Forms.Label();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.lInterval = new System.Windows.Forms.Label();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.gbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(133, 33);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(477, 22);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "https://en.wikipedia.org/wiki/Glenn_Gould";
            // 
            // lUrl
            // 
            this.lUrl.AutoSize = true;
            this.lUrl.Location = new System.Drawing.Point(94, 36);
            this.lUrl.Name = "lUrl";
            this.lUrl.Size = new System.Drawing.Size(30, 17);
            this.lUrl.TabIndex = 1;
            this.lUrl.Text = "Url:";
            // 
            // gbSettings
            // 
            this.gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSettings.Controls.Add(this.btnStop);
            this.gbSettings.Controls.Add(this.btnStart);
            this.gbSettings.Controls.Add(this.txtInterval);
            this.gbSettings.Controls.Add(this.lInterval);
            this.gbSettings.Controls.Add(this.txtUrl);
            this.gbSettings.Controls.Add(this.lUrl);
            this.gbSettings.Location = new System.Drawing.Point(12, 12);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(1204, 107);
            this.gbSettings.TabIndex = 2;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(724, 34);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 49);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(634, 33);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 50);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(133, 63);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(477, 22);
            this.txtInterval.TabIndex = 0;
            this.txtInterval.Text = "300";
            // 
            // lInterval
            // 
            this.lInterval.AutoSize = true;
            this.lInterval.Location = new System.Drawing.Point(28, 66);
            this.lInterval.Name = "lInterval";
            this.lInterval.Size = new System.Drawing.Size(96, 17);
            this.lInterval.TabIndex = 1;
            this.lInterval.Text = "Interval (Sec):";
            // 
            // wbBrowser
            // 
            this.wbBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbBrowser.Location = new System.Drawing.Point(12, 142);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.Size = new System.Drawing.Size(1204, 728);
            this.wbBrowser.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 882);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.gbSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Web Refresher";
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lUrl;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label lInterval;
    }
}

