
namespace HospiNetApp.UserControls.DoctorDashboard
{
    partial class ManageAttendancesControl
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
            this.monthCalendar_AttendanceDay = new System.Windows.Forms.MonthCalendar();
            this.checkBox_AlLDay = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_FromHour = new System.Windows.Forms.ComboBox();
            this.comboBox_ToHour = new System.Windows.Forms.ComboBox();
            this.comboBox_FromMinutes = new System.Windows.Forms.ComboBox();
            this.comboBox_ToMinutes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.label_Success = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_Hospitals = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_Failed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar_AttendanceDay
            // 
            this.monthCalendar_AttendanceDay.Location = new System.Drawing.Point(107, 216);
            this.monthCalendar_AttendanceDay.Name = "monthCalendar_AttendanceDay";
            this.monthCalendar_AttendanceDay.TabIndex = 0;
            // 
            // checkBox_AlLDay
            // 
            this.checkBox_AlLDay.AutoSize = true;
            this.checkBox_AlLDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_AlLDay.Location = new System.Drawing.Point(166, 390);
            this.checkBox_AlLDay.Name = "checkBox_AlLDay";
            this.checkBox_AlLDay.Size = new System.Drawing.Size(85, 28);
            this.checkBox_AlLDay.TabIndex = 1;
            this.checkBox_AlLDay.Text = "All day";
            this.checkBox_AlLDay.UseVisualStyleBackColor = true;
            this.checkBox_AlLDay.CheckedChanged += new System.EventHandler(this.checkBox_AllDay_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(530, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            // 
            // comboBox_FromHour
            // 
            this.comboBox_FromHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_FromHour.FormattingEnabled = true;
            this.comboBox_FromHour.Items.AddRange(new object[] {
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.comboBox_FromHour.Location = new System.Drawing.Point(601, 243);
            this.comboBox_FromHour.Name = "comboBox_FromHour";
            this.comboBox_FromHour.Size = new System.Drawing.Size(63, 32);
            this.comboBox_FromHour.TabIndex = 4;
            this.comboBox_FromHour.SelectedIndexChanged += new System.EventHandler(this.comboBox_FromHour_SelectedIndexChanged);
            // 
            // comboBox_ToHour
            // 
            this.comboBox_ToHour.Enabled = false;
            this.comboBox_ToHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ToHour.FormattingEnabled = true;
            this.comboBox_ToHour.Location = new System.Drawing.Point(601, 298);
            this.comboBox_ToHour.Name = "comboBox_ToHour";
            this.comboBox_ToHour.Size = new System.Drawing.Size(63, 32);
            this.comboBox_ToHour.TabIndex = 5;
            this.comboBox_ToHour.SelectedIndexChanged += new System.EventHandler(this.comboBox_ToHour_SelectedIndexChanged);
            // 
            // comboBox_FromMinutes
            // 
            this.comboBox_FromMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_FromMinutes.FormattingEnabled = true;
            this.comboBox_FromMinutes.Items.AddRange(new object[] {
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
            this.comboBox_FromMinutes.Location = new System.Drawing.Point(704, 243);
            this.comboBox_FromMinutes.Name = "comboBox_FromMinutes";
            this.comboBox_FromMinutes.Size = new System.Drawing.Size(63, 32);
            this.comboBox_FromMinutes.TabIndex = 6;
            this.comboBox_FromMinutes.SelectedIndexChanged += new System.EventHandler(this.comboBox_FromMinutes_SelectedIndexChanged);
            // 
            // comboBox_ToMinutes
            // 
            this.comboBox_ToMinutes.Enabled = false;
            this.comboBox_ToMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ToMinutes.FormattingEnabled = true;
            this.comboBox_ToMinutes.Items.AddRange(new object[] {
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
            this.comboBox_ToMinutes.Location = new System.Drawing.Point(704, 298);
            this.comboBox_ToMinutes.Name = "comboBox_ToMinutes";
            this.comboBox_ToMinutes.Size = new System.Drawing.Size(63, 32);
            this.comboBox_ToMinutes.TabIndex = 7;
            this.comboBox_ToMinutes.SelectedIndexChanged += new System.EventHandler(this.comboBox_ToMinutes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(603, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(700, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Minutes";
            // 
            // button_Confirm
            // 
            this.button_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Confirm.Location = new System.Drawing.Point(426, 479);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(142, 66);
            this.button_Confirm.TabIndex = 10;
            this.button_Confirm.Text = "Add Attendence";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // label_Success
            // 
            this.label_Success.AutoSize = true;
            this.label_Success.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Success.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_Success.Location = new System.Drawing.Point(377, 138);
            this.label_Success.Name = "label_Success";
            this.label_Success.Size = new System.Drawing.Size(272, 24);
            this.label_Success.TabIndex = 32;
            this.label_Success.Text = "Attendence successfully added";
            this.label_Success.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(326, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(373, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "ATTENDENCE REGISTRATION FORM";
            // 
            // comboBox_Hospitals
            // 
            this.comboBox_Hospitals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Hospitals.FormattingEnabled = true;
            this.comboBox_Hospitals.Location = new System.Drawing.Point(490, 362);
            this.comboBox_Hospitals.Name = "comboBox_Hospitals";
            this.comboBox_Hospitals.Size = new System.Drawing.Size(370, 32);
            this.comboBox_Hospitals.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Hospital:";
            // 
            // label_Failed
            // 
            this.label_Failed.AutoSize = true;
            this.label_Failed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Failed.ForeColor = System.Drawing.Color.DarkRed;
            this.label_Failed.Location = new System.Drawing.Point(356, 443);
            this.label_Failed.Name = "label_Failed";
            this.label_Failed.Size = new System.Drawing.Size(293, 24);
            this.label_Failed.TabIndex = 35;
            this.label_Failed.Text = "Start time cannot be after end time";
            this.label_Failed.Visible = false;
            // 
            // ManageAttendancesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_Failed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_Hospitals);
            this.Controls.Add(this.label_Success);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_ToMinutes);
            this.Controls.Add(this.comboBox_FromMinutes);
            this.Controls.Add(this.comboBox_ToHour);
            this.Controls.Add(this.comboBox_FromHour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_AlLDay);
            this.Controls.Add(this.monthCalendar_AttendanceDay);
            this.Name = "ManageAttendancesControl";
            this.Size = new System.Drawing.Size(980, 647);
            this.Load += new System.EventHandler(this.ManageAttendancesControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar_AttendanceDay;
        private System.Windows.Forms.CheckBox checkBox_AlLDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_FromHour;
        private System.Windows.Forms.ComboBox comboBox_ToHour;
        private System.Windows.Forms.ComboBox comboBox_FromMinutes;
        private System.Windows.Forms.ComboBox comboBox_ToMinutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Confirm;
        private System.Windows.Forms.Label label_Success;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Hospitals;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_Failed;
    }
}
