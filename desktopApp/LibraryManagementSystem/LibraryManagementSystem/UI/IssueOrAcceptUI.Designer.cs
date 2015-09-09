namespace LibraryManagementSystem.UI
{
    partial class IssueOrAcceptUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.booksdataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.issuedradioButton = new System.Windows.Forms.RadioButton();
            this.notIssuedradioButton = new System.Windows.Forms.RadioButton();
            this.bookIdradioButton = new System.Windows.Forms.RadioButton();
            this.memberIdradioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.acceptBookButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksdataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.booksdataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Books";
            // 
            // booksdataGridView
            // 
            this.booksdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksdataGridView.Location = new System.Drawing.Point(6, 19);
            this.booksdataGridView.Name = "booksdataGridView";
            this.booksdataGridView.Size = new System.Drawing.Size(286, 332);
            this.booksdataGridView.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.notIssuedradioButton);
            this.groupBox2.Controls.Add(this.issuedradioButton);
            this.groupBox2.Location = new System.Drawing.Point(316, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Books";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.acceptBookButton);
            this.groupBox3.Controls.Add(this.ClearButton);
            this.groupBox3.Controls.Add(this.searchButton);
            this.groupBox3.Controls.Add(this.searchtextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.memberIdradioButton);
            this.groupBox3.Controls.Add(this.bookIdradioButton);
            this.groupBox3.Location = new System.Drawing.Point(316, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 195);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Accept Books";
            // 
            // issuedradioButton
            // 
            this.issuedradioButton.AutoSize = true;
            this.issuedradioButton.Location = new System.Drawing.Point(14, 28);
            this.issuedradioButton.Name = "issuedradioButton";
            this.issuedradioButton.Size = new System.Drawing.Size(56, 17);
            this.issuedradioButton.TabIndex = 0;
            this.issuedradioButton.TabStop = true;
            this.issuedradioButton.Text = "Issued";
            this.issuedradioButton.UseVisualStyleBackColor = true;
            // 
            // notIssuedradioButton
            // 
            this.notIssuedradioButton.AutoSize = true;
            this.notIssuedradioButton.Location = new System.Drawing.Point(76, 28);
            this.notIssuedradioButton.Name = "notIssuedradioButton";
            this.notIssuedradioButton.Size = new System.Drawing.Size(76, 17);
            this.notIssuedradioButton.TabIndex = 0;
            this.notIssuedradioButton.TabStop = true;
            this.notIssuedradioButton.Text = "Not-Issued";
            this.notIssuedradioButton.UseVisualStyleBackColor = true;
            // 
            // bookIdradioButton
            // 
            this.bookIdradioButton.AutoSize = true;
            this.bookIdradioButton.Location = new System.Drawing.Point(6, 28);
            this.bookIdradioButton.Name = "bookIdradioButton";
            this.bookIdradioButton.Size = new System.Drawing.Size(62, 17);
            this.bookIdradioButton.TabIndex = 0;
            this.bookIdradioButton.TabStop = true;
            this.bookIdradioButton.Text = "Book Id";
            this.bookIdradioButton.UseVisualStyleBackColor = true;
            // 
            // memberIdradioButton
            // 
            this.memberIdradioButton.AutoSize = true;
            this.memberIdradioButton.Location = new System.Drawing.Point(76, 28);
            this.memberIdradioButton.Name = "memberIdradioButton";
            this.memberIdradioButton.Size = new System.Drawing.Size(75, 17);
            this.memberIdradioButton.TabIndex = 0;
            this.memberIdradioButton.TabStop = true;
            this.memberIdradioButton.Text = "Member Id";
            this.memberIdradioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(63, 71);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(100, 20);
            this.searchtextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(14, 112);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(68, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(88, 112);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // acceptBookButton
            // 
            this.acceptBookButton.Location = new System.Drawing.Point(36, 155);
            this.acceptBookButton.Name = "acceptBookButton";
            this.acceptBookButton.Size = new System.Drawing.Size(91, 23);
            this.acceptBookButton.TabIndex = 3;
            this.acceptBookButton.Text = "Accept Book";
            this.acceptBookButton.UseVisualStyleBackColor = true;
            // 
            // IssueOrAcceptUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 381);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "IssueOrAcceptUI";
            this.Text = "IssueOrAcceptUI";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksdataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView booksdataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton notIssuedradioButton;
        private System.Windows.Forms.RadioButton issuedradioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button acceptBookButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton memberIdradioButton;
        private System.Windows.Forms.RadioButton bookIdradioButton;
    }
}