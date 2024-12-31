namespace AnimalerieProjet
{
    partial class dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.commandeBtn = new FontAwesome.Sharp.IconButton();
            this.logoutbtn = new FontAwesome.Sharp.IconButton();
            this.clientsBtn = new FontAwesome.Sharp.IconButton();
            this.produitBtn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashTitle = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.commandeBtn);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.clientsBtn);
            this.panel1.Controls.Add(this.produitBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.MaximumSize = new System.Drawing.Size(300, 754);
            this.panel1.MinimumSize = new System.Drawing.Size(300, 754);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 754);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // commandeBtn
            // 
            this.commandeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.commandeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.commandeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commandeBtn.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandeBtn.ForeColor = System.Drawing.Color.DarkMagenta;
            this.commandeBtn.IconChar = FontAwesome.Sharp.IconChar.TruckRampBox;
            this.commandeBtn.IconColor = System.Drawing.Color.LavenderBlush;
            this.commandeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.commandeBtn.IconSize = 45;
            this.commandeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.commandeBtn.Location = new System.Drawing.Point(0, 250);
            this.commandeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commandeBtn.Name = "commandeBtn";
            this.commandeBtn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.commandeBtn.Size = new System.Drawing.Size(296, 60);
            this.commandeBtn.TabIndex = 9;
            this.commandeBtn.Text = "Commandes";
            this.commandeBtn.UseVisualStyleBackColor = true;
            this.commandeBtn.Click += new System.EventHandler(this.commandeBtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutbtn.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.Color.DarkMagenta;
            this.logoutbtn.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.logoutbtn.IconColor = System.Drawing.Color.LavenderBlush;
            this.logoutbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutbtn.IconSize = 45;
            this.logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutbtn.Location = new System.Drawing.Point(0, 690);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.logoutbtn.Size = new System.Drawing.Size(296, 60);
            this.logoutbtn.TabIndex = 8;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // clientsBtn
            // 
            this.clientsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.clientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsBtn.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsBtn.ForeColor = System.Drawing.Color.DarkMagenta;
            this.clientsBtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.clientsBtn.IconColor = System.Drawing.Color.LavenderBlush;
            this.clientsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clientsBtn.IconSize = 45;
            this.clientsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientsBtn.Location = new System.Drawing.Point(0, 190);
            this.clientsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientsBtn.Name = "clientsBtn";
            this.clientsBtn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.clientsBtn.Size = new System.Drawing.Size(296, 60);
            this.clientsBtn.TabIndex = 6;
            this.clientsBtn.Text = "Clients";
            this.clientsBtn.UseVisualStyleBackColor = true;
            this.clientsBtn.Click += new System.EventHandler(this.clientsBtn_Click_1);
            // 
            // produitBtn
            // 
            this.produitBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.produitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.produitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.produitBtn.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produitBtn.ForeColor = System.Drawing.Color.DarkMagenta;
            this.produitBtn.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.produitBtn.IconColor = System.Drawing.Color.LavenderBlush;
            this.produitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.produitBtn.IconSize = 45;
            this.produitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.produitBtn.Location = new System.Drawing.Point(0, 130);
            this.produitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.produitBtn.Name = "produitBtn";
            this.produitBtn.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.produitBtn.Size = new System.Drawing.Size(296, 60);
            this.produitBtn.TabIndex = 5;
            this.produitBtn.Text = "Produits";
            this.produitBtn.UseVisualStyleBackColor = true;
            this.produitBtn.Click += new System.EventHandler(this.produitBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dashTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 130);
            this.panel2.TabIndex = 4;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // dashTitle
            // 
            this.dashTitle.AutoSize = true;
            this.dashTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashTitle.ForeColor = System.Drawing.Color.DarkMagenta;
            this.dashTitle.Location = new System.Drawing.Point(12, 46);
            this.dashTitle.Name = "dashTitle";
            this.dashTitle.Size = new System.Drawing.Size(275, 37);
            this.dashTitle.TabIndex = 1;
            this.dashTitle.Text = "Admin Dashboard";
            this.dashTitle.Click += new System.EventHandler(this.dashTitle_Click);
            // 
            // bodyPanel
            // 
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(300, 0);
            this.bodyPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1081, 753);
            this.bodyPanel.TabIndex = 2;
            this.bodyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bodyPanel_Paint);
            this.bodyPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bodyPanel_MouseDown);
            this.bodyPanel.MouseEnter += new System.EventHandler(this.bodyPanel_MouseEnter);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1381, 753);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dashTitle;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton produitBtn;
        private FontAwesome.Sharp.IconButton clientsBtn;
        private FontAwesome.Sharp.IconButton logoutbtn;
        private FontAwesome.Sharp.IconButton commandeBtn;
    }
}