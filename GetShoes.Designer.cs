namespace BMSmall
{
    partial class GetShoes
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNike = new System.Windows.Forms.Label();
            this.lblSname = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSell = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPrice = new System.Windows.Forms.Panel();
            this.lblMoneyicon = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNike
            // 
            this.lblNike.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNike.AutoEllipsis = true;
            this.lblNike.AutoSize = true;
            this.lblNike.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNike.Location = new System.Drawing.Point(93, 6);
            this.lblNike.Name = "lblNike";
            this.lblNike.Size = new System.Drawing.Size(52, 21);
            this.lblNike.TabIndex = 4;
            this.lblNike.Text = "NIKE";
            // 
            // lblSname
            // 
            this.lblSname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSname.AutoEllipsis = true;
            this.lblSname.AutoSize = true;
            this.lblSname.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSname.Location = new System.Drawing.Point(99, 45);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(39, 11);
            this.lblSname.TabIndex = 3;
            this.lblSname.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoEllipsis = true;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrice.Location = new System.Drawing.Point(114, 3);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 11);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSell
            // 
            this.lblSell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSell.AutoEllipsis = true;
            this.lblSell.AutoSize = true;
            this.lblSell.Font = new System.Drawing.Font("나눔고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSell.ForeColor = System.Drawing.Color.Black;
            this.lblSell.Location = new System.Drawing.Point(94, 92);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(50, 13);
            this.lblSell.TabIndex = 6;
            this.lblSell.Text = "sold out";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlPrice, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNike, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSell, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSname, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 183);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(238, 109);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // pnlPrice
            // 
            this.pnlPrice.AutoSize = true;
            this.pnlPrice.Controls.Add(this.lblMoneyicon);
            this.pnlPrice.Controls.Add(this.lblPrice);
            this.pnlPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrice.Location = new System.Drawing.Point(3, 71);
            this.pnlPrice.Name = "pnlPrice";
            this.pnlPrice.Size = new System.Drawing.Size(232, 14);
            this.pnlPrice.TabIndex = 9;
            // 
            // lblMoneyicon
            // 
            this.lblMoneyicon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMoneyicon.AutoEllipsis = true;
            this.lblMoneyicon.BackColor = System.Drawing.Color.Transparent;
            this.lblMoneyicon.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMoneyicon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMoneyicon.Location = new System.Drawing.Point(74, 3);
            this.lblMoneyicon.Name = "lblMoneyicon";
            this.lblMoneyicon.Size = new System.Drawing.Size(34, 11);
            this.lblMoneyicon.TabIndex = 6;
            this.lblMoneyicon.Text = "₩";
            this.lblMoneyicon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::BMSmall.Properties.Resources.nike2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuy
            // 
            this.btnBuy.AutoSize = true;
            this.btnBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuy.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBuy.Location = new System.Drawing.Point(0, 162);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(238, 21);
            this.btnBuy.TabIndex = 9;
            this.btnBuy.Text = "구매하기";
            this.btnBuy.UseVisualStyleBackColor = true;
            // 
            // GetShoes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GetShoes";
            this.Size = new System.Drawing.Size(238, 292);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlPrice.ResumeLayout(false);
            this.pnlPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblNike;
        public System.Windows.Forms.Label lblSname;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlPrice;
        public System.Windows.Forms.Label lblMoneyicon;
        public System.Windows.Forms.Button btnBuy;
    }
}
