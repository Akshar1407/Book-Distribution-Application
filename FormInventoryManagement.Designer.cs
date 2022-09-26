namespace FINAL_PROJECT.GUI
{
    partial class FormInventoryManagement
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
            this.label9 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonListAllBooks = new System.Windows.Forms.Button();
            this.comboBoxPublisherId = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoryId = new System.Windows.Forms.ComboBox();
            this.textBoxYearPublished = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxQOH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTItle = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.comboBoxSearchOption = new System.Windows.Forms.ComboBox();
            this.labelUserMessage = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 222);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "CategoryId";
            // 
            // listView
            // 
            this.listView.AutoArrange = false;
            this.listView.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(61, 502);
            this.listView.Margin = new System.Windows.Forms.Padding(4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(656, 142);
            this.listView.TabIndex = 37;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ISBN";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unti Price";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Year Published";
            this.columnHeader4.Width = 118;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "QOH";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Category Name";
            this.columnHeader6.Width = 83;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Publisher Name";
            this.columnHeader7.Width = 81;
            // 
            // buttonListAllBooks
            // 
            this.buttonListAllBooks.Location = new System.Drawing.Point(231, 454);
            this.buttonListAllBooks.Margin = new System.Windows.Forms.Padding(4);
            this.buttonListAllBooks.Name = "buttonListAllBooks";
            this.buttonListAllBooks.Size = new System.Drawing.Size(276, 35);
            this.buttonListAllBooks.TabIndex = 33;
            this.buttonListAllBooks.Text = "&List All Inventory Books";
            this.buttonListAllBooks.UseVisualStyleBackColor = true;
            this.buttonListAllBooks.Click += new System.EventHandler(this.buttonListAllBooks_Click);
            // 
            // comboBoxPublisherId
            // 
            this.comboBoxPublisherId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPublisherId.FormattingEnabled = true;
            this.comboBoxPublisherId.Location = new System.Drawing.Point(136, 262);
            this.comboBoxPublisherId.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPublisherId.Name = "comboBoxPublisherId";
            this.comboBoxPublisherId.Size = new System.Drawing.Size(279, 24);
            this.comboBoxPublisherId.TabIndex = 28;
            // 
            // comboBoxCategoryId
            // 
            this.comboBoxCategoryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoryId.FormattingEnabled = true;
            this.comboBoxCategoryId.Location = new System.Drawing.Point(136, 217);
            this.comboBoxCategoryId.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCategoryId.Name = "comboBoxCategoryId";
            this.comboBoxCategoryId.Size = new System.Drawing.Size(279, 24);
            this.comboBoxCategoryId.TabIndex = 27;
            // 
            // textBoxYearPublished
            // 
            this.textBoxYearPublished.Location = new System.Drawing.Point(136, 151);
            this.textBoxYearPublished.Mask = "0000";
            this.textBoxYearPublished.Name = "textBoxYearPublished";
            this.textBoxYearPublished.Size = new System.Drawing.Size(279, 22);
            this.textBoxYearPublished.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 262);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "PublisherId";
            // 
            // textBoxQOH
            // 
            this.textBoxQOH.Location = new System.Drawing.Point(136, 180);
            this.textBoxQOH.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQOH.Name = "textBoxQOH";
            this.textBoxQOH.Size = new System.Drawing.Size(279, 22);
            this.textBoxQOH.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "QOH";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(441, 210);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(198, 36);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "&Delete Inventory";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(441, 146);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(198, 36);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "&Update Inventory";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(441, 84);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(198, 36);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "&Save Inventory";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Year Published";
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(136, 113);
            this.textBoxUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(279, 22);
            this.textBoxUnitPrice.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unit Price";
            // 
            // textBoxTItle
            // 
            this.textBoxTItle.Location = new System.Drawing.Point(136, 70);
            this.textBoxTItle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTItle.Name = "textBoxTItle";
            this.textBoxTItle.Size = new System.Drawing.Size(279, 22);
            this.textBoxTItle.TabIndex = 3;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(637, 674);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(106, 36);
            this.buttonExit.TabIndex = 35;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(136, 36);
            this.textBoxISBN.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(279, 22);
            this.textBoxISBN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(469, 38);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(137, 42);
            this.buttonSearch.TabIndex = 25;
            this.buttonSearch.Text = "Search &Inventory";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Search By:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(283, 55);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(156, 22);
            this.textBoxInput.TabIndex = 20;
            // 
            // comboBoxSearchOption
            // 
            this.comboBoxSearchOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchOption.FormattingEnabled = true;
            this.comboBoxSearchOption.Items.AddRange(new object[] {
            "ISBN ID",
            "Title"});
            this.comboBoxSearchOption.Location = new System.Drawing.Point(99, 54);
            this.comboBoxSearchOption.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSearchOption.Name = "comboBoxSearchOption";
            this.comboBoxSearchOption.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSearchOption.TabIndex = 23;
            // 
            // labelUserMessage
            // 
            this.labelUserMessage.AutoSize = true;
            this.labelUserMessage.Location = new System.Drawing.Point(279, 35);
            this.labelUserMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserMessage.Name = "labelUserMessage";
            this.labelUserMessage.Size = new System.Drawing.Size(64, 16);
            this.labelUserMessage.TabIndex = 24;
            this.labelUserMessage.Text = "Message";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxInput);
            this.groupBox2.Controls.Add(this.comboBoxSearchOption);
            this.groupBox2.Controls.Add(this.labelUserMessage);
            this.groupBox2.Location = new System.Drawing.Point(59, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 100);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Inventory";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxPublisherId);
            this.groupBox1.Controls.Add(this.comboBoxCategoryId);
            this.groupBox1.Controls.Add(this.textBoxYearPublished);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxQOH);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxUnitPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxTItle);
            this.groupBox1.Controls.Add(this.textBoxISBN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(58, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(657, 307);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventaory Information";
            // 
            // FormInventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 761);
            this.ControlBox = false;
            this.Controls.Add(this.listView);
            this.Controls.Add(this.buttonListAllBooks);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormInventoryManagement";
            this.Text = "FormInventoryManagement";
            this.Load += new System.EventHandler(this.FormInventoryManagement_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button buttonListAllBooks;
        private System.Windows.Forms.ComboBox comboBoxPublisherId;
        private System.Windows.Forms.ComboBox comboBoxCategoryId;
        private System.Windows.Forms.MaskedTextBox textBoxYearPublished;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxQOH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTItle;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.ComboBox comboBoxSearchOption;
        private System.Windows.Forms.Label labelUserMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}