namespace ContactBook
{
    partial class SettingsDialog
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpVisibility = new System.Windows.Forms.TabPage();
            this.tpOutput = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk1 = new System.Windows.Forms.Button();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.btnApply1 = new System.Windows.Forms.Button();
            this.cbxContactID = new System.Windows.Forms.CheckBox();
            this.cbxFirstName = new System.Windows.Forms.CheckBox();
            this.cbxLastName = new System.Windows.Forms.CheckBox();
            this.cbxStreet = new System.Windows.Forms.CheckBox();
            this.cbxCity = new System.Windows.Forms.CheckBox();
            this.cbxProvince = new System.Windows.Forms.CheckBox();
            this.cbxPostalCode = new System.Windows.Forms.CheckBox();
            this.cbxPhone = new System.Windows.Forms.CheckBox();
            this.cbxEmail = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpVisibility.SuspendLayout();
            this.tpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpVisibility);
            this.tabControl1.Controls.Add(this.tpOutput);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(431, 434);
            this.tabControl1.TabIndex = 0;
            // 
            // tpVisibility
            // 
            this.tpVisibility.Controls.Add(this.label2);
            this.tpVisibility.Controls.Add(this.cbxEmail);
            this.tpVisibility.Controls.Add(this.cbxPhone);
            this.tpVisibility.Controls.Add(this.cbxPostalCode);
            this.tpVisibility.Controls.Add(this.cbxProvince);
            this.tpVisibility.Controls.Add(this.cbxCity);
            this.tpVisibility.Controls.Add(this.cbxStreet);
            this.tpVisibility.Controls.Add(this.cbxLastName);
            this.tpVisibility.Controls.Add(this.cbxFirstName);
            this.tpVisibility.Controls.Add(this.cbxContactID);
            this.tpVisibility.Controls.Add(this.btnApply1);
            this.tpVisibility.Controls.Add(this.btnCancel1);
            this.tpVisibility.Controls.Add(this.btnOk1);
            this.tpVisibility.Location = new System.Drawing.Point(4, 22);
            this.tpVisibility.Name = "tpVisibility";
            this.tpVisibility.Padding = new System.Windows.Forms.Padding(3);
            this.tpVisibility.Size = new System.Drawing.Size(423, 408);
            this.tpVisibility.TabIndex = 0;
            this.tpVisibility.Text = "Default Visibility";
            this.tpVisibility.UseVisualStyleBackColor = true;
            // 
            // tpOutput
            // 
            this.tpOutput.Controls.Add(this.label1);
            this.tpOutput.Location = new System.Drawing.Point(4, 22);
            this.tpOutput.Name = "tpOutput";
            this.tpOutput.Padding = new System.Windows.Forms.Padding(3);
            this.tpOutput.Size = new System.Drawing.Size(332, 236);
            this.tpOutput.TabIndex = 1;
            this.tpOutput.Text = "Output";
            this.tpOutput.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Not yet implemented";
            // 
            // btnOk1
            // 
            this.btnOk1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk1.Location = new System.Drawing.Point(340, 377);
            this.btnOk1.Name = "btnOk1";
            this.btnOk1.Size = new System.Drawing.Size(75, 23);
            this.btnOk1.TabIndex = 0;
            this.btnOk1.Text = "Ok";
            this.btnOk1.UseVisualStyleBackColor = true;
            this.btnOk1.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel1
            // 
            this.btnCancel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel1.Location = new System.Drawing.Point(259, 377);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(75, 23);
            this.btnCancel1.TabIndex = 1;
            this.btnCancel1.Text = "Cancel";
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply1
            // 
            this.btnApply1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply1.Location = new System.Drawing.Point(178, 377);
            this.btnApply1.Name = "btnApply1";
            this.btnApply1.Size = new System.Drawing.Size(75, 23);
            this.btnApply1.TabIndex = 2;
            this.btnApply1.Text = "Apply";
            this.btnApply1.UseVisualStyleBackColor = true;
            this.btnApply1.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // cbxContactID
            // 
            this.cbxContactID.AutoSize = true;
            this.cbxContactID.Location = new System.Drawing.Point(8, 19);
            this.cbxContactID.Name = "cbxContactID";
            this.cbxContactID.Size = new System.Drawing.Size(75, 17);
            this.cbxContactID.TabIndex = 3;
            this.cbxContactID.Text = "Contact Id";
            this.cbxContactID.UseVisualStyleBackColor = true;
            // 
            // cbxFirstName
            // 
            this.cbxFirstName.AutoSize = true;
            this.cbxFirstName.Location = new System.Drawing.Point(8, 42);
            this.cbxFirstName.Name = "cbxFirstName";
            this.cbxFirstName.Size = new System.Drawing.Size(76, 17);
            this.cbxFirstName.TabIndex = 4;
            this.cbxFirstName.Text = "First Name";
            this.cbxFirstName.UseVisualStyleBackColor = true;
            // 
            // cbxLastName
            // 
            this.cbxLastName.AutoSize = true;
            this.cbxLastName.Location = new System.Drawing.Point(8, 65);
            this.cbxLastName.Name = "cbxLastName";
            this.cbxLastName.Size = new System.Drawing.Size(77, 17);
            this.cbxLastName.TabIndex = 5;
            this.cbxLastName.Text = "Last Name";
            this.cbxLastName.UseVisualStyleBackColor = true;
            // 
            // cbxStreet
            // 
            this.cbxStreet.AutoSize = true;
            this.cbxStreet.Location = new System.Drawing.Point(8, 88);
            this.cbxStreet.Name = "cbxStreet";
            this.cbxStreet.Size = new System.Drawing.Size(54, 17);
            this.cbxStreet.TabIndex = 6;
            this.cbxStreet.Text = "Street";
            this.cbxStreet.UseVisualStyleBackColor = true;
            // 
            // cbxCity
            // 
            this.cbxCity.AutoSize = true;
            this.cbxCity.Location = new System.Drawing.Point(8, 111);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(43, 17);
            this.cbxCity.TabIndex = 7;
            this.cbxCity.Text = "City";
            this.cbxCity.UseVisualStyleBackColor = true;
            // 
            // cbxProvince
            // 
            this.cbxProvince.AutoSize = true;
            this.cbxProvince.Location = new System.Drawing.Point(8, 134);
            this.cbxProvince.Name = "cbxProvince";
            this.cbxProvince.Size = new System.Drawing.Size(68, 17);
            this.cbxProvince.TabIndex = 8;
            this.cbxProvince.Text = "Province";
            this.cbxProvince.UseVisualStyleBackColor = true;
            // 
            // cbxPostalCode
            // 
            this.cbxPostalCode.AutoSize = true;
            this.cbxPostalCode.Location = new System.Drawing.Point(8, 157);
            this.cbxPostalCode.Name = "cbxPostalCode";
            this.cbxPostalCode.Size = new System.Drawing.Size(83, 17);
            this.cbxPostalCode.TabIndex = 9;
            this.cbxPostalCode.Text = "Postal Code";
            this.cbxPostalCode.UseVisualStyleBackColor = true;
            // 
            // cbxPhone
            // 
            this.cbxPhone.AutoSize = true;
            this.cbxPhone.Location = new System.Drawing.Point(8, 180);
            this.cbxPhone.Name = "cbxPhone";
            this.cbxPhone.Size = new System.Drawing.Size(57, 17);
            this.cbxPhone.TabIndex = 10;
            this.cbxPhone.Text = "Phone";
            this.cbxPhone.UseVisualStyleBackColor = true;
            // 
            // cbxEmail
            // 
            this.cbxEmail.AutoSize = true;
            this.cbxEmail.Location = new System.Drawing.Point(8, 203);
            this.cbxEmail.Name = "cbxEmail";
            this.cbxEmail.Size = new System.Drawing.Size(51, 17);
            this.cbxEmail.TabIndex = 11;
            this.cbxEmail.Text = "Email";
            this.cbxEmail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select which columns are to be visible by default";
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 434);
            this.Controls.Add(this.tabControl1);
            this.Name = "SettingsDialog";
            this.Text = "SettingsDialog";
            this.tabControl1.ResumeLayout(false);
            this.tpVisibility.ResumeLayout(false);
            this.tpVisibility.PerformLayout();
            this.tpOutput.ResumeLayout(false);
            this.tpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpVisibility;
        private System.Windows.Forms.TabPage tpOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApply1;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnOk1;
        private System.Windows.Forms.CheckBox cbxFirstName;
        private System.Windows.Forms.CheckBox cbxContactID;
        private System.Windows.Forms.CheckBox cbxEmail;
        private System.Windows.Forms.CheckBox cbxPhone;
        private System.Windows.Forms.CheckBox cbxPostalCode;
        private System.Windows.Forms.CheckBox cbxProvince;
        private System.Windows.Forms.CheckBox cbxCity;
        private System.Windows.Forms.CheckBox cbxStreet;
        private System.Windows.Forms.CheckBox cbxLastName;
        private System.Windows.Forms.Label label2;
    }
}