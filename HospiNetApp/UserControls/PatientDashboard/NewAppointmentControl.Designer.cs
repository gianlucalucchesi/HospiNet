
namespace HospiNetApp.UserControls.PatientDashboard
{
    partial class NewAppointmentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_Specialities = new System.Windows.Forms.ComboBox();
            this.comboBox_Doctors = new System.Windows.Forms.ComboBox();
            this.comboBox_Hospitals = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar_AppointmentDate = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker_patientBirthday = new System.Windows.Forms.DateTimePicker();
            this.textBox_patientFirstName = new System.Windows.Forms.TextBox();
            this.textBox_patientLastName = new System.Windows.Forms.TextBox();
            this.comboBox_AppointmentHour = new System.Windows.Forms.ComboBox();
            this.comboBox_AppointmentMinutes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_SuccessFailed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_Specialities
            // 
            this.comboBox_Specialities.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Specialities.FormattingEnabled = true;
            this.comboBox_Specialities.Items.AddRange(new object[] {
            "Allergy & Immunology",
            "Anesthesiology",
            "Dermatology",
            "Emergency Medicine",
            "Family Medicine",
            "Gynecology",
            "Infectious diseases",
            "Internal Medicine",
            "Medical Genetics",
            "Nephrology",
            "Neurology",
            "Nuclear Medicine",
            "Oncology",
            "Opthalmology",
            "Pathology",
            "Pediatrics",
            "Psychiatry",
            "Radiology",
            "Surgery",
            "Urology"});
            this.comboBox_Specialities.Location = new System.Drawing.Point(194, 111);
            this.comboBox_Specialities.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Specialities.Name = "comboBox_Specialities";
            this.comboBox_Specialities.Size = new System.Drawing.Size(290, 30);
            this.comboBox_Specialities.TabIndex = 0;
            this.comboBox_Specialities.SelectedIndexChanged += new System.EventHandler(this.comboBox_Specialities_SelectedIndexChanged);
            // 
            // comboBox_Doctors
            // 
            this.comboBox_Doctors.Enabled = false;
            this.comboBox_Doctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Doctors.FormattingEnabled = true;
            this.comboBox_Doctors.Location = new System.Drawing.Point(194, 174);
            this.comboBox_Doctors.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Doctors.Name = "comboBox_Doctors";
            this.comboBox_Doctors.Size = new System.Drawing.Size(290, 30);
            this.comboBox_Doctors.TabIndex = 1;
            // 
            // comboBox_Hospitals
            // 
            this.comboBox_Hospitals.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Hospitals.FormattingEnabled = true;
            this.comboBox_Hospitals.Location = new System.Drawing.Point(194, 231);
            this.comboBox_Hospitals.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Hospitals.Name = "comboBox_Hospitals";
            this.comboBox_Hospitals.Size = new System.Drawing.Size(290, 30);
            this.comboBox_Hospitals.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Speciality:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doctor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hospital:";
            // 
            // monthCalendar_AppointmentDate
            // 
            this.monthCalendar_AppointmentDate.Location = new System.Drawing.Point(665, 99);
            this.monthCalendar_AppointmentDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.monthCalendar_AppointmentDate.Name = "monthCalendar_AppointmentDate";
            this.monthCalendar_AppointmentDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 343);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Your details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Appointment details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 527);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Birthday:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 465);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Last name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(84, 407);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "First name:";
            // 
            // dateTimePicker_patientBirthday
            // 
            this.dateTimePicker_patientBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_patientBirthday.Location = new System.Drawing.Point(194, 527);
            this.dateTimePicker_patientBirthday.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_patientBirthday.Name = "dateTimePicker_patientBirthday";
            this.dateTimePicker_patientBirthday.Size = new System.Drawing.Size(290, 28);
            this.dateTimePicker_patientBirthday.TabIndex = 15;
            // 
            // textBox_patientFirstName
            // 
            this.textBox_patientFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_patientFirstName.Location = new System.Drawing.Point(194, 405);
            this.textBox_patientFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_patientFirstName.Name = "textBox_patientFirstName";
            this.textBox_patientFirstName.Size = new System.Drawing.Size(290, 28);
            this.textBox_patientFirstName.TabIndex = 16;
            // 
            // textBox_patientLastName
            // 
            this.textBox_patientLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_patientLastName.Location = new System.Drawing.Point(194, 465);
            this.textBox_patientLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_patientLastName.Name = "textBox_patientLastName";
            this.textBox_patientLastName.Size = new System.Drawing.Size(290, 28);
            this.textBox_patientLastName.TabIndex = 17;
            // 
            // comboBox_AppointmentHour
            // 
            this.comboBox_AppointmentHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_AppointmentHour.FormattingEnabled = true;
            this.comboBox_AppointmentHour.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.comboBox_AppointmentHour.Location = new System.Drawing.Point(692, 291);
            this.comboBox_AppointmentHour.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_AppointmentHour.Name = "comboBox_AppointmentHour";
            this.comboBox_AppointmentHour.Size = new System.Drawing.Size(62, 30);
            this.comboBox_AppointmentHour.TabIndex = 18;
            // 
            // comboBox_AppointmentMinutes
            // 
            this.comboBox_AppointmentMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_AppointmentMinutes.FormattingEnabled = true;
            this.comboBox_AppointmentMinutes.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.comboBox_AppointmentMinutes.Location = new System.Drawing.Point(791, 291);
            this.comboBox_AppointmentMinutes.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_AppointmentMinutes.Name = "comboBox_AppointmentMinutes";
            this.comboBox_AppointmentMinutes.Size = new System.Drawing.Size(62, 30);
            this.comboBox_AppointmentMinutes.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(689, 267);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Hour:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(787, 267);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Minutes:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(693, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 70);
            this.button1.TabIndex = 22;
            this.button1.Text = "MAKE APPOINTMENT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_SuccessFailed
            // 
            this.label_SuccessFailed.AutoSize = true;
            this.label_SuccessFailed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SuccessFailed.Location = new System.Drawing.Point(669, 531);
            this.label_SuccessFailed.Name = "label_SuccessFailed";
            this.label_SuccessFailed.Size = new System.Drawing.Size(184, 24);
            this.label_SuccessFailed.TabIndex = 23;
            this.label_SuccessFailed.Text = "label_SuccessFailed";
            this.label_SuccessFailed.Visible = false;
            // 
            // NewAppointmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_SuccessFailed);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox_AppointmentMinutes);
            this.Controls.Add(this.comboBox_AppointmentHour);
            this.Controls.Add(this.textBox_patientLastName);
            this.Controls.Add(this.textBox_patientFirstName);
            this.Controls.Add(this.dateTimePicker_patientBirthday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthCalendar_AppointmentDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Hospitals);
            this.Controls.Add(this.comboBox_Doctors);
            this.Controls.Add(this.comboBox_Specialities);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewAppointmentControl";
            this.Size = new System.Drawing.Size(980, 638);
            this.Load += new System.EventHandler(this.NewAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Specialities;
        private System.Windows.Forms.ComboBox comboBox_Doctors;
        private System.Windows.Forms.ComboBox comboBox_Hospitals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar_AppointmentDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker_patientBirthday;
        private System.Windows.Forms.TextBox textBox_patientFirstName;
        private System.Windows.Forms.TextBox textBox_patientLastName;
        private System.Windows.Forms.ComboBox comboBox_AppointmentHour;
        private System.Windows.Forms.ComboBox comboBox_AppointmentMinutes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_SuccessFailed;
    }
}
