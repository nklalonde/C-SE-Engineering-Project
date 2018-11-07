namespace LMS
{
    partial class Student
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
            this.Btn_A_Log_Out = new System.Windows.Forms.Button();
            this.Tab_Student = new System.Windows.Forms.TabControl();
            this.Tab_SCourse1 = new System.Windows.Forms.TabPage();
            this.Txt_C1_Grade = new System.Windows.Forms.TextBox();
            this.Lbl_C1_SGrade = new System.Windows.Forms.Label();
            this.Txt_C1_SName = new System.Windows.Forms.TextBox();
            this.Lbl_C1_PName = new System.Windows.Forms.Label();
            this.Tab_SCourse2 = new System.Windows.Forms.TabPage();
            this.Tab_SCourse3 = new System.Windows.Forms.TabPage();
            this.Tab_SCourse4 = new System.Windows.Forms.TabPage();
            this.SCalendar = new System.Windows.Forms.MonthCalendar();
            this.Txt_C2_Grade = new System.Windows.Forms.TextBox();
            this.Lbl_C2_Grade = new System.Windows.Forms.Label();
            this.Txt_C2_PName = new System.Windows.Forms.TextBox();
            this.Lbl_C2_PName = new System.Windows.Forms.Label();
            this.Txt_C3_Grade = new System.Windows.Forms.TextBox();
            this.Lbl_C3_SGrade = new System.Windows.Forms.Label();
            this.Txt_C3_SName = new System.Windows.Forms.TextBox();
            this.Lbl_C3_PName = new System.Windows.Forms.Label();
            this.Txt_C4_Grade = new System.Windows.Forms.TextBox();
            this.Lbl_C4_SGrade = new System.Windows.Forms.Label();
            this.Txt_C4_SName = new System.Windows.Forms.TextBox();
            this.Lbl_C4_PName = new System.Windows.Forms.Label();
            this.Txt_C3_CDays = new System.Windows.Forms.TextBox();
            this.Lbl_C3_CDays = new System.Windows.Forms.Label();
            this.Txt_C1_CDays = new System.Windows.Forms.TextBox();
            this.Lbl_C1_CDays = new System.Windows.Forms.Label();
            this.Txt_C2_CDays = new System.Windows.Forms.TextBox();
            this.Lbl_C2_CDays = new System.Windows.Forms.Label();
            this.Txt_C4_CDays = new System.Windows.Forms.TextBox();
            this.Lbl_C4_CDays = new System.Windows.Forms.Label();
            this.Txt_C1_Begins = new System.Windows.Forms.TextBox();
            this.Lbl_C1_Begins = new System.Windows.Forms.Label();
            this.Txt_C2_Begins = new System.Windows.Forms.TextBox();
            this.Lbl_C2_Begins = new System.Windows.Forms.Label();
            this.Txt_C3_Begins = new System.Windows.Forms.TextBox();
            this.Lbl_C3_Begins = new System.Windows.Forms.Label();
            this.Txt_C4_Begins = new System.Windows.Forms.TextBox();
            this.Lbl_C4_Begins = new System.Windows.Forms.Label();
            this.Tab_Student.SuspendLayout();
            this.Tab_SCourse1.SuspendLayout();
            this.Tab_SCourse2.SuspendLayout();
            this.Tab_SCourse3.SuspendLayout();
            this.Tab_SCourse4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_A_Log_Out
            // 
            this.Btn_A_Log_Out.Font = new System.Drawing.Font("Franklin Gothic Heavy", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_A_Log_Out.Location = new System.Drawing.Point(1163, 703);
            this.Btn_A_Log_Out.Name = "Btn_A_Log_Out";
            this.Btn_A_Log_Out.Size = new System.Drawing.Size(323, 147);
            this.Btn_A_Log_Out.TabIndex = 7;
            this.Btn_A_Log_Out.Text = "Log Out";
            this.Btn_A_Log_Out.UseVisualStyleBackColor = true;
            this.Btn_A_Log_Out.Click += new System.EventHandler(this.Btn_A_Log_Out_Click);
            // 
            // Tab_Student
            // 
            this.Tab_Student.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.Tab_Student.Controls.Add(this.Tab_SCourse1);
            this.Tab_Student.Controls.Add(this.Tab_SCourse2);
            this.Tab_Student.Controls.Add(this.Tab_SCourse3);
            this.Tab_Student.Controls.Add(this.Tab_SCourse4);
            this.Tab_Student.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab_Student.Location = new System.Drawing.Point(48, 36);
            this.Tab_Student.Multiline = true;
            this.Tab_Student.Name = "Tab_Student";
            this.Tab_Student.SelectedIndex = 0;
            this.Tab_Student.Size = new System.Drawing.Size(1080, 860);
            this.Tab_Student.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.Tab_Student.TabIndex = 8;
            // 
            // Tab_SCourse1
            // 
            this.Tab_SCourse1.BackColor = System.Drawing.Color.LightGray;
            this.Tab_SCourse1.Controls.Add(this.Txt_C1_Begins);
            this.Tab_SCourse1.Controls.Add(this.Lbl_C1_Begins);
            this.Tab_SCourse1.Controls.Add(this.Txt_C1_CDays);
            this.Tab_SCourse1.Controls.Add(this.Lbl_C1_CDays);
            this.Tab_SCourse1.Controls.Add(this.Txt_C1_Grade);
            this.Tab_SCourse1.Controls.Add(this.Lbl_C1_SGrade);
            this.Tab_SCourse1.Controls.Add(this.Txt_C1_SName);
            this.Tab_SCourse1.Controls.Add(this.Lbl_C1_PName);
            this.Tab_SCourse1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab_SCourse1.Location = new System.Drawing.Point(53, 4);
            this.Tab_SCourse1.Name = "Tab_SCourse1";
            this.Tab_SCourse1.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_SCourse1.Size = new System.Drawing.Size(1023, 852);
            this.Tab_SCourse1.TabIndex = 0;
            this.Tab_SCourse1.Text = "Course 1";
            // 
            // Txt_C1_Grade
            // 
            this.Txt_C1_Grade.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_C1_Grade.Location = new System.Drawing.Point(36, 202);
            this.Txt_C1_Grade.Name = "Txt_C1_Grade";
            this.Txt_C1_Grade.Size = new System.Drawing.Size(296, 49);
            this.Txt_C1_Grade.TabIndex = 15;
            // 
            // Lbl_C1_SGrade
            // 
            this.Lbl_C1_SGrade.AutoSize = true;
            this.Lbl_C1_SGrade.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_C1_SGrade.Location = new System.Drawing.Point(28, 156);
            this.Lbl_C1_SGrade.Name = "Lbl_C1_SGrade";
            this.Lbl_C1_SGrade.Size = new System.Drawing.Size(101, 43);
            this.Lbl_C1_SGrade.TabIndex = 14;
            this.Lbl_C1_SGrade.Text = "Grade";
            // 
            // Txt_C1_SName
            // 
            this.Txt_C1_SName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_C1_SName.Location = new System.Drawing.Point(36, 77);
            this.Txt_C1_SName.Name = "Txt_C1_SName";
            this.Txt_C1_SName.Size = new System.Drawing.Size(296, 49);
            this.Txt_C1_SName.TabIndex = 13;
            // 
            // Lbl_C1_PName
            // 
            this.Lbl_C1_PName.AutoSize = true;
            this.Lbl_C1_PName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_C1_PName.Location = new System.Drawing.Point(28, 30);
            this.Lbl_C1_PName.Name = "Lbl_C1_PName";
            this.Lbl_C1_PName.Size = new System.Drawing.Size(233, 43);
            this.Lbl_C1_PName.TabIndex = 12;
            this.Lbl_C1_PName.Text = "Professor Name";
            // 
            // Tab_SCourse2
            // 
            this.Tab_SCourse2.BackColor = System.Drawing.Color.LightGray;
            this.Tab_SCourse2.Controls.Add(this.Txt_C2_Begins);
            this.Tab_SCourse2.Controls.Add(this.Lbl_C2_Begins);
            this.Tab_SCourse2.Controls.Add(this.Txt_C2_CDays);
            this.Tab_SCourse2.Controls.Add(this.Lbl_C2_CDays);
            this.Tab_SCourse2.Controls.Add(this.Txt_C2_Grade);
            this.Tab_SCourse2.Controls.Add(this.Lbl_C2_Grade);
            this.Tab_SCourse2.Controls.Add(this.Txt_C2_PName);
            this.Tab_SCourse2.Controls.Add(this.Lbl_C2_PName);
            this.Tab_SCourse2.Location = new System.Drawing.Point(53, 4);
            this.Tab_SCourse2.Name = "Tab_SCourse2";
            this.Tab_SCourse2.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_SCourse2.Size = new System.Drawing.Size(1023, 852);
            this.Tab_SCourse2.TabIndex = 1;
            this.Tab_SCourse2.Text = "Course 2";
            // 
            // Tab_SCourse3
            // 
            this.Tab_SCourse3.BackColor = System.Drawing.Color.LightGray;
            this.Tab_SCourse3.Controls.Add(this.Txt_C3_Begins);
            this.Tab_SCourse3.Controls.Add(this.Lbl_C3_Begins);
            this.Tab_SCourse3.Controls.Add(this.Txt_C3_CDays);
            this.Tab_SCourse3.Controls.Add(this.Lbl_C3_CDays);
            this.Tab_SCourse3.Controls.Add(this.Txt_C3_Grade);
            this.Tab_SCourse3.Controls.Add(this.Lbl_C3_SGrade);
            this.Tab_SCourse3.Controls.Add(this.Txt_C3_SName);
            this.Tab_SCourse3.Controls.Add(this.Lbl_C3_PName);
            this.Tab_SCourse3.Location = new System.Drawing.Point(53, 4);
            this.Tab_SCourse3.Name = "Tab_SCourse3";
            this.Tab_SCourse3.Size = new System.Drawing.Size(1023, 852);
            this.Tab_SCourse3.TabIndex = 2;
            this.Tab_SCourse3.Text = "Course 3";
            // 
            // Tab_SCourse4
            // 
            this.Tab_SCourse4.BackColor = System.Drawing.Color.LightGray;
            this.Tab_SCourse4.Controls.Add(this.Txt_C4_Begins);
            this.Tab_SCourse4.Controls.Add(this.Lbl_C4_Begins);
            this.Tab_SCourse4.Controls.Add(this.Txt_C4_CDays);
            this.Tab_SCourse4.Controls.Add(this.Lbl_C4_CDays);
            this.Tab_SCourse4.Controls.Add(this.Txt_C4_Grade);
            this.Tab_SCourse4.Controls.Add(this.Lbl_C4_SGrade);
            this.Tab_SCourse4.Controls.Add(this.Txt_C4_SName);
            this.Tab_SCourse4.Controls.Add(this.Lbl_C4_PName);
            this.Tab_SCourse4.Location = new System.Drawing.Point(53, 4);
            this.Tab_SCourse4.Name = "Tab_SCourse4";
            this.Tab_SCourse4.Size = new System.Drawing.Size(1023, 852);
            this.Tab_SCourse4.TabIndex = 3;
            this.Tab_SCourse4.Text = "Course 4";
            // 
            // SCalendar
            // 
            this.SCalendar.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.SCalendar.Location = new System.Drawing.Point(1163, 40);
            this.SCalendar.MinimumSize = new System.Drawing.Size(323, 646);
            this.SCalendar.Name = "SCalendar";
            this.SCalendar.TabIndex = 16;
            // 
            // Txt_C2_Grade
            // 
            this.Txt_C2_Grade.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_C2_Grade.Location = new System.Drawing.Point(36, 202);
            this.Txt_C2_Grade.Name = "Txt_C2_Grade";
            this.Txt_C2_Grade.Size = new System.Drawing.Size(296, 49);
            this.Txt_C2_Grade.TabIndex = 19;
            // 
            // Lbl_C2_Grade
            // 
            this.Lbl_C2_Grade.AutoSize = true;
            this.Lbl_C2_Grade.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_C2_Grade.Location = new System.Drawing.Point(28, 156);
            this.Lbl_C2_Grade.Name = "Lbl_C2_Grade";
            this.Lbl_C2_Grade.Size = new System.Drawing.Size(101, 43);
            this.Lbl_C2_Grade.TabIndex = 18;
            this.Lbl_C2_Grade.Text = "Grade";
            // 
            // Txt_C2_PName
            // 
            this.Txt_C2_PName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_C2_PName.Location = new System.Drawing.Point(36, 77);
            this.Txt_C2_PName.Name = "Txt_C2_PName";
            this.Txt_C2_PName.Size = new System.Drawing.Size(296, 49);
            this.Txt_C2_PName.TabIndex = 17;
            // 
            // Lbl_C2_PName
            // 
            this.Lbl_C2_PName.AutoSize = true;
            this.Lbl_C2_PName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_C2_PName.Location = new System.Drawing.Point(28, 30);
            this.Lbl_C2_PName.Name = "Lbl_C2_PName";
            this.Lbl_C2_PName.Size = new System.Drawing.Size(233, 43);
            this.Lbl_C2_PName.TabIndex = 16;
            this.Lbl_C2_PName.Text = "Professor Name";
            // 
            // Txt_C3_Grade
            // 
            this.Txt_C3_Grade.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_C3_Grade.Location = new System.Drawing.Point(36, 202);
            this.Txt_C3_Grade.Name = "Txt_C3_Grade";
            this.Txt_C3_Grade.Size = new System.Drawing.Size(296, 49);
            this.Txt_C3_Grade.TabIndex = 19;
            this.Txt_C3_Grade.TextChanged += new System.EventHandler(this.Txt_C3_Grade_TextChanged);
            // 
            // Lbl_C3_SGrade
            // 
            this.Lbl_C3_SGrade.AutoSize = true;
            this.Lbl_C3_SGrade.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_C3_SGrade.Location = new System.Drawing.Point(28, 156);
            this.Lbl_C3_SGrade.Name = "Lbl_C3_SGrade";
            this.Lbl_C3_SGrade.Size = new System.Drawing.Size(101, 43);
            this.Lbl_C3_SGrade.TabIndex = 18;
            this.Lbl_C3_SGrade.Text = "Grade";
            // 
            // Txt_C3_SName
            // 
            this.Txt_C3_SName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_C3_SName.Location = new System.Drawing.Point(36, 77);
            this.Txt_C3_SName.Name = "Txt_C3_SName";
            this.Txt_C3_SName.Size = new System.Drawing.Size(296, 49);
            this.Txt_C3_SName.TabIndex = 17;
            this.Txt_C3_SName.TextChanged += new System.EventHandler(this.Txt_C3_SName_TextChanged);
            // 
            // Lbl_C3_PName
            // 
            this.Lbl_C3_PName.AutoSize = true;
            this.Lbl_C3_PName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_C3_PName.Location = new System.Drawing.Point(28, 30);
            this.Lbl_C3_PName.Name = "Lbl_C3_PName";
            this.Lbl_C3_PName.Size = new System.Drawing.Size(233, 43);
            this.Lbl_C3_PName.TabIndex = 16;
            this.Lbl_C3_PName.Text = "Professor Name";
            // 
            // Txt_C4_Grade
            // 
            this.Txt_C4_Grade.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_C4_Grade.Location = new System.Drawing.Point(36, 202);
            this.Txt_C4_Grade.Name = "Txt_C4_Grade";
            this.Txt_C4_Grade.Size = new System.Drawing.Size(296, 49);
            this.Txt_C4_Grade.TabIndex = 19;
            this.Txt_C4_Grade.TextChanged += new System.EventHandler(this.Txt_C4_Grade_TextChanged);
            // 
            // Lbl_C4_SGrade
            // 
            this.Lbl_C4_SGrade.AutoSize = true;
            this.Lbl_C4_SGrade.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_C4_SGrade.Location = new System.Drawing.Point(28, 156);
            this.Lbl_C4_SGrade.Name = "Lbl_C4_SGrade";
            this.Lbl_C4_SGrade.Size = new System.Drawing.Size(101, 43);
            this.Lbl_C4_SGrade.TabIndex = 18;
            this.Lbl_C4_SGrade.Text = "Grade";
            // 
            // Txt_C4_SName
            // 
            this.Txt_C4_SName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_C4_SName.Location = new System.Drawing.Point(36, 77);
            this.Txt_C4_SName.Name = "Txt_C4_SName";
            this.Txt_C4_SName.Size = new System.Drawing.Size(296, 49);
            this.Txt_C4_SName.TabIndex = 17;
            this.Txt_C4_SName.TextChanged += new System.EventHandler(this.Txt_C4_SName_TextChanged);
            // 
            // Lbl_C4_PName
            // 
            this.Lbl_C4_PName.AutoSize = true;
            this.Lbl_C4_PName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_C4_PName.Location = new System.Drawing.Point(28, 30);
            this.Lbl_C4_PName.Name = "Lbl_C4_PName";
            this.Lbl_C4_PName.Size = new System.Drawing.Size(233, 43);
            this.Lbl_C4_PName.TabIndex = 16;
            this.Lbl_C4_PName.Text = "Professor Name";
            // 
            // Txt_C3_CDays
            // 
            this.Txt_C3_CDays.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_C3_CDays.Location = new System.Drawing.Point(36, 331);
            this.Txt_C3_CDays.Name = "Txt_C3_CDays";
            this.Txt_C3_CDays.Size = new System.Drawing.Size(296, 49);
            this.Txt_C3_CDays.TabIndex = 21;
            // 
            // Lbl_C3_CDays
            // 
            this.Lbl_C3_CDays.AutoSize = true;
            this.Lbl_C3_CDays.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_C3_CDays.Location = new System.Drawing.Point(28, 285);
            this.Lbl_C3_CDays.Name = "Lbl_C3_CDays";
            this.Lbl_C3_CDays.Size = new System.Drawing.Size(187, 43);
            this.Lbl_C3_CDays.TabIndex = 20;
            this.Lbl_C3_CDays.Text = "Course Days";
            // 
            // Txt_C1_CDays
            // 
            this.Txt_C1_CDays.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_C1_CDays.Location = new System.Drawing.Point(36, 332);
            this.Txt_C1_CDays.Name = "Txt_C1_CDays";
            this.Txt_C1_CDays.Size = new System.Drawing.Size(296, 49);
            this.Txt_C1_CDays.TabIndex = 23;
            // 
            // Lbl_C1_CDays
            // 
            this.Lbl_C1_CDays.AutoSize = true;
            this.Lbl_C1_CDays.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_C1_CDays.Location = new System.Drawing.Point(28, 285);
            this.Lbl_C1_CDays.Name = "Lbl_C1_CDays";
            this.Lbl_C1_CDays.Size = new System.Drawing.Size(187, 43);
            this.Lbl_C1_CDays.TabIndex = 22;
            this.Lbl_C1_CDays.Text = "Course Days";
            // 
            // Txt_C2_CDays
            // 
            this.Txt_C2_CDays.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_C2_CDays.Location = new System.Drawing.Point(36, 332);
            this.Txt_C2_CDays.Name = "Txt_C2_CDays";
            this.Txt_C2_CDays.Size = new System.Drawing.Size(296, 49);
            this.Txt_C2_CDays.TabIndex = 25;
            // 
            // Lbl_C2_CDays
            // 
            this.Lbl_C2_CDays.AutoSize = true;
            this.Lbl_C2_CDays.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_C2_CDays.Location = new System.Drawing.Point(28, 285);
            this.Lbl_C2_CDays.Name = "Lbl_C2_CDays";
            this.Lbl_C2_CDays.Size = new System.Drawing.Size(187, 43);
            this.Lbl_C2_CDays.TabIndex = 24;
            this.Lbl_C2_CDays.Text = "Course Days";
            // 
            // Txt_C4_CDays
            // 
            this.Txt_C4_CDays.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_C4_CDays.Location = new System.Drawing.Point(36, 330);
            this.Txt_C4_CDays.Name = "Txt_C4_CDays";
            this.Txt_C4_CDays.Size = new System.Drawing.Size(296, 49);
            this.Txt_C4_CDays.TabIndex = 25;
            // 
            // Lbl_C4_CDays
            // 
            this.Lbl_C4_CDays.AutoSize = true;
            this.Lbl_C4_CDays.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_C4_CDays.Location = new System.Drawing.Point(28, 283);
            this.Lbl_C4_CDays.Name = "Lbl_C4_CDays";
            this.Lbl_C4_CDays.Size = new System.Drawing.Size(187, 43);
            this.Lbl_C4_CDays.TabIndex = 24;
            this.Lbl_C4_CDays.Text = "Course Days";
            // 
            // Txt_C1_Begins
            // 
            this.Txt_C1_Begins.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_C1_Begins.Location = new System.Drawing.Point(36, 461);
            this.Txt_C1_Begins.Name = "Txt_C1_Begins";
            this.Txt_C1_Begins.Size = new System.Drawing.Size(296, 49);
            this.Txt_C1_Begins.TabIndex = 25;
            this.Txt_C1_Begins.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Lbl_C1_Begins
            // 
            this.Lbl_C1_Begins.AutoSize = true;
            this.Lbl_C1_Begins.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_C1_Begins.Location = new System.Drawing.Point(28, 414);
            this.Lbl_C1_Begins.Name = "Lbl_C1_Begins";
            this.Lbl_C1_Begins.Size = new System.Drawing.Size(213, 43);
            this.Lbl_C1_Begins.TabIndex = 24;
            this.Lbl_C1_Begins.Text = "Course Begins";
            this.Lbl_C1_Begins.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_C2_Begins
            // 
            this.Txt_C2_Begins.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_C2_Begins.Location = new System.Drawing.Point(36, 461);
            this.Txt_C2_Begins.Name = "Txt_C2_Begins";
            this.Txt_C2_Begins.Size = new System.Drawing.Size(296, 49);
            this.Txt_C2_Begins.TabIndex = 27;
            // 
            // Lbl_C2_Begins
            // 
            this.Lbl_C2_Begins.AutoSize = true;
            this.Lbl_C2_Begins.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_C2_Begins.Location = new System.Drawing.Point(28, 414);
            this.Lbl_C2_Begins.Name = "Lbl_C2_Begins";
            this.Lbl_C2_Begins.Size = new System.Drawing.Size(213, 43);
            this.Lbl_C2_Begins.TabIndex = 26;
            this.Lbl_C2_Begins.Text = "Course Begins";
            // 
            // Txt_C3_Begins
            // 
            this.Txt_C3_Begins.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_C3_Begins.Location = new System.Drawing.Point(36, 457);
            this.Txt_C3_Begins.Name = "Txt_C3_Begins";
            this.Txt_C3_Begins.Size = new System.Drawing.Size(296, 49);
            this.Txt_C3_Begins.TabIndex = 27;
            // 
            // Lbl_C3_Begins
            // 
            this.Lbl_C3_Begins.AutoSize = true;
            this.Lbl_C3_Begins.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_C3_Begins.Location = new System.Drawing.Point(28, 410);
            this.Lbl_C3_Begins.Name = "Lbl_C3_Begins";
            this.Lbl_C3_Begins.Size = new System.Drawing.Size(213, 43);
            this.Lbl_C3_Begins.TabIndex = 26;
            this.Lbl_C3_Begins.Text = "Course Begins";
            // 
            // Txt_C4_Begins
            // 
            this.Txt_C4_Begins.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_C4_Begins.Location = new System.Drawing.Point(36, 459);
            this.Txt_C4_Begins.Name = "Txt_C4_Begins";
            this.Txt_C4_Begins.Size = new System.Drawing.Size(296, 49);
            this.Txt_C4_Begins.TabIndex = 27;
            // 
            // Lbl_C4_Begins
            // 
            this.Lbl_C4_Begins.AutoSize = true;
            this.Lbl_C4_Begins.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_C4_Begins.Location = new System.Drawing.Point(28, 412);
            this.Lbl_C4_Begins.Name = "Lbl_C4_Begins";
            this.Lbl_C4_Begins.Size = new System.Drawing.Size(213, 43);
            this.Lbl_C4_Begins.TabIndex = 26;
            this.Lbl_C4_Begins.Text = "Course Begins";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1621, 924);
            this.Controls.Add(this.SCalendar);
            this.Controls.Add(this.Tab_Student);
            this.Controls.Add(this.Btn_A_Log_Out);
            this.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Tab_Student.ResumeLayout(false);
            this.Tab_SCourse1.ResumeLayout(false);
            this.Tab_SCourse1.PerformLayout();
            this.Tab_SCourse2.ResumeLayout(false);
            this.Tab_SCourse2.PerformLayout();
            this.Tab_SCourse3.ResumeLayout(false);
            this.Tab_SCourse3.PerformLayout();
            this.Tab_SCourse4.ResumeLayout(false);
            this.Tab_SCourse4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_A_Log_Out;
        private System.Windows.Forms.TabControl Tab_Student;
        private System.Windows.Forms.TabPage Tab_SCourse1;
        private System.Windows.Forms.TextBox Txt_C1_Grade;
        private System.Windows.Forms.Label Lbl_C1_SGrade;
        private System.Windows.Forms.TextBox Txt_C1_SName;
        private System.Windows.Forms.Label Lbl_C1_PName;
        private System.Windows.Forms.TabPage Tab_SCourse2;
        private System.Windows.Forms.TabPage Tab_SCourse3;
        private System.Windows.Forms.TabPage Tab_SCourse4;
        private System.Windows.Forms.TextBox Txt_C2_Grade;
        private System.Windows.Forms.Label Lbl_C2_Grade;
        private System.Windows.Forms.TextBox Txt_C2_PName;
        private System.Windows.Forms.Label Lbl_C2_PName;
        private System.Windows.Forms.TextBox Txt_C3_Grade;
        private System.Windows.Forms.Label Lbl_C3_SGrade;
        private System.Windows.Forms.TextBox Txt_C3_SName;
        private System.Windows.Forms.Label Lbl_C3_PName;
        private System.Windows.Forms.TextBox Txt_C4_Grade;
        private System.Windows.Forms.Label Lbl_C4_SGrade;
        private System.Windows.Forms.TextBox Txt_C4_SName;
        private System.Windows.Forms.Label Lbl_C4_PName;
        private System.Windows.Forms.MonthCalendar SCalendar;
        private System.Windows.Forms.TextBox Txt_C1_Begins;
        private System.Windows.Forms.Label Lbl_C1_Begins;
        private System.Windows.Forms.TextBox Txt_C1_CDays;
        private System.Windows.Forms.Label Lbl_C1_CDays;
        private System.Windows.Forms.TextBox Txt_C2_CDays;
        private System.Windows.Forms.Label Lbl_C2_CDays;
        private System.Windows.Forms.TextBox Txt_C3_CDays;
        private System.Windows.Forms.Label Lbl_C3_CDays;
        private System.Windows.Forms.TextBox Txt_C4_CDays;
        private System.Windows.Forms.Label Lbl_C4_CDays;
        private System.Windows.Forms.TextBox Txt_C2_Begins;
        private System.Windows.Forms.Label Lbl_C2_Begins;
        private System.Windows.Forms.TextBox Txt_C3_Begins;
        private System.Windows.Forms.Label Lbl_C3_Begins;
        private System.Windows.Forms.TextBox Txt_C4_Begins;
        private System.Windows.Forms.Label Lbl_C4_Begins;
    }
}