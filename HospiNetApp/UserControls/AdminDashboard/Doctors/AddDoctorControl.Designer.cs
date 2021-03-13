
namespace HospiNetApp.UserControls.AdminDashboard.Hospitals
{
    partial class AddDoctorControl
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
            this.label8 = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label_Specialities = new System.Windows.Forms.Label();
            this.comboBox_Speciality = new System.Windows.Forms.ComboBox();
            this.label_Speciality = new System.Windows.Forms.Label();
            this.button_AddSpeciality = new System.Windows.Forms.Button();
            this.button_AddDoctor = new System.Windows.Forms.Button();
            this.listBox_Specialities = new System.Windows.Forms.ListBox();
            this.label_Success = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(338, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(320, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "DOCTOR REGISTRATION FORM";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FirstName.Location = new System.Drawing.Point(105, 214);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(106, 24);
            this.label_FirstName.TabIndex = 19;
            this.label_FirstName.Text = "First Name:";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LastName.Location = new System.Drawing.Point(105, 264);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(104, 24);
            this.label_LastName.TabIndex = 20;
            this.label_LastName.Text = "Last Name:";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FirstName.Location = new System.Drawing.Point(217, 211);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(262, 29);
            this.textBox_FirstName.TabIndex = 21;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LastName.Location = new System.Drawing.Point(217, 264);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(262, 29);
            this.textBox_LastName.TabIndex = 22;
            // 
            // label_Specialities
            // 
            this.label_Specialities.AutoSize = true;
            this.label_Specialities.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Specialities.Location = new System.Drawing.Point(670, 222);
            this.label_Specialities.Name = "label_Specialities";
            this.label_Specialities.Size = new System.Drawing.Size(109, 24);
            this.label_Specialities.TabIndex = 24;
            this.label_Specialities.Text = "Specialities:";
            // 
            // comboBox_Speciality
            // 
            this.comboBox_Speciality.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Speciality.FormattingEnabled = true;
            this.comboBox_Speciality.Items.AddRange(new object[] {
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
            this.comboBox_Speciality.Location = new System.Drawing.Point(217, 319);
            this.comboBox_Speciality.Name = "comboBox_Speciality";
            this.comboBox_Speciality.Size = new System.Drawing.Size(262, 32);
            this.comboBox_Speciality.TabIndex = 25;
            // 
            // label_Speciality
            // 
            this.label_Speciality.AutoSize = true;
            this.label_Speciality.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Speciality.Location = new System.Drawing.Point(105, 322);
            this.label_Speciality.Name = "label_Speciality";
            this.label_Speciality.Size = new System.Drawing.Size(94, 24);
            this.label_Speciality.TabIndex = 26;
            this.label_Speciality.Text = "Speciality:";
            // 
            // button_AddSpeciality
            // 
            this.button_AddSpeciality.Location = new System.Drawing.Point(485, 325);
            this.button_AddSpeciality.Name = "button_AddSpeciality";
            this.button_AddSpeciality.Size = new System.Drawing.Size(75, 23);
            this.button_AddSpeciality.TabIndex = 27;
            this.button_AddSpeciality.Text = "Add";
            this.button_AddSpeciality.UseVisualStyleBackColor = true;
            this.button_AddSpeciality.Click += new System.EventHandler(this.button_AddSpeciality_Click);
            // 
            // button_AddDoctor
            // 
            this.button_AddDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddDoctor.Location = new System.Drawing.Point(427, 445);
            this.button_AddDoctor.Name = "button_AddDoctor";
            this.button_AddDoctor.Size = new System.Drawing.Size(142, 66);
            this.button_AddDoctor.TabIndex = 28;
            this.button_AddDoctor.Text = "Add Doctor";
            this.button_AddDoctor.UseVisualStyleBackColor = true;
            this.button_AddDoctor.Click += new System.EventHandler(this.button_AddDoctor_Click);
            // 
            // listBox_Specialities
            // 
            this.listBox_Specialities.FormattingEnabled = true;
            this.listBox_Specialities.Location = new System.Drawing.Point(674, 249);
            this.listBox_Specialities.Name = "listBox_Specialities";
            this.listBox_Specialities.Size = new System.Drawing.Size(195, 121);
            this.listBox_Specialities.TabIndex = 29;
            // 
            // label_Success
            // 
            this.label_Success.AutoSize = true;
            this.label_Success.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Success.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_Success.Location = new System.Drawing.Point(387, 161);
            this.label_Success.Name = "label_Success";
            this.label_Success.Size = new System.Drawing.Size(230, 24);
            this.label_Success.TabIndex = 30;
            this.label_Success.Text = "Doctor successfully added";
            this.label_Success.Visible = false;
            // 
            // AddDoctorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_Success);
            this.Controls.Add(this.listBox_Specialities);
            this.Controls.Add(this.button_AddDoctor);
            this.Controls.Add(this.button_AddSpeciality);
            this.Controls.Add(this.label_Speciality);
            this.Controls.Add(this.comboBox_Speciality);
            this.Controls.Add(this.label_Specialities);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.label8);
            this.Name = "AddDoctorControl";
            this.Size = new System.Drawing.Size(980, 647);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label_Specialities;
        private System.Windows.Forms.ComboBox comboBox_Speciality;
        private System.Windows.Forms.Label label_Speciality;
        private System.Windows.Forms.Button button_AddSpeciality;
        private System.Windows.Forms.Button button_AddDoctor;
        private System.Windows.Forms.ListBox listBox_Specialities;
        private System.Windows.Forms.Label label_Success;
    }
}
