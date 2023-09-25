namespace KrediKartiMimari
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBankamatik = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKKPlatinium = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKKGold = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKKSilver = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDosya});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDosya
            // 
            this.mnuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.mnuYeni,
            this.toolStripMenuItem1,
            this.mnuCikis});
            this.mnuDosya.Name = "mnuDosya";
            this.mnuDosya.Size = new System.Drawing.Size(78, 29);
            this.mnuDosya.Text = "Dosya";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // mnuYeni
            // 
            this.mnuYeni.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKart});
            this.mnuYeni.Name = "mnuYeni";
            this.mnuYeni.Size = new System.Drawing.Size(270, 34);
            this.mnuYeni.Text = "Yeni";
            // 
            // mnuKart
            // 
            this.mnuKart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBankamatik,
            this.mnuKKPlatinium,
            this.mnuKKGold,
            this.mnuKKSilver});
            this.mnuKart.Name = "mnuKart";
            this.mnuKart.Size = new System.Drawing.Size(270, 34);
            this.mnuKart.Text = "Kart";
            // 
            // mnuBankamatik
            // 
            this.mnuBankamatik.Name = "mnuBankamatik";
            this.mnuBankamatik.Size = new System.Drawing.Size(282, 34);
            this.mnuBankamatik.Text = "Bankamatik";
            this.mnuBankamatik.Click += new System.EventHandler(this.mnuBankamatik_Click);
            // 
            // mnuKKPlatinium
            // 
            this.mnuKKPlatinium.Name = "mnuKKPlatinium";
            this.mnuKKPlatinium.Size = new System.Drawing.Size(282, 34);
            this.mnuKKPlatinium.Text = "Kredi Kartı (Platinium)";
            this.mnuKKPlatinium.Click += new System.EventHandler(this.mnuKKPlatinium_Click);
            // 
            // mnuKKGold
            // 
            this.mnuKKGold.Name = "mnuKKGold";
            this.mnuKKGold.Size = new System.Drawing.Size(282, 34);
            this.mnuKKGold.Text = "Kredi Kartı (Gold)";
            this.mnuKKGold.Click += new System.EventHandler(this.mnuKKGold_Click);
            // 
            // mnuKKSilver
            // 
            this.mnuKKSilver.Name = "mnuKKSilver";
            this.mnuKKSilver.Size = new System.Drawing.Size(282, 34);
            this.mnuKKSilver.Text = "Kredi Kartı (Silver)";
            this.mnuKKSilver.Click += new System.EventHandler(this.mnuKKSilver_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(267, 6);
            // 
            // mnuCikis
            // 
            this.mnuCikis.Name = "mnuCikis";
            this.mnuCikis.Size = new System.Drawing.Size(270, 34);
            this.mnuCikis.Text = "Çıkış";
            this.mnuCikis.Click += new System.EventHandler(this.mnuCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 229);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kredi Kartı Nesnel Mimari Tasarım Geliştirme";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDosya;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuYeni;
        private System.Windows.Forms.ToolStripMenuItem mnuKart;
        private System.Windows.Forms.ToolStripMenuItem mnuBankamatik;
        private System.Windows.Forms.ToolStripMenuItem mnuKKPlatinium;
        private System.Windows.Forms.ToolStripMenuItem mnuKKGold;
        private System.Windows.Forms.ToolStripMenuItem mnuKKSilver;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuCikis;
    }
}

