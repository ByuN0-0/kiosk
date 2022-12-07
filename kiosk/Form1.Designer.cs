namespace kiosk
{
    partial class firstScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.appCloseBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.adjbox = new System.Windows.Forms.PictureBox();
            this.takeOutBtn = new System.Windows.Forms.Button();
            this.simpleTakeOutBtn = new System.Windows.Forms.Button();
            this.takeInBtn = new System.Windows.Forms.Button();
            this.simpleTakeInBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adjbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // appCloseBtn
            // 
            this.appCloseBtn.Location = new System.Drawing.Point(539, 12);
            this.appCloseBtn.Name = "appCloseBtn";
            this.appCloseBtn.Size = new System.Drawing.Size(49, 23);
            this.appCloseBtn.TabIndex = 2;
            this.appCloseBtn.Text = "close";
            this.appCloseBtn.UseVisualStyleBackColor = true;
            this.appCloseBtn.Click += new System.EventHandler(this.appCloseBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.adjbox);
            this.mainPanel.Controls.Add(this.takeOutBtn);
            this.mainPanel.Controls.Add(this.simpleTakeOutBtn);
            this.mainPanel.Controls.Add(this.takeInBtn);
            this.mainPanel.Controls.Add(this.simpleTakeInBtn);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(600, 800);
            this.mainPanel.TabIndex = 3;
            // 
            // adjbox
            // 
            this.adjbox.Location = new System.Drawing.Point(0, 0);
            this.adjbox.Name = "adjbox";
            this.adjbox.Size = new System.Drawing.Size(600, 400);
            this.adjbox.TabIndex = 5;
            this.adjbox.TabStop = false;
            // 
            // takeOutBtn
            // 
            this.takeOutBtn.Location = new System.Drawing.Point(300, 600);
            this.takeOutBtn.Name = "takeOutBtn";
            this.takeOutBtn.Size = new System.Drawing.Size(300, 200);
            this.takeOutBtn.TabIndex = 4;
            this.takeOutBtn.Text = "포장";
            this.takeOutBtn.UseVisualStyleBackColor = true;
            this.takeOutBtn.Click += new System.EventHandler(this.takeoutBtn_Click);
            // 
            // simpleTakeOutBtn
            // 
            this.simpleTakeOutBtn.Location = new System.Drawing.Point(300, 400);
            this.simpleTakeOutBtn.Name = "simpleTakeOutBtn";
            this.simpleTakeOutBtn.Size = new System.Drawing.Size(300, 200);
            this.simpleTakeOutBtn.TabIndex = 3;
            this.simpleTakeOutBtn.Text = "간단 포장";
            this.simpleTakeOutBtn.UseVisualStyleBackColor = true;
            this.simpleTakeOutBtn.Click += new System.EventHandler(this.simpleTakeOutBtn_Click);
            // 
            // takeInBtn
            // 
            this.takeInBtn.Location = new System.Drawing.Point(0, 600);
            this.takeInBtn.Name = "takeInBtn";
            this.takeInBtn.Size = new System.Drawing.Size(300, 200);
            this.takeInBtn.TabIndex = 2;
            this.takeInBtn.Text = "매장 내 식사";
            this.takeInBtn.UseVisualStyleBackColor = true;
            this.takeInBtn.Click += new System.EventHandler(this.takeinBtn_Click);
            // 
            // simpleTakeInBtn
            // 
            this.simpleTakeInBtn.Location = new System.Drawing.Point(0, 400);
            this.simpleTakeInBtn.Name = "simpleTakeInBtn";
            this.simpleTakeInBtn.Size = new System.Drawing.Size(300, 200);
            this.simpleTakeInBtn.TabIndex = 1;
            this.simpleTakeInBtn.Text = "간단 매장 내 식사";
            this.simpleTakeInBtn.UseVisualStyleBackColor = true;
            this.simpleTakeInBtn.Click += new System.EventHandler(this.simpleTakeInBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // firstScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 800);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.appCloseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "firstScreen";
            this.Text = "firstScreen";
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adjbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button appCloseBtn;
        private Panel mainPanel;
        private PictureBox pictureBox1;
        private PictureBox adjbox;
        private Button takeOutBtn;
        private Button simpleTakeOutBtn;
        private Button takeInBtn;
        private Button simpleTakeInBtn;
    }
}