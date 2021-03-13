
namespace HospiNetApp.UserControls.AdminDashboard.Patients
{
    partial class UpdatePatientControl
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
            this.label_Success = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_UpdatePatient = new System.Windows.Forms.Button();
            this.dateTimePicker_Birthday = new System.Windows.Forms.DateTimePicker();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Failed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Success
            // 
            this.label_Success.AutoSize = true;
            this.label_Success.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Success.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_Success.Location = new System.Drawing.Point(378, 189);
            this.label_Success.Name = "label_Success";
            this.label_Success.Size = new System.Drawing.Size(246, 24);
            this.label_Success.TabIndex = 25;
            this.label_Success.Text = "Patient successfully updated";
            this.label_Success.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(373, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "PATIENT UPDATE FORM";
            // 
            // button_UpdatePatient
            // 
            this.button_UpdatePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UpdatePatient.Location = new System.Drawing.Point(419, 437);
            this.button_UpdatePatient.Margin = new System.Windows.Forms.Padding(2);
            this.button_UpdatePatient.Name = "button_UpdatePatient";
            this.button_UpdatePatient.Size = new System.Drawing.Size(142, 66);
            this.button_UpdatePatient.TabIndex = 23;
            this.button_UpdatePatient.Text = "Update Patient";
            this.button_UpdatePatient.UseVisualStyleBackColor = true;
            this.button_UpdatePatient.Click += new System.EventHandler(this.button_UpdatePatient_Click);
            // 
            // dateTimePicker_Birthday
            // 
            this.dateTimePicker_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Birthday.Location = new System.Drawing.Point(413, 348);
            this.dateTimePicker_Birthday.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_Birthday.Name = "dateTimePicker_Birthday";
            this.dateTimePicker_Birthday.Size = new System.Drawing.Size(261, 28);
            this.dateTimePicker_Birthday.TabIndex = 22;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LastName.Location = new System.Drawing.Point(413, 301);
            this.textBox_LastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(261, 28);
            this.textBox_LastName.TabIndex = 21;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FirstName.Location = new System.Drawing.Point(413, 260);
            this.textBox_FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(261, 28);
            this.textBox_FirstName.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Birthday:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Last name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "First name:";
            // 
            // label_Failed
            // 
            this.label_Failed.AutoSize = true;
            this.label_Failed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Failed.ForeColor = System.Drawing.Color.DarkRed;
            this.label_Failed.Location = new System.Drawing.Point(469, 189);
            this.label_Failed.Name = "label_Failed";
            this.label_Failed.Size = new System.Drawing.Size(52, 24);
            this.label_Failed.TabIndex = 26;
            this.label_Failed.Text = "Error";
            this.label_Failed.Visible = false;
            // 
            // UpdatePatientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_Failed);
            this.Controls.Add(this.label_Success);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_UpdatePatient);
            this.Controls.Add(this.dateTimePicker_Birthday);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePatientControl";
            this.Size = new System.Drawing.Size(980, 647);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Success;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_UpdatePatient;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Birthday;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Failed;
    }
}
