namespace RPBD_Shutov_Lab1_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            _actualConnection?.Close();
            _actualConnection?.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.storagesListBox = new System.Windows.Forms.ListBox();
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.name1 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.address2 = new System.Windows.Forms.TextBox();
            this.price1 = new System.Windows.Forms.TextBox();
            this.edit1 = new System.Windows.Forms.Button();
            this.add1 = new System.Windows.Forms.Button();
            this.del1 = new System.Windows.Forms.Button();
            this.del2 = new System.Windows.Forms.Button();
            this.add2 = new System.Windows.Forms.Button();
            this.edit2 = new System.Windows.Forms.Button();
            this.dbTypes = new System.Windows.Forms.ComboBox();
            this.connect = new System.Windows.Forms.Button();
            this.filter1 = new System.Windows.Forms.Button();
            this.filter2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.procButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.id2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.id1 = new System.Windows.Forms.TextBox();
            this.storage_id1 = new System.Windows.Forms.TextBox();
            this.refresh1 = new System.Windows.Forms.Button();
            this.refresh2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // storagesListBox
            // 
            this.storagesListBox.FormattingEnabled = true;
            this.storagesListBox.ItemHeight = 15;
            this.storagesListBox.Location = new System.Drawing.Point(610, 40);
            this.storagesListBox.Name = "storagesListBox";
            this.storagesListBox.Size = new System.Drawing.Size(147, 259);
            this.storagesListBox.TabIndex = 1;
            this.storagesListBox.SelectedIndexChanged += new System.EventHandler(this.storagesListBox_SelectedIndexChanged);
            // 
            // productsListBox
            // 
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.ItemHeight = 15;
            this.productsListBox.Location = new System.Drawing.Point(298, 42);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(147, 259);
            this.productsListBox.TabIndex = 2;
            this.productsListBox.SelectedIndexChanged += new System.EventHandler(this.productsListBox_SelectedIndexChanged);
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(167, 88);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(125, 23);
            this.name1.TabIndex = 3;
            // 
            // name2
            // 
            this.name2.Location = new System.Drawing.Point(479, 88);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(125, 23);
            this.name2.TabIndex = 5;
            // 
            // address2
            // 
            this.address2.Location = new System.Drawing.Point(479, 137);
            this.address2.Name = "address2";
            this.address2.Size = new System.Drawing.Size(125, 23);
            this.address2.TabIndex = 7;
            // 
            // price1
            // 
            this.price1.Location = new System.Drawing.Point(167, 137);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(125, 23);
            this.price1.TabIndex = 6;
            // 
            // edit1
            // 
            this.edit1.Location = new System.Drawing.Point(167, 250);
            this.edit1.Name = "edit1";
            this.edit1.Size = new System.Drawing.Size(122, 23);
            this.edit1.TabIndex = 12;
            this.edit1.Text = "Edit";
            this.edit1.UseVisualStyleBackColor = true;
            this.edit1.Click += new System.EventHandler(this.edit1_Click);
            // 
            // add1
            // 
            this.add1.Location = new System.Drawing.Point(167, 279);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(122, 23);
            this.add1.TabIndex = 13;
            this.add1.Text = "Add";
            this.add1.UseVisualStyleBackColor = true;
            this.add1.Click += new System.EventHandler(this.add1_Click);
            // 
            // del1
            // 
            this.del1.Location = new System.Drawing.Point(167, 308);
            this.del1.Name = "del1";
            this.del1.Size = new System.Drawing.Size(122, 23);
            this.del1.TabIndex = 14;
            this.del1.Text = "Delete";
            this.del1.UseVisualStyleBackColor = true;
            this.del1.Click += new System.EventHandler(this.del1_Click);
            // 
            // del2
            // 
            this.del2.Location = new System.Drawing.Point(479, 308);
            this.del2.Name = "del2";
            this.del2.Size = new System.Drawing.Size(122, 23);
            this.del2.TabIndex = 17;
            this.del2.Text = "Delete";
            this.del2.UseVisualStyleBackColor = true;
            this.del2.Click += new System.EventHandler(this.del2_Click);
            // 
            // add2
            // 
            this.add2.Location = new System.Drawing.Point(479, 279);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(122, 23);
            this.add2.TabIndex = 16;
            this.add2.Text = "Add";
            this.add2.UseVisualStyleBackColor = true;
            this.add2.Click += new System.EventHandler(this.add2_Click);
            // 
            // edit2
            // 
            this.edit2.Location = new System.Drawing.Point(479, 250);
            this.edit2.Name = "edit2";
            this.edit2.Size = new System.Drawing.Size(122, 23);
            this.edit2.TabIndex = 15;
            this.edit2.Text = "Edit";
            this.edit2.UseVisualStyleBackColor = true;
            this.edit2.Click += new System.EventHandler(this.edit2_Click);
            // 
            // dbTypes
            // 
            this.dbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dbTypes.FormattingEnabled = true;
            this.dbTypes.Location = new System.Drawing.Point(17, 208);
            this.dbTypes.Name = "dbTypes";
            this.dbTypes.Size = new System.Drawing.Size(121, 23);
            this.dbTypes.TabIndex = 18;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(17, 237);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(122, 23);
            this.connect.TabIndex = 19;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // filter1
            // 
            this.filter1.Location = new System.Drawing.Point(167, 338);
            this.filter1.Name = "filter1";
            this.filter1.Size = new System.Drawing.Size(122, 23);
            this.filter1.TabIndex = 20;
            this.filter1.Text = "Filter";
            this.filter1.UseVisualStyleBackColor = true;
            this.filter1.Click += new System.EventHandler(this.filter1_Click);
            // 
            // filter2
            // 
            this.filter2.Location = new System.Drawing.Point(479, 338);
            this.filter2.Name = "filter2";
            this.filter2.Size = new System.Drawing.Size(122, 23);
            this.filter2.TabIndex = 21;
            this.filter2.Text = "Filter";
            this.filter2.UseVisualStyleBackColor = true;
            this.filter2.Click += new System.EventHandler(this.filter2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Storages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Storage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Address";
            // 
            // procButton
            // 
            this.procButton.Location = new System.Drawing.Point(167, 221);
            this.procButton.Name = "procButton";
            this.procButton.Size = new System.Drawing.Size(122, 23);
            this.procButton.TabIndex = 30;
            this.procButton.Text = "Add with storage";
            this.procButton.UseVisualStyleBackColor = true;
            this.procButton.Visible = false;
            this.procButton.Click += new System.EventHandler(this.procButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Id";
            // 
            // id2
            // 
            this.id2.Location = new System.Drawing.Point(479, 42);
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(125, 23);
            this.id2.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "Id";
            // 
            // id1
            // 
            this.id1.Location = new System.Drawing.Point(167, 44);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(125, 23);
            this.id1.TabIndex = 33;
            // 
            // storage_id1
            // 
            this.storage_id1.Location = new System.Drawing.Point(167, 181);
            this.storage_id1.Name = "storage_id1";
            this.storage_id1.Size = new System.Drawing.Size(125, 23);
            this.storage_id1.TabIndex = 35;
            // 
            // refresh1
            // 
            this.refresh1.Location = new System.Drawing.Point(298, 307);
            this.refresh1.Name = "refresh1";
            this.refresh1.Size = new System.Drawing.Size(147, 23);
            this.refresh1.TabIndex = 36;
            this.refresh1.Text = "Refresh";
            this.refresh1.UseVisualStyleBackColor = true;
            this.refresh1.Click += new System.EventHandler(this.refresh1_Click);
            // 
            // refresh2
            // 
            this.refresh2.Location = new System.Drawing.Point(610, 308);
            this.refresh2.Name = "refresh2";
            this.refresh2.Size = new System.Drawing.Size(147, 23);
            this.refresh2.TabIndex = 37;
            this.refresh2.Text = "Refresh";
            this.refresh2.UseVisualStyleBackColor = true;
            this.refresh2.Click += new System.EventHandler(this.refresh2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 373);
            this.Controls.Add(this.refresh2);
            this.Controls.Add(this.refresh1);
            this.Controls.Add(this.storage_id1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.id1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.id2);
            this.Controls.Add(this.procButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filter2);
            this.Controls.Add(this.filter1);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.dbTypes);
            this.Controls.Add(this.del2);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.edit2);
            this.Controls.Add(this.del1);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.edit1);
            this.Controls.Add(this.address2);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.productsListBox);
            this.Controls.Add(this.storagesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "DB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox storagesListBox;
        private ListBox productsListBox;
        private TextBox name1;
        private TextBox name2;
        private TextBox address2;
        private TextBox price1;
        private Button edit1;
        private Button add1;
        private Button del1;
        private Button del2;
        private Button add2;
        private Button edit2;
        private ComboBox dbTypes;
        private Button connect;
        private Button filter1;
        private Button filter2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button procButton;
        private Label label8;
        private TextBox id2;
        private Label label9;
        private TextBox id1;
        private TextBox storage_id1;
        private Button refresh1;
        private Button refresh2;
    }
}