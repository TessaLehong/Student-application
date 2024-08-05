﻿namespace Portal
{
    partial class ModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleForm));
            this.BlackPanelSign = new System.Windows.Forms.Panel();
            this.lblModuleWeb = new System.Windows.Forms.Label();
            this.MaroonPanelSign = new System.Windows.Forms.Panel();
            this.GoldPanelSign = new System.Windows.Forms.Panel();
            this.groupBoxCourseDetails = new System.Windows.Forms.GroupBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsertCourse = new System.Windows.Forms.Button();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnSearchCourseID = new System.Windows.Forms.Button();
            this.txtSearchCourseID = new System.Windows.Forms.TextBox();
            this.lblSearchCourseID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.picBoxModule = new System.Windows.Forms.PictureBox();
            this.BlackPanelSign.SuspendLayout();
            this.groupBoxCourseDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxModule)).BeginInit();
            this.SuspendLayout();
            // 
            // BlackPanelSign
            // 
            this.BlackPanelSign.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BlackPanelSign.Controls.Add(this.lblModuleWeb);
            this.BlackPanelSign.Location = new System.Drawing.Point(-1, 522);
            this.BlackPanelSign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BlackPanelSign.Name = "BlackPanelSign";
            this.BlackPanelSign.Size = new System.Drawing.Size(1749, 43);
            this.BlackPanelSign.TabIndex = 0;
            // 
            // lblModuleWeb
            // 
            this.lblModuleWeb.AutoSize = true;
            this.lblModuleWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleWeb.ForeColor = System.Drawing.Color.White;
            this.lblModuleWeb.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblModuleWeb.Location = new System.Drawing.Point(789, 12);
            this.lblModuleWeb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModuleWeb.Name = "lblModuleWeb";
            this.lblModuleWeb.Size = new System.Drawing.Size(212, 18);
            this.lblModuleWeb.TabIndex = 2;
            this.lblModuleWeb.Text = "www.belgiumcampus.ac.za";
            this.lblModuleWeb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MaroonPanelSign
            // 
            this.MaroonPanelSign.BackColor = System.Drawing.Color.Maroon;
            this.MaroonPanelSign.Location = new System.Drawing.Point(-1, 492);
            this.MaroonPanelSign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaroonPanelSign.Name = "MaroonPanelSign";
            this.MaroonPanelSign.Size = new System.Drawing.Size(1749, 34);
            this.MaroonPanelSign.TabIndex = 1;
            // 
            // GoldPanelSign
            // 
            this.GoldPanelSign.BackColor = System.Drawing.Color.LightSlateGray;
            this.GoldPanelSign.Location = new System.Drawing.Point(-1, 479);
            this.GoldPanelSign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoldPanelSign.Name = "GoldPanelSign";
            this.GoldPanelSign.Size = new System.Drawing.Size(1749, 25);
            this.GoldPanelSign.TabIndex = 2;
            // 
            // groupBoxCourseDetails
            // 
            this.groupBoxCourseDetails.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBoxCourseDetails.Controls.Add(this.txtLink);
            this.groupBoxCourseDetails.Controls.Add(this.txtDescription);
            this.groupBoxCourseDetails.Controls.Add(this.txtCourseName);
            this.groupBoxCourseDetails.Controls.Add(this.txtCourseID);
            this.groupBoxCourseDetails.Controls.Add(this.label1);
            this.groupBoxCourseDetails.Controls.Add(this.lblDescription);
            this.groupBoxCourseDetails.Controls.Add(this.lblCourseName);
            this.groupBoxCourseDetails.Controls.Add(this.lblCourseID);
            this.groupBoxCourseDetails.Location = new System.Drawing.Point(60, 86);
            this.groupBoxCourseDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCourseDetails.Name = "groupBoxCourseDetails";
            this.groupBoxCourseDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCourseDetails.Size = new System.Drawing.Size(464, 303);
            this.groupBoxCourseDetails.TabIndex = 3;
            this.groupBoxCourseDetails.TabStop = false;
            this.groupBoxCourseDetails.Text = "Course Details";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(191, 241);
            this.txtLink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(161, 22);
            this.txtLink.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(191, 176);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(161, 22);
            this.txtDescription.TabIndex = 5;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(191, 110);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(161, 22);
            this.txtCourseName.TabIndex = 4;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(191, 42);
            this.txtCourseID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(161, 22);
            this.txtCourseID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Link To Course:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(9, 176);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(127, 25);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(8, 110);
            this.lblCourseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(151, 25);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseID.Location = new System.Drawing.Point(9, 42);
            this.lblCourseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(122, 25);
            this.lblCourseID.TabIndex = 0;
            this.lblCourseID.Text = "Course ID: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(600, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1105, 314);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnInsertCourse
            // 
            this.btnInsertCourse.BackColor = System.Drawing.Color.Maroon;
            this.btnInsertCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertCourse.ForeColor = System.Drawing.Color.White;
            this.btnInsertCourse.Location = new System.Drawing.Point(63, 396);
            this.btnInsertCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsertCourse.Name = "btnInsertCourse";
            this.btnInsertCourse.Size = new System.Drawing.Size(140, 62);
            this.btnInsertCourse.TabIndex = 5;
            this.btnInsertCourse.Text = "Insert Course";
            this.btnInsertCourse.UseVisualStyleBackColor = false;
            this.btnInsertCourse.Click += new System.EventHandler(this.btnInsertCourse_Click);
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.BackColor = System.Drawing.Color.Maroon;
            this.btnRemoveCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCourse.ForeColor = System.Drawing.Color.White;
            this.btnRemoveCourse.Location = new System.Drawing.Point(227, 396);
            this.btnRemoveCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(140, 62);
            this.btnRemoveCourse.TabIndex = 6;
            this.btnRemoveCourse.Text = "Remove Course";
            this.btnRemoveCourse.UseVisualStyleBackColor = false;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdateCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCourse.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCourse.Location = new System.Drawing.Point(387, 396);
            this.btnUpdateCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(140, 62);
            this.btnUpdateCourse.TabIndex = 7;
            this.btnUpdateCourse.Text = "Update Course";
            this.btnUpdateCourse.UseVisualStyleBackColor = false;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // btnSearchCourseID
            // 
            this.btnSearchCourseID.BackColor = System.Drawing.Color.Maroon;
            this.btnSearchCourseID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchCourseID.BackgroundImage")));
            this.btnSearchCourseID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchCourseID.Location = new System.Drawing.Point(973, 41);
            this.btnSearchCourseID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchCourseID.Name = "btnSearchCourseID";
            this.btnSearchCourseID.Size = new System.Drawing.Size(56, 33);
            this.btnSearchCourseID.TabIndex = 8;
            this.btnSearchCourseID.UseVisualStyleBackColor = false;
            this.btnSearchCourseID.Click += new System.EventHandler(this.btnSearchCourseID_Click);
            // 
            // txtSearchCourseID
            // 
            this.txtSearchCourseID.Location = new System.Drawing.Point(781, 46);
            this.txtSearchCourseID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchCourseID.Name = "txtSearchCourseID";
            this.txtSearchCourseID.Size = new System.Drawing.Size(183, 22);
            this.txtSearchCourseID.TabIndex = 9;
            this.txtSearchCourseID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchCourseID_KeyUp);
            // 
            // lblSearchCourseID
            // 
            this.lblSearchCourseID.AutoSize = true;
            this.lblSearchCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCourseID.Location = new System.Drawing.Point(596, 47);
            this.lblSearchCourseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchCourseID.Name = "lblSearchCourseID";
            this.lblSearchCourseID.Size = new System.Drawing.Size(170, 20);
            this.lblSearchCourseID.TabIndex = 10;
            this.lblSearchCourseID.Text = "Search by Course ID:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Location = new System.Drawing.Point(1595, 27);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 52);
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picBoxModule
            // 
            this.picBoxModule.Image = ((System.Drawing.Image)(resources.GetObject("picBoxModule.Image")));
            this.picBoxModule.Location = new System.Drawing.Point(-1, 5);
            this.picBoxModule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBoxModule.Name = "picBoxModule";
            this.picBoxModule.Size = new System.Drawing.Size(141, 69);
            this.picBoxModule.TabIndex = 11;
            this.picBoxModule.TabStop = false;
            // 
            // ModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1747, 564);
            this.Controls.Add(this.picBoxModule);
            this.Controls.Add(this.lblSearchCourseID);
            this.Controls.Add(this.txtSearchCourseID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearchCourseID);
            this.Controls.Add(this.btnUpdateCourse);
            this.Controls.Add(this.btnRemoveCourse);
            this.Controls.Add(this.btnInsertCourse);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxCourseDetails);
            this.Controls.Add(this.GoldPanelSign);
            this.Controls.Add(this.MaroonPanelSign);
            this.Controls.Add(this.BlackPanelSign);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModuleForm";
            this.Text = "ModuleForm";
            this.Load += new System.EventHandler(this.ModuleForm_Load);
            this.BlackPanelSign.ResumeLayout(false);
            this.BlackPanelSign.PerformLayout();
            this.groupBoxCourseDetails.ResumeLayout(false);
            this.groupBoxCourseDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxModule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BlackPanelSign;
        private System.Windows.Forms.Label lblModuleWeb;
        private System.Windows.Forms.Panel MaroonPanelSign;
        private System.Windows.Forms.Panel GoldPanelSign;
        private System.Windows.Forms.GroupBox groupBoxCourseDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsertCourse;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Button btnSearchCourseID;
        private System.Windows.Forms.TextBox txtSearchCourseID;
        private System.Windows.Forms.Label lblSearchCourseID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxModule;
    }
}