namespace BorrowRegis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.borrowBtn = new System.Windows.Forms.Button();
            this.LostBtn = new System.Windows.Forms.Button();
            this.ApproveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // borrowBtn
            // 
            this.borrowBtn.Font = new System.Drawing.Font("黑体", 16F);
            this.borrowBtn.Location = new System.Drawing.Point(33, 23);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(269, 59);
            this.borrowBtn.TabIndex = 0;
            this.borrowBtn.Text = "制品转借登记";
            this.borrowBtn.UseVisualStyleBackColor = true;
            this.borrowBtn.Click += new System.EventHandler(this.borrowBtn_Click);
            // 
            // LostBtn
            // 
            this.LostBtn.Font = new System.Drawing.Font("黑体", 16F);
            this.LostBtn.Location = new System.Drawing.Point(33, 110);
            this.LostBtn.Name = "LostBtn";
            this.LostBtn.Size = new System.Drawing.Size(269, 59);
            this.LostBtn.TabIndex = 1;
            this.LostBtn.Text = "制品遗失登记";
            this.LostBtn.UseVisualStyleBackColor = true;
            this.LostBtn.Click += new System.EventHandler(this.LostBtn_Click);
            // 
            // ApproveBtn
            // 
            this.ApproveBtn.Font = new System.Drawing.Font("黑体", 16F);
            this.ApproveBtn.Location = new System.Drawing.Point(33, 196);
            this.ApproveBtn.Name = "ApproveBtn";
            this.ApproveBtn.Size = new System.Drawing.Size(269, 59);
            this.ApproveBtn.TabIndex = 2;
            this.ApproveBtn.Text = "制品转借审批";
            this.ApproveBtn.UseVisualStyleBackColor = true;
            this.ApproveBtn.Click += new System.EventHandler(this.ApproveBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 287);
            this.Controls.Add(this.ApproveBtn);
            this.Controls.Add(this.LostBtn);
            this.Controls.Add(this.borrowBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主界面";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button borrowBtn;
        private System.Windows.Forms.Button LostBtn;
        private System.Windows.Forms.Button ApproveBtn;
    }
}