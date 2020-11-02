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
            this.cmbThuToTime = new System.Windows.Forms.ComboBox();
            this.cmbThuFromTime = new System.Windows.Forms.ComboBox();
            this.cmbWedToTime = new System.Windows.Forms.ComboBox();
            this.cmbWedFromTime = new System.Windows.Forms.ComboBox();
            this.cmbTueToTime = new System.Windows.Forms.ComboBox();
            this.cmbTueFromTime = new System.Windows.Forms.ComboBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.cmbComputerList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpbxTimeRestrictions.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbUserList
            // 
            this.cmbUserList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserList.FormattingEnabled = true;
            this.cmbUserList.Location = new System.Drawing.Point(149, 95);
            this.cmbUserList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUserList.Name = "cmbUserList";
            this.cmbUserList.Size = new System.Drawing.Size(263, 24);
            this.cmbUserList.TabIndex = 0;
            this.cmbUserList.TextChanged += new System.EventHandler(this.UserList_TextChanged);
            // 
            // lblSelectUser
            // 
            this.lblSelectUser.AutoSize = true;
            this.lblSelectUser.Location = new System.Drawing.Point(21, 98);
            this.lblSelectUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectUser.Name = "lblSelectUser";
            this.lblSelectUser.Size = new System.Drawing.Size(85, 17);
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
            this.grpbxTimeRestrictions.Controls.Add(this.cmbThuToTime);
            this.grpbxTimeRestrictions.Controls.Add(this.cmbThuFromTime);
            this.grpbxTimeRestrictions.Controls.Add(this.cmbWedToTime);
            this.grpbxTimeRestrictions.Controls.Add(this.cmbWedFromTime);
            this.grpbxTimeRestrictions.Controls.Add(this.cmbTueToTime);
            this.grpbxTimeRestrictions.Controls.Add(this.cmbTueFromTime);
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
            this.grpbxTimeRestrictions.Location = new System.Drawing.Point(20, 142);
            this.grpbxTimeRestrictions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxTimeRestrictions.Name = "grpbxTimeRestrictions";
            this.grpbxTimeRestrictions.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxTimeRestrictions.Size = new System.Drawing.Size(368, 380);
            this.grpbxTimeRestrictions.TabIndex = 2;
            this.grpbxTimeRestrictions.TabStop = false;
            this.grpbxTimeRestrictions.Text = "User Time Restrictions";
            this.grpbxTimeRestrictions.Visible = false;
            // 
            // btnDisableUser
            // 
            this.btnDisableUser.Location = new System.Drawing.Point(228, 334);
            this.btnDisableUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisableUser.Name = "btnDisableUser";
            this.btnDisableUser.Size = new System.Drawing.Size(100, 28);
            this.btnDisableUser.TabIndex = 27;
            this.btnDisableUser.Text = "Disable User";
            this.btnDisableUser.UseVisualStyleBackColor = true;
            this.btnDisableUser.Click += new System.EventHandler(this.DisableUser_Click);
            // 
            // btnEnableUser
            // 
            this.btnEnableUser.Location = new System.Drawing.Point(228, 297);
            this.btnEnableUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnableUser.Name = "btnEnableUser";
            this.btnEnableUser.Size = new System.Drawing.Size(100, 28);
            this.btnEnableUser.TabIndex = 26;
            this.btnEnableUser.Text = "Enable User";
            this.btnEnableUser.UseVisualStyleBackColor = true;
            this.btnEnableUser.Click += new System.EventHandler(this.EnableUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Day:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(31, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.MaximumSize = new System.Drawing.Size(666, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 1);
            this.label4.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "From:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(31, 297);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 28);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // cmbSatToTime
            // 
            this.cmbSatToTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSatToTime.FormattingEnabled = true;
            this.cmbSatToTime.Location = new System.Drawing.Point(241, 245);
            this.cmbSatToTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSatToTime.Name = "cmbSatToTime";
            this.cmbSatToTime.Size = new System.Drawing.Size(99, 24);
            this.cmbSatToTime.TabIndex = 20;
            this.cmbSatToTime.SelectedIndexChanged += new System.EventHandler(this.cmbSatToTime_SelectedIndexChanged);
            // 
            // cmbSatFromTime
            // 
            this.cmbSatFromTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSatFromTime.FormattingEnabled = true;
            this.cmbSatFromTime.Location = new System.Drawing.Point(127, 245);
            this.cmbSatFromTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSatFromTime.Name = "cmbSatFromTime";
            this.cmbSatFromTime.Size = new System.Drawing.Size(99, 24);
            this.cmbSatFromTime.TabIndex = 19;
            this.cmbSatFromTime.SelectedIndexChanged += new System.EventHandler(this.cmbSatFromTime_SelectedIndexChanged);
            // 
            // cmbFriToTime
            // 
            this.cmbFriToTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFriToTime.FormattingEnabled = true;
            this.cmbFriToTime.Location = new System.Drawing.Point(241, 213);
            this.cmbFriToTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFriToTime.Name = "cmbFriToTime";
            this.cmbFriToTime.Size = new System.Drawing.Size(99, 24);
            this.cmbFriToTime.TabIndex = 18;
            this.cmbFriToTime.SelectedIndexChanged += new System.EventHandler(this.cmbFriToTime_SelectedIndexChanged);
            // 
            // cmbFriFromTime
            // 
            this.cmbFriFromTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFriFromTime.FormattingEnabled = true;
            this.cmbFriFromTime.Location = new System.Drawing.Point(127, 213);
            this.cmbFriFromTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFriFromTime.Name = "cmbFriFromTime";
            this.cmbFriFromTime.Size = new System.Drawing.Size(99, 24);
            this.cmbFriFromTime.TabIndex = 17;
            this.cmbFriFromTime.SelectedIndexChanged += new System.EventHandler(this.cmbFriFromTime_SelectedIndexChanged);
            // 
            // cmbThuToTime
            // 
            this.cmbThuToTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThuToTime.FormattingEnabled = true;
            this.cmbThuToTime.Location = new System.Drawing.Point(241, 181);
            this.cmbThuToTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbThuToTime.Name = "cmbThuToTime";
            this.cmbThuToTime.Size = new System.Drawing.Size(99, 24);
            this.cmbThuToTime.TabIndex = 16;
            this.cmbThuToTime.SelectedIndexChanged += new System.EventHandler(this.cmbThuToTime_SelectedIndexChanged);
            // 
            // cmbThuFromTime
            // 
            this.cmbThuFromTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThuFromTime.FormattingEnabled = true;
            this.cmbThuFromTime.Location = new System.Drawing.Point(127, 181);
            this.cmbThuFromTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbThuFromTime.Name = "cmbThuFromTime";
            this.cmbThuFromTime.Size = new System.Drawing.Size(99, 24);
            this.cmbThuFromTime.TabIndex = 15;
            this.cmbThuFromTime.SelectedIndexChanged += new System.EventHandler(this.cmbThuFromTime_SelectedIndexChanged);
            // 
            // cmbWedToTime
            // 
            this.cmbWedToTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWedToTime.FormattingEnabled = true;
            this.cmbWedToTime.Location = new System.Drawing.Point(241, 149);
            this.cmbWedToTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbWedToTime.Name = "cmbWedToTime";
            this.cmbWedToTime.Size = new System.Drawing.Size(99, 24);
            this.cmbWedToTime.TabIndex = 14;
            this.cmbWedToTime.SelectedIndexChanged += new System.EventHandler(this.cmbWedToTime_SelectedIndexChanged);
            // 
            // cmbWedFromTime
            // 
            this.cmbWedFromTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWedFromTime.FormattingEnabled = true;
            this.cmbWedFromTime.Location = new System.Drawing.Point(127, 149);
            this.cmbWedFromTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbWedFromTime.Name = "cmbWedFromTime";
            this.cmbWedFromTime.Size = new System.Drawing.Size(99, 24);
            this.cmbWedFromTime.TabIndex = 13;
            this.cmbWedFromTime.SelectedIndexChanged += new System.EventHandler(this.cmbWedFromTime_SelectedIndexChanged);
            // 
            // cmbTueToTime
            // 
            this.cmbTueToTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTueToTime.FormattingEnabled = true;
            this.cmbTueToTime.Location = new System.Drawing.Point(241, 117);
            this.cmbTueToTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTueToTime.Name = "cmbTueToTime";
            this.cmbTueToTime.Size = new System.Drawing.Size(99, 24);
            this.cmbTueToTime.TabIndex = 12;
            this.cmbTueToTime.SelectedIndexChanged += new System.EventHandler(this.cmbTueToTime_SelectedIndexChanged);
            // 
            // cmbTueFromTime
            // 
            this.cmbTueFromTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTueFromTime.FormattingEnabled = true;
            this.cmbTueFromTime.Location = new System.Drawing.Point(127, 117);
            this.cmbTueFromTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTueFromTime.Name = "cmbTueFromTime";
            this.cmbTueFromTime.Size = new System.Drawing.Size(99, 24);
            this.cmbTueFromTime.TabIndex = 11;
            this.cmbTueFromTime.SelectedIndexChanged += new System.EventHandler(this.cmbTueFromTime_SelectedIndexChanged);
            // 
            // cmbMonToTime
            // 
            this.cmbMonToTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonToTime.FormattingEnabled = true;
            this.cmbMonToTime.Location = new System.Drawing.Point(241, 85);
            this.cmbMonToTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMonToTime.Name = "cmbMonToTime";
            this.cmbMonToTime.Size = new System.Drawing.Size(99, 24);
            this.cmbMonToTime.TabIndex = 10;
            this.cmbMonToTime.SelectedIndexChanged += new System.EventHandler(this.cmbMonToTime_SelectedIndexChanged);
            // 
            // cmbMonFromTime
            // 
            this.cmbMonFromTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonFromTime.FormattingEnabled = true;
            this.cmbMonFromTime.Location = new System.Drawing.Point(127, 85);
            this.cmbMonFromTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMonFromTime.Name = "cmbMonFromTime";
            this.cmbMonFromTime.Size = new System.Drawing.Size(99, 24);
            this.cmbMonFromTime.TabIndex = 9;
            this.cmbMonFromTime.SelectedIndexChanged += new System.EventHandler(this.cmbMonFromTime_SelectedIndexChanged);
            // 
            // cmbSunToTime
            // 
            this.cmbSunToTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSunToTime.FormattingEnabled = true;
            this.cmbSunToTime.Location = new System.Drawing.Point(241, 53);
            this.cmbSunToTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSunToTime.Name = "cmbSunToTime";
            this.cmbSunToTime.Size = new System.Drawing.Size(99, 24);
            this.cmbSunToTime.TabIndex = 8;
            this.cmbSunToTime.SelectedIndexChanged += new System.EventHandler(this.cmbSunToTime_SelectedIndexChanged);
            // 
            // cmbSunFromTime
            // 
            this.cmbSunFromTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSunFromTime.FormattingEnabled = true;
            this.cmbSunFromTime.Location = new System.Drawing.Point(127, 53);
            this.cmbSunFromTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSunFromTime.Name = "cmbSunFromTime";
            this.cmbSunFromTime.Size = new System.Drawing.Size(99, 24);
            this.cmbSunFromTime.TabIndex = 7;
            this.cmbSunFromTime.SelectedIndexChanged += new System.EventHandler(this.cmbSunFromTime_SelectedIndexChanged);
            // 
            // lblSaturday
            // 
            this.lblSaturday.AutoSize = true;
            this.lblSaturday.Location = new System.Drawing.Point(28, 249);
            this.lblSaturday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(65, 17);
            this.lblSaturday.TabIndex = 6;
            this.lblSaturday.Text = "Saturday";
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.Location = new System.Drawing.Point(28, 217);
            this.lblFriday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(47, 17);
            this.lblFriday.TabIndex = 5;
            this.lblFriday.Text = "Friday";
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = true;
            this.lblThursday.Location = new System.Drawing.Point(28, 185);
            this.lblThursday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(68, 17);
            this.lblThursday.TabIndex = 4;
            this.lblThursday.Text = "Thursday";
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.Location = new System.Drawing.Point(28, 153);
            this.lblWednesday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(83, 17);
            this.lblWednesday.TabIndex = 3;
            this.lblWednesday.Text = "Wednesday";
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Location = new System.Drawing.Point(28, 121);
            this.lblTuesday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(63, 17);
            this.lblTuesday.TabIndex = 2;
            this.lblTuesday.Text = "Tuesday";
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Location = new System.Drawing.Point(28, 89);
            this.lblMonday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(58, 17);
            this.lblMonday.TabIndex = 1;
            this.lblMonday.Text = "Monday";
            // 
            // lblSunday
            // 
            this.lblSunday.AutoSize = true;
            this.lblSunday.Location = new System.Drawing.Point(28, 57);
            this.lblSunday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(56, 17);
            this.lblSunday.TabIndex = 0;
            this.lblSunday.Text = "Sunday";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(820, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(819, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to My Parental Control Software! This custom software allows me to automa" +
    "tically set/change time limits and application / website access for this compute" +
    "r only.";
            // 
            // grpbxAppAndWebAccess
            // 
            this.grpbxAppAndWebAccess.Location = new System.Drawing.Point(396, 142);
            this.grpbxAppAndWebAccess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxAppAndWebAccess.Name = "grpbxAppAndWebAccess";
            this.grpbxAppAndWebAccess.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxAppAndWebAccess.Size = new System.Drawing.Size(427, 380);
            this.grpbxAppAndWebAccess.TabIndex = 4;
            this.grpbxAppAndWebAccess.TabStop = false;
            this.grpbxAppAndWebAccess.Text = "User Application and Website Access Restrictions";
            this.grpbxAppAndWebAccess.Visible = false;
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(476, 75);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(100, 28);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(584, 75);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Select Computer:";
            // 
            // cmbComputerList
            // 
            this.cmbComputerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComputerList.FormattingEnabled = true;
            this.cmbComputerList.Location = new System.Drawing.Point(149, 60);
            this.cmbComputerList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbComputerList.Name = "cmbComputerList";
            this.cmbComputerList.Size = new System.Drawing.Size(263, 24);
            this.cmbComputerList.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainAppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbComputerList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.grpbxAppAndWebAccess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpbxTimeRestrictions);
            this.Controls.Add(this.lblSelectUser);
            this.Controls.Add(this.cmbUserList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ComboBox cmbThuToTime;
        private System.Windows.Forms.ComboBox cmbThuFromTime;
        private System.Windows.Forms.ComboBox cmbWedToTime;
        private System.Windows.Forms.ComboBox cmbWedFromTime;
        private System.Windows.Forms.ComboBox cmbTueToTime;
        private System.Windows.Forms.ComboBox cmbTueFromTime;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbComputerList;
        private System.Windows.Forms.Button button1;
    }
}

