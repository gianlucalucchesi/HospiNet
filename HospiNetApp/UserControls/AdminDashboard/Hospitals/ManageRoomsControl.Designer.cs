
namespace HospiNetApp.UserControls.AdminDashboard.Hospitals
{
    partial class ManageRoomsControl
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
            this.dataGridView_Rooms = new System.Windows.Forms.DataGridView();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HospitalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_AddRoom = new System.Windows.Forms.Button();
            this.button_RemoveRoom = new System.Windows.Forms.Button();
            this.label_loading = new System.Windows.Forms.Label();
            this.panel_ManageRooms = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rooms)).BeginInit();
            this.panel_ManageRooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Rooms
            // 
            this.dataGridView_Rooms.AllowUserToDeleteRows = false;
            this.dataGridView_Rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Rooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomName,
            this.HospitalName});
            this.dataGridView_Rooms.Location = new System.Drawing.Point(18, 155);
            this.dataGridView_Rooms.Name = "dataGridView_Rooms";
            this.dataGridView_Rooms.ReadOnly = true;
            this.dataGridView_Rooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Rooms.Size = new System.Drawing.Size(944, 450);
            this.dataGridView_Rooms.TabIndex = 0;
            // 
            // RoomName
            // 
            this.RoomName.HeaderText = "Room";
            this.RoomName.Name = "RoomName";
            this.RoomName.ReadOnly = true;
            this.RoomName.Width = 450;
            // 
            // HospitalName
            // 
            this.HospitalName.HeaderText = "Hospital";
            this.HospitalName.Name = "HospitalName";
            this.HospitalName.ReadOnly = true;
            this.HospitalName.Width = 450;
            // 
            // button_AddRoom
            // 
            this.button_AddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddRoom.Location = new System.Drawing.Point(276, 36);
            this.button_AddRoom.Name = "button_AddRoom";
            this.button_AddRoom.Size = new System.Drawing.Size(155, 59);
            this.button_AddRoom.TabIndex = 1;
            this.button_AddRoom.Text = "Add Room";
            this.button_AddRoom.UseVisualStyleBackColor = true;
            this.button_AddRoom.Click += new System.EventHandler(this.button_AddRoom_Click);
            // 
            // button_RemoveRoom
            // 
            this.button_RemoveRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RemoveRoom.Location = new System.Drawing.Point(582, 36);
            this.button_RemoveRoom.Name = "button_RemoveRoom";
            this.button_RemoveRoom.Size = new System.Drawing.Size(155, 59);
            this.button_RemoveRoom.TabIndex = 2;
            this.button_RemoveRoom.Text = "Remove Room";
            this.button_RemoveRoom.UseVisualStyleBackColor = true;
            // 
            // label_loading
            // 
            this.label_loading.AutoSize = true;
            this.label_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loading.Location = new System.Drawing.Point(411, 305);
            this.label_loading.Name = "label_loading";
            this.label_loading.Size = new System.Drawing.Size(159, 37);
            this.label_loading.TabIndex = 6;
            this.label_loading.Text = "Loading...";
            // 
            // panel_ManageRooms
            // 
            this.panel_ManageRooms.Controls.Add(this.dataGridView_Rooms);
            this.panel_ManageRooms.Controls.Add(this.button_AddRoom);
            this.panel_ManageRooms.Controls.Add(this.button_RemoveRoom);
            this.panel_ManageRooms.Controls.Add(this.label_loading);
            this.panel_ManageRooms.Location = new System.Drawing.Point(0, 0);
            this.panel_ManageRooms.Name = "panel_ManageRooms";
            this.panel_ManageRooms.Size = new System.Drawing.Size(980, 647);
            this.panel_ManageRooms.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Loading...";
            // 
            // ManageRoomsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_ManageRooms);
            this.Name = "ManageRoomsControl";
            this.Size = new System.Drawing.Size(980, 647);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rooms)).EndInit();
            this.panel_ManageRooms.ResumeLayout(false);
            this.panel_ManageRooms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Rooms;
        private System.Windows.Forms.Button button_AddRoom;
        private System.Windows.Forms.Button button_RemoveRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HospitalName;
        private System.Windows.Forms.Label label_loading;
        private System.Windows.Forms.Panel panel_ManageRooms;
        private System.Windows.Forms.Label label1;
    }
}
