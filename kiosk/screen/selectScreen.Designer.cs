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
            this.pricetag = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuName
            // 
            this.menuName.AutoSize = true;
            this.menuName.Location = new System.Drawing.Point(113, 355);
            this.menuName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.menuName.Name = "menuName";
            this.menuName.Size = new System.Drawing.Size(65, 25);
            this.menuName.TabIndex = 23;
            this.menuName.Text = "MENU";
            // 
            // sizelabel
            // 
            this.sizelabel.AutoSize = true;
            this.sizelabel.Location = new System.Drawing.Point(57, 690);
            this.sizelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizelabel.Name = "sizelabel";
            this.sizelabel.Size = new System.Drawing.Size(66, 25);
            this.sizelabel.TabIndex = 22;
            this.sizelabel.Text = "사이즈";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(755, 324);
            this.price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(22, 25);
            this.price.TabIndex = 21;
            this.price.Text = "0";
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Location = new System.Drawing.Point(723, 324);
            this.pricelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(26, 25);
            this.pricelabel.TabIndex = 20;
            this.pricelabel.Text = "\\";
            // 
            // cntlabel
            // 
            this.cntlabel.AutoSize = true;
            this.cntlabel.Location = new System.Drawing.Point(369, 330);
            this.cntlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cntlabel.Name = "cntlabel";
            this.cntlabel.Size = new System.Drawing.Size(22, 25);
            this.cntlabel.TabIndex = 18;
            this.cntlabel.Text = "1";
            // 
            // increaseBtn
            // 
            this.increaseBtn.Location = new System.Drawing.Point(398, 324);
            this.increaseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.increaseBtn.Name = "increaseBtn";
            this.increaseBtn.Size = new System.Drawing.Size(34, 38);
            this.increaseBtn.TabIndex = 13;
            this.increaseBtn.Text = "+";
            this.increaseBtn.UseVisualStyleBackColor = true;
            this.increaseBtn.Click += new System.EventHandler(this.increaseBtn_Click);
            // 
            // decreaseBtn
            // 
            this.decreaseBtn.Location = new System.Drawing.Point(325, 324);
            this.decreaseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.decreaseBtn.Name = "decreaseBtn";
            this.decreaseBtn.Size = new System.Drawing.Size(34, 38);
            this.decreaseBtn.TabIndex = 12;
            this.decreaseBtn.Text = "-";
            this.decreaseBtn.UseVisualStyleBackColor = true;
            this.decreaseBtn.Click += new System.EventHandler(this.decreaseBtn_Click);
            // 
            // IcedBtn
            // 
            this.IcedBtn.Location = new System.Drawing.Point(433, 424);
            this.IcedBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IcedBtn.Name = "IcedBtn";
            this.IcedBtn.Size = new System.Drawing.Size(394, 136);
            this.IcedBtn.TabIndex = 14;
            this.IcedBtn.Text = "ICED";
            this.IcedBtn.UseVisualStyleBackColor = true;
            this.IcedBtn.Click += new System.EventHandler(this.IcedBtn_Click);
            // 
            // HotBtn
            // 
            this.HotBtn.Location = new System.Drawing.Point(27, 424);
            this.HotBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HotBtn.Name = "HotBtn";
            this.HotBtn.Size = new System.Drawing.Size(394, 136);
            this.HotBtn.TabIndex = 15;
            this.HotBtn.Text = "HOT";
            this.HotBtn.UseVisualStyleBackColor = true;
            this.HotBtn.Click += new System.EventHandler(this.HotBtn_Click);
            // 
            // extraBtn
            // 
            this.extraBtn.Location = new System.Drawing.Point(433, 611);
            this.extraBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.extraBtn.Name = "extraBtn";
            this.extraBtn.Size = new System.Drawing.Size(135, 183);
            this.extraBtn.TabIndex = 16;
            this.extraBtn.Text = "EXTRA";
            this.extraBtn.UseVisualStyleBackColor = true;
            this.extraBtn.Click += new System.EventHandler(this.extraBtn_Click);
            // 
            // regularBtn
            // 
            this.regularBtn.Location = new System.Drawing.Point(175, 610);
            this.regularBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.regularBtn.Name = "regularBtn";
            this.regularBtn.Size = new System.Drawing.Size(135, 183);
            this.regularBtn.TabIndex = 17;
            this.regularBtn.Text = "REGULAR";
            this.regularBtn.UseVisualStyleBackColor = true;
            this.regularBtn.Click += new System.EventHandler(this.regularBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kiosk.Properties.Resources.espresso1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(57, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 260);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // sumPriceLabel
            // 
            this.sumPriceLabel.AutoSize = true;
            this.sumPriceLabel.Location = new System.Drawing.Point(71, 1041);
            this.sumPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sumPriceLabel.Name = "sumPriceLabel";
            this.sumPriceLabel.Size = new System.Drawing.Size(48, 25);
            this.sumPriceLabel.TabIndex = 24;
            this.sumPriceLabel.Text = "가격";
            // 
            // sumPriceNum
            // 
            this.sumPriceNum.AutoSize = true;
            this.sumPriceNum.Location = new System.Drawing.Point(200, 1041);
            this.sumPriceNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sumPriceNum.Name = "sumPriceNum";
            this.sumPriceNum.Size = new System.Drawing.Size(22, 25);
            this.sumPriceNum.TabIndex = 25;
            this.sumPriceNum.Text = "0";
            // 
            // pricetag
            // 
            this.pricetag.AutoSize = true;
            this.pricetag.Location = new System.Drawing.Point(166, 1041);
            this.pricetag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pricetag.Name = "pricetag";
            this.pricetag.Size = new System.Drawing.Size(26, 25);
            this.pricetag.TabIndex = 27;
            this.pricetag.Text = "\\";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(27, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 2);
            this.label1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(27, 812);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 2);
            this.label2.TabIndex = 29;
            // 
            // selectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pricetag);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "selectScreen";
            this.Size = new System.Drawing.Size(857, 1333);
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
        private Label pricetag;
        private Label label1;
        private Label label2;
    }
}
