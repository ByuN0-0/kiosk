namespace kiosk.screen
{
    partial class selectScreen
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
            this.menuName = new System.Windows.Forms.Label();
            this.sizelabel = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.cntlabel = new System.Windows.Forms.Label();
            this.increaseBtn = new System.Windows.Forms.Button();
            this.decreaseBtn = new System.Windows.Forms.Button();
            this.IcedBtn = new System.Windows.Forms.Button();
            this.HotBtn = new System.Windows.Forms.Button();
            this.extraBtn = new System.Windows.Forms.Button();
            this.regularBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sumPriceLabel = new System.Windows.Forms.Label();
            this.sumPriceNum = new System.Windows.Forms.Label();
            this.takeBtn = new System.Windows.Forms.Button();
            this.pricetag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuName
            // 
            this.menuName.AutoSize = true;
            this.menuName.Location = new System.Drawing.Point(79, 213);
            this.menuName.Name = "menuName";
            this.menuName.Size = new System.Drawing.Size(41, 15);
            this.menuName.TabIndex = 23;
            this.menuName.Text = "MENU";
            // 
            // sizelabel
            // 
            this.sizelabel.AutoSize = true;
            this.sizelabel.Location = new System.Drawing.Point(37, 386);
            this.sizelabel.Name = "sizelabel";
            this.sizelabel.Size = new System.Drawing.Size(43, 15);
            this.sizelabel.TabIndex = 22;
            this.sizelabel.Text = "사이즈";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(508, 187);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(14, 15);
            this.price.TabIndex = 21;
            this.price.Text = "0";
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Location = new System.Drawing.Point(486, 187);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(16, 15);
            this.pricelabel.TabIndex = 20;
            this.pricelabel.Text = "\\";
            // 
            // cntlabel
            // 
            this.cntlabel.AutoSize = true;
            this.cntlabel.Location = new System.Drawing.Point(238, 191);
            this.cntlabel.Name = "cntlabel";
            this.cntlabel.Size = new System.Drawing.Size(14, 15);
            this.cntlabel.TabIndex = 18;
            this.cntlabel.Text = "1";
            // 
            // increaseBtn
            // 
            this.increaseBtn.Location = new System.Drawing.Point(258, 187);
            this.increaseBtn.Name = "increaseBtn";
            this.increaseBtn.Size = new System.Drawing.Size(24, 23);
            this.increaseBtn.TabIndex = 13;
            this.increaseBtn.Text = "+";
            this.increaseBtn.UseVisualStyleBackColor = true;
            this.increaseBtn.Click += new System.EventHandler(this.increaseBtn_Click);
            // 
            // decreaseBtn
            // 
            this.decreaseBtn.Location = new System.Drawing.Point(207, 187);
            this.decreaseBtn.Name = "decreaseBtn";
            this.decreaseBtn.Size = new System.Drawing.Size(24, 23);
            this.decreaseBtn.TabIndex = 12;
            this.decreaseBtn.Text = "-";
            this.decreaseBtn.UseVisualStyleBackColor = true;
            this.decreaseBtn.Click += new System.EventHandler(this.decreaseBtn_Click);
            // 
            // IcedBtn
            // 
            this.IcedBtn.Location = new System.Drawing.Point(300, 251);
            this.IcedBtn.Name = "IcedBtn";
            this.IcedBtn.Size = new System.Drawing.Size(276, 57);
            this.IcedBtn.TabIndex = 14;
            this.IcedBtn.Text = "ICED";
            this.IcedBtn.UseVisualStyleBackColor = true;
            this.IcedBtn.Click += new System.EventHandler(this.IcedBtn_Click);
            // 
            // HotBtn
            // 
            this.HotBtn.Location = new System.Drawing.Point(16, 251);
            this.HotBtn.Name = "HotBtn";
            this.HotBtn.Size = new System.Drawing.Size(276, 57);
            this.HotBtn.TabIndex = 15;
            this.HotBtn.Text = "HOT";
            this.HotBtn.UseVisualStyleBackColor = true;
            this.HotBtn.Click += new System.EventHandler(this.HotBtn_Click);
            // 
            // extraBtn
            // 
            this.extraBtn.Location = new System.Drawing.Point(217, 338);
            this.extraBtn.Name = "extraBtn";
            this.extraBtn.Size = new System.Drawing.Size(75, 110);
            this.extraBtn.TabIndex = 16;
            this.extraBtn.Text = "EXTRA";
            this.extraBtn.UseVisualStyleBackColor = true;
            this.extraBtn.Click += new System.EventHandler(this.extraBtn_Click);
            // 
            // regularBtn
            // 
            this.regularBtn.Location = new System.Drawing.Point(120, 338);
            this.regularBtn.Name = "regularBtn";
            this.regularBtn.Size = new System.Drawing.Size(75, 110);
            this.regularBtn.TabIndex = 17;
            this.regularBtn.Text = "REGULAR";
            this.regularBtn.UseVisualStyleBackColor = true;
            this.regularBtn.Click += new System.EventHandler(this.regularBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kiosk.Properties.Resources.espresso1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(37, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 156);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // sumPriceLabel
            // 
            this.sumPriceLabel.AutoSize = true;
            this.sumPriceLabel.Location = new System.Drawing.Point(419, 668);
            this.sumPriceLabel.Name = "sumPriceLabel";
            this.sumPriceLabel.Size = new System.Drawing.Size(31, 15);
            this.sumPriceLabel.TabIndex = 24;
            this.sumPriceLabel.Text = "가격";
            // 
            // sumPriceNum
            // 
            this.sumPriceNum.AutoSize = true;
            this.sumPriceNum.Location = new System.Drawing.Point(508, 668);
            this.sumPriceNum.Name = "sumPriceNum";
            this.sumPriceNum.Size = new System.Drawing.Size(14, 15);
            this.sumPriceNum.TabIndex = 25;
            this.sumPriceNum.Text = "0";
            // 
            // takeBtn
            // 
            this.takeBtn.Location = new System.Drawing.Point(475, 729);
            this.takeBtn.Name = "takeBtn";
            this.takeBtn.Size = new System.Drawing.Size(75, 23);
            this.takeBtn.TabIndex = 26;
            this.takeBtn.Text = "담기";
            this.takeBtn.UseVisualStyleBackColor = true;
            this.takeBtn.Click += new System.EventHandler(this.takeBtn_Click);
            // 
            // pricetag
            // 
            this.pricetag.AutoSize = true;
            this.pricetag.Location = new System.Drawing.Point(486, 668);
            this.pricetag.Name = "pricetag";
            this.pricetag.Size = new System.Drawing.Size(16, 15);
            this.pricetag.TabIndex = 27;
            this.pricetag.Text = "\\";
            // 
            // selectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pricetag);
            this.Controls.Add(this.takeBtn);
            this.Controls.Add(this.sumPriceNum);
            this.Controls.Add(this.sumPriceLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.regularBtn);
            this.Controls.Add(this.extraBtn);
            this.Controls.Add(this.HotBtn);
            this.Controls.Add(this.IcedBtn);
            this.Controls.Add(this.decreaseBtn);
            this.Controls.Add(this.increaseBtn);
            this.Controls.Add(this.cntlabel);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.price);
            this.Controls.Add(this.sizelabel);
            this.Controls.Add(this.menuName);
            this.Name = "selectScreen";
            this.Size = new System.Drawing.Size(600, 800);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label menuName;
        private Label sizelabel;
        private Label price;
        private Label pricelabel;
        private Label cntlabel;
        private Button increaseBtn;
        private Button decreaseBtn;
        private Button IcedBtn;
        private Button HotBtn;
        private Button extraBtn;
        private Button regularBtn;
        private PictureBox pictureBox1;
        private Label sumPriceLabel;
        private Label sumPriceNum;
        private Button takeBtn;
        private Label pricetag;
    }
}
