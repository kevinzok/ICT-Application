namespace WindowsFormsApplication1
{
    partial class Reservation
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabSchedule = new System.Windows.Forms.TabPage();
            this.cbBoxEmployee = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbBoxScheduleView = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.bttnDeleteEmployees = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lboxWorks = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.bttnEditProfile = new System.Windows.Forms.Button();
            this.bttnAddEmployee = new System.Windows.Forms.Button();
            this.lboxEmployee = new System.Windows.Forms.ListBox();
            this.tabWorkingField = new System.Windows.Forms.TabPage();
            this.tabServices = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.bttnDeleteServices = new System.Windows.Forms.Button();
            this.bttnEditServices = new System.Windows.Forms.Button();
            this.bttnAddServices = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.tabSchedule.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabEmployees.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabServices.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.userManualToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.aboutUsToolStripMenuItem.Text = "About us";
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.userManualToolStripMenuItem.Text = "User Manual";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(127, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabSchedule);
            this.tabPage.Controls.Add(this.tabEmployees);
            this.tabPage.Controls.Add(this.tabWorkingField);
            this.tabPage.Controls.Add(this.tabServices);
            this.tabPage.Location = new System.Drawing.Point(11, 27);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(662, 422);
            this.tabPage.TabIndex = 6;
            this.tabPage.SelectedIndexChanged += new System.EventHandler(this.ChangeTab);
            // 
            // tabSchedule
            // 
            this.tabSchedule.Controls.Add(this.cbBoxEmployee);
            this.tabSchedule.Controls.Add(this.label13);
            this.tabSchedule.Controls.Add(this.cbBoxScheduleView);
            this.tabSchedule.Controls.Add(this.groupBox3);
            this.tabSchedule.Location = new System.Drawing.Point(4, 22);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabSchedule.Size = new System.Drawing.Size(654, 396);
            this.tabSchedule.TabIndex = 0;
            this.tabSchedule.Text = "Schedule";
            this.tabSchedule.UseVisualStyleBackColor = true;
            // 
            // cbBoxEmployee
            // 
            this.cbBoxEmployee.FormattingEnabled = true;
            this.cbBoxEmployee.Location = new System.Drawing.Point(18, 105);
            this.cbBoxEmployee.Name = "cbBoxEmployee";
            this.cbBoxEmployee.Size = new System.Drawing.Size(121, 21);
            this.cbBoxEmployee.TabIndex = 6;
            this.cbBoxEmployee.Text = "--Employee--";
            this.cbBoxEmployee.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Schedule View";
            // 
            // cbBoxScheduleView
            // 
            this.cbBoxScheduleView.FormattingEnabled = true;
            this.cbBoxScheduleView.Location = new System.Drawing.Point(18, 48);
            this.cbBoxScheduleView.Name = "cbBoxScheduleView";
            this.cbBoxScheduleView.Size = new System.Drawing.Size(121, 21);
            this.cbBoxScheduleView.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.monthCalendar1);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(170, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 331);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.monthCalendar1.Location = new System.Drawing.Point(12, 36);
            this.monthCalendar1.MaximumSize = new System.Drawing.Size(240, 180);
            this.monthCalendar1.MinimumSize = new System.Drawing.Size(240, 180);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(276, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(168, 290);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Make Appointment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.bttnDeleteEmployees);
            this.tabEmployees.Controls.Add(this.label7);
            this.tabEmployees.Controls.Add(this.groupBox1);
            this.tabEmployees.Controls.Add(this.bttnEditProfile);
            this.tabEmployees.Controls.Add(this.bttnAddEmployee);
            this.tabEmployees.Controls.Add(this.lboxEmployee);
            this.tabEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployees.Size = new System.Drawing.Size(654, 396);
            this.tabEmployees.TabIndex = 1;
            this.tabEmployees.Text = "Employees";
            this.tabEmployees.UseVisualStyleBackColor = true;
            // 
            // bttnDeleteEmployees
            // 
            this.bttnDeleteEmployees.Location = new System.Drawing.Point(532, 108);
            this.bttnDeleteEmployees.Name = "bttnDeleteEmployees";
            this.bttnDeleteEmployees.Size = new System.Drawing.Size(75, 23);
            this.bttnDeleteEmployees.TabIndex = 9;
            this.bttnDeleteEmployees.Text = "Delete";
            this.bttnDeleteEmployees.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Employees";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPosition);
            this.groupBox1.Controls.Add(this.lboxWorks);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBirthday);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(192, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 306);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(79, 84);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(179, 20);
            this.txtPosition.TabIndex = 3;
            // 
            // lboxWorks
            // 
            this.lboxWorks.FormattingEnabled = true;
            this.lboxWorks.Location = new System.Drawing.Point(136, 179);
            this.lboxWorks.Name = "lboxWorks";
            this.lboxWorks.Size = new System.Drawing.Size(124, 108);
            this.lboxWorks.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(79, 136);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(179, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(79, 110);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(179, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birthday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Service can be done";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(79, 58);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.ReadOnly = true;
            this.txtBirthday.Size = new System.Drawing.Size(179, 20);
            this.txtBirthday.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 33);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(179, 20);
            this.txtName.TabIndex = 1;
            // 
            // bttnEditProfile
            // 
            this.bttnEditProfile.Location = new System.Drawing.Point(532, 75);
            this.bttnEditProfile.Name = "bttnEditProfile";
            this.bttnEditProfile.Size = new System.Drawing.Size(75, 23);
            this.bttnEditProfile.TabIndex = 8;
            this.bttnEditProfile.Text = "Edit Profile";
            this.bttnEditProfile.UseVisualStyleBackColor = true;
            // 
            // bttnAddEmployee
            // 
            this.bttnAddEmployee.Location = new System.Drawing.Point(532, 40);
            this.bttnAddEmployee.Name = "bttnAddEmployee";
            this.bttnAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.bttnAddEmployee.TabIndex = 7;
            this.bttnAddEmployee.Text = "Add new";
            this.bttnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // lboxEmployee
            // 
            this.lboxEmployee.FormattingEnabled = true;
            this.lboxEmployee.Location = new System.Drawing.Point(30, 40);
            this.lboxEmployee.Name = "lboxEmployee";
            this.lboxEmployee.Size = new System.Drawing.Size(132, 290);
            this.lboxEmployee.TabIndex = 0;
            // 
            // tabWorkingField
            // 
            this.tabWorkingField.Location = new System.Drawing.Point(4, 22);
            this.tabWorkingField.Name = "tabWorkingField";
            this.tabWorkingField.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorkingField.Size = new System.Drawing.Size(654, 396);
            this.tabWorkingField.TabIndex = 2;
            this.tabWorkingField.Text = "Working field";
            this.tabWorkingField.UseVisualStyleBackColor = true;
            // 
            // tabServices
            // 
            this.tabServices.Controls.Add(this.label12);
            this.tabServices.Controls.Add(this.bttnDeleteServices);
            this.tabServices.Controls.Add(this.bttnEditServices);
            this.tabServices.Controls.Add(this.bttnAddServices);
            this.tabServices.Controls.Add(this.groupBox2);
            this.tabServices.Controls.Add(this.listBox1);
            this.tabServices.Location = new System.Drawing.Point(4, 22);
            this.tabServices.Name = "tabServices";
            this.tabServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabServices.Size = new System.Drawing.Size(654, 396);
            this.tabServices.TabIndex = 3;
            this.tabServices.Text = "Services";
            this.tabServices.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Services";
            // 
            // bttnDeleteServices
            // 
            this.bttnDeleteServices.Location = new System.Drawing.Point(541, 135);
            this.bttnDeleteServices.Name = "bttnDeleteServices";
            this.bttnDeleteServices.Size = new System.Drawing.Size(75, 23);
            this.bttnDeleteServices.TabIndex = 4;
            this.bttnDeleteServices.Text = "Delete";
            this.bttnDeleteServices.UseVisualStyleBackColor = true;
            // 
            // bttnEditServices
            // 
            this.bttnEditServices.Location = new System.Drawing.Point(541, 95);
            this.bttnEditServices.Name = "bttnEditServices";
            this.bttnEditServices.Size = new System.Drawing.Size(75, 23);
            this.bttnEditServices.TabIndex = 3;
            this.bttnEditServices.Text = "Edit";
            this.bttnEditServices.UseVisualStyleBackColor = true;
            // 
            // bttnAddServices
            // 
            this.bttnAddServices.Location = new System.Drawing.Point(541, 57);
            this.bttnAddServices.Name = "bttnAddServices";
            this.bttnAddServices.Size = new System.Drawing.Size(75, 23);
            this.bttnAddServices.TabIndex = 2;
            this.bttnAddServices.Text = "Add new";
            this.bttnAddServices.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(192, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 301);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(101, 103);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(183, 169);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Gap time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Working time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(133, 264);
            this.listBox1.TabIndex = 0;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 461);
            this.Controls.Add(this.tabPage);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reservation";
            this.Text = "Reservation Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage.ResumeLayout(false);
            this.tabSchedule.ResumeLayout(false);
            this.tabSchedule.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabEmployees.ResumeLayout(false);
            this.tabEmployees.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabServices.ResumeLayout(false);
            this.tabServices.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabSchedule;
        private System.Windows.Forms.TabPage tabEmployees;
        private System.Windows.Forms.TabPage tabWorkingField;
        private System.Windows.Forms.TabPage tabServices;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lboxWorks;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lboxEmployee;
        private System.Windows.Forms.Button bttnEditProfile;
        private System.Windows.Forms.Button bttnAddEmployee;
        private System.Windows.Forms.Button bttnDeleteEmployees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttnDeleteServices;
        private System.Windows.Forms.Button bttnEditServices;
        private System.Windows.Forms.Button bttnAddServices;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbBoxEmployee;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbBoxScheduleView;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

