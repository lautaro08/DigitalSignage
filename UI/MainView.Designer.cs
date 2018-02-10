namespace UI
{
    partial class MainView
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
            this.operativeViewButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.campaignAdminButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bannerAdminButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.exitButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // operativeViewButton
            // 
            this.operativeViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.operativeViewButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.operativeViewButton.Depth = 0;
            this.operativeViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.operativeViewButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.operativeViewButton.Location = new System.Drawing.Point(143, 111);
            this.operativeViewButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.operativeViewButton.Name = "operativeViewButton";
            this.operativeViewButton.Primary = true;
            this.operativeViewButton.Size = new System.Drawing.Size(644, 40);
            this.operativeViewButton.TabIndex = 0;
            this.operativeViewButton.Text = "abrir ventana publicitaria";
            this.operativeViewButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.operativeViewButton.UseVisualStyleBackColor = true;
            this.operativeViewButton.Click += new System.EventHandler(this.operativeViewButton_Click);
            // 
            // campaignAdminButton
            // 
            this.campaignAdminButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.campaignAdminButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.campaignAdminButton.Depth = 0;
            this.campaignAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.campaignAdminButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.campaignAdminButton.Location = new System.Drawing.Point(143, 171);
            this.campaignAdminButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.campaignAdminButton.Name = "campaignAdminButton";
            this.campaignAdminButton.Primary = true;
            this.campaignAdminButton.Size = new System.Drawing.Size(644, 40);
            this.campaignAdminButton.TabIndex = 1;
            this.campaignAdminButton.Text = "administrador de camapañas";
            this.campaignAdminButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.campaignAdminButton.UseVisualStyleBackColor = true;
            this.campaignAdminButton.Click += new System.EventHandler(this.campaignAdminButton_Click);
            // 
            // bannerAdminButton
            // 
            this.bannerAdminButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bannerAdminButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bannerAdminButton.Depth = 0;
            this.bannerAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bannerAdminButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bannerAdminButton.Location = new System.Drawing.Point(143, 231);
            this.bannerAdminButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.bannerAdminButton.Name = "bannerAdminButton";
            this.bannerAdminButton.Primary = true;
            this.bannerAdminButton.Size = new System.Drawing.Size(644, 40);
            this.bannerAdminButton.TabIndex = 2;
            this.bannerAdminButton.Text = "administrador de banners";
            this.bannerAdminButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bannerAdminButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitButton.Depth = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitButton.Location = new System.Drawing.Point(143, 291);
            this.exitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitButton.Name = "exitButton";
            this.exitButton.Primary = true;
            this.exitButton.Size = new System.Drawing.Size(644, 40);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "salir";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 650F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.exitButton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.campaignAdminButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bannerAdminButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.operativeViewButton, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(930, 443);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(954, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "MainView";
            this.Text = "Digital Signage";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton operativeViewButton;
        private MaterialSkin.Controls.MaterialRaisedButton campaignAdminButton;
        private MaterialSkin.Controls.MaterialRaisedButton bannerAdminButton;
        private MaterialSkin.Controls.MaterialRaisedButton exitButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}