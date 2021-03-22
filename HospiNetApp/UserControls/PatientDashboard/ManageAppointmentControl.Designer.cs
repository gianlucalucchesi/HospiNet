
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
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar_AppointmentDate = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Hospitals = new System.Windows.Forms.ComboBox();
            this.comboBox_Doctors = new System.Windows.Forms.ComboBox();
            this.comboBox_Specialities = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_ReservationCode = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(768, 350);
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
            this.label9.Location = new System.Drawing.Point(670, 350);
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
            this.comboBox_AppointmentMinutes.Location = new System.Drawing.Point(772, 374);
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
            this.comboBox_AppointmentHour.Location = new System.Drawing.Point(673, 374);
            this.comboBox_AppointmentHour.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_AppointmentHour.Name = "comboBox_AppointmentHour";
            this.comboBox_AppointmentHour.Size = new System.Drawing.Size(62, 30);
            this.comboBox_AppointmentHour.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Appointment details";
            // 
            // monthCalendar_AppointmentDate
            // 
            this.monthCalendar_AppointmentDate.Enabled = false;
            this.monthCalendar_AppointmentDate.Location = new System.Drawing.Point(646, 182);
            this.monthCalendar_AppointmentDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.monthCalendar_AppointmentDate.Name = "monthCalendar_AppointmentDate";
            this.monthCalendar_AppointmentDate.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 371);
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
            this.label2.Location = new System.Drawing.Point(100, 310);
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
            this.label1.Location = new System.Drawing.Point(100, 251);
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
            this.comboBox_Hospitals.Location = new System.Drawing.Point(210, 371);
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
            this.comboBox_Doctors.Location = new System.Drawing.Point(210, 314);
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
            this.comboBox_Specialities.Location = new System.Drawing.Point(210, 251);
            this.comboBox_Specialities.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Specialities.Name = "comboBox_Specialities";
            this.comboBox_Specialities.Size = new System.Drawing.Size(290, 30);
            this.comboBox_Specialities.TabIndex = 22;
            this.comboBox_Specialities.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(67, 195);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 24);
            this.label11.TabIndex = 41;
            this.label11.Text = "Reserv. code:";
            // 
            // textBox_ReservationCode
            // 
            this.textBox_ReservationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ReservationCode.Location = new System.Drawing.Point(210, 195);
            this.textBox_ReservationCode.Name = "textBox_ReservationCode";
            this.textBox_ReservationCode.Size = new System.Drawing.Size(290, 29);
            this.textBox_ReservationCode.TabIndex = 42;
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(532, 477);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(166, 70);
            this.button_cancel.TabIndex = 44;
            this.button_cancel.Text = "CANCEL APPOINTMENT";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(331, 477);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(166, 70);
            this.button_update.TabIndex = 43;
            this.button_update.Text = "UPDATE APPOINTMENT";
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // ManageAppointmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBox_ReservationCode);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox_AppointmentMinutes);
            this.Controls.Add(this.comboBox_AppointmentHour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.monthCalendar_AppointmentDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Hospitals);
            this.Controls.Add(this.comboBox_Doctors);
            this.Controls.Add(this.comboBox_Specialities);
            this.Name = "ManageAppointmentControl";
            this.Size = new System.Drawing.Size(980, 638);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_AppointmentMinutes;
        private System.Windows.Forms.ComboBox comboBox_AppointmentHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar_AppointmentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Hospitals;
        private System.Windows.Forms.ComboBox comboBox_Doctors;
        private System.Windows.Forms.ComboBox comboBox_Specialities;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_ReservationCode;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_update;
    }
}
