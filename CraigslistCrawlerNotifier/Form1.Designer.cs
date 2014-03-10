namespace CraigslistCrawlerNotifier
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.listBox_Results = new System.Windows.Forms.ListBox();
            this.txtBx_SearchString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(193, 465);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(139, 23);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Start Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // listBox_Results
            // 
            this.listBox_Results.FormattingEnabled = true;
            this.listBox_Results.Location = new System.Drawing.Point(12, 12);
            this.listBox_Results.Name = "listBox_Results";
            this.listBox_Results.Size = new System.Drawing.Size(517, 420);
            this.listBox_Results.TabIndex = 1;
            // 
            // txtBx_SearchString
            // 
            this.txtBx_SearchString.Location = new System.Drawing.Point(12, 439);
            this.txtBx_SearchString.Name = "txtBx_SearchString";
            this.txtBx_SearchString.Size = new System.Drawing.Size(517, 20);
            this.txtBx_SearchString.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 499);
            this.Controls.Add(this.txtBx_SearchString);
            this.Controls.Add(this.listBox_Results);
            this.Controls.Add(this.btn_Search);
            this.Name = "MainForm";
            this.Text = "Craigslist Search Notifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ListBox listBox_Results;
        private System.Windows.Forms.TextBox txtBx_SearchString;
    }
}

