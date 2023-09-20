namespace BMSmall
{
    partial class AddUser
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
            this.lblShop = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new MetroSet_UI.Controls.MetroSetButton();
            this.lblAddCom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheck = new MetroSet_UI.Controls.MetroSetButton();
            this.txtUserID = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtUserPW = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtUserPW2 = new MetroSet_UI.Controls.MetroSetTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShop
            // 
            this.lblShop.AutoSize = true;
            this.lblShop.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblShop.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShop.ForeColor = System.Drawing.Color.White;
            this.lblShop.Location = new System.Drawing.Point(97, 107);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(51, 19);
            this.lblShop.TabIndex = 1;
            this.lblShop.Text = "아이디";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.txtUserPW2);
            this.groupBox1.Controls.Add(this.txtUserPW);
            this.groupBox1.Controls.Add(this.txtUserID);
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.lblAddCom);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblShop);
            this.groupBox1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 572);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "계정정보를 입력해주세요";
            // 
            // btnClose
            // 
            this.btnClose.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnClose.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnClose.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.HoverColor = System.Drawing.Color.Silver;
            this.btnClose.HoverTextColor = System.Drawing.Color.White;
            this.btnClose.IsDerivedStyle = true;
            this.btnClose.Location = new System.Drawing.Point(308, 537);
            this.btnClose.Name = "btnClose";
            this.btnClose.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.NormalColor = System.Drawing.Color.Black;
            this.btnClose.NormalTextColor = System.Drawing.Color.White;
            this.btnClose.PressBorderColor = System.Drawing.Color.Black;
            this.btnClose.PressColor = System.Drawing.Color.Gainsboro;
            this.btnClose.PressTextColor = System.Drawing.Color.White;
            this.btnClose.Size = new System.Drawing.Size(69, 29);
            this.btnClose.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnClose.StyleManager = null;
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Back";
            this.btnClose.ThemeAuthor = "Narwin";
            this.btnClose.ThemeName = "MetroLite";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAddCom
            // 
            this.lblAddCom.AutoSize = true;
            this.lblAddCom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddCom.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCom.ForeColor = System.Drawing.Color.White;
            this.lblAddCom.Location = new System.Drawing.Point(225, 263);
            this.lblAddCom.Name = "lblAddCom";
            this.lblAddCom.Size = new System.Drawing.Size(55, 16);
            this.lblAddCom.TabIndex = 8;
            this.lblAddCom.Text = "가입완료";
            this.lblAddCom.Click += new System.EventHandler(this.lblAddCom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BMSmall.Properties.Resources.nikewater;
            this.pictureBox1.Location = new System.Drawing.Point(113, 345);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "비밀번호";
            // 
            // btnCheck
            // 
            this.btnCheck.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCheck.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCheck.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCheck.HoverColor = System.Drawing.Color.Silver;
            this.btnCheck.HoverTextColor = System.Drawing.Color.White;
            this.btnCheck.IsDerivedStyle = true;
            this.btnCheck.Location = new System.Drawing.Point(284, 138);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCheck.NormalColor = System.Drawing.Color.Black;
            this.btnCheck.NormalTextColor = System.Drawing.Color.White;
            this.btnCheck.PressBorderColor = System.Drawing.Color.Black;
            this.btnCheck.PressColor = System.Drawing.Color.Gainsboro;
            this.btnCheck.PressTextColor = System.Drawing.Color.White;
            this.btnCheck.Size = new System.Drawing.Size(63, 18);
            this.btnCheck.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnCheck.StyleManager = null;
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "중복확인";
            this.btnCheck.ThemeAuthor = "Narwin";
            this.btnCheck.ThemeName = "MetroLite";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserID.AutoCompleteCustomSource = null;
            this.txtUserID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUserID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUserID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUserID.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUserID.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUserID.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUserID.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtUserID.Image = null;
            this.txtUserID.IsDerivedStyle = true;
            this.txtUserID.Lines = null;
            this.txtUserID.Location = new System.Drawing.Point(101, 132);
            this.txtUserID.MaxLength = 32767;
            this.txtUserID.Multiline = false;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = false;
            this.txtUserID.Size = new System.Drawing.Size(179, 24);
            this.txtUserID.Style = MetroSet_UI.Enums.Style.Light;
            this.txtUserID.StyleManager = null;
            this.txtUserID.TabIndex = 11;
            this.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserID.ThemeAuthor = "Narwin";
            this.txtUserID.ThemeName = "MetroLite";
            this.txtUserID.UseSystemPasswordChar = false;
            this.txtUserID.WatermarkText = "아이디";
            // 
            // txtUserPW
            // 
            this.txtUserPW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserPW.AutoCompleteCustomSource = null;
            this.txtUserPW.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUserPW.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUserPW.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUserPW.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUserPW.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUserPW.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtUserPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUserPW.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtUserPW.Image = null;
            this.txtUserPW.IsDerivedStyle = true;
            this.txtUserPW.Lines = null;
            this.txtUserPW.Location = new System.Drawing.Point(101, 186);
            this.txtUserPW.MaxLength = 32767;
            this.txtUserPW.Multiline = false;
            this.txtUserPW.Name = "txtUserPW";
            this.txtUserPW.ReadOnly = false;
            this.txtUserPW.Size = new System.Drawing.Size(179, 24);
            this.txtUserPW.Style = MetroSet_UI.Enums.Style.Light;
            this.txtUserPW.StyleManager = null;
            this.txtUserPW.TabIndex = 12;
            this.txtUserPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserPW.ThemeAuthor = "Narwin";
            this.txtUserPW.ThemeName = "MetroLite";
            this.txtUserPW.UseSystemPasswordChar = true;
            this.txtUserPW.WatermarkText = "비밀번호";
            // 
            // txtUserPW2
            // 
            this.txtUserPW2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserPW2.AutoCompleteCustomSource = null;
            this.txtUserPW2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUserPW2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUserPW2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUserPW2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUserPW2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUserPW2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtUserPW2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUserPW2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtUserPW2.Image = null;
            this.txtUserPW2.IsDerivedStyle = true;
            this.txtUserPW2.Lines = null;
            this.txtUserPW2.Location = new System.Drawing.Point(101, 221);
            this.txtUserPW2.MaxLength = 32767;
            this.txtUserPW2.Multiline = false;
            this.txtUserPW2.Name = "txtUserPW2";
            this.txtUserPW2.ReadOnly = false;
            this.txtUserPW2.Size = new System.Drawing.Size(179, 24);
            this.txtUserPW2.Style = MetroSet_UI.Enums.Style.Light;
            this.txtUserPW2.StyleManager = null;
            this.txtUserPW2.TabIndex = 13;
            this.txtUserPW2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserPW2.ThemeAuthor = "Narwin";
            this.txtUserPW2.ThemeName = "MetroLite";
            this.txtUserPW2.UseSystemPasswordChar = true;
            this.txtUserPW2.WatermarkText = "비밀번호확인";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(412, 600);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblShop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddCom;
        private MetroSet_UI.Controls.MetroSetButton btnClose;
        private MetroSet_UI.Controls.MetroSetButton btnCheck;
        private MetroSet_UI.Controls.MetroSetTextBox txtUserID;
        private MetroSet_UI.Controls.MetroSetTextBox txtUserPW2;
        private MetroSet_UI.Controls.MetroSetTextBox txtUserPW;
    }
}