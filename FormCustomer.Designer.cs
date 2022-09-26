namespace FINAL_PROJECT.GUI
{
    partial class FormCustomer
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonListCustomerFromDB = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonUpdateDatabase = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridViewCustomerFromDS = new System.Windows.Forms.DataGridView();
            this.dataGridViewCustomerFromDB = new System.Windows.Forms.DataGridView();
            this.buttonCustomerList = new System.Windows.Forms.Button();
            this.textBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCreditLimit = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFaxNumber = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxCustomerEmail = new System.Windows.Forms.TextBox();
            this.textBoxStreetAddress = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerFromDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerFromDB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(118, 27);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(375, 22);
            this.textBoxSearch.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 42;
            this.label11.Text = "Customer ID";
            // 
            // buttonListCustomerFromDB
            // 
            this.buttonListCustomerFromDB.Location = new System.Drawing.Point(129, 413);
            this.buttonListCustomerFromDB.Name = "buttonListCustomerFromDB";
            this.buttonListCustomerFromDB.Size = new System.Drawing.Size(250, 44);
            this.buttonListCustomerFromDB.TabIndex = 46;
            this.buttonListCustomerFromDB.Text = "&List Customer From DB";
            this.buttonListCustomerFromDB.UseVisualStyleBackColor = true;
            this.buttonListCustomerFromDB.Click += new System.EventHandler(this.buttonListCustomerFromDB_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(183, 132);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(141, 53);
            this.buttonSearch.TabIndex = 37;
            this.buttonSearch.Text = "&Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.buttonUpdateDatabase);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Location = new System.Drawing.Point(771, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 384);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search & Update";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "(4-digit)";
            // 
            // buttonUpdateDatabase
            // 
            this.buttonUpdateDatabase.Location = new System.Drawing.Point(183, 258);
            this.buttonUpdateDatabase.Name = "buttonUpdateDatabase";
            this.buttonUpdateDatabase.Size = new System.Drawing.Size(141, 63);
            this.buttonUpdateDatabase.TabIndex = 31;
            this.buttonUpdateDatabase.Text = "&Update Database";
            this.buttonUpdateDatabase.UseVisualStyleBackColor = true;
            this.buttonUpdateDatabase.Click += new System.EventHandler(this.buttonUpdateDatabase_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(1253, 701);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(159, 67);
            this.buttonClose.TabIndex = 50;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridViewCustomerFromDS
            // 
            this.dataGridViewCustomerFromDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerFromDS.Location = new System.Drawing.Point(748, 463);
            this.dataGridViewCustomerFromDS.Name = "dataGridViewCustomerFromDS";
            this.dataGridViewCustomerFromDS.RowHeadersWidth = 51;
            this.dataGridViewCustomerFromDS.RowTemplate.Height = 24;
            this.dataGridViewCustomerFromDS.Size = new System.Drawing.Size(556, 183);
            this.dataGridViewCustomerFromDS.TabIndex = 49;
            // 
            // dataGridViewCustomerFromDB
            // 
            this.dataGridViewCustomerFromDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerFromDB.Location = new System.Drawing.Point(22, 463);
            this.dataGridViewCustomerFromDB.Name = "dataGridViewCustomerFromDB";
            this.dataGridViewCustomerFromDB.RowHeadersWidth = 51;
            this.dataGridViewCustomerFromDB.RowTemplate.Height = 24;
            this.dataGridViewCustomerFromDB.Size = new System.Drawing.Size(556, 183);
            this.dataGridViewCustomerFromDB.TabIndex = 48;
            // 
            // buttonCustomerList
            // 
            this.buttonCustomerList.Location = new System.Drawing.Point(912, 413);
            this.buttonCustomerList.Name = "buttonCustomerList";
            this.buttonCustomerList.Size = new System.Drawing.Size(250, 44);
            this.buttonCustomerList.TabIndex = 47;
            this.buttonCustomerList.Text = "Customer List From DataSet";
            this.buttonCustomerList.UseVisualStyleBackColor = true;
            this.buttonCustomerList.Click += new System.EventHandler(this.buttonCustomerList_Click);
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(135, 228);
            this.textBoxPhoneNumber.Mask = "(999) 000-0000";
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(375, 22);
            this.textBoxPhoneNumber.TabIndex = 46;
            // 
            // textBoxCreditLimit
            // 
            this.textBoxCreditLimit.Location = new System.Drawing.Point(135, 306);
            this.textBoxCreditLimit.Name = "textBoxCreditLimit";
            this.textBoxCreditLimit.Size = new System.Drawing.Size(375, 22);
            this.textBoxCreditLimit.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPhoneNumber);
            this.groupBox1.Controls.Add(this.textBoxCreditLimit);
            this.groupBox1.Controls.Add(this.textBoxFaxNumber);
            this.groupBox1.Controls.Add(this.textBoxCity);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxPostalCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonModify);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBoxCustomerEmail);
            this.groupBox1.Controls.Add(this.textBoxStreetAddress);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 388);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // textBoxFaxNumber
            // 
            this.textBoxFaxNumber.Location = new System.Drawing.Point(135, 272);
            this.textBoxFaxNumber.Name = "textBoxFaxNumber";
            this.textBoxFaxNumber.Size = new System.Drawing.Size(375, 22);
            this.textBoxFaxNumber.TabIndex = 44;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(135, 151);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(375, 22);
            this.textBoxCity.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "CreditLimit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "FaxNumber";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "PhoneNumber";
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(135, 187);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(375, 22);
            this.textBoxPostalCode.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "PostalCode";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(571, 285);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(127, 53);
            this.buttonDelete.TabIndex = 30;
            this.buttonDelete.Text = "D&elete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(571, 156);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(127, 50);
            this.buttonModify.TabIndex = 29;
            this.buttonModify.Text = "&Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(571, 53);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(127, 53);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "&Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxCustomerEmail
            // 
            this.textBoxCustomerEmail.Location = new System.Drawing.Point(135, 344);
            this.textBoxCustomerEmail.Name = "textBoxCustomerEmail";
            this.textBoxCustomerEmail.Size = new System.Drawing.Size(375, 22);
            this.textBoxCustomerEmail.TabIndex = 25;
            // 
            // textBoxStreetAddress
            // 
            this.textBoxStreetAddress.Location = new System.Drawing.Point(135, 116);
            this.textBoxStreetAddress.Name = "textBoxStreetAddress";
            this.textBoxStreetAddress.Size = new System.Drawing.Size(375, 22);
            this.textBoxStreetAddress.TabIndex = 24;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(135, 71);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(375, 22);
            this.textBoxName.TabIndex = 23;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(135, 28);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(375, 22);
            this.textBoxId.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "StreetAdress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "CustomerName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Customer ID";
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 813);
            this.ControlBox = false;
            this.Controls.Add(this.buttonListCustomerFromDB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridViewCustomerFromDS);
            this.Controls.Add(this.dataGridViewCustomerFromDB);
            this.Controls.Add(this.buttonCustomerList);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerFromDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerFromDB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonListCustomerFromDB;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonUpdateDatabase;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridViewCustomerFromDS;
        private System.Windows.Forms.DataGridView dataGridViewCustomerFromDB;
        private System.Windows.Forms.Button buttonCustomerList;
        private System.Windows.Forms.MaskedTextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxCreditLimit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxFaxNumber;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxCustomerEmail;
        private System.Windows.Forms.TextBox textBoxStreetAddress;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}