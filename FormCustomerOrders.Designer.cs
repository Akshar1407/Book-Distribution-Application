namespace FINAL_PROJECT.GUI
{
    partial class FormCustomerOrders
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
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonListAllBooks = new System.Windows.Forms.Button();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEmployeeId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerShippingDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCustomerId = new System.Windows.Forms.ComboBox();
            this.comboBoxStatusId = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelShippingDate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.comboBoxSearchOption = new System.Windows.Forms.ComboBox();
            this.labelUserMessage = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelRequiredDate = new System.Windows.Forms.Label();
            this.textBoxOrderType = new System.Windows.Forms.TextBox();
            this.labelOrderType = new System.Windows.Forms.Label();
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.labelOrderId = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(43, 575);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(656, 133);
            this.listView.TabIndex = 42;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order Id";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Order Date";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Order Type";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "RequiredDate";
            this.columnHeader4.Width = 101;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ShippingDate";
            this.columnHeader5.Width = 104;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "StatusId";
            this.columnHeader6.Width = 66;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "CustomerId";
            this.columnHeader7.Width = 86;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "EmployeeId";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Payment";
            // 
            // buttonListAllBooks
            // 
            this.buttonListAllBooks.Location = new System.Drawing.Point(215, 523);
            this.buttonListAllBooks.Margin = new System.Windows.Forms.Padding(4);
            this.buttonListAllBooks.Name = "buttonListAllBooks";
            this.buttonListAllBooks.Size = new System.Drawing.Size(276, 35);
            this.buttonListAllBooks.TabIndex = 38;
            this.buttonListAllBooks.Text = "&List All Orders";
            this.buttonListAllBooks.UseVisualStyleBackColor = true;
            this.buttonListAllBooks.Click += new System.EventHandler(this.buttonListAllBooks_Click);
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Location = new System.Drawing.Point(136, 326);
            this.textBoxPayment.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(279, 22);
            this.textBoxPayment.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 329);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Payment";
            // 
            // comboBoxEmployeeId
            // 
            this.comboBoxEmployeeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployeeId.FormattingEnabled = true;
            this.comboBoxEmployeeId.Location = new System.Drawing.Point(136, 294);
            this.comboBoxEmployeeId.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEmployeeId.Name = "comboBoxEmployeeId";
            this.comboBoxEmployeeId.Size = new System.Drawing.Size(279, 24);
            this.comboBoxEmployeeId.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 294);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Employee Id";
            // 
            // dateTimePickerShippingDate
            // 
            this.dateTimePickerShippingDate.Location = new System.Drawing.Point(136, 183);
            this.dateTimePickerShippingDate.Name = "dateTimePickerShippingDate";
            this.dateTimePickerShippingDate.Size = new System.Drawing.Size(279, 22);
            this.dateTimePickerShippingDate.TabIndex = 31;
            // 
            // dateTimePickerRequiredDate
            // 
            this.dateTimePickerRequiredDate.Location = new System.Drawing.Point(136, 149);
            this.dateTimePickerRequiredDate.Name = "dateTimePickerRequiredDate";
            this.dateTimePickerRequiredDate.Size = new System.Drawing.Size(279, 22);
            this.dateTimePickerRequiredDate.TabIndex = 30;
            // 
            // dateTimePickerOrderDate
            // 
            this.dateTimePickerOrderDate.Location = new System.Drawing.Point(136, 73);
            this.dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            this.dateTimePickerOrderDate.Size = new System.Drawing.Size(279, 22);
            this.dateTimePickerOrderDate.TabIndex = 29;
            // 
            // comboBoxCustomerId
            // 
            this.comboBoxCustomerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomerId.FormattingEnabled = true;
            this.comboBoxCustomerId.Location = new System.Drawing.Point(136, 262);
            this.comboBoxCustomerId.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCustomerId.Name = "comboBoxCustomerId";
            this.comboBoxCustomerId.Size = new System.Drawing.Size(279, 24);
            this.comboBoxCustomerId.TabIndex = 28;
            // 
            // comboBoxStatusId
            // 
            this.comboBoxStatusId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatusId.FormattingEnabled = true;
            this.comboBoxStatusId.Location = new System.Drawing.Point(136, 217);
            this.comboBoxStatusId.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStatusId.Name = "comboBoxStatusId";
            this.comboBoxStatusId.Size = new System.Drawing.Size(279, 24);
            this.comboBoxStatusId.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 262);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Customer Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 222);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Status Id";
            // 
            // labelShippingDate
            // 
            this.labelShippingDate.AutoSize = true;
            this.labelShippingDate.Location = new System.Drawing.Point(20, 183);
            this.labelShippingDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShippingDate.Name = "labelShippingDate";
            this.labelShippingDate.Size = new System.Drawing.Size(92, 16);
            this.labelShippingDate.TabIndex = 12;
            this.labelShippingDate.Text = "Shipping Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxInput);
            this.groupBox2.Controls.Add(this.comboBoxSearchOption);
            this.groupBox2.Controls.Add(this.labelUserMessage);
            this.groupBox2.Location = new System.Drawing.Point(43, 403);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 100);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Orders";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(469, 38);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(137, 42);
            this.buttonSearch.TabIndex = 25;
            this.buttonSearch.Text = "Search &Order";
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
            "Order Id",
            "Order Type"});
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
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(621, 743);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(106, 36);
            this.buttonExit.TabIndex = 40;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPayment);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxEmployeeId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerShippingDate);
            this.groupBox1.Controls.Add(this.dateTimePickerRequiredDate);
            this.groupBox1.Controls.Add(this.dateTimePickerOrderDate);
            this.groupBox1.Controls.Add(this.comboBoxCustomerId);
            this.groupBox1.Controls.Add(this.comboBoxStatusId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.labelShippingDate);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.labelRequiredDate);
            this.groupBox1.Controls.Add(this.textBoxOrderType);
            this.groupBox1.Controls.Add(this.labelOrderType);
            this.groupBox1.Controls.Add(this.textBoxOrderId);
            this.groupBox1.Controls.Add(this.labelOrderDate);
            this.groupBox1.Controls.Add(this.labelOrderId);
            this.groupBox1.Location = new System.Drawing.Point(44, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(657, 373);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(441, 210);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(198, 36);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "&Delete Order";
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
            this.buttonUpdate.Text = "&Update Order";
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
            this.buttonSave.Text = "&Save Order";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelRequiredDate
            // 
            this.labelRequiredDate.AutoSize = true;
            this.labelRequiredDate.Location = new System.Drawing.Point(20, 149);
            this.labelRequiredDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRequiredDate.Name = "labelRequiredDate";
            this.labelRequiredDate.Size = new System.Drawing.Size(95, 16);
            this.labelRequiredDate.TabIndex = 6;
            this.labelRequiredDate.Text = "Required Date";
            // 
            // textBoxOrderType
            // 
            this.textBoxOrderType.Location = new System.Drawing.Point(136, 113);
            this.textBoxOrderType.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOrderType.Name = "textBoxOrderType";
            this.textBoxOrderType.Size = new System.Drawing.Size(279, 22);
            this.textBoxOrderType.TabIndex = 4;
            // 
            // labelOrderType
            // 
            this.labelOrderType.AutoSize = true;
            this.labelOrderType.Location = new System.Drawing.Point(18, 116);
            this.labelOrderType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrderType.Name = "labelOrderType";
            this.labelOrderType.Size = new System.Drawing.Size(76, 16);
            this.labelOrderType.TabIndex = 4;
            this.labelOrderType.Text = "Order Type";
            // 
            // textBoxOrderId
            // 
            this.textBoxOrderId.Location = new System.Drawing.Point(136, 36);
            this.textBoxOrderId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOrderId.Name = "textBoxOrderId";
            this.textBoxOrderId.Size = new System.Drawing.Size(279, 22);
            this.textBoxOrderId.TabIndex = 2;
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Location = new System.Drawing.Point(18, 73);
            this.labelOrderDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(73, 16);
            this.labelOrderDate.TabIndex = 1;
            this.labelOrderDate.Text = "Order Date";
            // 
            // labelOrderId
            // 
            this.labelOrderId.AutoSize = true;
            this.labelOrderId.Location = new System.Drawing.Point(20, 36);
            this.labelOrderId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrderId.Name = "labelOrderId";
            this.labelOrderId.Size = new System.Drawing.Size(55, 16);
            this.labelOrderId.TabIndex = 0;
            this.labelOrderId.Text = "Order Id";
            // 
            // FormCustomerOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 809);
            this.ControlBox = false;
            this.Controls.Add(this.listView);
            this.Controls.Add(this.buttonListAllBooks);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormCustomerOrders";
            this.Text = "FormCustomerOrders";
            this.Load += new System.EventHandler(this.FormCustomerOrders_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button buttonListAllBooks;
        private System.Windows.Forms.TextBox textBoxPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEmployeeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerShippingDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerRequiredDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderDate;
        private System.Windows.Forms.ComboBox comboBoxCustomerId;
        private System.Windows.Forms.ComboBox comboBoxStatusId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelShippingDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.ComboBox comboBoxSearchOption;
        private System.Windows.Forms.Label labelUserMessage;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelRequiredDate;
        private System.Windows.Forms.TextBox textBoxOrderType;
        private System.Windows.Forms.Label labelOrderType;
        private System.Windows.Forms.TextBox textBoxOrderId;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.Label labelOrderId;
    }
}