
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
            this.pictureBox_search = new System.Windows.Forms.PictureBox();
            this.comboBox_Availabilities = new System.Windows.Forms.ComboBox();
            this.label_SuccessFailed = new System.Windows.Forms.Label();
            this.label_Confirmed = new System.Windows.Forms.Label();
            this.label_NotFound = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).BeginInit();
            this.SuspendLayout();
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
            this.label3.Location = new System.Drawing.Point(112, 371);
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
            this.label2.Location = new System.Drawing.Point(124, 314);
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
            this.button_cancel.Enabled = false;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(532, 477);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(166, 70);
            this.button_cancel.TabIndex = 44;
            this.button_cancel.Text = "CANCEL APPOINTMENT";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_update
            // 
            this.button_update.Enabled = false;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(331, 477);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(166, 70);
            this.button_update.TabIndex = 43;
            this.button_update.Text = "UPDATE APPOINTMENT";
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // pictureBox_search
            // 
            this.pictureBox_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_search.Image = global::HospiNetApp.Properties.Resources.archive;
            this.pictureBox_search.Location = new System.Drawing.Point(506, 186);
            this.pictureBox_search.Name = "pictureBox_search";
            this.pictureBox_search.Size = new System.Drawing.Size(43, 38);
            this.pictureBox_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_search.TabIndex = 45;
            this.pictureBox_search.TabStop = false;
            this.pictureBox_search.Click += new System.EventHandler(this.pictureBox_search_ClickAsync);
            // 
            // comboBox_Availabilities
            // 
            this.comboBox_Availabilities.Enabled = false;
            this.comboBox_Availabilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Availabilities.FormattingEnabled = true;
            this.comboBox_Availabilities.IntegralHeight = false;
            this.comboBox_Availabilities.Location = new System.Drawing.Point(646, 352);
            this.comboBox_Availabilities.Name = "comboBox_Availabilities";
            this.comboBox_Availabilities.Size = new System.Drawing.Size(227, 32);
            this.comboBox_Availabilities.TabIndex = 46;
            // 
            // label_SuccessFailed
            // 
            this.label_SuccessFailed.AutoSize = true;
            this.label_SuccessFailed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SuccessFailed.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_SuccessFailed.Location = new System.Drawing.Point(421, 564);
            this.label_SuccessFailed.Name = "label_SuccessFailed";
            this.label_SuccessFailed.Size = new System.Drawing.Size(184, 24);
            this.label_SuccessFailed.TabIndex = 47;
            this.label_SuccessFailed.Text = "label_SuccessFailed";
            this.label_SuccessFailed.Visible = false;
            // 
            // label_Confirmed
            // 
            this.label_Confirmed.AutoSize = true;
            this.label_Confirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Confirmed.ForeColor = System.Drawing.Color.DarkRed;
            this.label_Confirmed.Location = new System.Drawing.Point(389, 564);
            this.label_Confirmed.Name = "label_Confirmed";
            this.label_Confirmed.Size = new System.Drawing.Size(272, 24);
            this.label_Confirmed.TabIndex = 48;
            this.label_Confirmed.Text = "Appointment already confirmed";
            this.label_Confirmed.Visible = false;
            // 
            // label_NotFound
            // 
            this.label_NotFound.AutoSize = true;
            this.label_NotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NotFound.ForeColor = System.Drawing.Color.DarkRed;
            this.label_NotFound.Location = new System.Drawing.Point(473, 564);
            this.label_NotFound.Name = "label_NotFound";
            this.label_NotFound.Size = new System.Drawing.Size(92, 24);
            this.label_NotFound.TabIndex = 49;
            this.label_NotFound.Text = "Not found";
            this.label_NotFound.Visible = false;
            // 
            // ManageAppointmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_SuccessFailed);
            this.Controls.Add(this.label_NotFound);
            this.Controls.Add(this.label_Confirmed);
            this.Controls.Add(this.comboBox_Availabilities);
            this.Controls.Add(this.pictureBox_search);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBox_ReservationCode);
            this.Controls.Add(this.label11);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.PictureBox pictureBox_search;
        private System.Windows.Forms.ComboBox comboBox_Availabilities;
        private System.Windows.Forms.Label label_SuccessFailed;
        private System.Windows.Forms.Label label_Confirmed;
        private System.Windows.Forms.Label label_NotFound;
    }
}
