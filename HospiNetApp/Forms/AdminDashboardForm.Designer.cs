
namespace HospiNetApp
{
    partial class AdminDashboardForm
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_admin_dashboard = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.AdminDashboardControlPanel = new System.Windows.Forms.Panel();
            this.label_hello = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_appName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_ManageHospitals = new System.Windows.Forms.Button();
            this.button_ManageRooms = new System.Windows.Forms.Button();
            this.button_ManageDoctors = new System.Windows.Forms.Button();
            this.button_ManagePatients = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.AdminDashboardControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label_admin_dashboard);
            this.panel2.Controls.Add(this.button_close);
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 100);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label_admin_dashboard
            // 
            this.label_admin_dashboard.AutoSize = true;
            this.label_admin_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.label_admin_dashboard.Location = new System.Drawing.Point(18, 28);
            this.label_admin_dashboard.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_admin_dashboard.Name = "label_admin_dashboard";
            this.label_admin_dashboard.Size = new System.Drawing.Size(258, 33);
            this.label_admin_dashboard.TabIndex = 1;
            this.label_admin_dashboard.Text = "Admin dashboard";
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.DarkRed;
            this.button_close.ForeColor = System.Drawing.SystemColors.Info;
            this.button_close.Location = new System.Drawing.Point(874, 17);
            this.button_close.Margin = new System.Windows.Forms.Padding(6);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(92, 63);
            this.button_close.TabIndex = 0;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // AdminDashboardControlPanel
            // 
            this.AdminDashboardControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminDashboardControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminDashboardControlPanel.Controls.Add(this.label_hello);
            this.AdminDashboardControlPanel.Location = new System.Drawing.Point(200, 97);
            this.AdminDashboardControlPanel.Name = "AdminDashboardControlPanel";
            this.AdminDashboardControlPanel.Size = new System.Drawing.Size(980, 647);
            this.AdminDashboardControlPanel.TabIndex = 2;
            // 
            // label_hello
            // 
            this.label_hello.AutoSize = true;
            this.label_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hello.Location = new System.Drawing.Point(441, 294);
            this.label_hello.Name = "label_hello";
            this.label_hello.Size = new System.Drawing.Size(93, 37);
            this.label_hello.TabIndex = 0;
            this.label_hello.Text = "hello.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospiNetApp.Properties.Resources.doctor_removebg;
            this.pictureBox1.Location = new System.Drawing.Point(4, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.label_appName.TabIndex = 1;
            this.label_appName.Text = "HospiNet";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button_ManageHospitals, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_ManageRooms, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_ManageDoctors, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_ManagePatients, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 204);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(190, 539);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button_ManageHospitals
            // 
            this.button_ManageHospitals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.button_ManageHospitals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ManageHospitals.Location = new System.Drawing.Point(6, 408);
            this.button_ManageHospitals.Margin = new System.Windows.Forms.Padding(6);
            this.button_ManageHospitals.Name = "button_ManageHospitals";
            this.button_ManageHospitals.Size = new System.Drawing.Size(178, 125);
            this.button_ManageHospitals.TabIndex = 6;
            this.button_ManageHospitals.Text = "Manage Hospitals";
            this.button_ManageHospitals.UseVisualStyleBackColor = false;
            this.button_ManageHospitals.Click += new System.EventHandler(this.button_ManageHospitals_Click);
            // 
            // button_ManageRooms
            // 
            this.button_ManageRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.button_ManageRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ManageRooms.Location = new System.Drawing.Point(6, 274);
            this.button_ManageRooms.Margin = new System.Windows.Forms.Padding(6);
            this.button_ManageRooms.Name = "button_ManageRooms";
            this.button_ManageRooms.Size = new System.Drawing.Size(178, 122);
            this.button_ManageRooms.TabIndex = 5;
            this.button_ManageRooms.Text = "Manage Rooms";
            this.button_ManageRooms.UseVisualStyleBackColor = false;
            this.button_ManageRooms.Click += new System.EventHandler(this.button_ManageRooms_Click);
            // 
            // button_ManageDoctors
            // 
            this.button_ManageDoctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.button_ManageDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ManageDoctors.Location = new System.Drawing.Point(6, 140);
            this.button_ManageDoctors.Margin = new System.Windows.Forms.Padding(6);
            this.button_ManageDoctors.Name = "button_ManageDoctors";
            this.button_ManageDoctors.Size = new System.Drawing.Size(178, 122);
            this.button_ManageDoctors.TabIndex = 4;
            this.button_ManageDoctors.Text = "Manage Doctors";
            this.button_ManageDoctors.UseVisualStyleBackColor = false;
            this.button_ManageDoctors.Click += new System.EventHandler(this.button_ManageDoctors_Click);
            // 
            // button_ManagePatients
            // 
            this.button_ManagePatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.button_ManagePatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ManagePatients.Location = new System.Drawing.Point(6, 6);
            this.button_ManagePatients.Margin = new System.Windows.Forms.Padding(6);
            this.button_ManagePatients.Name = "button_ManagePatients";
            this.button_ManagePatients.Size = new System.Drawing.Size(178, 122);
            this.button_ManagePatients.TabIndex = 3;
            this.button_ManagePatients.Text = "Manage Patients";
            this.button_ManagePatients.UseVisualStyleBackColor = false;
            this.button_ManagePatients.Click += new System.EventHandler(this.button_managePatients_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label_appName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 744);
            this.panel1.TabIndex = 0;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1182, 745);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AdminDashboardControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HospiNet";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.AdminDashboardControlPanel.ResumeLayout(false);
            this.AdminDashboardControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel AdminDashboardControlPanel;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_admin_dashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_appName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_ManageHospitals;
        private System.Windows.Forms.Button button_ManageRooms;
        private System.Windows.Forms.Button button_ManageDoctors;
        private System.Windows.Forms.Button button_ManagePatients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_hello;
    }
}