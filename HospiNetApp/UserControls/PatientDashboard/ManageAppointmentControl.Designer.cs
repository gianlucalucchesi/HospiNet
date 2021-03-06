
namespace HospiNetApp.UserControls.PatientDashboard
{
    partial class ManageAppointmentControl
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_AppointmentMinutes = new System.Windows.Forms.ComboBox();
            this.comboBox_AppointmentHour = new System.Windows.Forms.ComboBox();
            this.textBox_patientLastName = new System.Windows.Forms.TextBox();
            this.textBox_patientFirstName = new System.Windows.Forms.TextBox();
            this.dateTimePicker_patientBirthday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar_AppointmentDate = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Hospitals = new System.Windows.Forms.ComboBox();
            this.comboBox_Doctors = new System.Windows.Forms.ComboBox();
            this.comboBox_Specialities = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_ReservationCode = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(788, 267);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 24);
            this.label10.TabIndex = 40;
            this.label10.Text = "Minutes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(690, 267);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 39;
            this.label9.Text = "Hour:";
            // 
            // comboBox_AppointmentMinutes
            // 
            this.comboBox_AppointmentMinutes.Enabled = false;
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
            this.comboBox_AppointmentMinutes.Location = new System.Drawing.Point(792, 291);
            this.comboBox_AppointmentMinutes.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_AppointmentMinutes.Name = "comboBox_AppointmentMinutes";
            this.comboBox_AppointmentMinutes.Size = new System.Drawing.Size(62, 30);
            this.comboBox_AppointmentMinutes.TabIndex = 38;
            // 
            // comboBox_AppointmentHour
            // 
            this.comboBox_AppointmentHour.Enabled = false;
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
            this.comboBox_AppointmentHour.Location = new System.Drawing.Point(693, 291);
            this.comboBox_AppointmentHour.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_AppointmentHour.Name = "comboBox_AppointmentHour";
            this.comboBox_AppointmentHour.Size = new System.Drawing.Size(62, 30);
            this.comboBox_AppointmentHour.TabIndex = 37;
            // 
            // textBox_patientLastName
            // 
            this.textBox_patientLastName.Enabled = false;
            this.textBox_patientLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_patientLastName.Location = new System.Drawing.Point(195, 465);
            this.textBox_patientLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_patientLastName.Name = "textBox_patientLastName";
            this.textBox_patientLastName.Size = new System.Drawing.Size(290, 28);
            this.textBox_patientLastName.TabIndex = 36;
            // 
            // textBox_patientFirstName
            // 
            this.textBox_patientFirstName.Enabled = false;
            this.textBox_patientFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_patientFirstName.Location = new System.Drawing.Point(195, 405);
            this.textBox_patientFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_patientFirstName.Name = "textBox_patientFirstName";
            this.textBox_patientFirstName.Size = new System.Drawing.Size(290, 28);
            this.textBox_patientFirstName.TabIndex = 35;
            // 
            // dateTimePicker_patientBirthday
            // 
            this.dateTimePicker_patientBirthday.Enabled = false;
            this.dateTimePicker_patientBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_patientBirthday.Location = new System.Drawing.Point(195, 527);
            this.dateTimePicker_patientBirthday.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_patientBirthday.Name = "dateTimePicker_patientBirthday";
            this.dateTimePicker_patientBirthday.Size = new System.Drawing.Size(290, 28);
            this.dateTimePicker_patientBirthday.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 527);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "Birthday:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 465);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "Last name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 407);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "First name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Appointment details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 343);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "Your details";
            // 
            // monthCalendar_AppointmentDate
            // 
            this.monthCalendar_AppointmentDate.Enabled = false;
            this.monthCalendar_AppointmentDate.Location = new System.Drawing.Point(666, 99);
            this.monthCalendar_AppointmentDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.monthCalendar_AppointmentDate.Name = "monthCalendar_AppointmentDate";
            this.monthCalendar_AppointmentDate.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 291);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Hospital:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Doctor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Speciality:";
            // 
            // comboBox_Hospitals
            // 
            this.comboBox_Hospitals.Enabled = false;
            this.comboBox_Hospitals.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Hospitals.FormattingEnabled = true;
            this.comboBox_Hospitals.Location = new System.Drawing.Point(195, 291);
            this.comboBox_Hospitals.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Hospitals.Name = "comboBox_Hospitals";
            this.comboBox_Hospitals.Size = new System.Drawing.Size(290, 30);
            this.comboBox_Hospitals.TabIndex = 24;
            // 
            // comboBox_Doctors
            // 
            this.comboBox_Doctors.Enabled = false;
            this.comboBox_Doctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Doctors.FormattingEnabled = true;
            this.comboBox_Doctors.Location = new System.Drawing.Point(195, 234);
            this.comboBox_Doctors.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Doctors.Name = "comboBox_Doctors";
            this.comboBox_Doctors.Size = new System.Drawing.Size(290, 30);
            this.comboBox_Doctors.TabIndex = 23;
            // 
            // comboBox_Specialities
            // 
            this.comboBox_Specialities.Enabled = false;
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
            this.comboBox_Specialities.Location = new System.Drawing.Point(195, 171);
            this.comboBox_Specialities.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Specialities.Name = "comboBox_Specialities";
            this.comboBox_Specialities.Size = new System.Drawing.Size(290, 30);
            this.comboBox_Specialities.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(52, 115);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 24);
            this.label11.TabIndex = 41;
            this.label11.Text = "Reserv. code:";
            // 
            // textBox_ReservationCode
            // 
            this.textBox_ReservationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ReservationCode.Location = new System.Drawing.Point(195, 115);
            this.textBox_ReservationCode.Name = "textBox_ReservationCode";
            this.textBox_ReservationCode.Size = new System.Drawing.Size(290, 29);
            this.textBox_ReservationCode.TabIndex = 42;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(792, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 70);
            this.button2.TabIndex = 44;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(617, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 70);
            this.button1.TabIndex = 43;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ManageAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_ReservationCode);
            this.Controls.Add(this.label11);
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
            this.Name = "ManageAppointment";
            this.Size = new System.Drawing.Size(980, 638);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_AppointmentMinutes;
        private System.Windows.Forms.ComboBox comboBox_AppointmentHour;
        private System.Windows.Forms.TextBox textBox_patientLastName;
        private System.Windows.Forms.TextBox textBox_patientFirstName;
        private System.Windows.Forms.DateTimePicker dateTimePicker_patientBirthday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar_AppointmentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Hospitals;
        private System.Windows.Forms.ComboBox comboBox_Doctors;
        private System.Windows.Forms.ComboBox comboBox_Specialities;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_ReservationCode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
