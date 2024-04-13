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
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bathroomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservedRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.manageDataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(717, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
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
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cityToolStripMenuItem.Text = "City";
            this.cityToolStripMenuItem.Click += new System.EventHandler(this.cityToolStripMenuItem_Click);
            // 
            // bathroomToolStripMenuItem
            // 
            this.bathroomToolStripMenuItem.Name = "bathroomToolStripMenuItem";
            this.bathroomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bathroomToolStripMenuItem.Text = "Bathroom";
            this.bathroomToolStripMenuItem.Click += new System.EventHandler(this.bathroomToolStripMenuItem_Click);
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
            // MainViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 423);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainViewForm";
            this.Text = "MainViewForm";
            this.Load += new System.EventHandler(this.MainViewForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}