namespace Urbano_Car_Parking
{
    partial class Main
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
            this.MainElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date = new Guna.UI.WinForms.GunaLabel();
            this.time = new Guna.UI.WinForms.GunaLabel();
            this.LogoElipse = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.FilterBox = new Guna.UI.WinForms.GunaComboBox();
            this.LogoutBtn = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.SearchBtn = new Guna.UI.WinForms.GunaAdvenceTileButton();
            this.SearchBox = new Guna.UI.WinForms.GunaTextBox();
            this.AddMemberBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.AddGuestBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainElipse
            // 
            this.MainElipse.Radius = 0;
            this.MainElipse.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(212)))), ((int)(((byte)(34)))));
            this.gunaPanel1.Controls.Add(this.gunaLabel4);
            this.gunaPanel1.Controls.Add(this.panel1);
            this.gunaPanel1.Controls.Add(this.date);
            this.gunaPanel1.Controls.Add(this.time);
            this.gunaPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1052, 113);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(41)))));
            this.gunaLabel4.Location = new System.Drawing.Point(161, 32);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(503, 44);
            this.gunaLabel4.TabIndex = 6;
            this.gunaLabel4.Text = "Urbano Car Parking System";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(115)))), ((int)(((byte)(36)))));
            this.panel1.Location = new System.Drawing.Point(858, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 100);
            this.panel1.TabIndex = 5;
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(41)))));
            this.date.Location = new System.Drawing.Point(874, 58);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(140, 28);
            this.date.TabIndex = 4;
            this.date.Text = "mm/dd/yy";
            this.date.Click += new System.EventHandler(this.gunaLabel3_Click);
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(41)))));
            this.time.Location = new System.Drawing.Point(877, 22);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(137, 36);
            this.time.TabIndex = 3;
            this.time.Text = "00:00 PM";
            this.time.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // LogoElipse
            // 
            this.LogoElipse.Radius = 50;
            this.LogoElipse.TargetControl = this.gunaPictureBox1;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackgroundImage = global::Urbano_Car_Parking.Properties.Resources.Ufill;
            this.gunaPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPanel2.Controls.Add(this.FilterBox);
            this.gunaPanel2.Controls.Add(this.LogoutBtn);
            this.gunaPanel2.Controls.Add(this.SearchBtn);
            this.gunaPanel2.Controls.Add(this.SearchBox);
            this.gunaPanel2.Controls.Add(this.AddMemberBtn);
            this.gunaPanel2.Controls.Add(this.gunaElipsePanel1);
            this.gunaPanel2.Controls.Add(this.gunaLabel1);
            this.gunaPanel2.Controls.Add(this.AddGuestBtn);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 113);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1052, 555);
            this.gunaPanel2.TabIndex = 1;
            // 
            // FilterBox
            // 
            this.FilterBox.BackColor = System.Drawing.Color.Transparent;
            this.FilterBox.BaseColor = System.Drawing.Color.White;
            this.FilterBox.BorderColor = System.Drawing.Color.Silver;
            this.FilterBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterBox.FocusedColor = System.Drawing.Color.Empty;
            this.FilterBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterBox.ForeColor = System.Drawing.Color.Black;
            this.FilterBox.FormattingEnabled = true;
            this.FilterBox.Location = new System.Drawing.Point(556, 74);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FilterBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.FilterBox.Size = new System.Drawing.Size(204, 34);
            this.FilterBox.TabIndex = 8;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutBtn.AnimationHoverSpeed = 0.07F;
            this.LogoutBtn.AnimationSpeed = 0.03F;
            this.LogoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogoutBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(41)))));
            this.LogoutBtn.BorderColor = System.Drawing.Color.Black;
            this.LogoutBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.LogoutBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.LogoutBtn.CheckedForeColor = System.Drawing.Color.White;
            this.LogoutBtn.CheckedImage = global::Urbano_Car_Parking.Properties.Resources.icons8_log_out_100;
            this.LogoutBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.LogoutBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LogoutBtn.FocusedColor = System.Drawing.Color.Empty;
            this.LogoutBtn.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Image = global::Urbano_Car_Parking.Properties.Resources.icons8_log_out_100;
            this.LogoutBtn.ImageSize = new System.Drawing.Size(80, 80);
            this.LogoutBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LogoutBtn.Location = new System.Drawing.Point(911, 423);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(25)))));
            this.LogoutBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LogoutBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.LogoutBtn.OnHoverImage = global::Urbano_Car_Parking.Properties.Resources.icons8_log_out_100;
            this.LogoutBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LogoutBtn.OnPressedColor = System.Drawing.Color.Black;
            this.LogoutBtn.Radius = 15;
            this.LogoutBtn.Size = new System.Drawing.Size(103, 108);
            this.LogoutBtn.TabIndex = 7;
            this.LogoutBtn.Click += new System.EventHandler(this.gunaAdvenceTileButton1_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.AnimationHoverSpeed = 0.07F;
            this.SearchBtn.AnimationSpeed = 0.03F;
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.SearchBtn.BorderColor = System.Drawing.Color.Black;
            this.SearchBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.SearchBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.SearchBtn.CheckedForeColor = System.Drawing.Color.White;
            this.SearchBtn.CheckedImage = global::Urbano_Car_Parking.Properties.Resources.icons8_search_100;
            this.SearchBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SearchBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SearchBtn.FocusedColor = System.Drawing.Color.Empty;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Image = global::Urbano_Car_Parking.Properties.Resources.icons8_search_100;
            this.SearchBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.SearchBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SearchBtn.Location = new System.Drawing.Point(275, 75);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.SearchBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SearchBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.SearchBtn.OnHoverImage = global::Urbano_Car_Parking.Properties.Resources.icons8_search_100;
            this.SearchBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SearchBtn.OnPressedColor = System.Drawing.Color.Black;
            this.SearchBtn.Radius = 5;
            this.SearchBtn.Size = new System.Drawing.Size(42, 36);
            this.SearchBtn.TabIndex = 6;
            // 
            // SearchBox
            // 
            this.SearchBox.BaseColor = System.Drawing.Color.White;
            this.SearchBox.BorderColor = System.Drawing.Color.Silver;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBox.FocusedBaseColor = System.Drawing.Color.White;
            this.SearchBox.FocusedBorderColor = System.Drawing.Color.Black;
            this.SearchBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(32, 75);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.SelectedText = "";
            this.SearchBox.Size = new System.Drawing.Size(239, 36);
            this.SearchBox.TabIndex = 5;
            this.SearchBox.Text = "Search";
            // 
            // AddMemberBtn
            // 
            this.AddMemberBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddMemberBtn.AnimationHoverSpeed = 0.07F;
            this.AddMemberBtn.AnimationSpeed = 0.03F;
            this.AddMemberBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddMemberBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.AddMemberBtn.BorderColor = System.Drawing.Color.Black;
            this.AddMemberBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.AddMemberBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddMemberBtn.CheckedForeColor = System.Drawing.Color.White;
            this.AddMemberBtn.CheckedImage = global::Urbano_Car_Parking.Properties.Resources.icons8_add_96__1_;
            this.AddMemberBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddMemberBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddMemberBtn.FocusedColor = System.Drawing.Color.Empty;
            this.AddMemberBtn.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemberBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddMemberBtn.Image = global::Urbano_Car_Parking.Properties.Resources.icons8_add_961;
            this.AddMemberBtn.ImageSize = new System.Drawing.Size(90, 90);
            this.AddMemberBtn.LineColor = System.Drawing.Color.Empty;
            this.AddMemberBtn.Location = new System.Drawing.Point(673, 173);
            this.AddMemberBtn.Name = "AddMemberBtn";
            this.AddMemberBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(113)))), ((int)(((byte)(93)))));
            this.AddMemberBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddMemberBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.AddMemberBtn.OnHoverImage = global::Urbano_Car_Parking.Properties.Resources.icons8_add_96__1_;
            this.AddMemberBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(144)))), ((int)(((byte)(118)))));
            this.AddMemberBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(77)))), ((int)(((byte)(63)))));
            this.AddMemberBtn.Radius = 25;
            this.AddMemberBtn.Size = new System.Drawing.Size(341, 131);
            this.AddMemberBtn.TabIndex = 4;
            this.AddMemberBtn.Text = "Add Member";
            this.AddMemberBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AddMemberBtn.Click += new System.EventHandler(this.AddMemberBtn_Click);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(32, 86);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(728, 694);
            this.gunaElipsePanel1.TabIndex = 3;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(41)))));
            this.gunaLabel1.Location = new System.Drawing.Point(26, 16);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(258, 36);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Welcome Admin!";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // AddGuestBtn
            // 
            this.AddGuestBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddGuestBtn.AnimationHoverSpeed = 0.07F;
            this.AddGuestBtn.AnimationSpeed = 0.03F;
            this.AddGuestBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddGuestBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(140)))), ((int)(((byte)(116)))));
            this.AddGuestBtn.BorderColor = System.Drawing.Color.Black;
            this.AddGuestBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.AddGuestBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.AddGuestBtn.CheckedForeColor = System.Drawing.Color.White;
            this.AddGuestBtn.CheckedImage = global::Urbano_Car_Parking.Properties.Resources.icons8_add_96__1_;
            this.AddGuestBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.AddGuestBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddGuestBtn.FocusedColor = System.Drawing.Color.Empty;
            this.AddGuestBtn.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGuestBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddGuestBtn.Image = global::Urbano_Car_Parking.Properties.Resources.icons8_add_961;
            this.AddGuestBtn.ImageSize = new System.Drawing.Size(90, 90);
            this.AddGuestBtn.LineColor = System.Drawing.Color.Empty;
            this.AddGuestBtn.Location = new System.Drawing.Point(673, 16);
            this.AddGuestBtn.Name = "AddGuestBtn";
            this.AddGuestBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(113)))), ((int)(((byte)(93)))));
            this.AddGuestBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddGuestBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.AddGuestBtn.OnHoverImage = global::Urbano_Car_Parking.Properties.Resources.icons8_add_96__1_;
            this.AddGuestBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(144)))), ((int)(((byte)(118)))));
            this.AddGuestBtn.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(77)))), ((int)(((byte)(63)))));
            this.AddGuestBtn.Radius = 25;
            this.AddGuestBtn.Size = new System.Drawing.Size(341, 131);
            this.AddGuestBtn.TabIndex = 1;
            this.AddGuestBtn.Text = "Add Guest";
            this.AddGuestBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AddGuestBtn.TextOffsetX = 25;
            this.AddGuestBtn.Click += new System.EventHandler(this.AddGuestBtn_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gunaPictureBox1.BackgroundImage = global::Urbano_Car_Parking.Properties.Resources.LogoU;
            this.gunaPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Location = new System.Drawing.Point(50, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(105, 92);
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(1052, 668);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urbano Car Parking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse MainElipse;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaElipse LogoElipse;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton AddGuestBtn;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLabel time;
        private Guna.UI.WinForms.GunaLabel date;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton AddMemberBtn;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox SearchBox;
        private Guna.UI.WinForms.GunaAdvenceTileButton LogoutBtn;
        private Guna.UI.WinForms.GunaAdvenceTileButton SearchBtn;
        private Guna.UI.WinForms.GunaComboBox FilterBox;
        private System.Windows.Forms.Timer timer1;
    }
}

