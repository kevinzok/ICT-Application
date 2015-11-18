namespace WindowsFormsApplication1
{
    partial class MakeAppointment
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxStart = new System.Windows.Forms.ComboBox();
            this.cboxEnd = new System.Windows.Forms.ComboBox();
            this.lboxServices = new System.Windows.Forms.ListBox();
            this.lboxEmployee = new System.Windows.Forms.ListBox();
            this.lboxWorkfield = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bttnMakeAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // cboxStart
            // 
            this.cboxStart.FormattingEnabled = true;
            this.cboxStart.Location = new System.Drawing.Point(247, 39);
            this.cboxStart.Name = "cboxStart";
            this.cboxStart.Size = new System.Drawing.Size(121, 21);
            this.cboxStart.TabIndex = 2;
            // 
            // cboxEnd
            // 
            this.cboxEnd.FormattingEnabled = true;
            this.cboxEnd.Location = new System.Drawing.Point(374, 39);
            this.cboxEnd.Name = "cboxEnd";
            this.cboxEnd.Size = new System.Drawing.Size(121, 21);
            this.cboxEnd.TabIndex = 3;
            // 
            // lboxServices
            // 
            this.lboxServices.FormattingEnabled = true;
            this.lboxServices.Location = new System.Drawing.Point(30, 103);
            this.lboxServices.Name = "lboxServices";
            this.lboxServices.Size = new System.Drawing.Size(138, 199);
            this.lboxServices.TabIndex = 4;
            // 
            // lboxEmployee
            // 
            this.lboxEmployee.FormattingEnabled = true;
            this.lboxEmployee.Location = new System.Drawing.Point(197, 103);
            this.lboxEmployee.Name = "lboxEmployee";
            this.lboxEmployee.Size = new System.Drawing.Size(138, 199);
            this.lboxEmployee.TabIndex = 5;
            // 
            // lboxWorkfield
            // 
            this.lboxWorkfield.FormattingEnabled = true;
            this.lboxWorkfield.Location = new System.Drawing.Point(357, 103);
            this.lboxWorkfield.Name = "lboxWorkfield";
            this.lboxWorkfield.Size = new System.Drawing.Size(138, 199);
            this.lboxWorkfield.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Services";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Employee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Workfield";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Start Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "End Time";
            // 
            // bttnMakeAppointment
            // 
            this.bttnMakeAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnMakeAppointment.Location = new System.Drawing.Point(210, 308);
            this.bttnMakeAppointment.Name = "bttnMakeAppointment";
            this.bttnMakeAppointment.Size = new System.Drawing.Size(110, 53);
            this.bttnMakeAppointment.TabIndex = 12;
            this.bttnMakeAppointment.Text = "Make Appointment";
            this.bttnMakeAppointment.UseVisualStyleBackColor = true;
            // 
            // MakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 394);
            this.Controls.Add(this.bttnMakeAppointment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lboxWorkfield);
            this.Controls.Add(this.lboxEmployee);
            this.Controls.Add(this.lboxServices);
            this.Controls.Add(this.cboxEnd);
            this.Controls.Add(this.cboxStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "MakeAppointment";
            this.Text = "MakeAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxStart;
        private System.Windows.Forms.ComboBox cboxEnd;
        private System.Windows.Forms.ListBox lboxServices;
        private System.Windows.Forms.ListBox lboxEmployee;
        private System.Windows.Forms.ListBox lboxWorkfield;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttnMakeAppointment;
    }
}