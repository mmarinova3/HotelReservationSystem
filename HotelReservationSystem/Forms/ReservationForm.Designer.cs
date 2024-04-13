namespace HotelReservationSystem.Forms
{
    partial class ReservationForm
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
            this.guestNumberBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.egnComboBox = new System.Windows.Forms.ComboBox();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guestNumberBox
            // 
            this.guestNumberBox.Location = new System.Drawing.Point(428, 170);
            this.guestNumberBox.Name = "guestNumberBox";
            this.guestNumberBox.Size = new System.Drawing.Size(172, 20);
            this.guestNumberBox.TabIndex = 43;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(465, 319);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 23);
            this.searchButton.TabIndex = 41;
            this.searchButton.Text = "button1";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(409, 363);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(35, 13);
            this.infoLabel.TabIndex = 39;
            this.infoLabel.Text = "label1";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(465, 290);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 23);
            this.deleteButton.TabIndex = 38;
            this.deleteButton.Text = "button3";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(465, 261);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 23);
            this.editButton.TabIndex = 37;
            this.editButton.Text = "button2";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(465, 232);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(100, 23);
            this.insertButton.TabIndex = 36;
            this.insertButton.Text = "button1";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(378, 372);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // egnComboBox
            // 
            this.egnComboBox.FormattingEnabled = true;
            this.egnComboBox.Location = new System.Drawing.Point(428, 90);
            this.egnComboBox.Name = "egnComboBox";
            this.egnComboBox.Size = new System.Drawing.Size(172, 21);
            this.egnComboBox.TabIndex = 45;
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(428, 117);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(172, 21);
            this.employeeComboBox.TabIndex = 46;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(428, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.employeeComboBox);
            this.Controls.Add(this.egnComboBox);
            this.Controls.Add(this.guestNumberBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox guestNumberBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox egnComboBox;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}