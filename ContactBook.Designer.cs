namespace ContactBook
{
    partial class ContactBook
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactBook));
            this.cmsTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.contactIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provinceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postalCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.oddAdditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpDataBound = new System.Windows.Forms.TabPage();
            this.toolStripAlt = new System.Windows.Forms.ToolStrip();
            this.tsbAddAlt = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteAlt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefreshAlt = new System.Windows.Forms.ToolStripButton();
            this.tsbSettingsAlt = new System.Windows.Forms.ToolStripButton();
            this.dgvTableAlt = new System.Windows.Forms.DataGridView();
            this.tpContactList = new System.Windows.Forms.TabPage();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tsbAddMain = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdateMain = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteMain = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefreshMain = new System.Windows.Forms.ToolStripButton();
            this.tsbSettingsMain = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnDataBindRemarks = new System.Windows.Forms.Button();
            this.cmsTable.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tpDataBound.SuspendLayout();
            this.toolStripAlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAlt)).BeginInit();
            this.tpContactList.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsTable
            // 
            this.cmsTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAdd,
            this.cmsUpdate,
            this.cmsDelete});
            this.cmsTable.Name = "cmsTable";
            this.cmsTable.Size = new System.Drawing.Size(113, 70);
            // 
            // cmsAdd
            // 
            this.cmsAdd.Name = "cmsAdd";
            this.cmsAdd.Size = new System.Drawing.Size(112, 22);
            this.cmsAdd.Text = "Add";
            this.cmsAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // cmsUpdate
            // 
            this.cmsUpdate.Name = "cmsUpdate";
            this.cmsUpdate.Size = new System.Drawing.Size(112, 22);
            this.cmsUpdate.Text = "Update";
            this.cmsUpdate.Click += new System.EventHandler(this.Update_Click);
            // 
            // cmsDelete
            // 
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(112, 22);
            this.cmsDelete.Text = "Delete";
            this.cmsDelete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator3,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.Add_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.Update_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.Delete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(167, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.toolStripSeparator4,
            this.contactIdToolStripMenuItem,
            this.firstNameToolStripMenuItem,
            this.lastNameToolStripMenuItem,
            this.streetToolStripMenuItem,
            this.cityToolStripMenuItem,
            this.provinceToolStripMenuItem,
            this.postalCodeToolStripMenuItem,
            this.phoneNumberToolStripMenuItem,
            this.emailAddressToolStripMenuItem,
            this.toolStripSeparator5,
            this.oddAdditionToolStripMenuItem,
            this.toolStripTextBox2});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(157, 6);
            // 
            // contactIdToolStripMenuItem
            // 
            this.contactIdToolStripMenuItem.CheckOnClick = true;
            this.contactIdToolStripMenuItem.Name = "contactIdToolStripMenuItem";
            this.contactIdToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.contactIdToolStripMenuItem.Text = "Contact Id";
            this.contactIdToolStripMenuItem.Click += new System.EventHandler(this.contactIdToolStripMenuItem_Click);
            // 
            // firstNameToolStripMenuItem
            // 
            this.firstNameToolStripMenuItem.Checked = true;
            this.firstNameToolStripMenuItem.CheckOnClick = true;
            this.firstNameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.firstNameToolStripMenuItem.Name = "firstNameToolStripMenuItem";
            this.firstNameToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.firstNameToolStripMenuItem.Text = "First Name";
            this.firstNameToolStripMenuItem.Click += new System.EventHandler(this.firstNameToolStripMenuItem_Click);
            // 
            // lastNameToolStripMenuItem
            // 
            this.lastNameToolStripMenuItem.Checked = true;
            this.lastNameToolStripMenuItem.CheckOnClick = true;
            this.lastNameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lastNameToolStripMenuItem.Name = "lastNameToolStripMenuItem";
            this.lastNameToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.lastNameToolStripMenuItem.Text = "Last Name";
            this.lastNameToolStripMenuItem.Click += new System.EventHandler(this.lastNameToolStripMenuItem_Click);
            // 
            // streetToolStripMenuItem
            // 
            this.streetToolStripMenuItem.Checked = true;
            this.streetToolStripMenuItem.CheckOnClick = true;
            this.streetToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.streetToolStripMenuItem.Name = "streetToolStripMenuItem";
            this.streetToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.streetToolStripMenuItem.Text = "Street";
            this.streetToolStripMenuItem.Click += new System.EventHandler(this.streetToolStripMenuItem_Click);
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Checked = true;
            this.cityToolStripMenuItem.CheckOnClick = true;
            this.cityToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.cityToolStripMenuItem.Text = "City";
            this.cityToolStripMenuItem.Click += new System.EventHandler(this.cityToolStripMenuItem_Click);
            // 
            // provinceToolStripMenuItem
            // 
            this.provinceToolStripMenuItem.Checked = true;
            this.provinceToolStripMenuItem.CheckOnClick = true;
            this.provinceToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.provinceToolStripMenuItem.Name = "provinceToolStripMenuItem";
            this.provinceToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.provinceToolStripMenuItem.Text = "Province";
            this.provinceToolStripMenuItem.Click += new System.EventHandler(this.provinceToolStripMenuItem_Click);
            // 
            // postalCodeToolStripMenuItem
            // 
            this.postalCodeToolStripMenuItem.Checked = true;
            this.postalCodeToolStripMenuItem.CheckOnClick = true;
            this.postalCodeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.postalCodeToolStripMenuItem.Name = "postalCodeToolStripMenuItem";
            this.postalCodeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.postalCodeToolStripMenuItem.Text = "Postal Code";
            this.postalCodeToolStripMenuItem.Click += new System.EventHandler(this.postalCodeToolStripMenuItem_Click);
            // 
            // phoneNumberToolStripMenuItem
            // 
            this.phoneNumberToolStripMenuItem.Checked = true;
            this.phoneNumberToolStripMenuItem.CheckOnClick = true;
            this.phoneNumberToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.phoneNumberToolStripMenuItem.Name = "phoneNumberToolStripMenuItem";
            this.phoneNumberToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.phoneNumberToolStripMenuItem.Text = "Phone Number";
            this.phoneNumberToolStripMenuItem.Click += new System.EventHandler(this.phoneNumberToolStripMenuItem_Click);
            // 
            // emailAddressToolStripMenuItem
            // 
            this.emailAddressToolStripMenuItem.Checked = true;
            this.emailAddressToolStripMenuItem.CheckOnClick = true;
            this.emailAddressToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.emailAddressToolStripMenuItem.Name = "emailAddressToolStripMenuItem";
            this.emailAddressToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.emailAddressToolStripMenuItem.Text = "Email Address";
            this.emailAddressToolStripMenuItem.Click += new System.EventHandler(this.emailAddressToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(157, 6);
            // 
            // oddAdditionToolStripMenuItem
            // 
            this.oddAdditionToolStripMenuItem.Enabled = false;
            this.oddAdditionToolStripMenuItem.Name = "oddAdditionToolStripMenuItem";
            this.oddAdditionToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.oddAdditionToolStripMenuItem.Text = "Odd Addition";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox2_KeyPress);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tpDataBound
            // 
            this.tpDataBound.Controls.Add(this.btnDataBindRemarks);
            this.tpDataBound.Controls.Add(this.toolStripAlt);
            this.tpDataBound.Controls.Add(this.dgvTableAlt);
            this.tpDataBound.Location = new System.Drawing.Point(4, 22);
            this.tpDataBound.Name = "tpDataBound";
            this.tpDataBound.Padding = new System.Windows.Forms.Padding(3);
            this.tpDataBound.Size = new System.Drawing.Size(944, 522);
            this.tpDataBound.TabIndex = 1;
            this.tpDataBound.Text = "Data Bound";
            this.tpDataBound.UseVisualStyleBackColor = true;
            // 
            // toolStripAlt
            // 
            this.toolStripAlt.AutoSize = false;
            this.toolStripAlt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddAlt,
            this.tsbDeleteAlt,
            this.toolStripSeparator7,
            this.tsbRefreshAlt,
            this.tsbSettingsAlt});
            this.toolStripAlt.Location = new System.Drawing.Point(3, 3);
            this.toolStripAlt.Name = "toolStripAlt";
            this.toolStripAlt.Size = new System.Drawing.Size(938, 15);
            this.toolStripAlt.TabIndex = 4;
            this.toolStripAlt.Text = "toolStrip3";
            // 
            // tsbAddAlt
            // 
            this.tsbAddAlt.AutoSize = false;
            this.tsbAddAlt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddAlt.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddAlt.Image")));
            this.tsbAddAlt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAddAlt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddAlt.Name = "tsbAddAlt";
            this.tsbAddAlt.Size = new System.Drawing.Size(15, 14);
            this.tsbAddAlt.Text = "Add Contact";
            this.tsbAddAlt.ToolTipText = "Add Contact";
            this.tsbAddAlt.Click += new System.EventHandler(this.Add_Click);
            // 
            // tsbDeleteAlt
            // 
            this.tsbDeleteAlt.AutoSize = false;
            this.tsbDeleteAlt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteAlt.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteAlt.Image")));
            this.tsbDeleteAlt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDeleteAlt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteAlt.Name = "tsbDeleteAlt";
            this.tsbDeleteAlt.Size = new System.Drawing.Size(15, 14);
            this.tsbDeleteAlt.Text = "Delete Contact";
            this.tsbDeleteAlt.Click += new System.EventHandler(this.Delete_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 15);
            // 
            // tsbRefreshAlt
            // 
            this.tsbRefreshAlt.AutoSize = false;
            this.tsbRefreshAlt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefreshAlt.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefreshAlt.Image")));
            this.tsbRefreshAlt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRefreshAlt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefreshAlt.Name = "tsbRefreshAlt";
            this.tsbRefreshAlt.Size = new System.Drawing.Size(15, 14);
            this.tsbRefreshAlt.Text = "Refresh Contact List";
            this.tsbRefreshAlt.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // tsbSettingsAlt
            // 
            this.tsbSettingsAlt.AutoSize = false;
            this.tsbSettingsAlt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSettingsAlt.Image = ((System.Drawing.Image)(resources.GetObject("tsbSettingsAlt.Image")));
            this.tsbSettingsAlt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSettingsAlt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSettingsAlt.Name = "tsbSettingsAlt";
            this.tsbSettingsAlt.Size = new System.Drawing.Size(15, 14);
            this.tsbSettingsAlt.Text = "Settings";
            this.tsbSettingsAlt.ToolTipText = "Settings";
            // 
            // dgvTableAlt
            // 
            this.dgvTableAlt.AllowUserToAddRows = false;
            this.dgvTableAlt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTableAlt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTableAlt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableAlt.Location = new System.Drawing.Point(6, 21);
            this.dgvTableAlt.Name = "dgvTableAlt";
            this.dgvTableAlt.Size = new System.Drawing.Size(932, 466);
            this.dgvTableAlt.TabIndex = 0;
            this.dgvTableAlt.SelectionChanged += new System.EventHandler(this.dgvTable_SelectionChanged);
            // 
            // tpContactList
            // 
            this.tpContactList.Controls.Add(this.cmbFilter);
            this.tpContactList.Controls.Add(this.toolStripMain);
            this.tpContactList.Controls.Add(this.btnDelete);
            this.tpContactList.Controls.Add(this.btnUpdate);
            this.tpContactList.Controls.Add(this.btnAdd);
            this.tpContactList.Controls.Add(this.dgvTable);
            this.tpContactList.Location = new System.Drawing.Point(4, 22);
            this.tpContactList.Name = "tpContactList";
            this.tpContactList.Padding = new System.Windows.Forms.Padding(3);
            this.tpContactList.Size = new System.Drawing.Size(944, 522);
            this.tpContactList.TabIndex = 0;
            this.tpContactList.Text = "Contact List";
            this.tpContactList.UseVisualStyleBackColor = true;
            // 
            // toolStripMain
            // 
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddMain,
            this.tsbUpdateMain,
            this.tsbDeleteMain,
            this.toolStripSeparator6,
            this.tsbRefreshMain,
            this.tsbSettingsMain});
            this.toolStripMain.Location = new System.Drawing.Point(3, 3);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(938, 15);
            this.toolStripMain.TabIndex = 4;
            this.toolStripMain.Text = "toolStrip2";
            // 
            // tsbAddMain
            // 
            this.tsbAddMain.AutoSize = false;
            this.tsbAddMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddMain.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddMain.Image")));
            this.tsbAddMain.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAddMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddMain.Name = "tsbAddMain";
            this.tsbAddMain.Size = new System.Drawing.Size(15, 14);
            this.tsbAddMain.Text = "Add Contact";
            this.tsbAddMain.ToolTipText = "Add Contact";
            this.tsbAddMain.Click += new System.EventHandler(this.Add_Click);
            // 
            // tsbUpdateMain
            // 
            this.tsbUpdateMain.AutoSize = false;
            this.tsbUpdateMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUpdateMain.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdateMain.Image")));
            this.tsbUpdateMain.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUpdateMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateMain.Name = "tsbUpdateMain";
            this.tsbUpdateMain.Size = new System.Drawing.Size(15, 14);
            this.tsbUpdateMain.Text = "Update Contact";
            this.tsbUpdateMain.ToolTipText = "Update Contact";
            this.tsbUpdateMain.Click += new System.EventHandler(this.Update_Click);
            // 
            // tsbDeleteMain
            // 
            this.tsbDeleteMain.AutoSize = false;
            this.tsbDeleteMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteMain.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteMain.Image")));
            this.tsbDeleteMain.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDeleteMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteMain.Name = "tsbDeleteMain";
            this.tsbDeleteMain.Size = new System.Drawing.Size(15, 14);
            this.tsbDeleteMain.Text = "Delete Contact";
            this.tsbDeleteMain.Click += new System.EventHandler(this.Delete_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 15);
            // 
            // tsbRefreshMain
            // 
            this.tsbRefreshMain.AutoSize = false;
            this.tsbRefreshMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefreshMain.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefreshMain.Image")));
            this.tsbRefreshMain.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRefreshMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefreshMain.Name = "tsbRefreshMain";
            this.tsbRefreshMain.Size = new System.Drawing.Size(15, 14);
            this.tsbRefreshMain.Text = "Refresh Contact List";
            this.tsbRefreshMain.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // tsbSettingsMain
            // 
            this.tsbSettingsMain.AutoSize = false;
            this.tsbSettingsMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSettingsMain.Image = ((System.Drawing.Image)(resources.GetObject("tsbSettingsMain.Image")));
            this.tsbSettingsMain.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSettingsMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSettingsMain.Name = "tsbSettingsMain";
            this.tsbSettingsMain.Size = new System.Drawing.Size(15, 14);
            this.tsbSettingsMain.Text = "Settings";
            this.tsbSettingsMain.ToolTipText = "Settings";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(171, 492);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Location = new System.Drawing.Point(90, 492);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.Update_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(9, 492);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FName,
            this.LName,
            this.Street,
            this.City,
            this.Province,
            this.PostalCode,
            this.Phone,
            this.Email});
            this.dgvTable.ContextMenuStrip = this.cmsTable;
            this.dgvTable.Location = new System.Drawing.Point(6, 21);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(929, 465);
            this.dgvTable.TabIndex = 0;
            this.dgvTable.SelectionChanged += new System.EventHandler(this.dgvTable_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Contact ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // FName
            // 
            this.FName.HeaderText = "First Name";
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            // 
            // LName
            // 
            this.LName.HeaderText = "Last Name";
            this.LName.Name = "LName";
            this.LName.ReadOnly = true;
            // 
            // Street
            // 
            this.Street.HeaderText = "Street";
            this.Street.Name = "Street";
            this.Street.ReadOnly = true;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Province
            // 
            this.Province.HeaderText = "Province";
            this.Province.Name = "Province";
            this.Province.ReadOnly = true;
            // 
            // PostalCode
            // 
            this.PostalCode.HeaderText = "Postal Code";
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone Number";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email Address";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpContactList);
            this.tabControl1.Controls.Add(this.tpDataBound);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 548);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(814, 492);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbFilter.TabIndex = 5;
            this.cmbFilter.ValueMember = "ProvinceCode";
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // btnDataBindRemarks
            // 
            this.btnDataBindRemarks.Location = new System.Drawing.Point(7, 493);
            this.btnDataBindRemarks.Name = "btnDataBindRemarks";
            this.btnDataBindRemarks.Size = new System.Drawing.Size(159, 23);
            this.btnDataBindRemarks.TabIndex = 5;
            this.btnDataBindRemarks.Text = "Data Binding Remarks";
            this.btnDataBindRemarks.UseVisualStyleBackColor = true;
            this.btnDataBindRemarks.Click += new System.EventHandler(this.btnDataBindRemarks_Click);
            // 
            // ContactBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 587);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ContactBook";
            this.Text = "Contact Manager";
            this.cmsTable.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tpDataBound.ResumeLayout(false);
            this.toolStripAlt.ResumeLayout(false);
            this.toolStripAlt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAlt)).EndInit();
            this.tpContactList.ResumeLayout(false);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsTable;
        private System.Windows.Forms.ToolStripMenuItem cmsAdd;
        private System.Windows.Forms.ToolStripMenuItem cmsUpdate;
        private System.Windows.Forms.ToolStripMenuItem cmsDelete;
        private System.Windows.Forms.ToolStripMenuItem firstNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem lastNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provinceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postalCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem oddAdditionToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.TabPage tpDataBound;
        private System.Windows.Forms.ToolStrip toolStripAlt;
        private System.Windows.Forms.ToolStripButton tsbAddAlt;
        private System.Windows.Forms.ToolStripButton tsbDeleteAlt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbRefreshAlt;
        private System.Windows.Forms.ToolStripButton tsbSettingsAlt;
        private System.Windows.Forms.DataGridView dgvTableAlt;
        private System.Windows.Forms.TabPage tpContactList;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton tsbAddMain;
        private System.Windows.Forms.ToolStripButton tsbUpdateMain;
        private System.Windows.Forms.ToolStripButton tsbDeleteMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbRefreshMain;
        private System.Windows.Forms.ToolStripButton tsbSettingsMain;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Province;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnDataBindRemarks;
    }
}

