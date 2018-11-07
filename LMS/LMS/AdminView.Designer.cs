﻿namespace LMS
{
    partial class AdminView
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
            this.Admin_Tab_Control = new System.Windows.Forms.TabControl();
            this.Courses = new System.Windows.Forms.TabPage();
            this.Lbl_Ends = new System.Windows.Forms.Label();
            this.Txt_Ends = new System.Windows.Forms.TextBox();
            this.Txt_Mode = new System.Windows.Forms.TextBox();
            this.Lbl_Mode = new System.Windows.Forms.Label();
            this.Lbl_Begin = new System.Windows.Forms.Label();
            this.Txt_Begin = new System.Windows.Forms.TextBox();
            this.Txt_Professor = new System.Windows.Forms.TextBox();
            this.Lbl_Professor = new System.Windows.Forms.Label();
            this.Txt_Course_Num = new System.Windows.Forms.TextBox();
            this.Lbl_Course_Num = new System.Windows.Forms.Label();
            this.Txt_Course_ID = new System.Windows.Forms.TextBox();
            this.Lbl_Course_ID = new System.Windows.Forms.Label();
            this.Lbl_Course_Name = new System.Windows.Forms.Label();
            this.Txt_Course = new System.Windows.Forms.TextBox();
            this.lbl_Course_List = new System.Windows.Forms.Label();
            this.Cb_Courses = new System.Windows.Forms.ComboBox();
            this.Btn_Delete_Course = new System.Windows.Forms.Button();
            this.Btn_Modify_Course = new System.Windows.Forms.Button();
            this.Btn_Add_Course = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Professors = new System.Windows.Forms.TabPage();
            this.Txt_Office = new System.Windows.Forms.TextBox();
            this.Lbl_Office = new System.Windows.Forms.Label();
            this.Lbl_Last_Name = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lbl_Position = new System.Windows.Forms.Label();
            this.Txt_Department = new System.Windows.Forms.TextBox();
            this.Lbl_Department = new System.Windows.Forms.Label();
            this.Txt_Emp_ID = new System.Windows.Forms.TextBox();
            this.Lbl_Emp_ID = new System.Windows.Forms.Label();
            this.Lbl_First_Name = new System.Windows.Forms.Label();
            this.Txt_First_Name = new System.Windows.Forms.TextBox();
            this.Lbl_Professor_List = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Btn_Delete_Prof = new System.Windows.Forms.Button();
            this.Btn_Modify_Prof = new System.Windows.Forms.Button();
            this.Btn_Add_Prof = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Students = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Lbl_GPA = new System.Windows.Forms.Label();
            this.Lbl_Std_LName = new System.Windows.Forms.Label();
            this.Txt_Std_LName = new System.Windows.Forms.TextBox();
            this.Txt_Class_Lvl = new System.Windows.Forms.TextBox();
            this.Lbl_Class_Lvl = new System.Windows.Forms.Label();
            this.Txt_Std_ID = new System.Windows.Forms.TextBox();
            this.Lbl_Std_ID = new System.Windows.Forms.Label();
            this.Lbl_Std_FName = new System.Windows.Forms.Label();
            this.Txt_Std_FName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Btn_Delete_Std = new System.Windows.Forms.Button();
            this.Btn_Modify_Std = new System.Windows.Forms.Button();
            this.Btn_Add_Std = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Btn_Add_Tab = new System.Windows.Forms.Button();
            this.Btn_Remove_Tab = new System.Windows.Forms.Button();
            this.Btn_Remove_All_Tabs = new System.Windows.Forms.Button();
            this.Btn_A_Log_Out = new System.Windows.Forms.Button();
            this.Admin_Tab_Control.SuspendLayout();
            this.Courses.SuspendLayout();
            this.Professors.SuspendLayout();
            this.Students.SuspendLayout();
            this.SuspendLayout();
            // 
            // Admin_Tab_Control
            // 
            this.Admin_Tab_Control.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.Admin_Tab_Control.Controls.Add(this.Courses);
            this.Admin_Tab_Control.Controls.Add(this.Professors);
            this.Admin_Tab_Control.Controls.Add(this.Students);
            this.Admin_Tab_Control.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_Tab_Control.ItemSize = new System.Drawing.Size(25, 50);
            this.Admin_Tab_Control.Location = new System.Drawing.Point(35, 26);
            this.Admin_Tab_Control.Multiline = true;
            this.Admin_Tab_Control.Name = "Admin_Tab_Control";
            this.Admin_Tab_Control.SelectedIndex = 0;
            this.Admin_Tab_Control.Size = new System.Drawing.Size(1080, 860);
            this.Admin_Tab_Control.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.Admin_Tab_Control.TabIndex = 2;
            // 
            // Courses
            // 
            this.Courses.BackColor = System.Drawing.Color.LightGray;
            this.Courses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Courses.Controls.Add(this.Lbl_Ends);
            this.Courses.Controls.Add(this.Txt_Ends);
            this.Courses.Controls.Add(this.Txt_Mode);
            this.Courses.Controls.Add(this.Lbl_Mode);
            this.Courses.Controls.Add(this.Lbl_Begin);
            this.Courses.Controls.Add(this.Txt_Begin);
            this.Courses.Controls.Add(this.Txt_Professor);
            this.Courses.Controls.Add(this.Lbl_Professor);
            this.Courses.Controls.Add(this.Txt_Course_Num);
            this.Courses.Controls.Add(this.Lbl_Course_Num);
            this.Courses.Controls.Add(this.Txt_Course_ID);
            this.Courses.Controls.Add(this.Lbl_Course_ID);
            this.Courses.Controls.Add(this.Lbl_Course_Name);
            this.Courses.Controls.Add(this.Txt_Course);
            this.Courses.Controls.Add(this.lbl_Course_List);
            this.Courses.Controls.Add(this.Cb_Courses);
            this.Courses.Controls.Add(this.Btn_Delete_Course);
            this.Courses.Controls.Add(this.Btn_Modify_Course);
            this.Courses.Controls.Add(this.Btn_Add_Course);
            this.Courses.Controls.Add(this.label3);
            this.Courses.Font = new System.Drawing.Font("Franklin Gothic Heavy", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courses.Location = new System.Drawing.Point(54, 4);
            this.Courses.Name = "Courses";
            this.Courses.Padding = new System.Windows.Forms.Padding(3);
            this.Courses.Size = new System.Drawing.Size(1022, 852);
            this.Courses.TabIndex = 0;
            this.Courses.Text = "Courses";
            this.Courses.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // Lbl_Ends
            // 
            this.Lbl_Ends.AutoSize = true;
            this.Lbl_Ends.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ends.Location = new System.Drawing.Point(19, 590);
            this.Lbl_Ends.Name = "Lbl_Ends";
            this.Lbl_Ends.Size = new System.Drawing.Size(168, 43);
            this.Lbl_Ends.TabIndex = 20;
            this.Lbl_Ends.Text = "Class Ends";
            this.Lbl_Ends.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Txt_Ends
            // 
            this.Txt_Ends.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Ends.Location = new System.Drawing.Point(26, 636);
            this.Txt_Ends.Name = "Txt_Ends";
            this.Txt_Ends.Size = new System.Drawing.Size(296, 49);
            this.Txt_Ends.TabIndex = 19;
            this.Txt_Ends.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Txt_Mode
            // 
            this.Txt_Mode.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Mode.Location = new System.Drawing.Point(26, 342);
            this.Txt_Mode.Name = "Txt_Mode";
            this.Txt_Mode.Size = new System.Drawing.Size(296, 49);
            this.Txt_Mode.TabIndex = 18;
            // 
            // Lbl_Mode
            // 
            this.Lbl_Mode.AutoSize = true;
            this.Lbl_Mode.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mode.Location = new System.Drawing.Point(19, 296);
            this.Lbl_Mode.Name = "Lbl_Mode";
            this.Lbl_Mode.Size = new System.Drawing.Size(96, 43);
            this.Lbl_Mode.TabIndex = 17;
            this.Lbl_Mode.Text = "Mode";
            // 
            // Lbl_Begin
            // 
            this.Lbl_Begin.AutoSize = true;
            this.Lbl_Begin.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Begin.Location = new System.Drawing.Point(19, 492);
            this.Lbl_Begin.Name = "Lbl_Begin";
            this.Lbl_Begin.Size = new System.Drawing.Size(193, 43);
            this.Lbl_Begin.TabIndex = 16;
            this.Lbl_Begin.Text = "Class Begins";
            // 
            // Txt_Begin
            // 
            this.Txt_Begin.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Begin.Location = new System.Drawing.Point(26, 538);
            this.Txt_Begin.Name = "Txt_Begin";
            this.Txt_Begin.Size = new System.Drawing.Size(296, 49);
            this.Txt_Begin.TabIndex = 15;
            // 
            // Txt_Professor
            // 
            this.Txt_Professor.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Professor.Location = new System.Drawing.Point(26, 440);
            this.Txt_Professor.Name = "Txt_Professor";
            this.Txt_Professor.Size = new System.Drawing.Size(296, 49);
            this.Txt_Professor.TabIndex = 14;
            this.Txt_Professor.TextChanged += new System.EventHandler(this.txt_Professor_TextChanged);
            // 
            // Lbl_Professor
            // 
            this.Lbl_Professor.AutoSize = true;
            this.Lbl_Professor.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Professor.Location = new System.Drawing.Point(18, 394);
            this.Lbl_Professor.Name = "Lbl_Professor";
            this.Lbl_Professor.Size = new System.Drawing.Size(183, 43);
            this.Lbl_Professor.TabIndex = 13;
            this.Lbl_Professor.Text = "Professor ID";
            // 
            // Txt_Course_Num
            // 
            this.Txt_Course_Num.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Course_Num.Location = new System.Drawing.Point(27, 146);
            this.Txt_Course_Num.Name = "Txt_Course_Num";
            this.Txt_Course_Num.Size = new System.Drawing.Size(296, 49);
            this.Txt_Course_Num.TabIndex = 12;
            this.Txt_Course_Num.TextChanged += new System.EventHandler(this.txt_Course_Num_TextChanged);
            // 
            // Lbl_Course_Num
            // 
            this.Lbl_Course_Num.AutoSize = true;
            this.Lbl_Course_Num.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Course_Num.Location = new System.Drawing.Point(19, 100);
            this.Lbl_Course_Num.Name = "Lbl_Course_Num";
            this.Lbl_Course_Num.Size = new System.Drawing.Size(229, 43);
            this.Lbl_Course_Num.TabIndex = 11;
            this.Lbl_Course_Num.Text = "Course Number";
            // 
            // Txt_Course_ID
            // 
            this.Txt_Course_ID.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Course_ID.Location = new System.Drawing.Point(26, 48);
            this.Txt_Course_ID.Name = "Txt_Course_ID";
            this.Txt_Course_ID.Size = new System.Drawing.Size(296, 49);
            this.Txt_Course_ID.TabIndex = 10;
            this.Txt_Course_ID.TextChanged += new System.EventHandler(this.txt_Course_ID_TextChanged);
            // 
            // Lbl_Course_ID
            // 
            this.Lbl_Course_ID.AutoSize = true;
            this.Lbl_Course_ID.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Course_ID.Location = new System.Drawing.Point(19, 11);
            this.Lbl_Course_ID.Name = "Lbl_Course_ID";
            this.Lbl_Course_ID.Size = new System.Drawing.Size(151, 43);
            this.Lbl_Course_ID.TabIndex = 9;
            this.Lbl_Course_ID.Text = "Course ID";
            // 
            // Lbl_Course_Name
            // 
            this.Lbl_Course_Name.AutoSize = true;
            this.Lbl_Course_Name.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Course_Name.Location = new System.Drawing.Point(19, 198);
            this.Lbl_Course_Name.Name = "Lbl_Course_Name";
            this.Lbl_Course_Name.Size = new System.Drawing.Size(201, 43);
            this.Lbl_Course_Name.TabIndex = 8;
            this.Lbl_Course_Name.Text = "Course Name";
            // 
            // Txt_Course
            // 
            this.Txt_Course.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Course.Location = new System.Drawing.Point(26, 244);
            this.Txt_Course.Name = "Txt_Course";
            this.Txt_Course.Size = new System.Drawing.Size(296, 49);
            this.Txt_Course.TabIndex = 7;
            this.Txt_Course.TextChanged += new System.EventHandler(this.txt_Course_TextChanged);
            // 
            // lbl_Course_List
            // 
            this.lbl_Course_List.AutoSize = true;
            this.lbl_Course_List.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_List.Location = new System.Drawing.Point(348, 11);
            this.lbl_Course_List.Name = "lbl_Course_List";
            this.lbl_Course_List.Size = new System.Drawing.Size(169, 43);
            this.lbl_Course_List.TabIndex = 6;
            this.lbl_Course_List.Text = "Course List";
            // 
            // Cb_Courses
            // 
            this.Cb_Courses.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Courses.FormattingEnabled = true;
            this.Cb_Courses.Location = new System.Drawing.Point(356, 57);
            this.Cb_Courses.Name = "Cb_Courses";
            this.Cb_Courses.Size = new System.Drawing.Size(622, 51);
            this.Cb_Courses.TabIndex = 5;
            this.Cb_Courses.SelectedIndexChanged += new System.EventHandler(this.cb_Courses_SelectedIndexChanged);
            // 
            // Btn_Delete_Course
            // 
            this.Btn_Delete_Course.Location = new System.Drawing.Point(682, 694);
            this.Btn_Delete_Course.Name = "Btn_Delete_Course";
            this.Btn_Delete_Course.Size = new System.Drawing.Size(296, 148);
            this.Btn_Delete_Course.TabIndex = 4;
            this.Btn_Delete_Course.Text = "Delete Course";
            this.Btn_Delete_Course.UseVisualStyleBackColor = true;
            // 
            // Btn_Modify_Course
            // 
            this.Btn_Modify_Course.Location = new System.Drawing.Point(356, 691);
            this.Btn_Modify_Course.Name = "Btn_Modify_Course";
            this.Btn_Modify_Course.Size = new System.Drawing.Size(296, 148);
            this.Btn_Modify_Course.TabIndex = 3;
            this.Btn_Modify_Course.Text = "Modify Course";
            this.Btn_Modify_Course.UseVisualStyleBackColor = true;
            // 
            // Btn_Add_Course
            // 
            this.Btn_Add_Course.Location = new System.Drawing.Point(26, 691);
            this.Btn_Add_Course.Name = "Btn_Add_Course";
            this.Btn_Add_Course.Size = new System.Drawing.Size(296, 148);
            this.Btn_Add_Course.TabIndex = 2;
            this.Btn_Add_Course.Text = "Add Course";
            this.Btn_Add_Course.UseVisualStyleBackColor = true;
            this.Btn_Add_Course.Click += new System.EventHandler(this.Add_Course_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(628, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 43);
            this.label3.TabIndex = 1;
            // 
            // Professors
            // 
            this.Professors.BackColor = System.Drawing.Color.LightGray;
            this.Professors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Professors.Controls.Add(this.Txt_Office);
            this.Professors.Controls.Add(this.Lbl_Office);
            this.Professors.Controls.Add(this.Lbl_Last_Name);
            this.Professors.Controls.Add(this.textBox2);
            this.Professors.Controls.Add(this.textBox1);
            this.Professors.Controls.Add(this.Lbl_Position);
            this.Professors.Controls.Add(this.Txt_Department);
            this.Professors.Controls.Add(this.Lbl_Department);
            this.Professors.Controls.Add(this.Txt_Emp_ID);
            this.Professors.Controls.Add(this.Lbl_Emp_ID);
            this.Professors.Controls.Add(this.Lbl_First_Name);
            this.Professors.Controls.Add(this.Txt_First_Name);
            this.Professors.Controls.Add(this.Lbl_Professor_List);
            this.Professors.Controls.Add(this.comboBox1);
            this.Professors.Controls.Add(this.Btn_Delete_Prof);
            this.Professors.Controls.Add(this.Btn_Modify_Prof);
            this.Professors.Controls.Add(this.Btn_Add_Prof);
            this.Professors.Controls.Add(this.label7);
            this.Professors.Location = new System.Drawing.Point(54, 4);
            this.Professors.Name = "Professors";
            this.Professors.Padding = new System.Windows.Forms.Padding(3);
            this.Professors.Size = new System.Drawing.Size(1022, 852);
            this.Professors.TabIndex = 1;
            this.Professors.Text = "Professors";
            this.Professors.Click += new System.EventHandler(this.Professors_Click);
            // 
            // Txt_Office
            // 
            this.Txt_Office.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Office.Location = new System.Drawing.Point(27, 547);
            this.Txt_Office.Name = "Txt_Office";
            this.Txt_Office.Size = new System.Drawing.Size(296, 49);
            this.Txt_Office.TabIndex = 32;
            // 
            // Lbl_Office
            // 
            this.Lbl_Office.AutoSize = true;
            this.Lbl_Office.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Office.Location = new System.Drawing.Point(19, 501);
            this.Lbl_Office.Name = "Lbl_Office";
            this.Lbl_Office.Size = new System.Drawing.Size(212, 43);
            this.Lbl_Office.TabIndex = 31;
            this.Lbl_Office.Text = "Office Number";
            // 
            // Lbl_Last_Name
            // 
            this.Lbl_Last_Name.AutoSize = true;
            this.Lbl_Last_Name.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Last_Name.Location = new System.Drawing.Point(19, 207);
            this.Lbl_Last_Name.Name = "Lbl_Last_Name";
            this.Lbl_Last_Name.Size = new System.Drawing.Size(163, 43);
            this.Lbl_Last_Name.TabIndex = 30;
            this.Lbl_Last_Name.Text = "Last Name";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(27, 253);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(296, 49);
            this.textBox2.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(27, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 49);
            this.textBox1.TabIndex = 28;
            // 
            // Lbl_Position
            // 
            this.Lbl_Position.AutoSize = true;
            this.Lbl_Position.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Position.Location = new System.Drawing.Point(19, 305);
            this.Lbl_Position.Name = "Lbl_Position";
            this.Lbl_Position.Size = new System.Drawing.Size(129, 43);
            this.Lbl_Position.TabIndex = 27;
            this.Lbl_Position.Text = "Position";
            // 
            // Txt_Department
            // 
            this.Txt_Department.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Department.Location = new System.Drawing.Point(27, 449);
            this.Txt_Department.Name = "Txt_Department";
            this.Txt_Department.Size = new System.Drawing.Size(296, 49);
            this.Txt_Department.TabIndex = 26;
            // 
            // Lbl_Department
            // 
            this.Lbl_Department.AutoSize = true;
            this.Lbl_Department.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Department.Location = new System.Drawing.Point(19, 403);
            this.Lbl_Department.Name = "Lbl_Department";
            this.Lbl_Department.Size = new System.Drawing.Size(180, 43);
            this.Lbl_Department.TabIndex = 25;
            this.Lbl_Department.Text = "Department";
            // 
            // Txt_Emp_ID
            // 
            this.Txt_Emp_ID.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Emp_ID.Location = new System.Drawing.Point(27, 57);
            this.Txt_Emp_ID.Name = "Txt_Emp_ID";
            this.Txt_Emp_ID.Size = new System.Drawing.Size(296, 49);
            this.Txt_Emp_ID.TabIndex = 24;
            // 
            // Lbl_Emp_ID
            // 
            this.Lbl_Emp_ID.AutoSize = true;
            this.Lbl_Emp_ID.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Emp_ID.Location = new System.Drawing.Point(19, 11);
            this.Lbl_Emp_ID.Name = "Lbl_Emp_ID";
            this.Lbl_Emp_ID.Size = new System.Drawing.Size(187, 43);
            this.Lbl_Emp_ID.TabIndex = 23;
            this.Lbl_Emp_ID.Text = "Employee ID";
            // 
            // Lbl_First_Name
            // 
            this.Lbl_First_Name.AutoSize = true;
            this.Lbl_First_Name.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_First_Name.Location = new System.Drawing.Point(19, 109);
            this.Lbl_First_Name.Name = "Lbl_First_Name";
            this.Lbl_First_Name.Size = new System.Drawing.Size(165, 43);
            this.Lbl_First_Name.TabIndex = 22;
            this.Lbl_First_Name.Text = "First Name";
            // 
            // Txt_First_Name
            // 
            this.Txt_First_Name.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_First_Name.Location = new System.Drawing.Point(27, 155);
            this.Txt_First_Name.Name = "Txt_First_Name";
            this.Txt_First_Name.Size = new System.Drawing.Size(296, 49);
            this.Txt_First_Name.TabIndex = 21;
            // 
            // Lbl_Professor_List
            // 
            this.Lbl_Professor_List.AutoSize = true;
            this.Lbl_Professor_List.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Professor_List.Location = new System.Drawing.Point(350, 11);
            this.Lbl_Professor_List.Name = "Lbl_Professor_List";
            this.Lbl_Professor_List.Size = new System.Drawing.Size(201, 43);
            this.Lbl_Professor_List.TabIndex = 20;
            this.Lbl_Professor_List.Text = "Professor List";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(358, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(624, 51);
            this.comboBox1.TabIndex = 19;
            // 
            // Btn_Delete_Prof
            // 
            this.Btn_Delete_Prof.Font = new System.Drawing.Font("Franklin Gothic Heavy", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete_Prof.Location = new System.Drawing.Point(686, 689);
            this.Btn_Delete_Prof.Name = "Btn_Delete_Prof";
            this.Btn_Delete_Prof.Size = new System.Drawing.Size(296, 148);
            this.Btn_Delete_Prof.TabIndex = 18;
            this.Btn_Delete_Prof.Text = "Delete Professor";
            this.Btn_Delete_Prof.UseVisualStyleBackColor = true;
            // 
            // Btn_Modify_Prof
            // 
            this.Btn_Modify_Prof.Font = new System.Drawing.Font("Franklin Gothic Heavy", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modify_Prof.Location = new System.Drawing.Point(358, 691);
            this.Btn_Modify_Prof.Name = "Btn_Modify_Prof";
            this.Btn_Modify_Prof.Size = new System.Drawing.Size(296, 148);
            this.Btn_Modify_Prof.TabIndex = 17;
            this.Btn_Modify_Prof.Text = "Modify Professor";
            this.Btn_Modify_Prof.UseVisualStyleBackColor = true;
            // 
            // Btn_Add_Prof
            // 
            this.Btn_Add_Prof.Font = new System.Drawing.Font("Franklin Gothic Heavy", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add_Prof.Location = new System.Drawing.Point(26, 691);
            this.Btn_Add_Prof.Name = "Btn_Add_Prof";
            this.Btn_Add_Prof.Size = new System.Drawing.Size(296, 148);
            this.Btn_Add_Prof.TabIndex = 16;
            this.Btn_Add_Prof.Text = "Add Professor";
            this.Btn_Add_Prof.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(683, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 43);
            this.label7.TabIndex = 15;
            // 
            // Students
            // 
            this.Students.BackColor = System.Drawing.Color.LightGray;
            this.Students.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Students.Controls.Add(this.textBox3);
            this.Students.Controls.Add(this.Lbl_GPA);
            this.Students.Controls.Add(this.Lbl_Std_LName);
            this.Students.Controls.Add(this.Txt_Std_LName);
            this.Students.Controls.Add(this.Txt_Class_Lvl);
            this.Students.Controls.Add(this.Lbl_Class_Lvl);
            this.Students.Controls.Add(this.Txt_Std_ID);
            this.Students.Controls.Add(this.Lbl_Std_ID);
            this.Students.Controls.Add(this.Lbl_Std_FName);
            this.Students.Controls.Add(this.Txt_Std_FName);
            this.Students.Controls.Add(this.label9);
            this.Students.Controls.Add(this.comboBox2);
            this.Students.Controls.Add(this.Btn_Delete_Std);
            this.Students.Controls.Add(this.Btn_Modify_Std);
            this.Students.Controls.Add(this.Btn_Add_Std);
            this.Students.Controls.Add(this.label10);
            this.Students.Location = new System.Drawing.Point(54, 4);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(1022, 852);
            this.Students.TabIndex = 2;
            this.Students.Text = "Students";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(25, 449);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(296, 49);
            this.textBox3.TabIndex = 50;
            // 
            // Lbl_GPA
            // 
            this.Lbl_GPA.AutoSize = true;
            this.Lbl_GPA.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GPA.Location = new System.Drawing.Point(19, 403);
            this.Lbl_GPA.Name = "Lbl_GPA";
            this.Lbl_GPA.Size = new System.Drawing.Size(176, 43);
            this.Lbl_GPA.TabIndex = 49;
            this.Lbl_GPA.Text = "Overall GPA";
            // 
            // Lbl_Std_LName
            // 
            this.Lbl_Std_LName.AutoSize = true;
            this.Lbl_Std_LName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Std_LName.Location = new System.Drawing.Point(17, 207);
            this.Lbl_Std_LName.Name = "Lbl_Std_LName";
            this.Lbl_Std_LName.Size = new System.Drawing.Size(163, 43);
            this.Lbl_Std_LName.TabIndex = 48;
            this.Lbl_Std_LName.Text = "Last Name";
            // 
            // Txt_Std_LName
            // 
            this.Txt_Std_LName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Std_LName.Location = new System.Drawing.Point(25, 253);
            this.Txt_Std_LName.Name = "Txt_Std_LName";
            this.Txt_Std_LName.Size = new System.Drawing.Size(296, 49);
            this.Txt_Std_LName.TabIndex = 47;
            // 
            // Txt_Class_Lvl
            // 
            this.Txt_Class_Lvl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Class_Lvl.Location = new System.Drawing.Point(25, 351);
            this.Txt_Class_Lvl.Name = "Txt_Class_Lvl";
            this.Txt_Class_Lvl.Size = new System.Drawing.Size(296, 49);
            this.Txt_Class_Lvl.TabIndex = 46;
            // 
            // Lbl_Class_Lvl
            // 
            this.Lbl_Class_Lvl.AutoSize = true;
            this.Lbl_Class_Lvl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Class_Lvl.Location = new System.Drawing.Point(19, 305);
            this.Lbl_Class_Lvl.Name = "Lbl_Class_Lvl";
            this.Lbl_Class_Lvl.Size = new System.Drawing.Size(169, 43);
            this.Lbl_Class_Lvl.TabIndex = 45;
            this.Lbl_Class_Lvl.Text = "Class Level";
            // 
            // Txt_Std_ID
            // 
            this.Txt_Std_ID.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Std_ID.Location = new System.Drawing.Point(25, 57);
            this.Txt_Std_ID.Name = "Txt_Std_ID";
            this.Txt_Std_ID.Size = new System.Drawing.Size(296, 49);
            this.Txt_Std_ID.TabIndex = 42;
            // 
            // Lbl_Std_ID
            // 
            this.Lbl_Std_ID.AutoSize = true;
            this.Lbl_Std_ID.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Std_ID.Location = new System.Drawing.Point(19, 11);
            this.Lbl_Std_ID.Name = "Lbl_Std_ID";
            this.Lbl_Std_ID.Size = new System.Drawing.Size(163, 43);
            this.Lbl_Std_ID.TabIndex = 41;
            this.Lbl_Std_ID.Text = "Student ID";
            // 
            // Lbl_Std_FName
            // 
            this.Lbl_Std_FName.AutoSize = true;
            this.Lbl_Std_FName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Std_FName.Location = new System.Drawing.Point(17, 109);
            this.Lbl_Std_FName.Name = "Lbl_Std_FName";
            this.Lbl_Std_FName.Size = new System.Drawing.Size(165, 43);
            this.Lbl_Std_FName.TabIndex = 40;
            this.Lbl_Std_FName.Text = "First Name";
            // 
            // Txt_Std_FName
            // 
            this.Txt_Std_FName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Std_FName.Location = new System.Drawing.Point(25, 155);
            this.Txt_Std_FName.Name = "Txt_Std_FName";
            this.Txt_Std_FName.Size = new System.Drawing.Size(296, 49);
            this.Txt_Std_FName.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(345, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 43);
            this.label9.TabIndex = 38;
            this.label9.Text = "Professor List";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(353, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(631, 51);
            this.comboBox2.TabIndex = 37;
            // 
            // Btn_Delete_Std
            // 
            this.Btn_Delete_Std.Font = new System.Drawing.Font("Franklin Gothic Heavy", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete_Std.Location = new System.Drawing.Point(688, 690);
            this.Btn_Delete_Std.Name = "Btn_Delete_Std";
            this.Btn_Delete_Std.Size = new System.Drawing.Size(296, 149);
            this.Btn_Delete_Std.TabIndex = 36;
            this.Btn_Delete_Std.Text = "Delete Student";
            this.Btn_Delete_Std.UseVisualStyleBackColor = true;
            // 
            // Btn_Modify_Std
            // 
            this.Btn_Modify_Std.Font = new System.Drawing.Font("Franklin Gothic Heavy", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modify_Std.Location = new System.Drawing.Point(353, 690);
            this.Btn_Modify_Std.Name = "Btn_Modify_Std";
            this.Btn_Modify_Std.Size = new System.Drawing.Size(296, 149);
            this.Btn_Modify_Std.TabIndex = 35;
            this.Btn_Modify_Std.Text = "Modify Student";
            this.Btn_Modify_Std.UseVisualStyleBackColor = true;
            // 
            // Btn_Add_Std
            // 
            this.Btn_Add_Std.Font = new System.Drawing.Font("Franklin Gothic Heavy", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add_Std.Location = new System.Drawing.Point(25, 687);
            this.Btn_Add_Std.Name = "Btn_Add_Std";
            this.Btn_Add_Std.Size = new System.Drawing.Size(296, 149);
            this.Btn_Add_Std.TabIndex = 34;
            this.Btn_Add_Std.Text = "Add Student";
            this.Btn_Add_Std.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(700, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 43);
            this.label10.TabIndex = 33;
            // 
            // Btn_Add_Tab
            // 
            this.Btn_Add_Tab.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add_Tab.Location = new System.Drawing.Point(1150, 43);
            this.Btn_Add_Tab.Name = "Btn_Add_Tab";
            this.Btn_Add_Tab.Size = new System.Drawing.Size(323, 147);
            this.Btn_Add_Tab.TabIndex = 3;
            this.Btn_Add_Tab.Text = "Add New Tab";
            this.Btn_Add_Tab.UseVisualStyleBackColor = true;
            this.Btn_Add_Tab.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Remove_Tab
            // 
            this.Btn_Remove_Tab.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Remove_Tab.Location = new System.Drawing.Point(1150, 259);
            this.Btn_Remove_Tab.Name = "Btn_Remove_Tab";
            this.Btn_Remove_Tab.Size = new System.Drawing.Size(323, 147);
            this.Btn_Remove_Tab.TabIndex = 4;
            this.Btn_Remove_Tab.Text = "Remove Tab";
            this.Btn_Remove_Tab.UseVisualStyleBackColor = true;
            this.Btn_Remove_Tab.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Remove_All_Tabs
            // 
            this.Btn_Remove_All_Tabs.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Remove_All_Tabs.Location = new System.Drawing.Point(1150, 495);
            this.Btn_Remove_All_Tabs.Name = "Btn_Remove_All_Tabs";
            this.Btn_Remove_All_Tabs.Size = new System.Drawing.Size(323, 147);
            this.Btn_Remove_All_Tabs.TabIndex = 5;
            this.Btn_Remove_All_Tabs.Text = "Remove All Tabs";
            this.Btn_Remove_All_Tabs.UseVisualStyleBackColor = true;
            this.Btn_Remove_All_Tabs.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btn_A_Log_Out
            // 
            this.Btn_A_Log_Out.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_A_Log_Out.Location = new System.Drawing.Point(1150, 722);
            this.Btn_A_Log_Out.Name = "Btn_A_Log_Out";
            this.Btn_A_Log_Out.Size = new System.Drawing.Size(323, 147);
            this.Btn_A_Log_Out.TabIndex = 6;
            this.Btn_A_Log_Out.Text = "Log Out";
            this.Btn_A_Log_Out.UseVisualStyleBackColor = true;
            this.Btn_A_Log_Out.Click += new System.EventHandler(this.Btn_A_Log_Out_Click);
            // 
            // AdminView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1614, 908);
            this.Controls.Add(this.Btn_A_Log_Out);
            this.Controls.Add(this.Btn_Remove_All_Tabs);
            this.Controls.Add(this.Btn_Remove_Tab);
            this.Controls.Add(this.Btn_Add_Tab);
            this.Controls.Add(this.Admin_Tab_Control);
            this.Name = "AdminView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.Admin_Tab_Control.ResumeLayout(false);
            this.Courses.ResumeLayout(false);
            this.Courses.PerformLayout();
            this.Professors.ResumeLayout(false);
            this.Professors.PerformLayout();
            this.Students.ResumeLayout(false);
            this.Students.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Admin_Tab_Control;
        private System.Windows.Forms.TabPage Courses;
        private System.Windows.Forms.TabPage Professors;
        private System.Windows.Forms.Button Btn_Add_Tab;
        private System.Windows.Forms.Button Btn_Remove_Tab;
        private System.Windows.Forms.Button Btn_Remove_All_Tabs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage Students;
        private System.Windows.Forms.Button Btn_Delete_Course;
        private System.Windows.Forms.Button Btn_Modify_Course;
        private System.Windows.Forms.Button Btn_Add_Course;
        private System.Windows.Forms.Button Btn_A_Log_Out;
        private System.Windows.Forms.ComboBox Cb_Courses;
        private System.Windows.Forms.Label lbl_Course_List;
        private System.Windows.Forms.TextBox Txt_Professor;
        private System.Windows.Forms.Label Lbl_Professor;
        private System.Windows.Forms.TextBox Txt_Course_Num;
        private System.Windows.Forms.Label Lbl_Course_Num;
        private System.Windows.Forms.TextBox Txt_Course_ID;
        private System.Windows.Forms.Label Lbl_Course_ID;
        private System.Windows.Forms.Label Lbl_Course_Name;
        private System.Windows.Forms.TextBox Txt_Course;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lbl_Position;
        private System.Windows.Forms.TextBox Txt_Department;
        private System.Windows.Forms.Label Lbl_Department;
        private System.Windows.Forms.TextBox Txt_Emp_ID;
        private System.Windows.Forms.Label Lbl_Emp_ID;
        private System.Windows.Forms.Label Lbl_First_Name;
        private System.Windows.Forms.TextBox Txt_First_Name;
        private System.Windows.Forms.Label Lbl_Professor_List;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Btn_Delete_Prof;
        private System.Windows.Forms.Button Btn_Modify_Prof;
        private System.Windows.Forms.Button Btn_Add_Prof;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lbl_Last_Name;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Txt_Office;
        private System.Windows.Forms.Label Lbl_Office;
        private System.Windows.Forms.TextBox Txt_Mode;
        private System.Windows.Forms.Label Lbl_Mode;
        private System.Windows.Forms.Label Lbl_Begin;
        private System.Windows.Forms.TextBox Txt_Begin;
        private System.Windows.Forms.Label Lbl_Ends;
        private System.Windows.Forms.TextBox Txt_Ends;
        private System.Windows.Forms.Label Lbl_Std_LName;
        private System.Windows.Forms.TextBox Txt_Std_LName;
        private System.Windows.Forms.TextBox Txt_Class_Lvl;
        private System.Windows.Forms.Label Lbl_Class_Lvl;
        private System.Windows.Forms.TextBox Txt_Std_ID;
        private System.Windows.Forms.Label Lbl_Std_ID;
        private System.Windows.Forms.Label Lbl_Std_FName;
        private System.Windows.Forms.TextBox Txt_Std_FName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button Btn_Delete_Std;
        private System.Windows.Forms.Button Btn_Modify_Std;
        private System.Windows.Forms.Button Btn_Add_Std;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Lbl_GPA;
    }
}