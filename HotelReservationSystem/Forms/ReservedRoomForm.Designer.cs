namespace HotelReservationSystem.Forms
{
    partial class ReservedRoomForm
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
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.roomComboBox = new System.Windows.Forms.ComboBox();
            this.reservationComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(439, 144);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(172, 20);
            this.startDateTimePicker.TabIndex = 57;
            // 
            // roomComboBox
            // 
            this.roomComboBox.FormattingEnabled = true;
            this.roomComboBox.Location = new System.Drawing.Point(439, 117);
            this.roomComboBox.Name = "roomComboBox";
            this.roomComboBox.Size = new System.Drawing.Size(172, 21);
            this.roomComboBox.TabIndex = 56;
            // 
            // reservationComboBox
            // 
            this.reservationComboBox.FormattingEnabled = true;
            this.reservationComboBox.Location = new System.Drawing.Point(439, 90);
            this.reservationComboBox.Name = "reservationComboBox";
            this.reservationComboBox.Size = new System.Drawing.Size(172, 21);
            this.reservationComboBox.TabIndex = 55;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(476, 319);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 23);
            this.searchButton.TabIndex = 53;
            this.searchButton.Text = "button1";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(420, 363);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(35, 13);
            this.infoLabel.TabIndex = 52;
            this.infoLabel.Text = "label1";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(476, 290);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 23);
            this.deleteButton.TabIndex = 51;
            this.deleteButton.Text = "button3";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(476, 261);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 23);
            this.editButton.TabIndex = 50;
            this.editButton.Text = "button2";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(476, 232);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(100, 23);
            this.insertButton.TabIndex = 49;
            this.insertButton.Text = "button1";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(378, 372);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(439, 170);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(172, 20);
            this.endDateTimePicker.TabIndex = 58;
            // 
            // ReservedRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.roomComboBox);
            this.Controls.Add(this.reservationComboBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReservedRoomForm";
            this.Text = "ReservedRoomForm";
            this.Load += new System.EventHandler(this.ReservedRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.ComboBox roomComboBox;
        private System.Windows.Forms.ComboBox reservationComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
    }
}