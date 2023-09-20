namespace BMSmall
{
    partial class AddShoes
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
            this.gbAddShoes = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAddname = new System.Windows.Forms.Label();
            this.btnAddShoes = new System.Windows.Forms.Button();
            this.txtShoesPrice = new System.Windows.Forms.TextBox();
            this.txtShoesName = new System.Windows.Forms.TextBox();
            this.txtShoesState = new System.Windows.Forms.TextBox();
            this.ckSold = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckRM = new System.Windows.Forms.CheckBox();
            this.btnClose = new MetroSet_UI.Controls.MetroSetButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.lblDetail = new System.Windows.Forms.Label();
            this.gbAddShoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddShoes
            // 
            this.gbAddShoes.Controls.Add(this.lblPrice);
            this.gbAddShoes.Controls.Add(this.lblAddname);
            this.gbAddShoes.Controls.Add(this.btnAddShoes);
            this.gbAddShoes.Controls.Add(this.txtShoesPrice);
            this.gbAddShoes.Controls.Add(this.txtShoesName);
            this.gbAddShoes.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddShoes.ForeColor = System.Drawing.Color.IndianRed;
            this.gbAddShoes.Location = new System.Drawing.Point(3, 3);
            this.gbAddShoes.Name = "gbAddShoes";
            this.gbAddShoes.Size = new System.Drawing.Size(289, 216);
            this.gbAddShoes.TabIndex = 0;
            this.gbAddShoes.TabStop = false;
            this.gbAddShoes.Text = "제품등록";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(34, 112);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 16);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblAddname
            // 
            this.lblAddname.AutoSize = true;
            this.lblAddname.Location = new System.Drawing.Point(34, 82);
            this.lblAddname.Name = "lblAddname";
            this.lblAddname.Size = new System.Drawing.Size(43, 16);
            this.lblAddname.TabIndex = 3;
            this.lblAddname.Text = "Name";
            // 
            // btnAddShoes
            // 
            this.btnAddShoes.Location = new System.Drawing.Point(197, 112);
            this.btnAddShoes.Name = "btnAddShoes";
            this.btnAddShoes.Size = new System.Drawing.Size(75, 23);
            this.btnAddShoes.TabIndex = 2;
            this.btnAddShoes.Text = "등록";
            this.btnAddShoes.UseVisualStyleBackColor = true;
            this.btnAddShoes.Click += new System.EventHandler(this.btnAddShoes_Click);
            // 
            // txtShoesPrice
            // 
            this.txtShoesPrice.Location = new System.Drawing.Point(91, 109);
            this.txtShoesPrice.Name = "txtShoesPrice";
            this.txtShoesPrice.Size = new System.Drawing.Size(100, 27);
            this.txtShoesPrice.TabIndex = 1;
            // 
            // txtShoesName
            // 
            this.txtShoesName.Location = new System.Drawing.Point(91, 82);
            this.txtShoesName.Name = "txtShoesName";
            this.txtShoesName.Size = new System.Drawing.Size(100, 27);
            this.txtShoesName.TabIndex = 0;
            // 
            // txtShoesState
            // 
            this.txtShoesState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShoesState.Enabled = false;
            this.txtShoesState.Location = new System.Drawing.Point(619, 367);
            this.txtShoesState.Name = "txtShoesState";
            this.txtShoesState.Size = new System.Drawing.Size(100, 25);
            this.txtShoesState.TabIndex = 3;
            this.txtShoesState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckSold
            // 
            this.ckSold.AutoSize = true;
            this.ckSold.ForeColor = System.Drawing.Color.IndianRed;
            this.ckSold.Location = new System.Drawing.Point(645, 400);
            this.ckSold.Name = "ckSold";
            this.ckSold.Size = new System.Drawing.Size(70, 19);
            this.ckSold.TabIndex = 4;
            this.ckSold.Text = "판매완료";
            this.ckSold.UseVisualStyleBackColor = true;
            this.ckSold.CheckedChanged += new System.EventHandler(this.ckSold_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(6, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(724, 274);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.Color.IndianRed;
            this.btnUpdate.Location = new System.Drawing.Point(644, 424);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "변경등록";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpdateName.Enabled = false;
            this.txtUpdateName.ForeColor = System.Drawing.Color.Black;
            this.txtUpdateName.Location = new System.Drawing.Point(372, 367);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(241, 25);
            this.txtUpdateName.TabIndex = 6;
            this.txtUpdateName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(536, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 25);
            this.txtSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSearch.Location = new System.Drawing.Point(642, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.gbAddShoes);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 116);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1055, 560);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDetail);
            this.groupBox1.Controls.Add(this.txtDetail);
            this.groupBox1.Controls.Add(this.ckRM);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txtShoesState);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtUpdateName);
            this.groupBox1.Controls.Add(this.ckSold);
            this.groupBox1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(298, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 527);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상품 조회/상태변경";
            // 
            // ckRM
            // 
            this.ckRM.AutoSize = true;
            this.ckRM.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ckRM.Location = new System.Drawing.Point(566, 400);
            this.ckRM.Name = "ckRM";
            this.ckRM.Size = new System.Drawing.Size(70, 19);
            this.ckRM.TabIndex = 9;
            this.ckRM.Text = "재고있음";
            this.ckRM.UseVisualStyleBackColor = true;
            this.ckRM.CheckedChanged += new System.EventHandler(this.ckRM_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnClose.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnClose.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.HoverColor = System.Drawing.Color.Silver;
            this.btnClose.HoverTextColor = System.Drawing.Color.White;
            this.btnClose.IsDerivedStyle = true;
            this.btnClose.Location = new System.Drawing.Point(1010, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.NormalColor = System.Drawing.Color.Black;
            this.btnClose.NormalTextColor = System.Drawing.Color.White;
            this.btnClose.PressBorderColor = System.Drawing.Color.Black;
            this.btnClose.PressColor = System.Drawing.Color.Gainsboro;
            this.btnClose.PressTextColor = System.Drawing.Color.White;
            this.btnClose.Size = new System.Drawing.Size(82, 32);
            this.btnClose.Style = MetroSet_UI.Enums.Style.Custom;
            this.btnClose.StyleManager = null;
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Back";
            this.btnClose.ThemeAuthor = "Narwin";
            this.btnClose.ThemeName = "MetroLite";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::BMSmall.Properties.Resources.nike;
            this.pictureBox1.Location = new System.Drawing.Point(25, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1055, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtDetail
            // 
            this.txtDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetail.Location = new System.Drawing.Point(17, 378);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(292, 128);
            this.txtDetail.TabIndex = 10;
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(14, 360);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(51, 15);
            this.lblDetail.TabIndex = 5;
            this.lblDetail.Text = "상품설명";
            // 
            // AddShoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1092, 690);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddShoes";
            this.Text = "AddShoes";
            this.Load += new System.EventHandler(this.AddShoes_Load);
            this.gbAddShoes.ResumeLayout(false);
            this.gbAddShoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddShoes;
        private System.Windows.Forms.TextBox txtShoesPrice;
        private System.Windows.Forms.TextBox txtShoesName;
        private System.Windows.Forms.Button btnAddShoes;
        private System.Windows.Forms.TextBox txtShoesState;
        private System.Windows.Forms.CheckBox ckSold;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAddname;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroSet_UI.Controls.MetroSetButton btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ckRM;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.TextBox txtDetail;
    }
}