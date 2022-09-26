namespace FINAL_PROJECT.GUI
{
    partial class FormUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSearchUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxInputUser = new System.Windows.Forms.TextBox();
            this.comboBoxUserSearchOption = new System.Windows.Forms.ComboBox();
            this.labelUserMessage = new System.Windows.Forms.Label();
            this.listViewUser = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExitUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonUpdateUser = new System.Windows.Forms.Button();
            this.buttonSaveUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonListAllUser = new System.Windows.Forms.Button();
            this.comboBoxEmployeeId = new System.Windows.Forms.ComboBox();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSearchUser);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxInputUser);
            this.groupBox1.Controls.Add(this.comboBoxUserSearchOption);
            this.groupBox1.Controls.Add(this.labelUserMessage);
            this.groupBox1.Location = new System.Drawing.Point(26, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 100);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search User";
            // 
            // buttonSearchUser
            // 
            this.buttonSearchUser.Location = new System.Drawing.Point(463, 40);
            this.buttonSearchUser.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchUser.Name = "buttonSearchUser";
            this.buttonSearchUser.Size = new System.Drawing.Size(137, 42);
            this.buttonSearchUser.TabIndex = 33;
            this.buttonSearchUser.Text = "Search &User";
            this.buttonSearchUser.UseVisualStyleBackColor = true;
            this.buttonSearchUser.Click += new System.EventHandler(this.buttonSearchUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Search By:";
            // 
            // textBoxInputUser
            // 
            this.textBoxInputUser.Location = new System.Drawing.Point(277, 57);
            this.textBoxInputUser.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInputUser.Name = "textBoxInputUser";
            this.textBoxInputUser.Size = new System.Drawing.Size(156, 22);
            this.textBoxInputUser.TabIndex = 28;
            // 
            // comboBoxUserSearchOption
            // 
            this.comboBoxUserSearchOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserSearchOption.FormattingEnabled = true;
            this.comboBoxUserSearchOption.Items.AddRange(new object[] {
            "User ID",
            "Employee ID"});
            this.comboBoxUserSearchOption.Location = new System.Drawing.Point(93, 56);
            this.comboBoxUserSearchOption.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUserSearchOption.Name = "comboBoxUserSearchOption";
            this.comboBoxUserSearchOption.Size = new System.Drawing.Size(160, 24);
            this.comboBoxUserSearchOption.TabIndex = 31;
            this.comboBoxUserSearchOption.SelectedIndexChanged += new System.EventHandler(this.comboBoxUserSearchOption_SelectedIndexChanged);
            // 
            // labelUserMessage
            // 
            this.labelUserMessage.AutoSize = true;
            this.labelUserMessage.Location = new System.Drawing.Point(273, 37);
            this.labelUserMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserMessage.Name = "labelUserMessage";
            this.labelUserMessage.Size = new System.Drawing.Size(64, 16);
            this.labelUserMessage.TabIndex = 32;
            this.labelUserMessage.Text = "Message";
            // 
            // listViewUser
            // 
            this.listViewUser.AutoArrange = false;
            this.listViewUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewUser.GridLines = true;
            this.listViewUser.HideSelection = false;
            this.listViewUser.Location = new System.Drawing.Point(26, 366);
            this.listViewUser.Margin = new System.Windows.Forms.Padding(4);
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.Size = new System.Drawing.Size(656, 142);
            this.listViewUser.TabIndex = 37;
            this.listViewUser.UseCompatibleStateImageBehavior = false;
            this.listViewUser.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "User ID";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Employee ID";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "First Name";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Last Name";
            this.columnHeader5.Width = 136;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(141, 84);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(258, 22);
            this.textBoxPassword.TabIndex = 3;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(141, 36);
            this.textBoxUserId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(327, 22);
            this.textBoxUserId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // buttonExitUser
            // 
            this.buttonExitUser.Location = new System.Drawing.Point(579, 516);
            this.buttonExitUser.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExitUser.Name = "buttonExitUser";
            this.buttonExitUser.Size = new System.Drawing.Size(127, 44);
            this.buttonExitUser.TabIndex = 38;
            this.buttonExitUser.Text = "E&xit";
            this.buttonExitUser.UseVisualStyleBackColor = true;
            this.buttonExitUser.Click += new System.EventHandler(this.buttonExitUser_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(488, 120);
            this.buttonDeleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(139, 36);
            this.buttonDeleteUser.TabIndex = 10;
            this.buttonDeleteUser.Text = "&Delete User";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonUpdateUser
            // 
            this.buttonUpdateUser.Location = new System.Drawing.Point(488, 77);
            this.buttonUpdateUser.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateUser.Name = "buttonUpdateUser";
            this.buttonUpdateUser.Size = new System.Drawing.Size(139, 36);
            this.buttonUpdateUser.TabIndex = 9;
            this.buttonUpdateUser.Text = "&Update User";
            this.buttonUpdateUser.UseVisualStyleBackColor = true;
            this.buttonUpdateUser.Click += new System.EventHandler(this.buttonUpdateUser_Click);
            // 
            // buttonSaveUser
            // 
            this.buttonSaveUser.Location = new System.Drawing.Point(488, 31);
            this.buttonSaveUser.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveUser.Name = "buttonSaveUser";
            this.buttonSaveUser.Size = new System.Drawing.Size(139, 36);
            this.buttonSaveUser.TabIndex = 8;
            this.buttonSaveUser.Text = "&Save User";
            this.buttonSaveUser.UseVisualStyleBackColor = true;
            this.buttonSaveUser.Click += new System.EventHandler(this.buttonSaveUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "EmployeeId";
            // 
            // buttonListAllUser
            // 
            this.buttonListAllUser.Location = new System.Drawing.Point(200, 322);
            this.buttonListAllUser.Margin = new System.Windows.Forms.Padding(4);
            this.buttonListAllUser.Name = "buttonListAllUser";
            this.buttonListAllUser.Size = new System.Drawing.Size(294, 36);
            this.buttonListAllUser.TabIndex = 35;
            this.buttonListAllUser.Text = "&List All User";
            this.buttonListAllUser.UseVisualStyleBackColor = true;
            this.buttonListAllUser.Click += new System.EventHandler(this.buttonListAllUser_Click);
            // 
            // comboBoxEmployeeId
            // 
            this.comboBoxEmployeeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployeeId.FormattingEnabled = true;
            this.comboBoxEmployeeId.Location = new System.Drawing.Point(138, 127);
            this.comboBoxEmployeeId.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEmployeeId.Name = "comboBoxEmployeeId";
            this.comboBoxEmployeeId.Size = new System.Drawing.Size(330, 24);
            this.comboBoxEmployeeId.TabIndex = 34;
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.checkBox1);
            this.groupBoxUser.Controls.Add(this.comboBoxEmployeeId);
            this.groupBoxUser.Controls.Add(this.buttonDeleteUser);
            this.groupBoxUser.Controls.Add(this.buttonUpdateUser);
            this.groupBoxUser.Controls.Add(this.buttonSaveUser);
            this.groupBoxUser.Controls.Add(this.label3);
            this.groupBoxUser.Controls.Add(this.textBoxPassword);
            this.groupBoxUser.Controls.Add(this.textBoxUserId);
            this.groupBoxUser.Controls.Add(this.label2);
            this.groupBoxUser.Controls.Add(this.label1);
            this.groupBoxUser.Location = new System.Drawing.Point(26, 27);
            this.groupBoxUser.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxUser.Size = new System.Drawing.Size(657, 172);
            this.groupBoxUser.TabIndex = 36;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "User Information";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(406, 87);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 20);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 623);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewUser);
            this.Controls.Add(this.buttonExitUser);
            this.Controls.Add(this.buttonListAllUser);
            this.Controls.Add(this.groupBoxUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearchUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxInputUser;
        private System.Windows.Forms.ComboBox comboBoxUserSearchOption;
        private System.Windows.Forms.Label labelUserMessage;
        private System.Windows.Forms.ListView listViewUser;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExitUser;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonUpdateUser;
        private System.Windows.Forms.Button buttonSaveUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonListAllUser;
        private System.Windows.Forms.ComboBox comboBoxEmployeeId;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}