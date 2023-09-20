namespace BMSmall
{
    partial class DirectBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectBuy));
            this.lblTitleBuy = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picNaver = new System.Windows.Forms.PictureBox();
            this.picPayco = new System.Windows.Forms.PictureBox();
            this.picKakao = new System.Windows.Forms.PictureBox();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnClose = new MetroSet_UI.Controls.MetroSetButton();
            this.tabCard = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gpbPay = new System.Windows.Forms.GroupBox();
            this.btnRealBuy = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNaver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKakao)).BeginInit();
            this.tabCard.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.gpbPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleBuy
            // 
            this.lblTitleBuy.AutoSize = true;
            this.lblTitleBuy.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitleBuy.Location = new System.Drawing.Point(84, 35);
            this.lblTitleBuy.Name = "lblTitleBuy";
            this.lblTitleBuy.Size = new System.Drawing.Size(82, 21);
            this.lblTitleBuy.TabIndex = 0;
            this.lblTitleBuy.Text = "간편결제";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.picNaver, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.picPayco, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.picKakao, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCard, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(224, 119);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // picNaver
            // 
            this.picNaver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNaver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picNaver.Image = global::BMSmall.Properties.Resources.naver;
            this.picNaver.Location = new System.Drawing.Point(4, 63);
            this.picNaver.Name = "picNaver";
            this.picNaver.Size = new System.Drawing.Size(104, 52);
            this.picNaver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNaver.TabIndex = 2;
            this.picNaver.TabStop = false;
            this.picNaver.Click += new System.EventHandler(this.picNaver_Click);
            // 
            // picPayco
            // 
            this.picPayco.BackColor = System.Drawing.Color.White;
            this.picPayco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPayco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPayco.Image = global::BMSmall.Properties.Resources.payco;
            this.picPayco.Location = new System.Drawing.Point(115, 4);
            this.picPayco.Name = "picPayco";
            this.picPayco.Size = new System.Drawing.Size(105, 52);
            this.picPayco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPayco.TabIndex = 1;
            this.picPayco.TabStop = false;
            this.picPayco.Click += new System.EventHandler(this.picPayco_Click);
            // 
            // picKakao
            // 
            this.picKakao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picKakao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picKakao.Image = global::BMSmall.Properties.Resources.kakao;
            this.picKakao.Location = new System.Drawing.Point(4, 4);
            this.picKakao.Name = "picKakao";
            this.picKakao.Size = new System.Drawing.Size(104, 52);
            this.picKakao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKakao.TabIndex = 0;
            this.picKakao.TabStop = false;
            this.picKakao.Click += new System.EventHandler(this.picKakao_Click);
            // 
            // btnCard
            // 
            this.btnCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCard.FlatAppearance.BorderSize = 0;
            this.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCard.Location = new System.Drawing.Point(115, 63);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(105, 52);
            this.btnCard.TabIndex = 3;
            this.btnCard.Text = "카드결제";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnClose.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnClose.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.HoverColor = System.Drawing.Color.Silver;
            this.btnClose.HoverTextColor = System.Drawing.Color.White;
            this.btnClose.IsDerivedStyle = true;
            this.btnClose.Location = new System.Drawing.Point(230, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.NormalColor = System.Drawing.Color.Black;
            this.btnClose.NormalTextColor = System.Drawing.Color.White;
            this.btnClose.PressBorderColor = System.Drawing.Color.Black;
            this.btnClose.PressColor = System.Drawing.Color.Gainsboro;
            this.btnClose.PressTextColor = System.Drawing.Color.White;
            this.btnClose.Size = new System.Drawing.Size(30, 24);
            this.btnClose.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnClose.StyleManager = null;
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.ThemeAuthor = "Narwin";
            this.btnClose.ThemeName = "MetroLite";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabCard
            // 
            this.tabCard.Controls.Add(this.tabPage2);
            this.tabCard.Controls.Add(this.tabPage1);
            this.tabCard.Controls.Add(this.tabPage3);
            this.tabCard.Location = new System.Drawing.Point(10, 154);
            this.tabCard.Name = "tabCard";
            this.tabCard.SelectedIndex = 0;
            this.tabCard.Size = new System.Drawing.Size(216, 416);
            this.tabCard.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(208, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "신한카드";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(18, 96);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 288);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BMSmall.Properties.Resources.sinhan;
            this.pictureBox4.Location = new System.Drawing.Point(21, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(166, 86);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.pictureBox5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(208, 390);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "국민카드";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(19, 97);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 287);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::BMSmall.Properties.Resources.guk;
            this.pictureBox5.Location = new System.Drawing.Point(22, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(166, 86);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.pictureBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(208, 390);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "우리카드";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(19, 97);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(172, 287);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::BMSmall.Properties.Resources.uri;
            this.pictureBox6.Location = new System.Drawing.Point(22, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(166, 86);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalPrice.Location = new System.Drawing.Point(74, 679);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(101, 15);
            this.lblTotalPrice.TabIndex = 25;
            this.lblTotalPrice.Text = "0";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(17, 679);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 15);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "결제금액:";
            // 
            // gpbPay
            // 
            this.gpbPay.Controls.Add(this.tableLayoutPanel1);
            this.gpbPay.Controls.Add(this.tabCard);
            this.gpbPay.Location = new System.Drawing.Point(12, 85);
            this.gpbPay.Name = "gpbPay";
            this.gpbPay.Size = new System.Drawing.Size(234, 572);
            this.gpbPay.TabIndex = 26;
            this.gpbPay.TabStop = false;
            this.gpbPay.Text = "결제수단";
            // 
            // btnRealBuy
            // 
            this.btnRealBuy.Location = new System.Drawing.Point(187, 675);
            this.btnRealBuy.Name = "btnRealBuy";
            this.btnRealBuy.Size = new System.Drawing.Size(59, 23);
            this.btnRealBuy.TabIndex = 27;
            this.btnRealBuy.Text = "결제";
            this.btnRealBuy.UseVisualStyleBackColor = true;
            this.btnRealBuy.Click += new System.EventHandler(this.btnRealBuy_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(20, 13);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(39, 21);
            this.txtUser.TabIndex = 28;
            this.txtUser.Visible = false;
            // 
            // DirectBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 722);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnRealBuy);
            this.Controls.Add(this.gpbPay);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitleBuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DirectBuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DirectBuy";
            this.Load += new System.EventHandler(this.DirectBuy_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNaver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKakao)).EndInit();
            this.tabCard.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.gpbPay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleBuy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroSet_UI.Controls.MetroSetButton btnClose;
        private System.Windows.Forms.PictureBox picNaver;
        private System.Windows.Forms.PictureBox picPayco;
        private System.Windows.Forms.PictureBox picKakao;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.TabControl tabCard;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.GroupBox gpbPay;
        private System.Windows.Forms.Button btnRealBuy;
        public System.Windows.Forms.TextBox txtUser;
    }
}