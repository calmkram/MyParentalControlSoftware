﻿namespace MyParentalControlSoftware
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
            this.btnDisableUser = new System.Windows.Forms.Button();
            this.btnEnableUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbSatToTime = new System.Windows.Forms.ComboBox();
            this.cmbSatFromTime = new System.Windows.Forms.ComboBox();
            this.cmbFriToTime = new System.Windows.Forms.ComboBox();
            this.cmbFriFromTime = new System.Windows.Forms.ComboBox();
            this.cmbThurToTime = new System.Windows.Forms.ComboBox();
            this.cmbThurFromTime = new System.Windows.Forms.ComboBox();
            this.cmbWedToTime = new System.Windows.Forms.ComboBox();
            this.cmbWedFromTime = new System.Windows.Forms.ComboBox();
            this.cmbTuesToTime = new System.Windows.Forms.ComboBox();
            this.cmbTuesFromTime = new System.Windows.Forms.ComboBox();
            this.cmbMonToTime = new System.Windows.Forms.ComboBox();
            this.cmbMonFromTime = new System.Windows.Forms.ComboBox();
            this.cmbSunToTime = new System.Windows.Forms.ComboBox();
            this.cmbSunFromTime = new System.Windows.Forms.ComboBox();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblSunday = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbxAppAndWebAccess = new System.Windows.Forms.GroupBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpbxTimeRestrictions.SuspendLayout();
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
            this.grpbxTimeRestrictions.Controls.Add(this.btnDisableUser);
            this.grpbxTimeRestrictions.Controls.Add(this.btnEnableUser);
            this.grpbxTimeRestrictions.Controls.Add(this.label5);
            this.grpbxTimeRestrictions.Controls.Add(this.label4);
            this.grpbxTimeRestrictions.Controls.Add(this.label3);
            this.grpbxTimeRestrictions.Controls.Add(this.label2);
            this.grpbxTimeRestrictions.Controls.Add(this.btnSave);
            this.grpbxTimeRestrictions.Controls.Add(this.cmbSatToTime);
            this.grpbxTimeRestrictions.Controls.Add(this.cmbSatFromTime);
            this.grpbxTimeRestrictions.Controls.Add(this.cmbFriToTime);
            this.grpbxTimeRestrictions.Controls.Add(this.cmbFriFromTime);
            this.grpbxTimeRestrictions.Controls.Add(this.cmbThurToTime);
            this.grpbxTimeRestrictions.Controls.Add(this.cmbThurFromTime);
            this.grpbxTimeRestrictions.Controls.Add(this.cmbWedToTime);
            this.grpbxTimeRestrictions.Controls.Add(this.cmbWedFromTime);
            this.grpbxTimeRestrictions.Controls.Add(this.cmbTuesToTime);
            this.grpbxTimeRestrictions.Controls.Add(this.cmbTuesFromTime);
            this.grpbxTimeRestrictions.Controls.Add(this.cmbMonToTime);
            this.grpbxTimeRestrictions.Controls.Add(this.cmbMonFromTime);
            this.grpbxTimeRestrictions.Controls.Add(this.cmbSunToTime);
            this.grpbxTimeRestrictions.Controls.Add(this.cmbSunFromTime);
            this.grpbxTimeRestrictions.Controls.Add(this.lblSaturday);
            this.grpbxTimeRestrictions.Controls.Add(this.lblFriday);
            this.grpbxTimeRestrictions.Controls.Add(this.lblThursday);
            this.grpbxTimeRestrictions.Controls.Add(this.lblWednesday);
            this.grpbxTimeRestrictions.Controls.Add(this.lblTuesday);
            this.grpbxTimeRestrictions.Controls.Add(this.lblMonday);
            this.grpbxTimeRestrictions.Controls.Add(this.lblSunday);
            this.grpbxTimeRestrictions.Location = new System.Drawing.Point(15, 85);
            this.grpbxTimeRestrictions.Name = "grpbxTimeRestrictions";
            this.grpbxTimeRestrictions.Size = new System.Drawing.Size(276, 309);
            this.grpbxTimeRestrictions.TabIndex = 2;
            this.grpbxTimeRestrictions.TabStop = false;
            this.grpbxTimeRestrictions.Text = "User Time Restrictions";
            this.grpbxTimeRestrictions.Visible = false;
            // 
            // btnDisableUser
            // 
            this.btnDisableUser.Location = new System.Drawing.Point(171, 271);
            this.btnDisableUser.Name = "btnDisableUser";
            this.btnDisableUser.Size = new System.Drawing.Size(75, 23);
            this.btnDisableUser.TabIndex = 27;
            this.btnDisableUser.Text = "Disable User";
            this.btnDisableUser.UseVisualStyleBackColor = true;
            this.btnDisableUser.Click += new System.EventHandler(this.DisableUser_Click);
            // 
            // btnEnableUser
            // 
            this.btnEnableUser.Location = new System.Drawing.Point(171, 241);
            this.btnEnableUser.Name = "btnEnableUser";
            this.btnEnableUser.Size = new System.Drawing.Size(75, 23);
            this.btnEnableUser.TabIndex = 26;
            this.btnEnableUser.Text = "Enable User";
            this.btnEnableUser.UseVisualStyleBackColor = true;
            this.btnEnableUser.Click += new System.EventHandler(this.EnableUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Day:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(23, 37);
            this.label4.MaximumSize = new System.Drawing.Size(500, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 1);
            this.label4.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "From:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(23, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // cmbSatToTime
            // 
            this.cmbSatToTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSatToTime.FormattingEnabled = true;
            this.cmbSatToTime.Location = new System.Drawing.Point(181, 199);
            this.cmbSatToTime.Name = "cmbSatToTime";
            this.cmbSatToTime.Size = new System.Drawing.Size(75, 21);
            this.cmbSatToTime.TabIndex = 20;
            // 
            // cmbSatFromTime
            // 
            this.cmbSatFromTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSatFromTime.FormattingEnabled = true;
            this.cmbSatFromTime.Location = new System.Drawing.Point(95, 199);
            this.cmbSatFromTime.Name = "cmbSatFromTime";
            this.cmbSatFromTime.Size = new System.Drawing.Size(75, 21);
            this.cmbSatFromTime.TabIndex = 19;
            // 
            // cmbFriToTime
            // 
            this.cmbFriToTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFriToTime.FormattingEnabled = true;
            this.cmbFriToTime.Location = new System.Drawing.Point(181, 173);
            this.cmbFriToTime.Name = "cmbFriToTime";
            this.cmbFriToTime.Size = new System.Drawing.Size(75, 21);
            this.cmbFriToTime.TabIndex = 18;
            // 
            // cmbFriFromTime
            // 
            this.cmbFriFromTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFriFromTime.FormattingEnabled = true;
            this.cmbFriFromTime.Location = new System.Drawing.Point(95, 173);
            this.cmbFriFromTime.Name = "cmbFriFromTime";
            this.cmbFriFromTime.Size = new System.Drawing.Size(75, 21);
            this.cmbFriFromTime.TabIndex = 17;
            // 
            // cmbThurToTime
            // 
            this.cmbThurToTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThurToTime.FormattingEnabled = true;
            this.cmbThurToTime.Location = new System.Drawing.Point(181, 147);
            this.cmbThurToTime.Name = "cmbThurToTime";
            this.cmbThurToTime.Size = new System.Drawing.Size(75, 21);
            this.cmbThurToTime.TabIndex = 16;
            // 
            // cmbThurFromTime
            // 
            this.cmbThurFromTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThurFromTime.FormattingEnabled = true;
            this.cmbThurFromTime.Location = new System.Drawing.Point(95, 147);
            this.cmbThurFromTime.Name = "cmbThurFromTime";
            this.cmbThurFromTime.Size = new System.Drawing.Size(75, 21);
            this.cmbThurFromTime.TabIndex = 15;
            // 
            // cmbWedToTime
            // 
            this.cmbWedToTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWedToTime.FormattingEnabled = true;
            this.cmbWedToTime.Location = new System.Drawing.Point(181, 121);
            this.cmbWedToTime.Name = "cmbWedToTime";
            this.cmbWedToTime.Size = new System.Drawing.Size(75, 21);
            this.cmbWedToTime.TabIndex = 14;
            // 
            // cmbWedFromTime
            // 
            this.cmbWedFromTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWedFromTime.FormattingEnabled = true;
            this.cmbWedFromTime.Location = new System.Drawing.Point(95, 121);
            this.cmbWedFromTime.Name = "cmbWedFromTime";
            this.cmbWedFromTime.Size = new System.Drawing.Size(75, 21);
            this.cmbWedFromTime.TabIndex = 13;
            // 
            // cmbTuesToTime
            // 
            this.cmbTuesToTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTuesToTime.FormattingEnabled = true;
            this.cmbTuesToTime.Location = new System.Drawing.Point(181, 95);
            this.cmbTuesToTime.Name = "cmbTuesToTime";
            this.cmbTuesToTime.Size = new System.Drawing.Size(75, 21);
            this.cmbTuesToTime.TabIndex = 12;
            // 
            // cmbTuesFromTime
            // 
            this.cmbTuesFromTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTuesFromTime.FormattingEnabled = true;
            this.cmbTuesFromTime.Location = new System.Drawing.Point(95, 95);
            this.cmbTuesFromTime.Name = "cmbTuesFromTime";
            this.cmbTuesFromTime.Size = new System.Drawing.Size(75, 21);
            this.cmbTuesFromTime.TabIndex = 11;
            // 
            // cmbMonToTime
            // 
            this.cmbMonToTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonToTime.FormattingEnabled = true;
            this.cmbMonToTime.Location = new System.Drawing.Point(181, 69);
            this.cmbMonToTime.Name = "cmbMonToTime";
            this.cmbMonToTime.Size = new System.Drawing.Size(75, 21);
            this.cmbMonToTime.TabIndex = 10;
            // 
            // cmbMonFromTime
            // 
            this.cmbMonFromTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonFromTime.FormattingEnabled = true;
            this.cmbMonFromTime.Location = new System.Drawing.Point(95, 69);
            this.cmbMonFromTime.Name = "cmbMonFromTime";
            this.cmbMonFromTime.Size = new System.Drawing.Size(75, 21);
            this.cmbMonFromTime.TabIndex = 9;
            // 
            // cmbSunToTime
            // 
            this.cmbSunToTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSunToTime.FormattingEnabled = true;
            this.cmbSunToTime.Location = new System.Drawing.Point(181, 43);
            this.cmbSunToTime.Name = "cmbSunToTime";
            this.cmbSunToTime.Size = new System.Drawing.Size(75, 21);
            this.cmbSunToTime.TabIndex = 8;
            // 
            // cmbSunFromTime
            // 
            this.cmbSunFromTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSunFromTime.FormattingEnabled = true;
            this.cmbSunFromTime.Location = new System.Drawing.Point(95, 43);
            this.cmbSunFromTime.Name = "cmbSunFromTime";
            this.cmbSunFromTime.Size = new System.Drawing.Size(75, 21);
            this.cmbSunFromTime.TabIndex = 7;
            // 
            // lblSaturday
            // 
            this.lblSaturday.AutoSize = true;
            this.lblSaturday.Location = new System.Drawing.Point(21, 202);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(49, 13);
            this.lblSaturday.TabIndex = 6;
            this.lblSaturday.Text = "Saturday";
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.Location = new System.Drawing.Point(21, 176);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(35, 13);
            this.lblFriday.TabIndex = 5;
            this.lblFriday.Text = "Friday";
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = true;
            this.lblThursday.Location = new System.Drawing.Point(21, 150);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(51, 13);
            this.lblThursday.TabIndex = 4;
            this.lblThursday.Text = "Thursday";
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.Location = new System.Drawing.Point(21, 124);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(64, 13);
            this.lblWednesday.TabIndex = 3;
            this.lblWednesday.Text = "Wednesday";
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Location = new System.Drawing.Point(21, 98);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(48, 13);
            this.lblTuesday.TabIndex = 2;
            this.lblTuesday.Text = "Tuesday";
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Location = new System.Drawing.Point(21, 72);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(45, 13);
            this.lblMonday.TabIndex = 1;
            this.lblMonday.Text = "Monday";
            // 
            // lblSunday
            // 
            this.lblSunday.AutoSize = true;
            this.lblSunday.Location = new System.Drawing.Point(21, 46);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(43, 13);
            this.lblSunday.TabIndex = 0;
            this.lblSunday.Text = "Sunday";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.MaximumSize = new System.Drawing.Size(615, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to My Parental Control Software! This custom software allows me to automa" +
    "tically set/change time limits and application / website access for this compute" +
    "r only.";
            // 
            // grpbxAppAndWebAccess
            // 
            this.grpbxAppAndWebAccess.Location = new System.Drawing.Point(297, 85);
            this.grpbxAppAndWebAccess.Name = "grpbxAppAndWebAccess";
            this.grpbxAppAndWebAccess.Size = new System.Drawing.Size(320, 309);
            this.grpbxAppAndWebAccess.TabIndex = 4;
            this.grpbxAppAndWebAccess.TabStop = false;
            this.grpbxAppAndWebAccess.Text = "User Application and Website Access Restrictions";
            this.grpbxAppAndWebAccess.Visible = false;
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(340, 45);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(421, 45);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 400);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(602, 40);
            this.textBox1.TabIndex = 0;
            // 
            // MainAppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 488);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.grpbxAppAndWebAccess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpbxTimeRestrictions);
            this.Controls.Add(this.lblSelectUser);
            this.Controls.Add(this.cmbUserList);
            this.Name = "MainAppWindow";
            this.Text = "My Parental Control Software";
            this.grpbxTimeRestrictions.ResumeLayout(false);
            this.grpbxTimeRestrictions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUserList;
        private System.Windows.Forms.Label lblSelectUser;
        private System.Windows.Forms.GroupBox grpbxTimeRestrictions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbxAppAndWebAccess;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSaturday;
        private System.Windows.Forms.Label lblFriday;
        private System.Windows.Forms.Label lblThursday;
        private System.Windows.Forms.Label lblWednesday;
        private System.Windows.Forms.Label lblTuesday;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.Label lblSunday;
        private System.Windows.Forms.ComboBox cmbSatToTime;
        private System.Windows.Forms.ComboBox cmbSatFromTime;
        private System.Windows.Forms.ComboBox cmbFriToTime;
        private System.Windows.Forms.ComboBox cmbFriFromTime;
        private System.Windows.Forms.ComboBox cmbThurToTime;
        private System.Windows.Forms.ComboBox cmbThurFromTime;
        private System.Windows.Forms.ComboBox cmbWedToTime;
        private System.Windows.Forms.ComboBox cmbWedFromTime;
        private System.Windows.Forms.ComboBox cmbTuesToTime;
        private System.Windows.Forms.ComboBox cmbTuesFromTime;
        private System.Windows.Forms.ComboBox cmbMonToTime;
        private System.Windows.Forms.ComboBox cmbMonFromTime;
        private System.Windows.Forms.ComboBox cmbSunToTime;
        private System.Windows.Forms.ComboBox cmbSunFromTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDisableUser;
        private System.Windows.Forms.Button btnEnableUser;
        private System.Windows.Forms.TextBox textBox1;
    }
}
