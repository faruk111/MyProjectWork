namespace LibraryManagementSystem.UI
{
    partial class SearchUI
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
            this.searchRecordsdataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.issueButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.memberradioButton = new System.Windows.Forms.RadioButton();
            this.bookradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.authorradioButton = new System.Windows.Forms.RadioButton();
            this.titleradioButton = new System.Windows.Forms.RadioButton();
            this.rackradioButton = new System.Windows.Forms.RadioButton();
            this.idradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.contrainsradioButton = new System.Windows.Forms.RadioButton();
            this.exactradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchRecordsdataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchRecordsdataGridView);
            this.groupBox1.Location = new System.Drawing.Point(21, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Records";
            // 
            // searchRecordsdataGridView
            // 
            this.searchRecordsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchRecordsdataGridView.Location = new System.Drawing.Point(6, 19);
            this.searchRecordsdataGridView.Name = "searchRecordsdataGridView";
            this.searchRecordsdataGridView.Size = new System.Drawing.Size(309, 268);
            this.searchRecordsdataGridView.TabIndex = 0;
            this.searchRecordsdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchRecordsdataGridView_CellClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(25, 342);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(106, 342);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(187, 342);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(75, 23);
            this.detailsButton.TabIndex = 1;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            // 
            // issueButton
            // 
            this.issueButton.Location = new System.Drawing.Point(268, 342);
            this.issueButton.Name = "issueButton";
            this.issueButton.Size = new System.Drawing.Size(75, 23);
            this.issueButton.TabIndex = 1;
            this.issueButton.Text = "Issue Book";
            this.issueButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.memberradioButton);
            this.groupBox2.Controls.Add(this.bookradioButton);
            this.groupBox2.Location = new System.Drawing.Point(348, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 73);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // memberradioButton
            // 
            this.memberradioButton.AutoSize = true;
            this.memberradioButton.Location = new System.Drawing.Point(76, 32);
            this.memberradioButton.Name = "memberradioButton";
            this.memberradioButton.Size = new System.Drawing.Size(68, 17);
            this.memberradioButton.TabIndex = 0;
            this.memberradioButton.TabStop = true;
            this.memberradioButton.Text = "Members";
            this.memberradioButton.UseVisualStyleBackColor = true;
            this.memberradioButton.CheckedChanged += new System.EventHandler(this.memberradioButton_CheckedChanged);
            // 
            // bookradioButton
            // 
            this.bookradioButton.AutoSize = true;
            this.bookradioButton.Location = new System.Drawing.Point(15, 32);
            this.bookradioButton.Name = "bookradioButton";
            this.bookradioButton.Size = new System.Drawing.Size(55, 17);
            this.bookradioButton.TabIndex = 0;
            this.bookradioButton.TabStop = true;
            this.bookradioButton.Text = "Books";
            this.bookradioButton.UseVisualStyleBackColor = true;
            this.bookradioButton.CheckedChanged += new System.EventHandler(this.bookradioButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.authorradioButton);
            this.groupBox3.Controls.Add(this.titleradioButton);
            this.groupBox3.Controls.Add(this.rackradioButton);
            this.groupBox3.Controls.Add(this.idradioButton);
            this.groupBox3.Location = new System.Drawing.Point(348, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 69);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Book By";
            // 
            // authorradioButton
            // 
            this.authorradioButton.AutoSize = true;
            this.authorradioButton.Location = new System.Drawing.Point(53, 43);
            this.authorradioButton.Name = "authorradioButton";
            this.authorradioButton.Size = new System.Drawing.Size(56, 17);
            this.authorradioButton.TabIndex = 0;
            this.authorradioButton.TabStop = true;
            this.authorradioButton.Text = "Author";
            this.authorradioButton.UseVisualStyleBackColor = true;
            this.authorradioButton.CheckedChanged += new System.EventHandler(this.authorradioButton_CheckedChanged);
            // 
            // titleradioButton
            // 
            this.titleradioButton.AutoSize = true;
            this.titleradioButton.Location = new System.Drawing.Point(11, 43);
            this.titleradioButton.Name = "titleradioButton";
            this.titleradioButton.Size = new System.Drawing.Size(45, 17);
            this.titleradioButton.TabIndex = 0;
            this.titleradioButton.TabStop = true;
            this.titleradioButton.Text = "Title";
            this.titleradioButton.UseVisualStyleBackColor = true;
            this.titleradioButton.CheckedChanged += new System.EventHandler(this.titleradioButton_CheckedChanged);
            // 
            // rackradioButton
            // 
            this.rackradioButton.AutoSize = true;
            this.rackradioButton.Location = new System.Drawing.Point(53, 20);
            this.rackradioButton.Name = "rackradioButton";
            this.rackradioButton.Size = new System.Drawing.Size(65, 17);
            this.rackradioButton.TabIndex = 0;
            this.rackradioButton.TabStop = true;
            this.rackradioButton.Text = "Rack ID";
            this.rackradioButton.UseVisualStyleBackColor = true;
            this.rackradioButton.CheckedChanged += new System.EventHandler(this.rackradioButton_CheckedChanged);
            // 
            // idradioButton
            // 
            this.idradioButton.AutoSize = true;
            this.idradioButton.Location = new System.Drawing.Point(11, 20);
            this.idradioButton.Name = "idradioButton";
            this.idradioButton.Size = new System.Drawing.Size(36, 17);
            this.idradioButton.TabIndex = 0;
            this.idradioButton.TabStop = true;
            this.idradioButton.Text = "ID";
            this.idradioButton.UseVisualStyleBackColor = true;
            this.idradioButton.CheckedChanged += new System.EventHandler(this.idradioButton_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.contrainsradioButton);
            this.groupBox4.Controls.Add(this.exactradioButton);
            this.groupBox4.Location = new System.Drawing.Point(348, 178);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(148, 69);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Method";
            // 
            // contrainsradioButton
            // 
            this.contrainsradioButton.AutoSize = true;
            this.contrainsradioButton.Location = new System.Drawing.Point(72, 26);
            this.contrainsradioButton.Name = "contrainsradioButton";
            this.contrainsradioButton.Size = new System.Drawing.Size(66, 17);
            this.contrainsradioButton.TabIndex = 0;
            this.contrainsradioButton.TabStop = true;
            this.contrainsradioButton.Text = "Contains";
            this.contrainsradioButton.UseVisualStyleBackColor = true;
            // 
            // exactradioButton
            // 
            this.exactradioButton.AutoSize = true;
            this.exactradioButton.Location = new System.Drawing.Point(14, 26);
            this.exactradioButton.Name = "exactradioButton";
            this.exactradioButton.Size = new System.Drawing.Size(52, 17);
            this.exactradioButton.TabIndex = 0;
            this.exactradioButton.TabStop = true;
            this.exactradioButton.Text = "Exact";
            this.exactradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.clearButton);
            this.groupBox5.Controls.Add(this.searchTextBox);
            this.groupBox5.Location = new System.Drawing.Point(348, 253);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(148, 112);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search String";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(32, 64);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(66, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(6, 32);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(136, 26);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // SearchUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 383);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.issueButton);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchUI";
            this.Text = "SearchUI";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchRecordsdataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView searchRecordsdataGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button issueButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton memberradioButton;
        private System.Windows.Forms.RadioButton bookradioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton authorradioButton;
        private System.Windows.Forms.RadioButton titleradioButton;
        private System.Windows.Forms.RadioButton rackradioButton;
        private System.Windows.Forms.RadioButton idradioButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton contrainsradioButton;
        private System.Windows.Forms.RadioButton exactradioButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}