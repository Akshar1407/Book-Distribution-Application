namespace FINAL_PROJECT.GUI
{
    partial class FormMainMenu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonFormUser = new System.Windows.Forms.Button();
            this.buttonFormEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "What would you like to do?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(593, 422);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(101, 49);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonFormUser
            // 
            this.buttonFormUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFormUser.Location = new System.Drawing.Point(412, 188);
            this.buttonFormUser.Name = "buttonFormUser";
            this.buttonFormUser.Size = new System.Drawing.Size(273, 180);
            this.buttonFormUser.TabIndex = 8;
            this.buttonFormUser.Text = "Open &User Maintenance";
            this.buttonFormUser.UseVisualStyleBackColor = true;
            this.buttonFormUser.Click += new System.EventHandler(this.buttonFormUser_Click);
            // 
            // buttonFormEmployee
            // 
            this.buttonFormEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFormEmployee.Location = new System.Drawing.Point(64, 188);
            this.buttonFormEmployee.Name = "buttonFormEmployee";
            this.buttonFormEmployee.Size = new System.Drawing.Size(272, 180);
            this.buttonFormEmployee.TabIndex = 7;
            this.buttonFormEmployee.Text = "Open &Employee Maintenance";
            this.buttonFormEmployee.UseVisualStyleBackColor = true;
            this.buttonFormEmployee.Click += new System.EventHandler(this.buttonFormEmployee_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 535);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonFormUser);
            this.Controls.Add(this.buttonFormEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonFormUser;
        private System.Windows.Forms.Button buttonFormEmployee;
    }
}