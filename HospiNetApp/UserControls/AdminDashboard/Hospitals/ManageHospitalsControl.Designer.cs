
namespace HospiNetApp.UserControls.AdminDashboard.Hospitals
{
    partial class ManageHospitalsControl
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
            this.panel_ManageHospitals = new System.Windows.Forms.Panel();
            this.button_AddHospital = new System.Windows.Forms.Button();
            this.button_UpdateHospital = new System.Windows.Forms.Button();
            this.dataGridView_Hospitals = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_loading = new System.Windows.Forms.Label();
            this.panel_ManageHospitals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Hospitals)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ManageHospitals
            // 
            this.panel_ManageHospitals.Controls.Add(this.label_loading);
            this.panel_ManageHospitals.Controls.Add(this.button_AddHospital);
            this.panel_ManageHospitals.Controls.Add(this.button_UpdateHospital);
            this.panel_ManageHospitals.Controls.Add(this.dataGridView_Hospitals);
            this.panel_ManageHospitals.Location = new System.Drawing.Point(0, 0);
            this.panel_ManageHospitals.Name = "panel_ManageHospitals";
            this.panel_ManageHospitals.Size = new System.Drawing.Size(980, 647);
            this.panel_ManageHospitals.TabIndex = 0;
            // 
            // button_AddHospital
            // 
            this.button_AddHospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddHospital.Location = new System.Drawing.Point(276, 39);
            this.button_AddHospital.Name = "button_AddHospital";
            this.button_AddHospital.Size = new System.Drawing.Size(155, 59);
            this.button_AddHospital.TabIndex = 6;
            this.button_AddHospital.Text = "Add Hospital";
            this.button_AddHospital.UseVisualStyleBackColor = true;
            this.button_AddHospital.Click += new System.EventHandler(this.button_AddHospital_Click);
            // 
            // button_UpdateHospital
            // 
            this.button_UpdateHospital.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UpdateHospital.Location = new System.Drawing.Point(582, 39);
            this.button_UpdateHospital.Name = "button_UpdateHospital";
            this.button_UpdateHospital.Size = new System.Drawing.Size(155, 59);
            this.button_UpdateHospital.TabIndex = 7;
            this.button_UpdateHospital.Text = "Update Hospital";
            this.button_UpdateHospital.UseVisualStyleBackColor = true;
            this.button_UpdateHospital.Click += new System.EventHandler(this.button_UpdateHospital_Click);
            // 
            // dataGridView_Hospitals
            // 
            this.dataGridView_Hospitals.AllowUserToAddRows = false;
            this.dataGridView_Hospitals.AllowUserToDeleteRows = false;
            this.dataGridView_Hospitals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Hospitals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Address,
            this.ZipCode,
            this.City});
            this.dataGridView_Hospitals.Enabled = false;
            this.dataGridView_Hospitals.Location = new System.Drawing.Point(18, 158);
            this.dataGridView_Hospitals.Name = "dataGridView_Hospitals";
            this.dataGridView_Hospitals.ReadOnly = true;
            this.dataGridView_Hospitals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Hospitals.Size = new System.Drawing.Size(944, 450);
            this.dataGridView_Hospitals.TabIndex = 5;
            // 
            // Name
            // 
            this.Name.HeaderText = "Hospital";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 225;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 225;
            // 
            // ZipCode
            // 
            this.ZipCode.HeaderText = "Zip Code";
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.ReadOnly = true;
            this.ZipCode.Width = 225;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 225;
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
            // ManageHospitalsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_ManageHospitals);
            this.Size = new System.Drawing.Size(980, 647);
            this.panel_ManageHospitals.ResumeLayout(false);
            this.panel_ManageHospitals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Hospitals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ManageHospitals;
        private System.Windows.Forms.Button button_AddHospital;
        private System.Windows.Forms.Button button_UpdateHospital;
        private System.Windows.Forms.DataGridView dataGridView_Hospitals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.Label label_loading;
    }
}
