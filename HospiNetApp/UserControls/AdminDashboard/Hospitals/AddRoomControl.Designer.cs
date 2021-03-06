
namespace HospiNetApp.UserControls.AdminDashboard.Hospitals
{
    partial class AddRoomControl
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
            this.label_Failed = new System.Windows.Forms.Label();
            this.label_Success = new System.Windows.Forms.Label();
            this.button_AddRoom = new System.Windows.Forms.Button();
            this.textBox_RoomName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Hospitals = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(355, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(296, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "ROOM REGISTRATION FORM";
            // 
            // label_Failed
            // 
            this.label_Failed.AutoSize = true;
            this.label_Failed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Failed.ForeColor = System.Drawing.Color.DarkRed;
            this.label_Failed.Location = new System.Drawing.Point(400, 166);
            this.label_Failed.Name = "label_Failed";
            this.label_Failed.Size = new System.Drawing.Size(184, 24);
            this.label_Failed.TabIndex = 24;
            this.label_Failed.Text = "Patient already exists";
            this.label_Failed.Visible = false;
            // 
            // label_Success
            // 
            this.label_Success.AutoSize = true;
            this.label_Success.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Success.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_Success.Location = new System.Drawing.Point(379, 166);
            this.label_Success.Name = "label_Success";
            this.label_Success.Size = new System.Drawing.Size(231, 24);
            this.label_Success.TabIndex = 23;
            this.label_Success.Text = "Patient successfully added";
            this.label_Success.Visible = false;
            // 
            // button_AddRoom
            // 
            this.button_AddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddRoom.Location = new System.Drawing.Point(420, 414);
            this.button_AddRoom.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddRoom.Name = "button_AddRoom";
            this.button_AddRoom.Size = new System.Drawing.Size(142, 66);
            this.button_AddRoom.TabIndex = 22;
            this.button_AddRoom.Text = "Add Room";
            this.button_AddRoom.UseVisualStyleBackColor = true;
            // 
            // textBox_RoomName
            // 
            this.textBox_RoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_RoomName.Location = new System.Drawing.Point(414, 237);
            this.textBox_RoomName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_RoomName.Name = "textBox_RoomName";
            this.textBox_RoomName.Size = new System.Drawing.Size(261, 28);
            this.textBox_RoomName.TabIndex = 20;
            this.textBox_RoomName.TextChanged += new System.EventHandler(this.textBox_RoomName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Hospital:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Room name:";
            // 
            // comboBox_Hospitals
            // 
            this.comboBox_Hospitals.Enabled = false;
            this.comboBox_Hospitals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Hospitals.FormattingEnabled = true;
            this.comboBox_Hospitals.Location = new System.Drawing.Point(414, 278);
            this.comboBox_Hospitals.Name = "comboBox_Hospitals";
            this.comboBox_Hospitals.Size = new System.Drawing.Size(261, 32);
            this.comboBox_Hospitals.TabIndex = 25;
            // 
            // AddRoomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox_Hospitals);
            this.Controls.Add(this.label_Failed);
            this.Controls.Add(this.label_Success);
            this.Controls.Add(this.button_AddRoom);
            this.Controls.Add(this.textBox_RoomName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "AddRoomControl";
            this.Size = new System.Drawing.Size(980, 647);
            this.Load += new System.EventHandler(this.AddRoomControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_Failed;
        private System.Windows.Forms.Label label_Success;
        private System.Windows.Forms.Button button_AddRoom;
        private System.Windows.Forms.TextBox textBox_RoomName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Hospitals;
    }
}
