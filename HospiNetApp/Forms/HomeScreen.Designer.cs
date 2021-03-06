
namespace HospiNetApp.Forms
{
    partial class HomeScreen
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
            this.label_loginScreen_title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_homeScreen_Patient = new System.Windows.Forms.Button();
            this.button_homeScreen_Administration = new System.Windows.Forms.Button();
            this.button_homeScreen_Doctor = new System.Windows.Forms.Button();
            this.panel_HomeScreen = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_close = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_HomeScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_loginScreen_title
            // 
            this.label_loginScreen_title.AutoSize = true;
            this.label_loginScreen_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loginScreen_title.ForeColor = System.Drawing.Color.DarkRed;
            this.label_loginScreen_title.Location = new System.Drawing.Point(386, 137);
            this.label_loginScreen_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_loginScreen_title.Name = "label_loginScreen_title";
            this.label_loginScreen_title.Size = new System.Drawing.Size(230, 55);
            this.label_loginScreen_title.TabIndex = 0;
            this.label_loginScreen_title.Text = "HospiNet";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button_homeScreen_Patient, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_homeScreen_Administration, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_homeScreen_Doctor, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 137);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(924, 128);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_homeScreen_Patient
            // 
            this.button_homeScreen_Patient.BackColor = System.Drawing.Color.White;
            this.button_homeScreen_Patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_homeScreen_Patient.Location = new System.Drawing.Point(618, 2);
            this.button_homeScreen_Patient.Margin = new System.Windows.Forms.Padding(2);
            this.button_homeScreen_Patient.Name = "button_homeScreen_Patient";
            this.button_homeScreen_Patient.Size = new System.Drawing.Size(304, 124);
            this.button_homeScreen_Patient.TabIndex = 2;
            this.button_homeScreen_Patient.Text = "Patient";
            this.button_homeScreen_Patient.UseVisualStyleBackColor = false;
            this.button_homeScreen_Patient.Click += new System.EventHandler(this.button_homeScreen_Patient_Click);
            // 
            // button_homeScreen_Administration
            // 
            this.button_homeScreen_Administration.BackColor = System.Drawing.Color.White;
            this.button_homeScreen_Administration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_homeScreen_Administration.Location = new System.Drawing.Point(2, 2);
            this.button_homeScreen_Administration.Margin = new System.Windows.Forms.Padding(2);
            this.button_homeScreen_Administration.Name = "button_homeScreen_Administration";
            this.button_homeScreen_Administration.Size = new System.Drawing.Size(304, 124);
            this.button_homeScreen_Administration.TabIndex = 0;
            this.button_homeScreen_Administration.Text = "Administration";
            this.button_homeScreen_Administration.UseVisualStyleBackColor = false;
            this.button_homeScreen_Administration.Click += new System.EventHandler(this.button_homeScreen_Administration_Click);
            // 
            // button_homeScreen_Doctor
            // 
            this.button_homeScreen_Doctor.BackColor = System.Drawing.Color.White;
            this.button_homeScreen_Doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_homeScreen_Doctor.Location = new System.Drawing.Point(310, 2);
            this.button_homeScreen_Doctor.Margin = new System.Windows.Forms.Padding(2);
            this.button_homeScreen_Doctor.Name = "button_homeScreen_Doctor";
            this.button_homeScreen_Doctor.Size = new System.Drawing.Size(304, 124);
            this.button_homeScreen_Doctor.TabIndex = 1;
            this.button_homeScreen_Doctor.Text = "Doctor";
            this.button_homeScreen_Doctor.UseVisualStyleBackColor = false;
            this.button_homeScreen_Doctor.Click += new System.EventHandler(this.button_homeScreen_Doctor_Click);
            // 
            // panel_HomeScreen
            // 
            this.panel_HomeScreen.Controls.Add(this.tableLayoutPanel1);
            this.panel_HomeScreen.Location = new System.Drawing.Point(129, 231);
            this.panel_HomeScreen.Margin = new System.Windows.Forms.Padding(2);
            this.panel_HomeScreen.Name = "panel_HomeScreen";
            this.panel_HomeScreen.Size = new System.Drawing.Size(926, 393);
            this.panel_HomeScreen.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospiNetApp.Properties.Resources.doctor_removebg;
            this.pictureBox1.Location = new System.Drawing.Point(634, 83);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.DarkRed;
            this.button_close.ForeColor = System.Drawing.SystemColors.Info;
            this.button_close.Location = new System.Drawing.Point(1083, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(87, 58);
            this.button_close.TabIndex = 4;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1182, 745);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_loginScreen_title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_HomeScreen);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginScreen";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomeScreen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomeScreen_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HomeScreen_MouseUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_HomeScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_loginScreen_title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_homeScreen_Patient;
        private System.Windows.Forms.Button button_homeScreen_Doctor;
        private System.Windows.Forms.Button button_homeScreen_Administration;
        private System.Windows.Forms.Panel panel_HomeScreen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_close;
    }
}