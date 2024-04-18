namespace HotelReservationSystem.Forms
{
    partial class RoomForm
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
            this.searchButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.bathroomComboBox = new System.Windows.Forms.ComboBox();
            this.roomTextBox = new System.Windows.Forms.TextBox();
            this.floorTextBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(405, 323);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(116, 23);
            this.searchButton.TabIndex = 64;
            this.searchButton.Text = "button1";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(365, 367);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(35, 13);
            this.infoLabel.TabIndex = 63;
            this.infoLabel.Text = "label1";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(405, 294);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(116, 23);
            this.deleteButton.TabIndex = 62;
            this.deleteButton.Text = "button3";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(405, 238);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(116, 23);
            this.insertButton.TabIndex = 60;
            this.insertButton.Text = "button1";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(334, 372);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(368, 148);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(188, 21);
            this.categoryComboBox.TabIndex = 67;
            // 
            // bathroomComboBox
            // 
            this.bathroomComboBox.FormattingEnabled = true;
            this.bathroomComboBox.Location = new System.Drawing.Point(368, 175);
            this.bathroomComboBox.Name = "bathroomComboBox";
            this.bathroomComboBox.Size = new System.Drawing.Size(188, 21);
            this.bathroomComboBox.TabIndex = 68;
            // 
            // roomTextBox
            // 
            this.roomTextBox.Location = new System.Drawing.Point(368, 96);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.Size = new System.Drawing.Size(188, 20);
            this.roomTextBox.TabIndex = 69;
            // 
            // floorTextBox
            // 
            this.floorTextBox.Location = new System.Drawing.Point(368, 122);
            this.floorTextBox.Name = "floorTextBox";
            this.floorTextBox.Size = new System.Drawing.Size(188, 20);
            this.floorTextBox.TabIndex = 70;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(405, 265);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(116, 23);
            this.editButton.TabIndex = 71;
            this.editButton.Text = "button1";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.floorTextBox);
            this.Controls.Add(this.roomTextBox);
            this.Controls.Add(this.bathroomComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox bathroomComboBox;
        private System.Windows.Forms.TextBox roomTextBox;
        private System.Windows.Forms.TextBox floorTextBox;
        private System.Windows.Forms.Button editButton;
    }
}