namespace HotelReservationSystem.Forms
{
    partial class MainViewForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bathroomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservedRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.adultsNumTextBox = new System.Windows.Forms.TextBox();
            this.childNumTextBox = new System.Windows.Forms.TextBox();
            this.reservationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.makeReservationButton = new System.Windows.Forms.Button();
            this.roomReferenceDataGridView = new System.Windows.Forms.DataGridView();
            this.referenceStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.referenceEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            this.roomCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bathroomCheckBox = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.reservationIDComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.roomResEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.roomResStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.roomNumberComboBox = new System.Windows.Forms.ComboBox();
            this.reservationEGNTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.noteRichTextBox = new System.Windows.Forms.RichTextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.infoLabel2 = new System.Windows.Forms.Label();
            this.reserveRoomButton = new System.Windows.Forms.Button();
            this.checkEGNButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomReferenceDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.manageDataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // manageDataToolStripMenuItem
            // 
            this.manageDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bathroomToolStripMenuItem,
            this.cityToolStripMenuItem,
            this.roomCategoryToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.guestToolStripMenuItem,
            this.reservationToolStripMenuItem,
            this.reservedRoomToolStripMenuItem,
            this.roomToolStripMenuItem,
            this.userToolStripMenuItem});
            this.manageDataToolStripMenuItem.Name = "manageDataToolStripMenuItem";
            this.manageDataToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.manageDataToolStripMenuItem.Text = "Manage data";
            // 
            // bathroomToolStripMenuItem
            // 
            this.bathroomToolStripMenuItem.Name = "bathroomToolStripMenuItem";
            this.bathroomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bathroomToolStripMenuItem.Text = "Bathroom";
            this.bathroomToolStripMenuItem.Click += new System.EventHandler(this.bathroomToolStripMenuItem_Click);
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cityToolStripMenuItem.Text = "City";
            this.cityToolStripMenuItem.Click += new System.EventHandler(this.cityToolStripMenuItem_Click);
            // 
            // roomCategoryToolStripMenuItem
            // 
            this.roomCategoryToolStripMenuItem.Name = "roomCategoryToolStripMenuItem";
            this.roomCategoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.roomCategoryToolStripMenuItem.Text = "Room Category";
            this.roomCategoryToolStripMenuItem.Click += new System.EventHandler(this.roomCategoryToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // guestToolStripMenuItem
            // 
            this.guestToolStripMenuItem.Name = "guestToolStripMenuItem";
            this.guestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guestToolStripMenuItem.Text = "Guest";
            this.guestToolStripMenuItem.Click += new System.EventHandler(this.guestToolStripMenuItem_Click);
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reservationToolStripMenuItem.Text = "Reservation";
            this.reservationToolStripMenuItem.Click += new System.EventHandler(this.reservationToolStripMenuItem_Click);
            // 
            // reservedRoomToolStripMenuItem
            // 
            this.reservedRoomToolStripMenuItem.Name = "reservedRoomToolStripMenuItem";
            this.reservedRoomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reservedRoomToolStripMenuItem.Text = "ReservedRoom";
            this.reservedRoomToolStripMenuItem.Click += new System.EventHandler(this.reservedRoomToolStripMenuItem_Click);
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.roomToolStripMenuItem.Text = "Room";
            this.roomToolStripMenuItem.Click += new System.EventHandler(this.roomToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make reservation";
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(115, 159);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(171, 21);
            this.cityComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "EGN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Employee";
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(115, 238);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(171, 21);
            this.employeeComboBox.TabIndex = 6;
            // 
            // adultsNumTextBox
            // 
            this.adultsNumTextBox.Location = new System.Drawing.Point(115, 265);
            this.adultsNumTextBox.Name = "adultsNumTextBox";
            this.adultsNumTextBox.Size = new System.Drawing.Size(171, 20);
            this.adultsNumTextBox.TabIndex = 7;
            // 
            // childNumTextBox
            // 
            this.childNumTextBox.Location = new System.Drawing.Point(115, 291);
            this.childNumTextBox.Name = "childNumTextBox";
            this.childNumTextBox.Size = new System.Drawing.Size(171, 20);
            this.childNumTextBox.TabIndex = 8;
            // 
            // reservationDateTimePicker
            // 
            this.reservationDateTimePicker.Location = new System.Drawing.Point(115, 317);
            this.reservationDateTimePicker.Name = "reservationDateTimePicker";
            this.reservationDateTimePicker.Size = new System.Drawing.Size(171, 20);
            this.reservationDateTimePicker.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adults";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Children";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(15, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Reservation date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(17, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Note";
            // 
            // makeReservationButton
            // 
            this.makeReservationButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.makeReservationButton.Location = new System.Drawing.Point(113, 419);
            this.makeReservationButton.Name = "makeReservationButton";
            this.makeReservationButton.Size = new System.Drawing.Size(173, 23);
            this.makeReservationButton.TabIndex = 15;
            this.makeReservationButton.Text = "Make reservation";
            this.makeReservationButton.UseVisualStyleBackColor = true;
            this.makeReservationButton.Click += new System.EventHandler(this.makeReservationButton_Click);
            // 
            // roomReferenceDataGridView
            // 
            this.roomReferenceDataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.roomReferenceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomReferenceDataGridView.Location = new System.Drawing.Point(338, 199);
            this.roomReferenceDataGridView.Name = "roomReferenceDataGridView";
            this.roomReferenceDataGridView.Size = new System.Drawing.Size(341, 243);
            this.roomReferenceDataGridView.TabIndex = 16;
            // 
            // referenceStartDateTimePicker
            // 
            this.referenceStartDateTimePicker.Location = new System.Drawing.Point(486, 90);
            this.referenceStartDateTimePicker.Name = "referenceStartDateTimePicker";
            this.referenceStartDateTimePicker.Size = new System.Drawing.Size(193, 20);
            this.referenceStartDateTimePicker.TabIndex = 17;
            this.referenceStartDateTimePicker.ValueChanged += new System.EventHandler(this.referenceStartDateTimePicker_ValueChanged);
            // 
            // referenceEndDateTimePicker
            // 
            this.referenceEndDateTimePicker.Location = new System.Drawing.Point(486, 116);
            this.referenceEndDateTimePicker.Name = "referenceEndDateTimePicker";
            this.referenceEndDateTimePicker.Size = new System.Drawing.Size(193, 20);
            this.referenceEndDateTimePicker.TabIndex = 18;
            this.referenceEndDateTimePicker.ValueChanged += new System.EventHandler(this.referenceEndDateTimePicker_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(335, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Start date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(335, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "End date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(332, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(347, 37);
            this.label11.TabIndex = 21;
            this.label11.Text = "Check free rooms for period";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // roomCategoryComboBox
            // 
            this.roomCategoryComboBox.FormattingEnabled = true;
            this.roomCategoryComboBox.Location = new System.Drawing.Point(486, 141);
            this.roomCategoryComboBox.Name = "roomCategoryComboBox";
            this.roomCategoryComboBox.Size = new System.Drawing.Size(193, 21);
            this.roomCategoryComboBox.TabIndex = 23;
            this.roomCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.roomCategoryComboBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(335, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Room Category";
            // 
            // bathroomCheckBox
            // 
            this.bathroomCheckBox.AutoSize = true;
            this.bathroomCheckBox.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bathroomCheckBox.Location = new System.Drawing.Point(486, 168);
            this.bathroomCheckBox.Name = "bathroomCheckBox";
            this.bathroomCheckBox.Size = new System.Drawing.Size(66, 17);
            this.bathroomCheckBox.TabIndex = 25;
            this.bathroomCheckBox.Text = "is single";
            this.bathroomCheckBox.UseVisualStyleBackColor = true;
            this.bathroomCheckBox.CheckedChanged += new System.EventHandler(this.bathroomCheckBox_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(335, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Bathroom";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(15, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 37);
            this.label14.TabIndex = 27;
            this.label14.Text = "Reserve room\r\n";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(19, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Reservation ID";
            // 
            // reservationIDComboBox
            // 
            this.reservationIDComboBox.FormattingEnabled = true;
            this.reservationIDComboBox.Location = new System.Drawing.Point(807, 168);
            this.reservationIDComboBox.Name = "reservationIDComboBox";
            this.reservationIDComboBox.Size = new System.Drawing.Size(171, 21);
            this.reservationIDComboBox.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(19, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "End date";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(19, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Start date";
            // 
            // roomResEndDateTimePicker
            // 
            this.roomResEndDateTimePicker.Location = new System.Drawing.Point(807, 115);
            this.roomResEndDateTimePicker.Name = "roomResEndDateTimePicker";
            this.roomResEndDateTimePicker.Size = new System.Drawing.Size(171, 20);
            this.roomResEndDateTimePicker.TabIndex = 31;
            // 
            // roomResStartDateTimePicker
            // 
            this.roomResStartDateTimePicker.Location = new System.Drawing.Point(807, 89);
            this.roomResStartDateTimePicker.Name = "roomResStartDateTimePicker";
            this.roomResStartDateTimePicker.Size = new System.Drawing.Size(171, 20);
            this.roomResStartDateTimePicker.TabIndex = 30;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(19, 168);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Room number";
            // 
            // roomNumberComboBox
            // 
            this.roomNumberComboBox.FormattingEnabled = true;
            this.roomNumberComboBox.Location = new System.Drawing.Point(807, 141);
            this.roomNumberComboBox.Name = "roomNumberComboBox";
            this.roomNumberComboBox.Size = new System.Drawing.Size(171, 21);
            this.roomNumberComboBox.TabIndex = 34;
            // 
            // reservationEGNTextBox
            // 
            this.reservationEGNTextBox.Location = new System.Drawing.Point(115, 109);
            this.reservationEGNTextBox.Name = "reservationEGNTextBox";
            this.reservationEGNTextBox.Size = new System.Drawing.Size(171, 20);
            this.reservationEGNTextBox.TabIndex = 37;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(115, 186);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(171, 20);
            this.addressTextBox.TabIndex = 38;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(115, 133);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(171, 20);
            this.nameTextBox.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(12, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "Name";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(15, 160);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 13);
            this.label20.TabIndex = 41;
            this.label20.Text = "City";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(115, 212);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(171, 20);
            this.phoneTextBox.TabIndex = 42;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(15, 213);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 13);
            this.label21.TabIndex = 43;
            this.label21.Text = "Mobile number";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(15, 187);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 13);
            this.label22.TabIndex = 44;
            this.label22.Text = "Address";
            // 
            // noteRichTextBox
            // 
            this.noteRichTextBox.Location = new System.Drawing.Point(115, 343);
            this.noteRichTextBox.Name = "noteRichTextBox";
            this.noteRichTextBox.Size = new System.Drawing.Size(171, 69);
            this.noteRichTextBox.TabIndex = 45;
            this.noteRichTextBox.Text = "";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.ForeColor = System.Drawing.Color.Red;
            this.infoLabel.Location = new System.Drawing.Point(17, 449);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 46;
            // 
            // infoLabel2
            // 
            this.infoLabel2.AutoSize = true;
            this.infoLabel2.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel2.ForeColor = System.Drawing.Color.Red;
            this.infoLabel2.Location = new System.Drawing.Point(715, 229);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(0, 40);
            this.infoLabel2.TabIndex = 47;
            // 
            // reserveRoomButton
            // 
            this.reserveRoomButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reserveRoomButton.Location = new System.Drawing.Point(107, 202);
            this.reserveRoomButton.Name = "reserveRoomButton";
            this.reserveRoomButton.Size = new System.Drawing.Size(173, 23);
            this.reserveRoomButton.TabIndex = 48;
            this.reserveRoomButton.Text = "Reserve room";
            this.reserveRoomButton.UseVisualStyleBackColor = true;
            this.reserveRoomButton.Click += new System.EventHandler(this.reserveRoomButton_Click);
            // 
            // checkEGNButton
            // 
            this.checkEGNButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkEGNButton.Location = new System.Drawing.Point(199, 86);
            this.checkEGNButton.Name = "checkEGNButton";
            this.checkEGNButton.Size = new System.Drawing.Size(87, 20);
            this.checkEGNButton.TabIndex = 49;
            this.checkEGNButton.Text = "Check EGN";
            this.checkEGNButton.UseVisualStyleBackColor = true;
            this.checkEGNButton.Click += new System.EventHandler(this.checkEGNButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(107, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "OPEN GUEST VIEW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.reserveRoomButton);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(700, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 495);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox2.Controls.Add(this.checkEGNButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.makeReservationButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 495);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // MainViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 487);
            this.Controls.Add(this.infoLabel2);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.noteRichTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.reservationEGNTextBox);
            this.Controls.Add(this.roomNumberComboBox);
            this.Controls.Add(this.roomResEndDateTimePicker);
            this.Controls.Add(this.roomResStartDateTimePicker);
            this.Controls.Add(this.reservationIDComboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bathroomCheckBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.roomCategoryComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.referenceEndDateTimePicker);
            this.Controls.Add(this.referenceStartDateTimePicker);
            this.Controls.Add(this.roomReferenceDataGridView);
            this.Controls.Add(this.reservationDateTimePicker);
            this.Controls.Add(this.childNumTextBox);
            this.Controls.Add(this.adultsNumTextBox);
            this.Controls.Add(this.employeeComboBox);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainViewForm";
            this.Text = "MainViewForm";
            this.Load += new System.EventHandler(this.MainViewForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomReferenceDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bathroomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservedRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.TextBox adultsNumTextBox;
        private System.Windows.Forms.TextBox childNumTextBox;
        private System.Windows.Forms.DateTimePicker reservationDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button makeReservationButton;
        private System.Windows.Forms.DataGridView roomReferenceDataGridView;
        private System.Windows.Forms.DateTimePicker referenceStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker referenceEndDateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private System.Windows.Forms.ComboBox roomCategoryComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox bathroomCheckBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox reservationIDComboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker roomResEndDateTimePicker;
        private System.Windows.Forms.DateTimePicker roomResStartDateTimePicker;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox roomNumberComboBox;
        private System.Windows.Forms.TextBox reservationEGNTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RichTextBox noteRichTextBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label infoLabel2;
        private System.Windows.Forms.Button reserveRoomButton;
        private System.Windows.Forms.Button checkEGNButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}