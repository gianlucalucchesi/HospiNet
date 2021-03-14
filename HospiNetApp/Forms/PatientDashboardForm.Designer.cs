
namespace HospiNetApp.Forms
{
    partial class PatientDashboardForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_appName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_patientDashboard_ManageAppointments = new System.Windows.Forms.Button();
            this.button_patientDashboard_NewAppointment = new System.Windows.Forms.Button();
            this.PatientDashboardControlPanel = new System.Windows.Forms.Panel();
            this.button_close = new System.Windows.Forms.Button();
            this.label_patient_dashboard = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_hello = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.PatientDashboardControlPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.label_appName);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 744);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label_appName
            // 
            this.label_appName.AutoSize = true;
            this.label_appName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_appName.ForeColor = System.Drawing.Color.DarkRed;
            this.label_appName.Location = new System.Drawing.Point(4, 0);
            this.label_appName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_appName.Name = "label_appName";
            this.label_appName.Size = new System.Drawing.Size(96, 24);
            this.label_appName.TabIndex = 3;
            this.label_appName.Text = "HospiNet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospiNetApp.Properties.Resources.doctor_removebg;
            this.pictureBox1.Location = new System.Drawing.Point(4, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button_patientDashboard_ManageAppointments, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_patientDashboard_NewAppointment, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 204);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(190, 539);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // button_patientDashboard_ManageAppointments
            // 
            this.button_patientDashboard_ManageAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.button_patientDashboard_ManageAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_patientDashboard_ManageAppointments.Location = new System.Drawing.Point(3, 272);
            this.button_patientDashboard_ManageAppointments.Name = "button_patientDashboard_ManageAppointments";
            this.button_patientDashboard_ManageAppointments.Size = new System.Drawing.Size(184, 264);
            this.button_patientDashboard_ManageAppointments.TabIndex = 1;
            this.button_patientDashboard_ManageAppointments.Text = "Manage Appointments";
            this.button_patientDashboard_ManageAppointments.UseVisualStyleBackColor = false;
            this.button_patientDashboard_ManageAppointments.Click += new System.EventHandler(this.button_patientDashboard_ManageAppointments_Click);
            // 
            // button_patientDashboard_NewAppointment
            // 
            this.button_patientDashboard_NewAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.button_patientDashboard_NewAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_patientDashboard_NewAppointment.Location = new System.Drawing.Point(3, 3);
            this.button_patientDashboard_NewAppointment.Name = "button_patientDashboard_NewAppointment";
            this.button_patientDashboard_NewAppointment.Size = new System.Drawing.Size(184, 263);
            this.button_patientDashboard_NewAppointment.TabIndex = 0;
            this.button_patientDashboard_NewAppointment.Text = "New Appointment";
            this.button_patientDashboard_NewAppointment.UseVisualStyleBackColor = false;
            this.button_patientDashboard_NewAppointment.Click += new System.EventHandler(this.button_patientDashboard_NewAppointment_Click);
            // 
            // PatientDashboardControlPanel
            // 
            this.PatientDashboardControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientDashboardControlPanel.Controls.Add(this.label_hello);
            this.PatientDashboardControlPanel.Location = new System.Drawing.Point(200, 97);
            this.PatientDashboardControlPanel.Name = "PatientDashboardControlPanel";
            this.PatientDashboardControlPanel.Size = new System.Drawing.Size(980, 647);
            this.PatientDashboardControlPanel.TabIndex = 6;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.DarkRed;
            this.button_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.ForeColor = System.Drawing.SystemColors.Info;
            this.button_close.Location = new System.Drawing.Point(874, 17);
            this.button_close.Margin = new System.Windows.Forms.Padding(6);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(92, 63);
            this.button_close.TabIndex = 3;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_patient_dashboard
            // 
            this.label_patient_dashboard.AutoSize = true;
            this.label_patient_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_patient_dashboard.Location = new System.Drawing.Point(18, 28);
            this.label_patient_dashboard.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_patient_dashboard.Name = "label_patient_dashboard";
            this.label_patient_dashboard.Size = new System.Drawing.Size(267, 33);
            this.label_patient_dashboard.TabIndex = 2;
            this.label_patient_dashboard.Text = "Patient dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_close);
            this.panel1.Controls.Add(this.label_patient_dashboard);
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 100);
            this.panel1.TabIndex = 7;
            // 
            // label_hello
            // 
            this.label_hello.AutoSize = true;
            this.label_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hello.Location = new System.Drawing.Point(427, 275);
            this.label_hello.Name = "label_hello";
            this.label_hello.Size = new System.Drawing.Size(93, 37);
            this.label_hello.TabIndex = 8;
            this.label_hello.Text = "hello.";
            // 
            // PatientDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 745);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.PatientDashboardControlPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "PatientDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientDashboardForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PatientDashboardControlPanel.ResumeLayout(false);
            this.PatientDashboardControlPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label_appName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_patientDashboard_ManageAppointments;
        private System.Windows.Forms.Button button_patientDashboard_NewAppointment;
        private System.Windows.Forms.Panel PatientDashboardControlPanel;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_patient_dashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_hello;
    }
}