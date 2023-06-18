namespace Goodness_Pharmacy
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bill_panel = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dragbillingpage = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bill_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bill_panel
            // 
            this.bill_panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bill_panel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(153)))));
            this.bill_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bill_panel.BackgroundImage")));
            this.bill_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bill_panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(153)))));
            this.bill_panel.BorderRadius = 3;
            this.bill_panel.BorderThickness = 1;
            this.bill_panel.Controls.Add(this.bunifuImageButton1);
            this.bill_panel.Location = new System.Drawing.Point(-2, -1);
            this.bill_panel.Name = "bill_panel";
            this.bill_panel.ShowBorders = true;
            this.bill_panel.Size = new System.Drawing.Size(962, 45);
            this.bill_panel.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ActiveImage")));
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(153)))));
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ImageActive")));
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 20;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(20, 19);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(40, 39);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(908, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 39);
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dragbillingpage
            // 
            this.dragbillingpage.Fixed = true;
            this.dragbillingpage.Horizontal = true;
            this.dragbillingpage.TargetControl = this.bill_panel;
            this.dragbillingpage.Vertical = true;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AllowParentOverrides = false;
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.CursorType = null;
            this.bunifuLabel7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel7.Location = new System.Drawing.Point(4, 183);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(237, 21);
            this.bunifuLabel7.TabIndex = 16;
            this.bunifuLabel7.Text = "goodpharmacy44@gmail.com";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel1.Location = new System.Drawing.Point(5, 213);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(90, 21);
            this.bunifuLabel1.TabIndex = 17;
            this.bunifuLabel1.Text = "0112233333";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel2.Location = new System.Drawing.Point(4, 246);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(118, 21);
            this.bunifuLabel2.TabIndex = 18;
            this.bunifuLabel2.Text = "Colombo ja ela";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel3.Location = new System.Drawing.Point(551, 504);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(98, 21);
            this.bunifuLabel3.TabIndex = 21;
            this.bunifuLabel3.Text = "Grand Total:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel4.Location = new System.Drawing.Point(552, 471);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(72, 21);
            this.bunifuLabel4.TabIndex = 20;
            this.bunifuLabel4.Text = "Discount:";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuLabel5.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel5.Location = new System.Drawing.Point(551, 441);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(43, 21);
            this.bunifuLabel5.TabIndex = 19;
            this.bunifuLabel5.Text = "Total:";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 561);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.bunifuLabel7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bill_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.bill_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuPanel bill_panel;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDragControl dragbillingpage;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
    }
}