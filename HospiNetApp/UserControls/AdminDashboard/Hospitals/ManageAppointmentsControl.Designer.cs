
namespace HospiNetApp.UserControls.AdminDashboard.Hospitals
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
            this.button_ConfirmAppointment = new System.Windows.Forms.Button();
            this.button_CancelAppointment = new System.Windows.Forms.Button();
            this.label_loading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Appointments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Appointments
            // 
            this.dataGridView_Appointments.AllowUserToAddRows = false;
            this.dataGridView_Appointments.AllowUserToDeleteRows = false;
            this.dataGridView_Appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Appointments.Location = new System.Drawing.Point(18, 155);
            this.dataGridView_Appointments.Name = "dataGridView_Appointments";
            this.dataGridView_Appointments.ReadOnly = true;
            this.dataGridView_Appointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Appointments.Size = new System.Drawing.Size(944, 450);
            this.dataGridView_Appointments.TabIndex = 0;
            // 
            // button_ConfirmAppointment
            // 
            this.button_ConfirmAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ConfirmAppointment.Location = new System.Drawing.Point(276, 36);
            this.button_ConfirmAppointment.Name = "button_ConfirmAppointment";
            this.button_ConfirmAppointment.Size = new System.Drawing.Size(155, 59);
            this.button_ConfirmAppointment.TabIndex = 3;
            this.button_ConfirmAppointment.Text = "Confirm Appointment";
            this.button_ConfirmAppointment.UseVisualStyleBackColor = true;
            // 
            // button_CancelAppointment
            // 
            this.button_CancelAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CancelAppointment.Location = new System.Drawing.Point(582, 36);
            this.button_CancelAppointment.Name = "button_CancelAppointment";
            this.button_CancelAppointment.Size = new System.Drawing.Size(155, 59);
            this.button_CancelAppointment.TabIndex = 4;
            this.button_CancelAppointment.Text = "Cancel Appointment";
            this.button_CancelAppointment.UseVisualStyleBackColor = true;
            // 
            // label_loading
            // 
            this.label_loading.AutoSize = true;
            this.label_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loading.Location = new System.Drawing.Point(411, 305);
            this.label_loading.Name = "label_loading";
            this.label_loading.Size = new System.Drawing.Size(159, 37);
            this.label_loading.TabIndex = 11;
            this.label_loading.Text = "Loading...";
            // 
            // ManageAppointmentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_loading);
            this.Controls.Add(this.button_ConfirmAppointment);
            this.Controls.Add(this.button_CancelAppointment);
            this.Controls.Add(this.dataGridView_Appointments);
            this.Name = "ManageAppointmentsControl";
            this.Size = new System.Drawing.Size(980, 647);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Appointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Appointments;
        private System.Windows.Forms.Button button_ConfirmAppointment;
        private System.Windows.Forms.Button button_CancelAppointment;
        private System.Windows.Forms.Label label_loading;
    }
}
