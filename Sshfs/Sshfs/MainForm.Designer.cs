namespace Sshfs
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.muButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.fieldsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.passphraseBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.authLabel = new System.Windows.Forms.Label();
            this.proxyHostBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.proxyPassBox = new System.Windows.Forms.TextBox();
            this.proxyLoginBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hostBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.authCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.letterBox = new System.Windows.Forms.ComboBox();
            this.mountCheck = new System.Windows.Forms.CheckBox();
            this.directoryBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mountPointBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.proxyType = new System.Windows.Forms.ComboBox();
            this.labelKeepAlive = new System.Windows.Forms.Label();
            this.keepAliveIntervalBox = new System.Windows.Forms.NumericUpDown();
            this.portBox = new System.Windows.Forms.NumericUpDown();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.privateKeyButton = new System.Windows.Forms.Button();
            this.privateKeyBox = new System.Windows.Forms.TextBox();
            this.driveListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unmountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.startupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.fieldsPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keepAliveIntervalBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portBox)).BeginInit();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fieldsPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.driveListView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(654, 621);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.muButton);
            this.flowLayoutPanel1.Controls.Add(this.saveButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(266, 566);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(377, 44);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // muButton
            // 
            this.muButton.AutoSize = true;
            this.muButton.Image = global::Sshfs.Properties.Resources.mount;
            this.muButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.muButton.Location = new System.Drawing.Point(252, 3);
            this.muButton.Name = "muButton";
            this.muButton.Size = new System.Drawing.Size(122, 36);
            this.muButton.TabIndex = 5;
            this.muButton.Text = "Mount";
            this.muButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.muButton.Click += new System.EventHandler(this.muButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.Location = new System.Drawing.Point(133, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(113, 36);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // fieldsPanel
            // 
            this.fieldsPanel.ColumnCount = 2;
            this.fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.fieldsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fieldsPanel.Controls.Add(this.label14, 0, 7);
            this.fieldsPanel.Controls.Add(this.label13, 0, 6);
            this.fieldsPanel.Controls.Add(this.passphraseBox, 1, 6);
            this.fieldsPanel.Controls.Add(this.passwordBox, 1, 7);
            this.fieldsPanel.Controls.Add(this.authLabel, 0, 5);
            this.fieldsPanel.Controls.Add(this.proxyHostBox, 1, 12);
            this.fieldsPanel.Controls.Add(this.label12, 0, 12);
            this.fieldsPanel.Controls.Add(this.panel3, 1, 13);
            this.fieldsPanel.Controls.Add(this.label11, 0, 13);
            this.fieldsPanel.Controls.Add(this.label1, 0, 0);
            this.fieldsPanel.Controls.Add(this.hostBox, 1, 1);
            this.fieldsPanel.Controls.Add(this.label2, 0, 1);
            this.fieldsPanel.Controls.Add(this.label3, 0, 2);
            this.fieldsPanel.Controls.Add(this.label4, 0, 3);
            this.fieldsPanel.Controls.Add(this.userBox, 1, 3);
            this.fieldsPanel.Controls.Add(this.authCombo, 1, 4);
            this.fieldsPanel.Controls.Add(this.label5, 0, 4);
            this.fieldsPanel.Controls.Add(this.label6, 0, 9);
            this.fieldsPanel.Controls.Add(this.panel1, 1, 9);
            this.fieldsPanel.Controls.Add(this.directoryBox, 1, 8);
            this.fieldsPanel.Controls.Add(this.label7, 0, 8);
            this.fieldsPanel.Controls.Add(this.label8, 0, 10);
            this.fieldsPanel.Controls.Add(this.mountPointBox, 1, 10);
            this.fieldsPanel.Controls.Add(this.label10, 0, 11);
            this.fieldsPanel.Controls.Add(this.proxyType, 1, 11);
            this.fieldsPanel.Controls.Add(this.labelKeepAlive, 0, 14);
            this.fieldsPanel.Controls.Add(this.keepAliveIntervalBox, 1, 14);
            this.fieldsPanel.Controls.Add(this.portBox, 1, 2);
            this.fieldsPanel.Controls.Add(this.nameBox, 1, 0);
            this.fieldsPanel.Controls.Add(this.panel5, 1, 5);
            this.fieldsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldsPanel.Location = new System.Drawing.Point(266, 11);
            this.fieldsPanel.Name = "fieldsPanel";
            this.fieldsPanel.RowCount = 16;
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.fieldsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fieldsPanel.Size = new System.Drawing.Size(377, 549);
            this.fieldsPanel.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Right;
            this.label14.Location = new System.Drawing.Point(44, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 36);
            this.label14.TabIndex = 52;
            this.label14.Text = "Password:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Right;
            this.label13.Location = new System.Drawing.Point(29, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 36);
            this.label13.TabIndex = 51;
            this.label13.Text = "Pass Phrase";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passphraseBox
            // 
            this.passphraseBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passphraseBox.Location = new System.Drawing.Point(128, 224);
            this.passphraseBox.Margin = new System.Windows.Forms.Padding(8);
            this.passphraseBox.Name = "passphraseBox";
            this.passphraseBox.PasswordChar = '*';
            this.passphraseBox.Size = new System.Drawing.Size(241, 22);
            this.passphraseBox.TabIndex = 50;
            // 
            // passwordBox
            // 
            this.passwordBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordBox.Location = new System.Drawing.Point(128, 260);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(8);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(241, 22);
            this.passwordBox.TabIndex = 43;
            // 
            // authLabel
            // 
            this.authLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authLabel.Location = new System.Drawing.Point(3, 180);
            this.authLabel.Name = "authLabel";
            this.authLabel.Size = new System.Drawing.Size(114, 36);
            this.authLabel.TabIndex = 29;
            this.authLabel.Text = "Private Key";
            this.authLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // proxyHostBox
            // 
            this.proxyHostBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proxyHostBox.Location = new System.Drawing.Point(128, 440);
            this.proxyHostBox.Margin = new System.Windows.Forms.Padding(8);
            this.proxyHostBox.Name = "proxyHostBox";
            this.proxyHostBox.Size = new System.Drawing.Size(241, 22);
            this.proxyHostBox.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Right;
            this.label12.Location = new System.Drawing.Point(51, 432);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 36);
            this.label12.TabIndex = 25;
            this.label12.Text = "Host:port";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.proxyPassBox);
            this.panel3.Controls.Add(this.proxyLoginBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(120, 468);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8);
            this.panel3.Size = new System.Drawing.Size(257, 36);
            this.panel3.TabIndex = 11;
            // 
            // proxyPassBox
            // 
            this.proxyPassBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.proxyPassBox.Location = new System.Drawing.Point(132, 8);
            this.proxyPassBox.Name = "proxyPassBox";
            this.proxyPassBox.Size = new System.Drawing.Size(117, 22);
            this.proxyPassBox.TabIndex = 1;
            this.proxyPassBox.UseSystemPasswordChar = true;
            // 
            // proxyLoginBox
            // 
            this.proxyLoginBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyLoginBox.Location = new System.Drawing.Point(8, 8);
            this.proxyLoginBox.Name = "proxyLoginBox";
            this.proxyLoginBox.Size = new System.Drawing.Size(118, 22);
            this.proxyLoginBox.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Right;
            this.label11.Location = new System.Drawing.Point(39, 468);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 36);
            this.label11.TabIndex = 23;
            this.label11.Text = "Login/Pass";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(35, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drive Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hostBox
            // 
            this.hostBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostBox.Location = new System.Drawing.Point(128, 44);
            this.hostBox.Margin = new System.Windows.Forms.Padding(8);
            this.hostBox.Name = "hostBox";
            this.hostBox.Size = new System.Drawing.Size(241, 22);
            this.hostBox.TabIndex = 1;
            this.hostBox.Leave += new System.EventHandler(this.box_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(80, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Host";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(83, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(44, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userBox
            // 
            this.userBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBox.Location = new System.Drawing.Point(128, 116);
            this.userBox.Margin = new System.Windows.Forms.Padding(8);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(241, 22);
            this.userBox.TabIndex = 3;
            this.userBox.Leave += new System.EventHandler(this.box_Leave);
            // 
            // authCombo
            // 
            this.authCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authCombo.FormattingEnabled = true;
            this.authCombo.Items.AddRange(new object[] {
            "Password",
            "PrivateKey",
            "Pageant"});
            this.authCombo.Location = new System.Drawing.Point(128, 152);
            this.authCombo.Margin = new System.Windows.Forms.Padding(8);
            this.authCombo.Name = "authCombo";
            this.authCombo.Size = new System.Drawing.Size(241, 24);
            this.authCombo.TabIndex = 4;
            this.authCombo.SelectedIndexChanged += new System.EventHandler(this.authBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(19, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Authentication method";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Location = new System.Drawing.Point(35, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "Drive Letter";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.letterBox);
            this.panel1.Controls.Add(this.mountCheck);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(120, 324);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.panel1.Size = new System.Drawing.Size(257, 36);
            this.panel1.TabIndex = 7;
            // 
            // letterBox
            // 
            this.letterBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.letterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.letterBox.FormattingEnabled = true;
            this.letterBox.Location = new System.Drawing.Point(8, 6);
            this.letterBox.Name = "letterBox";
            this.letterBox.Size = new System.Drawing.Size(100, 24);
            this.letterBox.Sorted = true;
            this.letterBox.TabIndex = 0;
            this.letterBox.SelectedIndexChanged += new System.EventHandler(this.letterBox_SelectedIndexChanged);
            // 
            // mountCheck
            // 
            this.mountCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mountCheck.AutoSize = true;
            this.mountCheck.Location = new System.Drawing.Point(132, 7);
            this.mountCheck.Name = "mountCheck";
            this.mountCheck.Size = new System.Drawing.Size(119, 21);
            this.mountCheck.TabIndex = 1;
            this.mountCheck.Text = "Mount at login";
            this.mountCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mountCheck.UseVisualStyleBackColor = true;
            // 
            // directoryBox
            // 
            this.directoryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directoryBox.FormattingEnabled = true;
            this.directoryBox.Items.AddRange(new object[] {
            ".",
            "/"});
            this.directoryBox.Location = new System.Drawing.Point(128, 296);
            this.directoryBox.Margin = new System.Windows.Forms.Padding(8);
            this.directoryBox.Name = "directoryBox";
            this.directoryBox.Size = new System.Drawing.Size(241, 24);
            this.directoryBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(52, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 36);
            this.label7.TabIndex = 14;
            this.label7.Text = "Directory";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Location = new System.Drawing.Point(26, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 36);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mount Folder";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mountPointBox
            // 
            this.mountPointBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mountPointBox.Location = new System.Drawing.Point(128, 368);
            this.mountPointBox.Margin = new System.Windows.Forms.Padding(8);
            this.mountPointBox.Name = "mountPointBox";
            this.mountPointBox.Size = new System.Drawing.Size(241, 22);
            this.mountPointBox.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.Location = new System.Drawing.Point(38, 396);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 36);
            this.label10.TabIndex = 19;
            this.label10.Text = "Proxy Type";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // proxyType
            // 
            this.proxyType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proxyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proxyType.FormattingEnabled = true;
            this.proxyType.Items.AddRange(new object[] {
            "None",
            "HTTP",
            "SOCKS4",
            "SOCKS5"});
            this.proxyType.Location = new System.Drawing.Point(128, 404);
            this.proxyType.Margin = new System.Windows.Forms.Padding(8);
            this.proxyType.Name = "proxyType";
            this.proxyType.Size = new System.Drawing.Size(241, 24);
            this.proxyType.TabIndex = 9;
            // 
            // labelKeepAlive
            // 
            this.labelKeepAlive.AutoSize = true;
            this.labelKeepAlive.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelKeepAlive.Location = new System.Drawing.Point(25, 504);
            this.labelKeepAlive.Name = "labelKeepAlive";
            this.labelKeepAlive.Size = new System.Drawing.Size(92, 36);
            this.labelKeepAlive.TabIndex = 26;
            this.labelKeepAlive.Text = "KeepAlive (s)";
            this.labelKeepAlive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // keepAliveIntervalBox
            // 
            this.keepAliveIntervalBox.Location = new System.Drawing.Point(128, 512);
            this.keepAliveIntervalBox.Margin = new System.Windows.Forms.Padding(8);
            this.keepAliveIntervalBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.keepAliveIntervalBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.keepAliveIntervalBox.Name = "keepAliveIntervalBox";
            this.keepAliveIntervalBox.Size = new System.Drawing.Size(91, 22);
            this.keepAliveIntervalBox.TabIndex = 27;
            this.keepAliveIntervalBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(128, 80);
            this.portBox.Margin = new System.Windows.Forms.Padding(8);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(91, 22);
            this.portBox.TabIndex = 2;
            // 
            // nameBox
            // 
            this.nameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameBox.Location = new System.Drawing.Point(128, 8);
            this.nameBox.Margin = new System.Windows.Forms.Padding(8);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(241, 22);
            this.nameBox.TabIndex = 0;
            this.nameBox.Leave += new System.EventHandler(this.box_Leave);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.privateKeyButton);
            this.panel5.Controls.Add(this.privateKeyBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(120, 180);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(8);
            this.panel5.Size = new System.Drawing.Size(257, 36);
            this.panel5.TabIndex = 42;
            // 
            // privateKeyButton
            // 
            this.privateKeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.privateKeyButton.Location = new System.Drawing.Point(223, 5);
            this.privateKeyButton.Margin = new System.Windows.Forms.Padding(0);
            this.privateKeyButton.Name = "privateKeyButton";
            this.privateKeyButton.Size = new System.Drawing.Size(28, 28);
            this.privateKeyButton.TabIndex = 49;
            this.privateKeyButton.Text = "...";
            this.privateKeyButton.UseVisualStyleBackColor = true;
            // 
            // privateKeyBox
            // 
            this.privateKeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.privateKeyBox.Location = new System.Drawing.Point(8, 8);
            this.privateKeyBox.Name = "privateKeyBox";
            this.privateKeyBox.Size = new System.Drawing.Size(212, 22);
            this.privateKeyBox.TabIndex = 48;
            // 
            // driveListView
            // 
            this.driveListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.driveListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driveListView.FullRowSelect = true;
            this.driveListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.driveListView.HideSelection = false;
            this.driveListView.LabelWrap = false;
            this.driveListView.Location = new System.Drawing.Point(12, 12);
            this.driveListView.Margin = new System.Windows.Forms.Padding(4);
            this.driveListView.MultiSelect = false;
            this.driveListView.Name = "driveListView";
            this.driveListView.Size = new System.Drawing.Size(247, 547);
            this.driveListView.SmallImageList = this.imageList;
            this.driveListView.TabIndex = 0;
            this.driveListView.UseCompatibleStateImageBehavior = false;
            this.driveListView.View = System.Windows.Forms.View.Details;
            this.driveListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_ItemSelectionChanged);
            this.driveListView.ClientSizeChanged += new System.EventHandler(this.driveListView_ClientSizeChanged);
            this.driveListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.driveListView_MouseUpDown);
            this.driveListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.driveListView_MouseUpDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 200;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "network-offline.png");
            this.imageList.Images.SetKeyName(1, "connect_creating.png");
            this.imageList.Images.SetKeyName(2, "network-offline.png");
            this.imageList.Images.SetKeyName(3, "network-idle.png");
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.addButton);
            this.flowLayoutPanel2.Controls.Add(this.removeButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(11, 566);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(249, 44);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 36);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.AutoSize = true;
            this.removeButton.Image = ((System.Drawing.Image)(resources.GetObject("removeButton.Image")));
            this.removeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeButton.Location = new System.Drawing.Point(89, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(98, 36);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "id_rsa";
            this.openFileDialog.Filter = "Pivate Key Files (*.*)|*";
            this.openFileDialog.Title = "Open Private Key";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Sshfs";
            this.notifyIcon.Visible = true;
            this.notifyIcon.BalloonTipClosed += new System.EventHandler(this.notifyIcon_BalloonTipClosed);
            this.notifyIcon.BalloonTipShown += new System.EventHandler(this.notifyIcon_BalloonTipShown);
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMenuItem,
            this.toolStripSeparator1,
            this.mountMenuItem,
            this.unmountMenuItem,
            this.toolStripSeparator2,
            this.startupMenuItem,
            this.aboutMenuItem,
            this.exitMenuItem});
            this.contextMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.contextMenu.MaximumSize = new System.Drawing.Size(135, 0);
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.ShowCheckMargin = true;
            this.contextMenu.ShowImageMargin = false;
            this.contextMenu.Size = new System.Drawing.Size(135, 148);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            this.contextMenu.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.contextMenu_PreviewKeyDown);
            // 
            // showMenuItem
            // 
            this.showMenuItem.AutoSize = false;
            this.showMenuItem.Name = "showMenuItem";
            this.showMenuItem.Size = new System.Drawing.Size(134, 22);
            this.showMenuItem.Text = "Show Manager";
            this.showMenuItem.Click += new System.EventHandler(this.showMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // mountMenuItem
            // 
            this.mountMenuItem.AutoSize = false;
            this.mountMenuItem.Name = "mountMenuItem";
            this.mountMenuItem.Size = new System.Drawing.Size(134, 22);
            this.mountMenuItem.Text = "Mount";
            this.mountMenuItem.DropDownClosed += new System.EventHandler(this.mountMenuItem_DropDownClosed);
            this.mountMenuItem.DropDownOpening += new System.EventHandler(this.mountMenuItem_DropDownOpening);
            // 
            // unmountMenuItem
            // 
            this.unmountMenuItem.AutoSize = false;
            this.unmountMenuItem.Name = "unmountMenuItem";
            this.unmountMenuItem.Size = new System.Drawing.Size(134, 22);
            this.unmountMenuItem.Text = "Unmount";
            this.unmountMenuItem.DropDownClosed += new System.EventHandler(this.unmountMenuItem_DropDownClosed);
            this.unmountMenuItem.DropDownOpening += new System.EventHandler(this.unmountMenuItem_DropDownOpening);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(131, 6);
            // 
            // startupMenuItem
            // 
            this.startupMenuItem.AutoSize = false;
            this.startupMenuItem.CheckOnClick = true;
            this.startupMenuItem.Name = "startupMenuItem";
            this.startupMenuItem.Size = new System.Drawing.Size(134, 22);
            this.startupMenuItem.Text = "Run at startup";
            this.startupMenuItem.CheckedChanged += new System.EventHandler(this.startupMenuItem_CheckedChanged);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.AutoSize = false;
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(134, 22);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.AutoSize = false;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 621);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.fieldsPanel.ResumeLayout(false);
            this.fieldsPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keepAliveIntervalBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portBox)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ListView driveListView;
        private System.Windows.Forms.TableLayoutPanel fieldsPanel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hostBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown portBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.ComboBox authCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox letterBox;
        private System.Windows.Forms.CheckBox mountCheck;
        private System.Windows.Forms.ComboBox directoryBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStripMenuItem startupMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem showMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mountMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unmountMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mountPointBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox proxyType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox proxyHostBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox proxyPassBox;
        private System.Windows.Forms.TextBox proxyLoginBox;
        private System.Windows.Forms.Label labelKeepAlive;
        private System.Windows.Forms.NumericUpDown keepAliveIntervalBox;
        private System.Windows.Forms.Label authLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox privateKeyBox;
        private System.Windows.Forms.Button privateKeyButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox passphraseBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button muButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label14;
    }
}