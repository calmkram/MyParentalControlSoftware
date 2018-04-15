namespace MyParentalControlSoftware
{
    partial class MainAppWindow
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
            this.cmbUserList = new System.Windows.Forms.ComboBox();
            this.lblSelectUser = new System.Windows.Forms.Label();
            this.grpbxTimeRestrictions = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // cmbUserList
            // 
            this.cmbUserList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserList.FormattingEnabled = true;
            this.cmbUserList.Location = new System.Drawing.Point(112, 47);
            this.cmbUserList.Name = "cmbUserList";
            this.cmbUserList.Size = new System.Drawing.Size(198, 21);
            this.cmbUserList.TabIndex = 0;
            this.cmbUserList.TextChanged += new System.EventHandler(this.UserList_TextChanged);
            // 
            // lblSelectUser
            // 
            this.lblSelectUser.AutoSize = true;
            this.lblSelectUser.Location = new System.Drawing.Point(12, 50);
            this.lblSelectUser.Name = "lblSelectUser";
            this.lblSelectUser.Size = new System.Drawing.Size(65, 13);
            this.lblSelectUser.TabIndex = 1;
            this.lblSelectUser.Text = "Select User:";
            // 
            // grpbxTimeRestrictions
            // 
            this.grpbxTimeRestrictions.Location = new System.Drawing.Point(15, 85);
            this.grpbxTimeRestrictions.Name = "grpbxTimeRestrictions";
            this.grpbxTimeRestrictions.Size = new System.Drawing.Size(611, 296);
            this.grpbxTimeRestrictions.TabIndex = 2;
            this.grpbxTimeRestrictions.TabStop = false;
            this.grpbxTimeRestrictions.Text = "User Time Restrictions";
            this.grpbxTimeRestrictions.Visible = false;
            // 
            // MainAppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 393);
            this.Controls.Add(this.grpbxTimeRestrictions);
            this.Controls.Add(this.lblSelectUser);
            this.Controls.Add(this.cmbUserList);
            this.Name = "MainAppWindow";
            this.Text = "My Parental Control Software";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUserList;
        private System.Windows.Forms.Label lblSelectUser;
        private System.Windows.Forms.GroupBox grpbxTimeRestrictions;
    }
}

