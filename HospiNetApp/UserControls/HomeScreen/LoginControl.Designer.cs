
namespace HospiNetApp.UserControls
{
    partial class Login
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
            this.textBox_loginScreen_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_loginScreen_LastName = new System.Windows.Forms.TextBox();
            this.button_loginScreen_login = new System.Windows.Forms.Button();
            this.label_UnknownUser = new System.Windows.Forms.Label();
            this.label_loading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // textBox_loginScreen_FirstName
            // 
            this.textBox_loginScreen_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_loginScreen_FirstName.Location = new System.Drawing.Point(385, 151);
            this.textBox_loginScreen_FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_loginScreen_FirstName.Name = "textBox_loginScreen_FirstName";
            this.textBox_loginScreen_FirstName.Size = new System.Drawing.Size(241, 28);
            this.textBox_loginScreen_FirstName.TabIndex = 2;
            // 
            // textBox_loginScreen_LastName
            // 
            this.textBox_loginScreen_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_loginScreen_LastName.Location = new System.Drawing.Point(385, 195);
            this.textBox_loginScreen_LastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_loginScreen_LastName.Name = "textBox_loginScreen_LastName";
            this.textBox_loginScreen_LastName.Size = new System.Drawing.Size(241, 28);
            this.textBox_loginScreen_LastName.TabIndex = 3;
            // 
            // button_loginScreen_login
            // 
            this.button_loginScreen_login.BackColor = System.Drawing.Color.White;
            this.button_loginScreen_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_loginScreen_login.Location = new System.Drawing.Point(412, 267);
            this.button_loginScreen_login.Margin = new System.Windows.Forms.Padding(2);
            this.button_loginScreen_login.Name = "button_loginScreen_login";
            this.button_loginScreen_login.Size = new System.Drawing.Size(112, 48);
            this.button_loginScreen_login.TabIndex = 4;
            this.button_loginScreen_login.Text = "Login";
            this.button_loginScreen_login.UseVisualStyleBackColor = false;
            this.button_loginScreen_login.Click += new System.EventHandler(this.button_loginScreen_login_Click);
            // 
            // label_UnknownUser
            // 
            this.label_UnknownUser.AutoSize = true;
            this.label_UnknownUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UnknownUser.ForeColor = System.Drawing.Color.Red;
            this.label_UnknownUser.Location = new System.Drawing.Point(408, 92);
            this.label_UnknownUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_UnknownUser.Name = "label_UnknownUser";
            this.label_UnknownUser.Size = new System.Drawing.Size(132, 24);
            this.label_UnknownUser.TabIndex = 5;
            this.label_UnknownUser.Text = "Unknown user";
            this.label_UnknownUser.Visible = false;
            // 
            // label_loading
            // 
            this.label_loading.AutoSize = true;
            this.label_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loading.Location = new System.Drawing.Point(425, 92);
            this.label_loading.Name = "label_loading";
            this.label_loading.Size = new System.Drawing.Size(93, 24);
            this.label_loading.TabIndex = 7;
            this.label_loading.Text = "Loading...";
            this.label_loading.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_loading);
            this.Controls.Add(this.label_UnknownUser);
            this.Controls.Add(this.button_loginScreen_login);
            this.Controls.Add(this.textBox_loginScreen_LastName);
            this.Controls.Add(this.textBox_loginScreen_FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(926, 393);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_loginScreen_FirstName;
        private System.Windows.Forms.TextBox textBox_loginScreen_LastName;
        private System.Windows.Forms.Button button_loginScreen_login;
        private System.Windows.Forms.Label label_UnknownUser;
        private System.Windows.Forms.Label label_loading;
    }
}
