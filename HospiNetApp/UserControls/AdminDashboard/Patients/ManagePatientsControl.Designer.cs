
namespace HospiNetApp.UserControls
{
    partial class HomePatientsControl
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
            this.button_HomePatients_AddPatient = new System.Windows.Forms.Button();
            this.button_HomePatients_UpdatePatient = new System.Windows.Forms.Button();
            this.HomePatientsControlPanel = new System.Windows.Forms.Panel();
            this.label_loading = new System.Windows.Forms.Label();
            this.dataGridView_homePatients = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomePatientsControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_homePatients)).BeginInit();
            this.SuspendLayout();
            // 
            // button_HomePatients_AddPatient
            // 
            this.button_HomePatients_AddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_HomePatients_AddPatient.Location = new System.Drawing.Point(276, 36);
            this.button_HomePatients_AddPatient.Margin = new System.Windows.Forms.Padding(2);
            this.button_HomePatients_AddPatient.Name = "button_HomePatients_AddPatient";
            this.button_HomePatients_AddPatient.Size = new System.Drawing.Size(155, 59);
            this.button_HomePatients_AddPatient.TabIndex = 1;
            this.button_HomePatients_AddPatient.Text = "Add Patient";
            this.button_HomePatients_AddPatient.UseVisualStyleBackColor = true;
            this.button_HomePatients_AddPatient.Click += new System.EventHandler(this.button_HomePatients_AddPatient_Click);
            // 
            // button_HomePatients_UpdatePatient
            // 
            this.button_HomePatients_UpdatePatient.Enabled = false;
            this.button_HomePatients_UpdatePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_HomePatients_UpdatePatient.Location = new System.Drawing.Point(582, 36);
            this.button_HomePatients_UpdatePatient.Margin = new System.Windows.Forms.Padding(2);
            this.button_HomePatients_UpdatePatient.Name = "button_HomePatients_UpdatePatient";
            this.button_HomePatients_UpdatePatient.Size = new System.Drawing.Size(155, 59);
            this.button_HomePatients_UpdatePatient.TabIndex = 2;
            this.button_HomePatients_UpdatePatient.Text = "Update Patient";
            this.button_HomePatients_UpdatePatient.UseVisualStyleBackColor = true;
            this.button_HomePatients_UpdatePatient.Click += new System.EventHandler(this.button_HomePatients_UpdatePatient_Click);
            // 
            // HomePatientsControlPanel
            // 
            this.HomePatientsControlPanel.Controls.Add(this.label_loading);
            this.HomePatientsControlPanel.Controls.Add(this.dataGridView_homePatients);
            this.HomePatientsControlPanel.Controls.Add(this.button_HomePatients_UpdatePatient);
            this.HomePatientsControlPanel.Controls.Add(this.button_HomePatients_AddPatient);
            this.HomePatientsControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePatientsControlPanel.Location = new System.Drawing.Point(0, 0);
            this.HomePatientsControlPanel.Name = "HomePatientsControlPanel";
            this.HomePatientsControlPanel.Size = new System.Drawing.Size(980, 647);
            this.HomePatientsControlPanel.TabIndex = 4;
            // 
            // label_loading
            // 
            this.label_loading.AutoSize = true;
            this.label_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loading.Location = new System.Drawing.Point(420, 293);
            this.label_loading.Name = "label_loading";
            this.label_loading.Size = new System.Drawing.Size(159, 37);
            this.label_loading.TabIndex = 5;
            this.label_loading.Text = "Loading...";
            // 
            // dataGridView_homePatients
            // 
            this.dataGridView_homePatients.AllowUserToAddRows = false;
            this.dataGridView_homePatients.AllowUserToDeleteRows = false;
            this.dataGridView_homePatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_homePatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.Birthday});
            this.dataGridView_homePatients.Location = new System.Drawing.Point(18, 155);
            this.dataGridView_homePatients.MultiSelect = false;
            this.dataGridView_homePatients.Name = "dataGridView_homePatients";
            this.dataGridView_homePatients.ReadOnly = true;
            this.dataGridView_homePatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_homePatients.Size = new System.Drawing.Size(944, 450);
            this.dataGridView_homePatients.TabIndex = 4;
            this.dataGridView_homePatients.Visible = false;
            this.dataGridView_homePatients.SelectionChanged += new System.EventHandler(this.dataGridView_homePatients_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 300;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 300;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 300;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 300;
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.MinimumWidth = 300;
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            this.Birthday.Width = 300;
            // 
            // HomePatientsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HomePatientsControlPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomePatientsControl";
            this.Size = new System.Drawing.Size(980, 647);
            this.HomePatientsControlPanel.ResumeLayout(false);
            this.HomePatientsControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_homePatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_HomePatients_AddPatient;
        private System.Windows.Forms.Button button_HomePatients_UpdatePatient;
        private System.Windows.Forms.Panel HomePatientsControlPanel;
        private System.Windows.Forms.DataGridView dataGridView_homePatients;
        private System.Windows.Forms.Label label_loading;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
    }
}
