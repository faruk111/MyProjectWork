namespace LibraryManagementSystem.UI
{
    partial class BookUI
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
            this.bookRecordsdataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pricetextBox = new System.Windows.Forms.TextBox();
            this.publishertextBox = new System.Windows.Forms.TextBox();
            this.rackNotextBox = new System.Windows.Forms.TextBox();
            this.authortextBox = new System.Windows.Forms.TextBox();
            this.subjectCodetextBox = new System.Windows.Forms.TextBox();
            this.titletextBox = new System.Windows.Forms.TextBox();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.issuebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.idShowtextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.titleShowtextBox = new System.Windows.Forms.TextBox();
            this.codeShowtextBox = new System.Windows.Forms.TextBox();
            this.authorShowtextBox = new System.Windows.Forms.TextBox();
            this.publisherShowtextBox = new System.Windows.Forms.TextBox();
            this.priceShowtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookRecordsdataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bookRecordsdataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Books Records";
            // 
            // bookRecordsdataGridView
            // 
            this.bookRecordsdataGridView.AllowUserToOrderColumns = true;
            this.bookRecordsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookRecordsdataGridView.Location = new System.Drawing.Point(6, 19);
            this.bookRecordsdataGridView.Name = "bookRecordsdataGridView";
            this.bookRecordsdataGridView.Size = new System.Drawing.Size(273, 278);
            this.bookRecordsdataGridView.TabIndex = 0;
            this.bookRecordsdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookRecordsdataGridView_CellClick);
            this.bookRecordsdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookRecordsdataGridView_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pricetextBox);
            this.groupBox2.Controls.Add(this.publishertextBox);
            this.groupBox2.Controls.Add(this.rackNotextBox);
            this.groupBox2.Controls.Add(this.authortextBox);
            this.groupBox2.Controls.Add(this.subjectCodetextBox);
            this.groupBox2.Controls.Add(this.titletextBox);
            this.groupBox2.Controls.Add(this.idtextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(614, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 249);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Book";
            // 
            // pricetextBox
            // 
            this.pricetextBox.Location = new System.Drawing.Point(81, 210);
            this.pricetextBox.Name = "pricetextBox";
            this.pricetextBox.Size = new System.Drawing.Size(100, 20);
            this.pricetextBox.TabIndex = 7;
            // 
            // publishertextBox
            // 
            this.publishertextBox.Location = new System.Drawing.Point(81, 169);
            this.publishertextBox.Name = "publishertextBox";
            this.publishertextBox.Size = new System.Drawing.Size(100, 20);
            this.publishertextBox.TabIndex = 6;
            // 
            // rackNotextBox
            // 
            this.rackNotextBox.Location = new System.Drawing.Point(81, 133);
            this.rackNotextBox.Name = "rackNotextBox";
            this.rackNotextBox.Size = new System.Drawing.Size(100, 20);
            this.rackNotextBox.TabIndex = 5;
            // 
            // authortextBox
            // 
            this.authortextBox.Location = new System.Drawing.Point(81, 98);
            this.authortextBox.Name = "authortextBox";
            this.authortextBox.Size = new System.Drawing.Size(100, 20);
            this.authortextBox.TabIndex = 4;
            // 
            // subjectCodetextBox
            // 
            this.subjectCodetextBox.Location = new System.Drawing.Point(81, 72);
            this.subjectCodetextBox.Name = "subjectCodetextBox";
            this.subjectCodetextBox.Size = new System.Drawing.Size(100, 20);
            this.subjectCodetextBox.TabIndex = 3;
            // 
            // titletextBox
            // 
            this.titletextBox.Location = new System.Drawing.Point(81, 48);
            this.titletextBox.Name = "titletextBox";
            this.titletextBox.Size = new System.Drawing.Size(100, 20);
            this.titletextBox.TabIndex = 2;
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(81, 25);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(100, 20);
            this.idtextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Price*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Publisher*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rack No*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Author*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Subject Code*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BookId*";
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(614, 292);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 1;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(12, 334);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 3;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(93, 334);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 4;
            this.updatebutton.Text = "Updae";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // issuebutton
            // 
            this.issuebutton.Location = new System.Drawing.Point(186, 334);
            this.issuebutton.Name = "issuebutton";
            this.issuebutton.Size = new System.Drawing.Size(75, 23);
            this.issuebutton.TabIndex = 6;
            this.issuebutton.Text = "Issue Book";
            this.issuebutton.UseVisualStyleBackColor = true;
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(710, 292);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 23);
            this.clearbutton.TabIndex = 2;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // idShowtextBox
            // 
            this.idShowtextBox.Location = new System.Drawing.Point(82, 25);
            this.idShowtextBox.Name = "idShowtextBox";
            this.idShowtextBox.Size = new System.Drawing.Size(132, 20);
            this.idShowtextBox.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.priceShowtextBox);
            this.groupBox3.Controls.Add(this.publisherShowtextBox);
            this.groupBox3.Controls.Add(this.authorShowtextBox);
            this.groupBox3.Controls.Add(this.codeShowtextBox);
            this.groupBox3.Controls.Add(this.titleShowtextBox);
            this.groupBox3.Controls.Add(this.idShowtextBox);
            this.groupBox3.Location = new System.Drawing.Point(323, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 278);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Show Details";
            // 
            // titleShowtextBox
            // 
            this.titleShowtextBox.Location = new System.Drawing.Point(82, 65);
            this.titleShowtextBox.Name = "titleShowtextBox";
            this.titleShowtextBox.Size = new System.Drawing.Size(132, 20);
            this.titleShowtextBox.TabIndex = 7;
            // 
            // codeShowtextBox
            // 
            this.codeShowtextBox.Location = new System.Drawing.Point(82, 98);
            this.codeShowtextBox.Name = "codeShowtextBox";
            this.codeShowtextBox.Size = new System.Drawing.Size(132, 20);
            this.codeShowtextBox.TabIndex = 7;
            // 
            // authorShowtextBox
            // 
            this.authorShowtextBox.Location = new System.Drawing.Point(82, 133);
            this.authorShowtextBox.Name = "authorShowtextBox";
            this.authorShowtextBox.Size = new System.Drawing.Size(132, 20);
            this.authorShowtextBox.TabIndex = 7;
            // 
            // publisherShowtextBox
            // 
            this.publisherShowtextBox.Location = new System.Drawing.Point(82, 169);
            this.publisherShowtextBox.Name = "publisherShowtextBox";
            this.publisherShowtextBox.Size = new System.Drawing.Size(132, 20);
            this.publisherShowtextBox.TabIndex = 7;
            // 
            // priceShowtextBox
            // 
            this.priceShowtextBox.Location = new System.Drawing.Point(82, 206);
            this.priceShowtextBox.Name = "priceShowtextBox";
            this.priceShowtextBox.Size = new System.Drawing.Size(132, 20);
            this.priceShowtextBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Title";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Author";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Publisher";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Price";
            // 
            // BookUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 378);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.issuebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BookUI";
            this.Text = "BookUI";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookRecordsdataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView bookRecordsdataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox pricetextBox;
        private System.Windows.Forms.TextBox publishertextBox;
        private System.Windows.Forms.TextBox rackNotextBox;
        private System.Windows.Forms.TextBox authortextBox;
        private System.Windows.Forms.TextBox subjectCodetextBox;
        private System.Windows.Forms.TextBox titletextBox;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button issuebutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.TextBox idShowtextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox priceShowtextBox;
        private System.Windows.Forms.TextBox publisherShowtextBox;
        private System.Windows.Forms.TextBox authorShowtextBox;
        private System.Windows.Forms.TextBox codeShowtextBox;
        private System.Windows.Forms.TextBox titleShowtextBox;
    }
}