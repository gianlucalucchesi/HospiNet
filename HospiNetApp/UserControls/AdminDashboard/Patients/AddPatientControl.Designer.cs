
namespace HospiNetApp.UserControls
{
    partial class AddPatientIControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_AddPatient_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_AddPatient_LastName = new System.Windows.Forms.TextBox();
            this.dateTimePicker_AddPatient_Birthday = new System.Windows.Forms.DateTimePicker();
            this.button_AddPatient_Add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label_AddPatient_Success = new System.Windows.Forms.Label();
            this.label_AddPatient_Failed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birthday:";
            // 
            // textBox_AddPatient_FirstName
            // 
            this.textBox_AddPatient_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AddPatient_FirstName.Location = new System.Drawing.Point(413, 260);
            this.textBox_AddPatient_FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_AddPatient_FirstName.Name = "textBox_AddPatient_FirstName";
            this.textBox_AddPatient_FirstName.Size = new System.Drawing.Size(261, 28);
            this.textBox_AddPatient_FirstName.TabIndex = 7;
            // 
            // textBox_AddPatient_LastName
            // 
            this.textBox_AddPatient_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AddPatient_LastName.Location = new System.Drawing.Point(413, 301);
            this.textBox_AddPatient_LastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_AddPatient_LastName.Name = "textBox_AddPatient_LastName";
            this.textBox_AddPatient_LastName.Size = new System.Drawing.Size(261, 28);
            this.textBox_AddPatient_LastName.TabIndex = 8;
            // 
            // dateTimePicker_AddPatient_Birthday
            // 
            this.dateTimePicker_AddPatient_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_AddPatient_Birthday.Location = new System.Drawing.Point(413, 348);
            this.dateTimePicker_AddPatient_Birthday.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_AddPatient_Birthday.Name = "dateTimePicker_AddPatient_Birthday";
            this.dateTimePicker_AddPatient_Birthday.Size = new System.Drawing.Size(261, 28);
            this.dateTimePicker_AddPatient_Birthday.TabIndex = 12;
            // 
            // button_AddPatient_Add
            // 
            this.button_AddPatient_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddPatient_Add.Location = new System.Drawing.Point(419, 437);
            this.button_AddPatient_Add.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddPatient_Add.Name = "button_AddPatient_Add";
            this.button_AddPatient_Add.Size = new System.Drawing.Size(142, 66);
            this.button_AddPatient_Add.TabIndex = 14;
            this.button_AddPatient_Add.Text = "Add Patient";
            this.button_AddPatient_Add.UseVisualStyleBackColor = true;
            this.button_AddPatient_Add.Click += new System.EventHandler(this.button_AddPatient_Add_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(349, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(320, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "PATIENT REGISTRATION FORM";
            // 
            // label_AddPatient_Success
            // 
            this.label_AddPatient_Success.AutoSize = true;
            this.label_AddPatient_Success.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddPatient_Success.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_AddPatient_Success.Location = new System.Drawing.Point(378, 189);
            this.label_AddPatient_Success.Name = "label_AddPatient_Success";
            this.label_AddPatient_Success.Size = new System.Drawing.Size(231, 24);
            this.label_AddPatient_Success.TabIndex = 16;
            this.label_AddPatient_Success.Text = "Patient successfully added";
            this.label_AddPatient_Success.Visible = false;
            // 
            // label_AddPatient_Failed
            // 
            this.label_AddPatient_Failed.AutoSize = true;
            this.label_AddPatient_Failed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddPatient_Failed.ForeColor = System.Drawing.Color.DarkRed;
            this.label_AddPatient_Failed.Location = new System.Drawing.Point(399, 189);
            this.label_AddPatient_Failed.Name = "label_AddPatient_Failed";
            this.label_AddPatient_Failed.Size = new System.Drawing.Size(184, 24);
            this.label_AddPatient_Failed.TabIndex = 17;
            this.label_AddPatient_Failed.Text = "Patient already exists";
            this.label_AddPatient_Failed.Visible = false;
            // 
            // AddPatientIControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_AddPatient_Failed);
            this.Controls.Add(this.label_AddPatient_Success);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_AddPatient_Add);
            this.Controls.Add(this.dateTimePicker_AddPatient_Birthday);
            this.Controls.Add(this.textBox_AddPatient_LastName);
            this.Controls.Add(this.textBox_AddPatient_FirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPatientIControl";
            this.Size = new System.Drawing.Size(980, 647);
            this.Load += new System.EventHandler(this.AddPatientIControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_AddPatient_FirstName;
        private System.Windows.Forms.TextBox textBox_AddPatient_LastName;
        private System.Windows.Forms.DateTimePicker dateTimePicker_AddPatient_Birthday;
        private System.Windows.Forms.Button button_AddPatient_Add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_AddPatient_Success;
        private System.Windows.Forms.Label label_AddPatient_Failed;
    }
}
