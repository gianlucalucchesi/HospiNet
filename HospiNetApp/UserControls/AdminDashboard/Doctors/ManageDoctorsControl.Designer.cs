
namespace HospiNetApp.UserControls.AdminDashboard.Doctors
{
    partial class ManageDoctorsControl
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
            this.label_loading = new System.Windows.Forms.Label();
            this.button_AddDoctor = new System.Windows.Forms.Button();
            this.dataGridView_ManageDoctors = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_ManageDoctors = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ManageDoctors)).BeginInit();
            this.panel_ManageDoctors.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_loading
            // 
            this.label_loading.AutoSize = true;
            this.label_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loading.Location = new System.Drawing.Point(420, 296);
            this.label_loading.Name = "label_loading";
            this.label_loading.Size = new System.Drawing.Size(159, 37);
            this.label_loading.TabIndex = 10;
            this.label_loading.Text = "Loading...";
            // 
            // button_AddDoctor
            // 
            this.button_AddDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddDoctor.Location = new System.Drawing.Point(415, 51);
            this.button_AddDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddDoctor.Name = "button_AddDoctor";
            this.button_AddDoctor.Size = new System.Drawing.Size(155, 59);
            this.button_AddDoctor.TabIndex = 7;
            this.button_AddDoctor.Text = "Add Doctor";
            this.button_AddDoctor.UseVisualStyleBackColor = true;
            this.button_AddDoctor.Click += new System.EventHandler(this.button_AddDoctor_Click);
            // 
            // dataGridView_ManageDoctors
            // 
            this.dataGridView_ManageDoctors.AllowUserToAddRows = false;
            this.dataGridView_ManageDoctors.AllowUserToDeleteRows = false;
            this.dataGridView_ManageDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ManageDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.Specialities});
            this.dataGridView_ManageDoctors.Location = new System.Drawing.Point(18, 155);
            this.dataGridView_ManageDoctors.Name = "dataGridView_ManageDoctors";
            this.dataGridView_ManageDoctors.ReadOnly = true;
            this.dataGridView_ManageDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ManageDoctors.Size = new System.Drawing.Size(944, 450);
            this.dataGridView_ManageDoctors.TabIndex = 12;
            this.dataGridView_ManageDoctors.Visible = false;
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
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 300;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 300;
            // 
            // Specialities
            // 
            this.Specialities.HeaderText = "Specialities";
            this.Specialities.Name = "Specialities";
            this.Specialities.ReadOnly = true;
            this.Specialities.Width = 300;
            // 
            // panel_ManageDoctors
            // 
            this.panel_ManageDoctors.Controls.Add(this.button_AddDoctor);
            this.panel_ManageDoctors.Location = new System.Drawing.Point(0, 0);
            this.panel_ManageDoctors.Name = "panel_ManageDoctors";
            this.panel_ManageDoctors.Size = new System.Drawing.Size(980, 647);
            this.panel_ManageDoctors.TabIndex = 13;
            // 
            // ManageDoctorsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_loading);
            this.Controls.Add(this.dataGridView_ManageDoctors);
            this.Controls.Add(this.panel_ManageDoctors);
            this.Name = "ManageDoctorsControl";
            this.Size = new System.Drawing.Size(980, 647);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ManageDoctors)).EndInit();
            this.panel_ManageDoctors.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_loading;
        private System.Windows.Forms.Button button_AddDoctor;
        private System.Windows.Forms.DataGridView dataGridView_ManageDoctors;
        private System.Windows.Forms.Panel panel_ManageDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialities;
    }
}
