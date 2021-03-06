﻿namespace ContactsAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contactsLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.addContact = new System.Windows.Forms.ToolStripMenuItem();
            this.EditContact = new System.Windows.Forms.ToolStripMenuItem();
            this.removeContact = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ContactsList = new System.Windows.Forms.ListView();
            this.ContactsCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemoveContactButton = new System.Windows.Forms.Button();
            this.EditContactButton = new System.Windows.Forms.Button();
            this.addContactButton = new System.Windows.Forms.Button();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Label();
            this.BirthdayText = new System.Windows.Forms.Label();
            this.BirthdayPanel = new System.Windows.Forms.Panel();
            this.BirthdayShowLabel = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.BirthdayDayTool = new System.Windows.Forms.DateTimePicker();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.VK = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.Label();
            this.NamePerson = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.BirthdayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactsLabel
            // 
            this.contactsLabel.AutoSize = true;
            this.contactsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactsLabel.Location = new System.Drawing.Point(0, 27);
            this.contactsLabel.Name = "contactsLabel";
            this.contactsLabel.Size = new System.Drawing.Size(0, 22);
            this.contactsLabel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.edit,
            this.help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.exit,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exit.Size = new System.Drawing.Size(162, 26);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // edit
            // 
            this.edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContact,
            this.EditContact,
            this.removeContact});
            this.edit.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(46, 23);
            this.edit.Text = "Edit";
            // 
            // addContact
            // 
            this.addContact.Name = "addContact";
            this.addContact.Size = new System.Drawing.Size(190, 26);
            this.addContact.Text = "Add Contact";
            this.addContact.Click += new System.EventHandler(this.addContact_Click);
            // 
            // EditContact
            // 
            this.EditContact.Name = "EditContact";
            this.EditContact.Size = new System.Drawing.Size(190, 26);
            this.EditContact.Text = "Edit Contact";
            this.EditContact.Click += new System.EventHandler(this.EditContact_Click);
            // 
            // removeContact
            // 
            this.removeContact.Name = "removeContact";
            this.removeContact.Size = new System.Drawing.Size(190, 26);
            this.removeContact.Text = "Remove Contact";
            this.removeContact.Click += new System.EventHandler(this.RemoveContact_Click);
            // 
            // help
            // 
            this.help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about});
            this.help.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(52, 23);
            this.help.Text = "Help";
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.about.Size = new System.Drawing.Size(148, 26);
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.About_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(323, 403);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(915, 512);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.ContactsList);
            this.splitContainer1.Panel1.Controls.Add(this.RemoveContactButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditContactButton);
            this.splitContainer1.Panel1.Controls.Add(this.addContactButton);
            this.splitContainer1.Panel1.Controls.Add(this.FindTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.Find);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.BirthdayText);
            this.splitContainer1.Panel2.Controls.Add(this.BirthdayPanel);
            this.splitContainer1.Panel2.Controls.Add(this.PhoneTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.BirthdayDayTool);
            this.splitContainer1.Panel2.Controls.Add(this.VKTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.EmailTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.NameTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.SurnameTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.VK);
            this.splitContainer1.Panel2.Controls.Add(this.Email);
            this.splitContainer1.Panel2.Controls.Add(this.Phone);
            this.splitContainer1.Panel2.Controls.Add(this.Birthday);
            this.splitContainer1.Panel2.Controls.Add(this.NamePerson);
            this.splitContainer1.Panel2.Controls.Add(this.Surname);
            this.splitContainer1.Size = new System.Drawing.Size(915, 512);
            this.splitContainer1.SplitterDistance = 253;
            this.splitContainer1.TabIndex = 2;
            // 
            // ContactsList
            // 
            this.ContactsList.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.ContactsList.AllowDrop = true;
            this.ContactsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ContactsCol});
            this.ContactsList.Location = new System.Drawing.Point(17, 47);
            this.ContactsList.Margin = new System.Windows.Forms.Padding(4);
            this.ContactsList.Name = "ContactsList";
            this.ContactsList.Scrollable = false;
            this.ContactsList.Size = new System.Drawing.Size(226, 405);
            this.ContactsList.TabIndex = 50;
            this.ContactsList.UseCompatibleStateImageBehavior = false;
            this.ContactsList.View = System.Windows.Forms.View.Details;
            this.ContactsList.SelectedIndexChanged += new System.EventHandler(this.ContactsList_SelectedIndexChanged);
            // 
            // ContactsCol
            // 
            this.ContactsCol.Text = "Contact";
            this.ContactsCol.Width = 365;
            // 
            // RemoveContactButton
            // 
            this.RemoveContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveContactButton.Enabled = false;
            this.RemoveContactButton.FlatAppearance.BorderSize = 0;
            this.RemoveContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveContactButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveContactButton.Image")));
            this.RemoveContactButton.Location = new System.Drawing.Point(202, 459);
            this.RemoveContactButton.Name = "RemoveContactButton";
            this.RemoveContactButton.Size = new System.Drawing.Size(41, 41);
            this.RemoveContactButton.TabIndex = 49;
            this.RemoveContactButton.UseVisualStyleBackColor = true;
            this.RemoveContactButton.Click += new System.EventHandler(this.RemoveContact_Click);
            // 
            // EditContactButton
            // 
            this.EditContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditContactButton.Enabled = false;
            this.EditContactButton.FlatAppearance.BorderSize = 0;
            this.EditContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditContactButton.Image = ((System.Drawing.Image)(resources.GetObject("EditContactButton.Image")));
            this.EditContactButton.Location = new System.Drawing.Point(155, 459);
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Size = new System.Drawing.Size(41, 41);
            this.EditContactButton.TabIndex = 48;
            this.EditContactButton.UseVisualStyleBackColor = true;
            this.EditContactButton.Click += new System.EventHandler(this.EditContactButton_Click);
            // 
            // addContactButton
            // 
            this.addContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addContactButton.FlatAppearance.BorderSize = 0;
            this.addContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addContactButton.Image = ((System.Drawing.Image)(resources.GetObject("addContactButton.Image")));
            this.addContactButton.Location = new System.Drawing.Point(109, 459);
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.Size = new System.Drawing.Size(41, 41);
            this.addContactButton.TabIndex = 47;
            this.addContactButton.UseVisualStyleBackColor = true;
            this.addContactButton.Click += new System.EventHandler(this.addContactButton_Click);
            // 
            // FindTextBox
            // 
            this.FindTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindTextBox.Location = new System.Drawing.Point(64, 13);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(179, 29);
            this.FindTextBox.TabIndex = 46;
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged_1);
            // 
            // Find
            // 
            this.Find.AutoSize = true;
            this.Find.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find.Location = new System.Drawing.Point(12, 13);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(53, 26);
            this.Find.TabIndex = 45;
            this.Find.Text = "Find:";
            // 
            // BirthdayText
            // 
            this.BirthdayText.AutoSize = true;
            this.BirthdayText.Location = new System.Drawing.Point(3, 387);
            this.BirthdayText.Name = "BirthdayText";
            this.BirthdayText.Size = new System.Drawing.Size(121, 22);
            this.BirthdayText.TabIndex = 52;
            this.BirthdayText.Text = "Today birthday:";
            // 
            // BirthdayPanel
            // 
            this.BirthdayPanel.Controls.Add(this.BirthdayShowLabel);
            this.BirthdayPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BirthdayPanel.Location = new System.Drawing.Point(0, 412);
            this.BirthdayPanel.Name = "BirthdayPanel";
            this.BirthdayPanel.Size = new System.Drawing.Size(658, 100);
            this.BirthdayPanel.TabIndex = 53;
            // 
            // BirthdayShowLabel
            // 
            this.BirthdayShowLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BirthdayShowLabel.Location = new System.Drawing.Point(0, 0);
            this.BirthdayShowLabel.Name = "BirthdayShowLabel";
            this.BirthdayShowLabel.Size = new System.Drawing.Size(658, 100);
            this.BirthdayShowLabel.TabIndex = 0;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneTextBox.Enabled = false;
            this.PhoneTextBox.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTextBox.Location = new System.Drawing.Point(95, 133);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneTextBox.MinimumSize = new System.Drawing.Size(136, 25);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(540, 30);
            this.PhoneTextBox.TabIndex = 51;
            // 
            // BirthdayDayTool
            // 
            this.BirthdayDayTool.Enabled = false;
            this.BirthdayDayTool.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthdayDayTool.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdayDayTool.Location = new System.Drawing.Point(95, 93);
            this.BirthdayDayTool.Margin = new System.Windows.Forms.Padding(4);
            this.BirthdayDayTool.MaxDate = new System.DateTime(2021, 3, 19, 0, 0, 0, 0);
            this.BirthdayDayTool.MaximumSize = new System.Drawing.Size(136, 30);
            this.BirthdayDayTool.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthdayDayTool.MinimumSize = new System.Drawing.Size(136, 25);
            this.BirthdayDayTool.Name = "BirthdayDayTool";
            this.BirthdayDayTool.Size = new System.Drawing.Size(136, 27);
            this.BirthdayDayTool.TabIndex = 50;
            this.BirthdayDayTool.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // VKTextBox
            // 
            this.VKTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VKTextBox.Enabled = false;
            this.VKTextBox.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VKTextBox.Location = new System.Drawing.Point(96, 213);
            this.VKTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.VKTextBox.MinimumSize = new System.Drawing.Size(136, 25);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(540, 30);
            this.VKTextBox.TabIndex = 45;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Enabled = false;
            this.EmailTextBox.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(95, 173);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailTextBox.MinimumSize = new System.Drawing.Size(136, 25);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(540, 30);
            this.EmailTextBox.TabIndex = 46;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(95, 53);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.MinimumSize = new System.Drawing.Size(136, 25);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(540, 30);
            this.NameTextBox.TabIndex = 48;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.Enabled = false;
            this.SurnameTextBox.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameTextBox.Location = new System.Drawing.Point(95, 13);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.SurnameTextBox.MinimumSize = new System.Drawing.Size(136, 25);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(540, 30);
            this.SurnameTextBox.TabIndex = 49;
            // 
            // VK
            // 
            this.VK.AutoSize = true;
            this.VK.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VK.Location = new System.Drawing.Point(14, 216);
            this.VK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VK.Name = "VK";
            this.VK.Size = new System.Drawing.Size(67, 22);
            this.VK.TabIndex = 39;
            this.VK.Text = "vk.com:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(14, 176);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(61, 22);
            this.Email.TabIndex = 40;
            this.Email.Text = "E-mail:";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(14, 136);
            this.Phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(60, 22);
            this.Phone.TabIndex = 41;
            this.Phone.Text = "Phone:";
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday.Location = new System.Drawing.Point(14, 96);
            this.Birthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(73, 22);
            this.Birthday.TabIndex = 42;
            this.Birthday.Text = "Birthday:";
            // 
            // NamePerson
            // 
            this.NamePerson.AutoSize = true;
            this.NamePerson.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamePerson.Location = new System.Drawing.Point(14, 56);
            this.NamePerson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NamePerson.Name = "NamePerson";
            this.NamePerson.Size = new System.Drawing.Size(58, 22);
            this.NamePerson.TabIndex = 43;
            this.NamePerson.Text = "Name:";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname.Location = new System.Drawing.Point(14, 16);
            this.Surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(77, 22);
            this.Surname.TabIndex = 44;
            this.Surname.Text = "Surname:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 539);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.contactsLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(933, 586);
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.BirthdayPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contactsLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem addContact;
        private System.Windows.Forms.ToolStripMenuItem EditContact;
        private System.Windows.Forms.ToolStripMenuItem removeContact;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label VK;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Birthday;
        private System.Windows.Forms.Label NamePerson;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Button RemoveContactButton;
        private System.Windows.Forms.Button EditContactButton;
        private System.Windows.Forms.Button addContactButton;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Label Find;
        private System.Windows.Forms.ListView ContactsList;
        private System.Windows.Forms.ColumnHeader ContactsCol;
        private System.Windows.Forms.DateTimePicker BirthdayDayTool;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label BirthdayText;
        private System.Windows.Forms.Panel BirthdayPanel;
        private System.Windows.Forms.Label BirthdayShowLabel;
    }
}

