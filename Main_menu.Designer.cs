namespace BMSmall
{
    partial class Main_menu
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
            this.tblAll = new System.Windows.Forms.TableLayoutPanel();
            this.tblDowntwo = new System.Windows.Forms.TableLayoutPanel();
            this.pnlShoesList = new System.Windows.Forms.Panel();
            this.tblShoes = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblHello = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSheet = new System.Windows.Forms.Label();
            this.lblShop = new System.Windows.Forms.Label();
            this.pnlUP = new System.Windows.Forms.Panel();
            this.btnClose = new MetroSet_UI.Controls.MetroSetButton();
            this.picTop = new System.Windows.Forms.PictureBox();
            this.tblAll.SuspendLayout();
            this.tblDowntwo.SuspendLayout();
            this.pnlShoesList.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
            this.SuspendLayout();
            // 
            // tblAll
            // 
            this.tblAll.ColumnCount = 1;
            this.tblAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblAll.Controls.Add(this.tblDowntwo, 0, 1);
            this.tblAll.Controls.Add(this.pnlUP, 0, 0);
            this.tblAll.Location = new System.Drawing.Point(12, 12);
            this.tblAll.Name = "tblAll";
            this.tblAll.RowCount = 2;
            this.tblAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.89047F));
            this.tblAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.10954F));
            this.tblAll.Size = new System.Drawing.Size(883, 756);
            this.tblAll.TabIndex = 5;
            // 
            // tblDowntwo
            // 
            this.tblDowntwo.ColumnCount = 2;
            this.tblDowntwo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tblDowntwo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDowntwo.Controls.Add(this.pnlShoesList, 1, 0);
            this.tblDowntwo.Controls.Add(this.pnlMenu, 0, 0);
            this.tblDowntwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDowntwo.Location = new System.Drawing.Point(3, 100);
            this.tblDowntwo.Name = "tblDowntwo";
            this.tblDowntwo.RowCount = 1;
            this.tblDowntwo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDowntwo.Size = new System.Drawing.Size(877, 653);
            this.tblDowntwo.TabIndex = 3;
            // 
            // pnlShoesList
            // 
            this.pnlShoesList.AutoScroll = true;
            this.pnlShoesList.BackColor = System.Drawing.Color.Transparent;
            this.pnlShoesList.Controls.Add(this.tblShoes);
            this.pnlShoesList.Location = new System.Drawing.Point(155, 3);
            this.pnlShoesList.Name = "pnlShoesList";
            this.pnlShoesList.Size = new System.Drawing.Size(719, 647);
            this.pnlShoesList.TabIndex = 6;
            // 
            // tblShoes
            // 
            this.tblShoes.AutoSize = true;
            this.tblShoes.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblShoes.ColumnCount = 1;
            this.tblShoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tblShoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tblShoes.Location = new System.Drawing.Point(213, 3);
            this.tblShoes.Name = "tblShoes";
            this.tblShoes.RowCount = 8;
            this.tblShoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tblShoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tblShoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tblShoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tblShoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tblShoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tblShoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tblShoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tblShoes.Size = new System.Drawing.Size(269, 2412);
            this.tblShoes.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Black;
            this.pnlMenu.Controls.Add(this.lblHello);
            this.pnlMenu.Controls.Add(this.lblUser);
            this.pnlMenu.Controls.Add(this.lblSheet);
            this.pnlMenu.Controls.Add(this.lblShop);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.ForeColor = System.Drawing.Color.DimGray;
            this.pnlMenu.Location = new System.Drawing.Point(4, 3);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(144, 647);
            this.pnlMenu.TabIndex = 1;
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(39, 25);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(62, 15);
            this.lblHello.TabIndex = 3;
            this.lblHello.Text = "반갑습니다";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.DarkGray;
            this.lblUser.Location = new System.Drawing.Point(25, 52);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(61, 16);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "label1";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSheet
            // 
            this.lblSheet.AutoSize = true;
            this.lblSheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSheet.ForeColor = System.Drawing.Color.White;
            this.lblSheet.Location = new System.Drawing.Point(19, 214);
            this.lblSheet.Name = "lblSheet";
            this.lblSheet.Size = new System.Drawing.Size(106, 21);
            this.lblSheet.TabIndex = 1;
            this.lblSheet.Text = "Cart/Buy";
            this.lblSheet.Click += new System.EventHandler(this.lblSheet_Click);
            // 
            // lblShop
            // 
            this.lblShop.AutoSize = true;
            this.lblShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShop.ForeColor = System.Drawing.Color.White;
            this.lblShop.Location = new System.Drawing.Point(38, 143);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(58, 21);
            this.lblShop.TabIndex = 0;
            this.lblShop.Text = "Shop";
            this.lblShop.Click += new System.EventHandler(this.lblShop_Click);
            // 
            // pnlUP
            // 
            this.pnlUP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlUP.BackColor = System.Drawing.Color.Black;
            this.pnlUP.Controls.Add(this.btnClose);
            this.pnlUP.Controls.Add(this.picTop);
            this.pnlUP.Location = new System.Drawing.Point(3, 7);
            this.pnlUP.Name = "pnlUP";
            this.pnlUP.Size = new System.Drawing.Size(877, 83);
            this.pnlUP.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnClose.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnClose.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.HoverColor = System.Drawing.Color.Silver;
            this.btnClose.HoverTextColor = System.Drawing.Color.White;
            this.btnClose.IsDerivedStyle = true;
            this.btnClose.Location = new System.Drawing.Point(795, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.NormalColor = System.Drawing.Color.Black;
            this.btnClose.NormalTextColor = System.Drawing.Color.White;
            this.btnClose.PressBorderColor = System.Drawing.Color.Black;
            this.btnClose.PressColor = System.Drawing.Color.Gainsboro;
            this.btnClose.PressTextColor = System.Drawing.Color.White;
            this.btnClose.Size = new System.Drawing.Size(82, 83);
            this.btnClose.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnClose.StyleManager = null;
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Logout";
            this.btnClose.ThemeAuthor = "Narwin";
            this.btnClose.ThemeName = "MetroLite";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picTop
            // 
            this.picTop.BackColor = System.Drawing.Color.Transparent;
            this.picTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTop.Image = global::BMSmall.Properties.Resources.nikeslo;
            this.picTop.Location = new System.Drawing.Point(0, 0);
            this.picTop.Name = "picTop";
            this.picTop.Size = new System.Drawing.Size(877, 83);
            this.picTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTop.TabIndex = 5;
            this.picTop.TabStop = false;
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(915, 812);
            this.Controls.Add(this.tblAll);
            this.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Main_menu_Load);
            this.tblAll.ResumeLayout(false);
            this.tblDowntwo.ResumeLayout(false);
            this.pnlShoesList.ResumeLayout(false);
            this.pnlShoesList.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlUP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tblAll;
        private System.Windows.Forms.TableLayoutPanel tblDowntwo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.TableLayoutPanel tblShoes;
        private System.Windows.Forms.Label lblSheet;
        private System.Windows.Forms.Label lblShop;
        private System.Windows.Forms.Panel pnlUP;
        private MetroSet_UI.Controls.MetroSetButton btnClose;
        private System.Windows.Forms.PictureBox picTop;
        private System.Windows.Forms.Panel pnlShoesList;
        private System.Windows.Forms.Label lblHello;
        public System.Windows.Forms.Label lblUser;
    }
}