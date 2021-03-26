
namespace HospiNetApp.UserControls.DoctorDashboard
{
    partial class ManageAppointmentsControl
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
            this.dataGridView_Appointments = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HospitalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Confirmed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_ConfirmedSuccess = new System.Windows.Forms.Label();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.checkBox_ConfirmedUnconfirmedAppointment = new System.Windows.Forms.CheckBox();
            this.label_loading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Appointments)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Appointments
            // 
            this.dataGridView_Appointments.AllowUserToAddRows = false;
            this.dataGridView_Appointments.AllowUserToDeleteRows = false;
            this.dataGridView_Appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Appointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.HospitalName,
            this.RoomName,
            this.PatientName,
            this.DateTimeStart,
            this.DateTimeEnd,
            this.Confirmed});
            this.dataGridView_Appointments.Location = new System.Drawing.Point(282, 14);
            this.dataGridView_Appointments.Name = "dataGridView_Appointments";
            this.dataGridView_Appointments.ReadOnly = true;
            this.dataGridView_Appointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Appointments.Size = new System.Drawing.Size(695, 623);
            this.dataGridView_Appointments.TabIndex = 0;
            this.dataGridView_Appointments.Visible = false;
            this.dataGridView_Appointments.SelectionChanged += new System.EventHandler(this.dataGridView_Appointments_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // HospitalName
            // 
            this.HospitalName.HeaderText = "Hospital";
            this.HospitalName.Name = "HospitalName";
            this.HospitalName.ReadOnly = true;
            this.HospitalName.Width = 150;
            // 
            // RoomName
            // 
            this.RoomName.HeaderText = "Room";
            this.RoomName.Name = "RoomName";
            this.RoomName.ReadOnly = true;
            // 
            // PatientName
            // 
            this.PatientName.HeaderText = "Patient";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            this.PatientName.Width = 142;
            // 
            // DateTimeStart
            // 
            this.DateTimeStart.HeaderText = "Start";
            this.DateTimeStart.Name = "DateTimeStart";
            this.DateTimeStart.ReadOnly = true;
            // 
            // DateTimeEnd
            // 
            this.DateTimeEnd.HeaderText = "End";
            this.DateTimeEnd.Name = "DateTimeEnd";
            this.DateTimeEnd.ReadOnly = true;
            // 
            // Confirmed
            // 
            this.Confirmed.HeaderText = "Confirmed";
            this.Confirmed.Name = "Confirmed";
            this.Confirmed.ReadOnly = true;
            this.Confirmed.Width = 60;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(9, 45);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label_ConfirmedSuccess);
            this.panel1.Controls.Add(this.button_Confirm);
            this.panel1.Controls.Add(this.checkBox_ConfirmedUnconfirmedAppointment);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Location = new System.Drawing.Point(9, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 622);
            this.panel1.TabIndex = 3;
            // 
            // label_ConfirmedSuccess
            // 
            this.label_ConfirmedSuccess.AutoSize = true;
            this.label_ConfirmedSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ConfirmedSuccess.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_ConfirmedSuccess.Location = new System.Drawing.Point(23, 523);
            this.label_ConfirmedSuccess.Name = "label_ConfirmedSuccess";
            this.label_ConfirmedSuccess.Size = new System.Drawing.Size(206, 24);
            this.label_ConfirmedSuccess.TabIndex = 5;
            this.label_ConfirmedSuccess.Text = "Appointment confirmed";
            this.label_ConfirmedSuccess.Visible = false;
            // 
            // button_Confirm
            // 
            this.button_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Confirm.Location = new System.Drawing.Point(51, 454);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(142, 66);
            this.button_Confirm.TabIndex = 4;
            this.button_Confirm.Text = "Confirm Appointment";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // checkBox_ConfirmedUnconfirmedAppointment
            // 
            this.checkBox_ConfirmedUnconfirmedAppointment.AutoSize = true;
            this.checkBox_ConfirmedUnconfirmedAppointment.Location = new System.Drawing.Point(39, 356);
            this.checkBox_ConfirmedUnconfirmedAppointment.Name = "checkBox_ConfirmedUnconfirmedAppointment";
            this.checkBox_ConfirmedUnconfirmedAppointment.Size = new System.Drawing.Size(190, 17);
            this.checkBox_ConfirmedUnconfirmedAppointment.TabIndex = 3;
            this.checkBox_ConfirmedUnconfirmedAppointment.Text = "Only show confirmed appointments";
            this.checkBox_ConfirmedUnconfirmedAppointment.UseVisualStyleBackColor = true;
            this.checkBox_ConfirmedUnconfirmedAppointment.CheckedChanged += new System.EventHandler(this.checkBox_ConfirmedUnconfirmedAppointment_CheckedChanged);
            // 
            // label_loading
            // 
            this.label_loading.AutoSize = true;
            this.label_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loading.Location = new System.Drawing.Point(575, 307);
            this.label_loading.Name = "label_loading";
            this.label_loading.Size = new System.Drawing.Size(159, 37);
            this.label_loading.TabIndex = 6;
            this.label_loading.Text = "Loading...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "No appointments on this day";
            this.label1.Visible = false;
            // 
            // ManageAppointmentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_loading);
            this.Controls.Add(this.dataGridView_Appointments);
            this.Controls.Add(this.panel1);
            this.Name = "ManageAppointmentsControl";
            this.Size = new System.Drawing.Size(980, 647);
            this.Load += new System.EventHandler(this.ManageAppointmentsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Appointments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Appointments;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_loading;
        private System.Windows.Forms.Button button_Confirm;
        private System.Windows.Forms.CheckBox checkBox_ConfirmedUnconfirmedAppointment;
        private System.Windows.Forms.Label label_ConfirmedSuccess;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn HospitalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Confirmed;
        private System.Windows.Forms.Label label1;
    }
}
