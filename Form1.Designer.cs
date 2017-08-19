using System;

namespace SetThisUp
{
    partial class Form1
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.firstStep = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.logs = new System.Windows.Forms.Label();
            this.dutstate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkDriver = new System.Windows.Forms.CheckBox();
            this.checkImage = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imageBurn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ip_address = new System.Windows.Forms.TextBox();
            this.setup = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.provision = new System.Windows.Forms.CheckBox();
            this.errorMsg3 = new System.Windows.Forms.Label();
            this.errorMsg2 = new System.Windows.Forms.Label();
            this.errorMsg = new System.Windows.Forms.Label();
            this.saveSettings = new System.Windows.Forms.Button();
            this.me_pass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.me_name = new System.Windows.Forms.TextBox();
            this.platform_userpass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.platform_username = new System.Windows.Forms.TextBox();
            this.ppolicy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sku = new System.Windows.Forms.ComboBox();
            this.platformType = new System.Windows.Forms.ComboBox();
            this.platform = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dutIP = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.testflow = new System.Windows.Forms.CheckBox();
            this.twoLevel = new System.Windows.Forms.CheckBox();
            this.firstLevel = new System.Windows.Forms.CheckBox();
            this.runall = new System.Windows.Forms.Button();
            this.itrs = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.run_script = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.table_ressults = new System.Windows.Forms.TableLayoutPanel();
            this.exitbutton = new System.Windows.Forms.Button();
            this.pint_dut = new System.Windows.Forms.Button();
            this.firstStep.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "AC/DC";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(106, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "G3";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // firstStep
            // 
            this.firstStep.Controls.Add(this.tabPage1);
            this.firstStep.Controls.Add(this.tabPage2);
            this.firstStep.Controls.Add(this.tabPage3);
            this.firstStep.Controls.Add(this.tabPage4);
            this.firstStep.Location = new System.Drawing.Point(3, 47);
            this.firstStep.Name = "firstStep";
            this.firstStep.SelectedIndex = 0;
            this.firstStep.Size = new System.Drawing.Size(415, 407);
            this.firstStep.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.logs);
            this.tabPage1.Controls.Add(this.dutstate);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.checkDriver);
            this.tabPage1.Controls.Add(this.checkImage);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.imageBurn);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.ip_address);
            this.tabPage1.Controls.Add(this.setup);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(407, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "First Level";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // logs
            // 
            this.logs.AutoSize = true;
            this.logs.Location = new System.Drawing.Point(43, 255);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(26, 13);
            this.logs.TabIndex = 22;
            this.logs.Text = "logs";
            // 
            // dutstate
            // 
            this.dutstate.AutoSize = true;
            this.dutstate.Location = new System.Drawing.Point(198, 25);
            this.dutstate.Name = "dutstate";
            this.dutstate.Size = new System.Drawing.Size(35, 13);
            this.dutstate.TabIndex = 21;
            this.dutstate.Text = "label9";
            this.dutstate.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(43, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Note: Need IP in hostConfig ";
            // 
            // checkDriver
            // 
            this.checkDriver.AutoSize = true;
            this.checkDriver.Location = new System.Drawing.Point(6, 167);
            this.checkDriver.Name = "checkDriver";
            this.checkDriver.Size = new System.Drawing.Size(15, 14);
            this.checkDriver.TabIndex = 19;
            this.checkDriver.UseVisualStyleBackColor = true;
            // 
            // checkImage
            // 
            this.checkImage.AutoSize = true;
            this.checkImage.Location = new System.Drawing.Point(5, 74);
            this.checkImage.Name = "checkImage";
            this.checkImage.Size = new System.Drawing.Size(15, 14);
            this.checkImage.TabIndex = 18;
            this.checkImage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(44, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 26);
            this.textBox1.TabIndex = 16;
            // 
            // imageBurn
            // 
            this.imageBurn.Location = new System.Drawing.Point(201, 67);
            this.imageBurn.Name = "imageBurn";
            this.imageBurn.Size = new System.Drawing.Size(96, 27);
            this.imageBurn.TabIndex = 15;
            this.imageBurn.Text = "Browse Image";
            this.imageBurn.UseVisualStyleBackColor = true;
            this.imageBurn.Click += new System.EventHandler(this.imageBurn_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Browse DriverMe";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ip_address
            // 
            this.ip_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ip_address.Location = new System.Drawing.Point(44, 159);
            this.ip_address.Name = "ip_address";
            this.ip_address.Size = new System.Drawing.Size(127, 26);
            this.ip_address.TabIndex = 11;
            // 
            // setup
            // 
            this.setup.Location = new System.Drawing.Point(201, 243);
            this.setup.Name = "setup";
            this.setup.Size = new System.Drawing.Size(96, 25);
            this.setup.TabIndex = 10;
            this.setup.Text = "Setup";
            this.setup.UseVisualStyleBackColor = true;
            this.setup.Click += new System.EventHandler(this.setup_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.provision);
            this.tabPage2.Controls.Add(this.errorMsg3);
            this.tabPage2.Controls.Add(this.errorMsg2);
            this.tabPage2.Controls.Add(this.errorMsg);
            this.tabPage2.Controls.Add(this.saveSettings);
            this.tabPage2.Controls.Add(this.me_pass);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.me_name);
            this.tabPage2.Controls.Add(this.platform_userpass);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.platform_username);
            this.tabPage2.Controls.Add(this.ppolicy);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.sku);
            this.tabPage2.Controls.Add(this.platformType);
            this.tabPage2.Controls.Add(this.platform);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dutIP);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(407, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Host Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // provision
            // 
            this.provision.AutoSize = true;
            this.provision.Location = new System.Drawing.Point(19, 306);
            this.provision.Name = "provision";
            this.provision.Size = new System.Drawing.Size(69, 17);
            this.provision.TabIndex = 36;
            this.provision.Text = "Provision";
            this.provision.UseVisualStyleBackColor = true;
            // 
            // errorMsg3
            // 
            this.errorMsg3.AutoSize = true;
            this.errorMsg3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.errorMsg3.ForeColor = System.Drawing.Color.Firebrick;
            this.errorMsg3.Location = new System.Drawing.Point(16, 96);
            this.errorMsg3.Name = "errorMsg3";
            this.errorMsg3.Size = new System.Drawing.Size(48, 13);
            this.errorMsg3.TabIndex = 35;
            this.errorMsg3.Text = "errorMsg";
            this.errorMsg3.Visible = false;
            // 
            // errorMsg2
            // 
            this.errorMsg2.AutoSize = true;
            this.errorMsg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.errorMsg2.ForeColor = System.Drawing.Color.Firebrick;
            this.errorMsg2.Location = new System.Drawing.Point(14, 168);
            this.errorMsg2.Name = "errorMsg2";
            this.errorMsg2.Size = new System.Drawing.Size(48, 13);
            this.errorMsg2.TabIndex = 34;
            this.errorMsg2.Text = "errorMsg";
            this.errorMsg2.Visible = false;
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.errorMsg.ForeColor = System.Drawing.Color.Firebrick;
            this.errorMsg.Location = new System.Drawing.Point(16, 31);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(48, 13);
            this.errorMsg.TabIndex = 33;
            this.errorMsg.Text = "errorMsg";
            this.errorMsg.Visible = false;
            // 
            // saveSettings
            // 
            this.saveSettings.BackColor = System.Drawing.SystemColors.WindowText;
            this.saveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.saveSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveSettings.Location = new System.Drawing.Point(290, 346);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(65, 29);
            this.saveSettings.TabIndex = 32;
            this.saveSettings.Text = "Save";
            this.saveSettings.UseVisualStyleBackColor = false;
            this.saveSettings.Click += new System.EventHandler(this.saveSettings_Click);
            // 
            // me_pass
            // 
            this.me_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.me_pass.Location = new System.Drawing.Point(228, 275);
            this.me_pass.Name = "me_pass";
            this.me_pass.Size = new System.Drawing.Size(127, 24);
            this.me_pass.TabIndex = 31;
            this.me_pass.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(224, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 30;
            this.label8.Text = "ME Account";
            // 
            // me_name
            // 
            this.me_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.me_name.Location = new System.Drawing.Point(228, 245);
            this.me_name.Name = "me_name";
            this.me_name.Size = new System.Drawing.Size(127, 24);
            this.me_name.TabIndex = 29;
            this.me_name.Text = "UserName";
            // 
            // platform_userpass
            // 
            this.platform_userpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.platform_userpass.Location = new System.Drawing.Point(227, 180);
            this.platform_userpass.Name = "platform_userpass";
            this.platform_userpass.Size = new System.Drawing.Size(127, 24);
            this.platform_userpass.TabIndex = 28;
            this.platform_userpass.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(223, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Platform Account";
            // 
            // platform_username
            // 
            this.platform_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.platform_username.Location = new System.Drawing.Point(227, 150);
            this.platform_username.Name = "platform_username";
            this.platform_username.Size = new System.Drawing.Size(127, 24);
            this.platform_username.TabIndex = 26;
            this.platform_username.Text = "UserName";
            // 
            // ppolicy
            // 
            this.ppolicy.AllowDrop = true;
            this.ppolicy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ppolicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ppolicy.FormattingEnabled = true;
            this.ppolicy.Items.AddRange(new object[] {
            "None",
            "PowerPolicy1",
            "PowerPolicy2"});
            this.ppolicy.Location = new System.Drawing.Point(226, 78);
            this.ppolicy.Name = "ppolicy";
            this.ppolicy.Size = new System.Drawing.Size(128, 26);
            this.ppolicy.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(223, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Power Policy";
            // 
            // sku
            // 
            this.sku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sku.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sku.FormattingEnabled = true;
            this.sku.Items.AddRange(new object[] {
            "None",
            "Consumer",
            "Corporate"});
            this.sku.Location = new System.Drawing.Point(19, 273);
            this.sku.Name = "sku";
            this.sku.Size = new System.Drawing.Size(127, 26);
            this.sku.TabIndex = 23;
            this.sku.SelectedIndexChanged += new System.EventHandler(this.sku_SelectedIndexChanged);
            // 
            // platformType
            // 
            this.platformType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.platformType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.platformType.FormattingEnabled = true;
            this.platformType.Items.AddRange(new object[] {
            "None",
            "Mobile",
            "Desktop"});
            this.platformType.Location = new System.Drawing.Point(18, 202);
            this.platformType.Name = "platformType";
            this.platformType.Size = new System.Drawing.Size(127, 26);
            this.platformType.TabIndex = 22;
            // 
            // platform
            // 
            this.platform.AllowDrop = true;
            this.platform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.platform.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.platform.FormattingEnabled = true;
            this.platform.Items.AddRange(new object[] {
            "None",
            "KabyLake",
            "CanonLake",
            "IceLake"});
            this.platform.Location = new System.Drawing.Point(17, 130);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(128, 26);
            this.platform.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(15, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "SKU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(14, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Platform Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Platform";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Machine IP";
            // 
            // dutIP
            // 
            this.dutIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dutIP.Location = new System.Drawing.Point(19, 65);
            this.dutIP.Name = "dutIP";
            this.dutIP.Size = new System.Drawing.Size(127, 24);
            this.dutIP.TabIndex = 13;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.testflow);
            this.tabPage3.Controls.Add(this.twoLevel);
            this.tabPage3.Controls.Add(this.firstLevel);
            this.tabPage3.Controls.Add(this.runall);
            this.tabPage3.Controls.Add(this.itrs);
            this.tabPage3.Controls.Add(this.numericUpDown1);
            this.tabPage3.Controls.Add(this.run_script);
            this.tabPage3.Controls.Add(this.treeView1);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(407, 381);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TestFlow";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // testflow
            // 
            this.testflow.AutoSize = true;
            this.testflow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.testflow.Location = new System.Drawing.Point(196, 346);
            this.testflow.Name = "testflow";
            this.testflow.Size = new System.Drawing.Size(72, 17);
            this.testflow.TabIndex = 7;
            this.testflow.Text = "Test Flow";
            this.testflow.UseVisualStyleBackColor = true;
            // 
            // twoLevel
            // 
            this.twoLevel.AutoSize = true;
            this.twoLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.twoLevel.Location = new System.Drawing.Point(93, 346);
            this.twoLevel.Name = "twoLevel";
            this.twoLevel.Size = new System.Drawing.Size(81, 17);
            this.twoLevel.TabIndex = 6;
            this.twoLevel.Text = "Host Config";
            this.twoLevel.UseVisualStyleBackColor = true;
            // 
            // firstLevel
            // 
            this.firstLevel.AutoSize = true;
            this.firstLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.firstLevel.Location = new System.Drawing.Point(12, 346);
            this.firstLevel.Name = "firstLevel";
            this.firstLevel.Size = new System.Drawing.Size(71, 17);
            this.firstLevel.TabIndex = 5;
            this.firstLevel.Text = "FirstLevel";
            this.firstLevel.UseVisualStyleBackColor = true;
            // 
            // runall
            // 
            this.runall.BackColor = System.Drawing.Color.Gray;
            this.runall.ForeColor = System.Drawing.Color.Yellow;
            this.runall.Location = new System.Drawing.Point(291, 346);
            this.runall.Name = "runall";
            this.runall.Size = new System.Drawing.Size(78, 29);
            this.runall.TabIndex = 4;
            this.runall.Text = "RUN ALL";
            this.runall.UseVisualStyleBackColor = false;
            this.runall.Click += new System.EventHandler(this.runall_Click);
            // 
            // itrs
            // 
            this.itrs.AutoSize = true;
            this.itrs.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itrs.Location = new System.Drawing.Point(15, 281);
            this.itrs.Name = "itrs";
            this.itrs.Size = new System.Drawing.Size(54, 19);
            this.itrs.TabIndex = 3;
            this.itrs.Text = "Iteration";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(93, 281);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // run_script
            // 
            this.run_script.BackColor = System.Drawing.Color.Gray;
            this.run_script.ForeColor = System.Drawing.Color.Yellow;
            this.run_script.Location = new System.Drawing.Point(291, 281);
            this.run_script.Name = "run_script";
            this.run_script.Size = new System.Drawing.Size(78, 29);
            this.run_script.TabIndex = 1;
            this.run_script.Text = "RUN";
            this.run_script.UseVisualStyleBackColor = false;
            this.run_script.Click += new System.EventHandler(this.run_script_Click);
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(18, 22);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(351, 252);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck_1);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.table_ressults);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(407, 381);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // table_ressults
            // 
            this.table_ressults.ColumnCount = 3;
            this.table_ressults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_ressults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_ressults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.table_ressults.Location = new System.Drawing.Point(33, 45);
            this.table_ressults.Name = "table_ressults";
            this.table_ressults.RowCount = 2;
            this.table_ressults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_ressults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_ressults.Size = new System.Drawing.Size(200, 100);
            this.table_ressults.TabIndex = 0;
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(12, 460);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(96, 25);
            this.exitbutton.TabIndex = 14;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click_1);
            // 
            // pint_dut
            // 
            this.pint_dut.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pint_dut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pint_dut.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pint_dut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pint_dut.Location = new System.Drawing.Point(12, 3);
            this.pint_dut.Name = "pint_dut";
            this.pint_dut.Size = new System.Drawing.Size(57, 38);
            this.pint_dut.TabIndex = 13;
            this.pint_dut.Text = "Ping";
            this.pint_dut.UseVisualStyleBackColor = false;
            this.pint_dut.Click += new System.EventHandler(this.pint_dut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 501);
            this.Controls.Add(this.pint_dut);
            this.Controls.Add(this.firstStep);
            this.Controls.Add(this.exitbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SetAndRun";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.firstStep.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl firstStep;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button imageBurn;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ip_address;
        private System.Windows.Forms.Button setup;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dutIP;
        private System.Windows.Forms.ComboBox platform;
        private System.Windows.Forms.ComboBox platformType;
        private System.Windows.Forms.ComboBox sku;
        private System.Windows.Forms.ComboBox ppolicy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox platform_username;
        private System.Windows.Forms.TextBox me_pass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox me_name;
        private System.Windows.Forms.TextBox platform_userpass;
        private System.Windows.Forms.Button pint_dut;
        private System.Windows.Forms.Button saveSettings;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button run_script;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.Label errorMsg2;
        private System.Windows.Forms.Label errorMsg3;
        private System.Windows.Forms.CheckBox checkDriver;
        private System.Windows.Forms.CheckBox checkImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox provision;
        private System.Windows.Forms.Label itrs;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label dutstate;
        private System.Windows.Forms.Button runall;
        private System.Windows.Forms.CheckBox testflow;
        private System.Windows.Forms.CheckBox twoLevel;
        private System.Windows.Forms.CheckBox firstLevel;
        private System.Windows.Forms.Label logs;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel table_ressults;
    }
}

