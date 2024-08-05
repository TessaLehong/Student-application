﻿namespace Portal
{
    partial class StudentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReturn = new System.Windows.Forms.Button();
            this.picBoxStudentForm = new System.Windows.Forms.PictureBox();
            this.groupBoxMainDetail = new System.Windows.Forms.GroupBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMoreInfo = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtModule = new System.Windows.Forms.ComboBox();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtDOB = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.GoldPanelStudent = new System.Windows.Forms.Panel();
            this.MaroonPanelStudent = new System.Windows.Forms.Panel();
            this.BlackPanelStudent = new System.Windows.Forms.Panel();
            this.lblStudentWeb = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.lblSearchStudentID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStudentForm)).BeginInit();
            this.groupBoxMainDetail.SuspendLayout();
            this.groupBoxMoreInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.BlackPanelStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Maroon;
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(1681, 15);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(131, 48);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // picBoxStudentForm
            // 
            this.picBoxStudentForm.Location = new System.Drawing.Point(-9, 1);
            this.picBoxStudentForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBoxStudentForm.Name = "picBoxStudentForm";
            this.picBoxStudentForm.Size = new System.Drawing.Size(189, 111);
            this.picBoxStudentForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxStudentForm.TabIndex = 1;
            this.picBoxStudentForm.TabStop = false;
            // 
            // groupBoxMainDetail
            // 
            this.groupBoxMainDetail.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBoxMainDetail.Controls.Add(this.txtSurname);
            this.groupBoxMainDetail.Controls.Add(this.txtName);
            this.groupBoxMainDetail.Controls.Add(this.txtID);
            this.groupBoxMainDetail.Controls.Add(this.label3);
            this.groupBoxMainDetail.Controls.Add(this.label2);
            this.groupBoxMainDetail.Controls.Add(this.label1);
            this.groupBoxMainDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxMainDetail.Location = new System.Drawing.Point(261, 89);
            this.groupBoxMainDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMainDetail.Name = "groupBoxMainDetail";
            this.groupBoxMainDetail.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMainDetail.Size = new System.Drawing.Size(417, 210);
            this.groupBoxMainDetail.TabIndex = 2;
            this.groupBoxMainDetail.TabStop = false;
            this.groupBoxMainDetail.Text = "Main Details";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(176, 160);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(173, 22);
            this.txtSurname.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(176, 110);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(176, 50);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(173, 22);
            this.txtID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // groupBoxMoreInfo
            // 
            this.groupBoxMoreInfo.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBoxMoreInfo.Controls.Add(this.btnClear);
            this.groupBoxMoreInfo.Controls.Add(this.txtModule);
            this.groupBoxMoreInfo.Controls.Add(this.txtGender);
            this.groupBoxMoreInfo.Controls.Add(this.txtPhone);
            this.groupBoxMoreInfo.Controls.Add(this.txtDOB);
            this.groupBoxMoreInfo.Controls.Add(this.txtAddress);
            this.groupBoxMoreInfo.Controls.Add(this.label7);
            this.groupBoxMoreInfo.Controls.Add(this.label8);
            this.groupBoxMoreInfo.Controls.Add(this.label6);
            this.groupBoxMoreInfo.Controls.Add(this.label5);
            this.groupBoxMoreInfo.Controls.Add(this.label4);
            this.groupBoxMoreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxMoreInfo.Location = new System.Drawing.Point(740, 59);
            this.groupBoxMoreInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMoreInfo.Name = "groupBoxMoreInfo";
            this.groupBoxMoreInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMoreInfo.Size = new System.Drawing.Size(753, 266);
            this.groupBoxMoreInfo.TabIndex = 2;
            this.groupBoxMoreInfo.TabStop = false;
            this.groupBoxMoreInfo.Text = "More Info";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Maroon;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(573, 34);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 48);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtModule
            // 
            this.txtModule.FormattingEnabled = true;
            this.txtModule.Location = new System.Drawing.Point(564, 202);
            this.txtModule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(172, 24);
            this.txtModule.TabIndex = 5;
            // 
            // txtGender
            // 
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtGender.Location = new System.Drawing.Point(156, 128);
            this.txtGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(173, 24);
            this.txtGender.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(156, 201);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(179, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(161, 60);
            this.txtDOB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(261, 22);
            this.txtDOB.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(564, 127);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(173, 22);
            this.txtAddress.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(395, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(395, 203);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Class Module:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(61, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(55, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(61, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "DOB:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(261, 405);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1232, 272);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetInfo);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Maroon;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(624, 362);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 36);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Maroon;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(1579, 405);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(131, 63);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert Student";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Maroon;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(1579, 475);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(131, 64);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove Student";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1579, 546);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 64);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update Student";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(449, 369);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(161, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up_Search);
            // 
            // GoldPanelStudent
            // 
            this.GoldPanelStudent.BackColor = System.Drawing.Color.LightSlateGray;
            this.GoldPanelStudent.Location = new System.Drawing.Point(-9, 800);
            this.GoldPanelStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoldPanelStudent.Name = "GoldPanelStudent";
            this.GoldPanelStudent.Size = new System.Drawing.Size(1844, 30);
            this.GoldPanelStudent.TabIndex = 4;
            // 
            // MaroonPanelStudent
            // 
            this.MaroonPanelStudent.BackColor = System.Drawing.Color.Maroon;
            this.MaroonPanelStudent.Location = new System.Drawing.Point(-9, 831);
            this.MaroonPanelStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaroonPanelStudent.Name = "MaroonPanelStudent";
            this.MaroonPanelStudent.Size = new System.Drawing.Size(1844, 30);
            this.MaroonPanelStudent.TabIndex = 4;
            // 
            // BlackPanelStudent
            // 
            this.BlackPanelStudent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BlackPanelStudent.Controls.Add(this.lblStudentWeb);
            this.BlackPanelStudent.Location = new System.Drawing.Point(-9, 860);
            this.BlackPanelStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BlackPanelStudent.Name = "BlackPanelStudent";
            this.BlackPanelStudent.Size = new System.Drawing.Size(1844, 38);
            this.BlackPanelStudent.TabIndex = 4;
            // 
            // lblStudentWeb
            // 
            this.lblStudentWeb.AutoSize = true;
            this.lblStudentWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentWeb.ForeColor = System.Drawing.Color.White;
            this.lblStudentWeb.Location = new System.Drawing.Point(801, 10);
            this.lblStudentWeb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentWeb.Name = "lblStudentWeb";
            this.lblStudentWeb.Size = new System.Drawing.Size(212, 18);
            this.lblStudentWeb.TabIndex = 1;
            this.lblStudentWeb.Text = "www.belgiumcampus.ac.za";
            this.lblStudentWeb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.BackColor = System.Drawing.Color.Maroon;
            this.btnLoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoadImage.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLoadImage.Location = new System.Drawing.Point(1579, 618);
            this.btnLoadImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(131, 59);
            this.btnLoadImage.TabIndex = 5;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = false;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // lblSearchStudentID
            // 
            this.lblSearchStudentID.AutoSize = true;
            this.lblSearchStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchStudentID.Location = new System.Drawing.Point(261, 370);
            this.lblSearchStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchStudentID.Name = "lblSearchStudentID";
            this.lblSearchStudentID.Size = new System.Drawing.Size(173, 20);
            this.lblSearchStudentID.TabIndex = 7;
            this.lblSearchStudentID.Text = "Search by Student ID:";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1833, 897);
            this.Controls.Add(this.lblSearchStudentID);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.BlackPanelStudent);
            this.Controls.Add(this.MaroonPanelStudent);
            this.Controls.Add(this.GoldPanelStudent);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxMoreInfo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBoxMainDetail);
            this.Controls.Add(this.picBoxStudentForm);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReturn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStudentForm)).EndInit();
            this.groupBoxMainDetail.ResumeLayout(false);
            this.groupBoxMainDetail.PerformLayout();
            this.groupBoxMoreInfo.ResumeLayout(false);
            this.groupBoxMoreInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.BlackPanelStudent.ResumeLayout(false);
            this.BlackPanelStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox picBoxStudentForm;
        private System.Windows.Forms.GroupBox groupBoxMainDetail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMoreInfo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel GoldPanelStudent;
        private System.Windows.Forms.Panel MaroonPanelStudent;
        private System.Windows.Forms.Panel BlackPanelStudent;
        private System.Windows.Forms.Label lblStudentWeb;
        private System.Windows.Forms.DateTimePicker txtDOB;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Label lblSearchStudentID;
        private System.Windows.Forms.ComboBox txtGender;
        private System.Windows.Forms.ComboBox txtModule;
        private System.Windows.Forms.Button btnClear;
    }
}