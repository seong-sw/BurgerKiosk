namespace BurgerKiosk
{
    partial class Form1
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
            lblTitle = new Label();
            grpMenu = new GroupBox();
            rdoChickenBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoHamburger = new RadioButton();
            picBurger3 = new PictureBox();
            picBurger2 = new PictureBox();
            picBurger1 = new PictureBox();
            grpOptions = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkFries = new CheckBox();
            grpList = new GroupBox();
            lblTotal = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnReset = new Button();
            grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBurger3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBurger2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBurger1).BeginInit();
            grpOptions.SuspendLayout();
            grpList.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Pretendard JP Variable", 36F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lblTitle.Location = new Point(14, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(569, 86);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "버거 주문 키오스크";
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Controls.Add(rdoHamburger);
            grpMenu.Controls.Add(picBurger3);
            grpMenu.Controls.Add(picBurger2);
            grpMenu.Controls.Add(picBurger1);
            grpMenu.Font = new Font("Pretendard JP Variable", 16F, FontStyle.Regular, GraphicsUnit.Point, 128);
            grpMenu.Location = new Point(32, 147);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(391, 420);
            grpMenu.TabIndex = 1;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Location = new Point(30, 317);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(154, 42);
            rdoChickenBurger.TabIndex = 6;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Location = new Point(30, 199);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(182, 42);
            rdoBulgogiBurger.TabIndex = 5;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoHamburger
            // 
            rdoHamburger.AutoSize = true;
            rdoHamburger.Location = new Point(30, 79);
            rdoHamburger.Name = "rdoHamburger";
            rdoHamburger.Size = new Size(126, 42);
            rdoHamburger.TabIndex = 2;
            rdoHamburger.TabStop = true;
            rdoHamburger.Text = "햄버거";
            rdoHamburger.UseVisualStyleBackColor = true;
            // 
            // picBurger3
            // 
            picBurger3.Image = Properties.Resources.chicken;
            picBurger3.Location = new Point(236, 281);
            picBurger3.Name = "picBurger3";
            picBurger3.Size = new Size(129, 112);
            picBurger3.SizeMode = PictureBoxSizeMode.StretchImage;
            picBurger3.TabIndex = 4;
            picBurger3.TabStop = false;
            // 
            // picBurger2
            // 
            picBurger2.Image = Properties.Resources.bulgogi;
            picBurger2.Location = new Point(229, 163);
            picBurger2.Name = "picBurger2";
            picBurger2.Size = new Size(144, 112);
            picBurger2.SizeMode = PictureBoxSizeMode.StretchImage;
            picBurger2.TabIndex = 3;
            picBurger2.TabStop = false;
            // 
            // picBurger1
            // 
            picBurger1.Image = Properties.Resources.burger;
            picBurger1.Location = new Point(241, 45);
            picBurger1.Name = "picBurger1";
            picBurger1.Size = new Size(122, 112);
            picBurger1.SizeMode = PictureBoxSizeMode.StretchImage;
            picBurger1.TabIndex = 2;
            picBurger1.TabStop = false;
            // 
            // grpOptions
            // 
            grpOptions.Controls.Add(chkSauce);
            grpOptions.Controls.Add(chkCheese);
            grpOptions.Controls.Add(chkCola);
            grpOptions.Controls.Add(chkFries);
            grpOptions.Font = new Font("Pretendard JP Variable", 16F, FontStyle.Regular, GraphicsUnit.Point, 128);
            grpOptions.Location = new Point(458, 147);
            grpOptions.Name = "grpOptions";
            grpOptions.Size = new Size(224, 342);
            grpOptions.TabIndex = 7;
            grpOptions.TabStop = false;
            grpOptions.Text = "추가 옵션";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Location = new Point(31, 266);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(163, 42);
            chkSauce.TabIndex = 10;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Location = new Point(31, 205);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(163, 42);
            chkCheese.TabIndex = 9;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Location = new Point(31, 142);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(99, 42);
            chkCola.TabIndex = 9;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkFries
            // 
            chkFries.AutoSize = true;
            chkFries.Location = new Point(31, 79);
            chkFries.Name = "chkFries";
            chkFries.Size = new Size(155, 42);
            chkFries.TabIndex = 8;
            chkFries.Text = "감자튀김";
            chkFries.UseVisualStyleBackColor = true;
            // 
            // grpList
            // 
            grpList.Controls.Add(lblTotal);
            grpList.Controls.Add(lstOrder);
            grpList.Font = new Font("Pretendard JP Variable", 16F, FontStyle.Regular, GraphicsUnit.Point, 128);
            grpList.Location = new Point(721, 147);
            grpList.Name = "grpList";
            grpList.Size = new Size(391, 376);
            grpList.TabIndex = 7;
            grpList.TabStop = false;
            grpList.Text = "주문 내역";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(29, 311);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(180, 38);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "총 금액 : 0원";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(29, 60);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(330, 232);
            lstOrder.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Pretendard JP Variable", 16F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btnOrder.Location = new Point(826, 547);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(139, 57);
            btnOrder.TabIndex = 8;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Pretendard JP Variable", 16F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btnReset.Location = new Point(990, 547);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(122, 57);
            btnReset.TabIndex = 9;
            btnReset.Text = "초기화";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 630);
            Controls.Add(btnReset);
            Controls.Add(btnOrder);
            Controls.Add(grpList);
            Controls.Add(grpOptions);
            Controls.Add(grpMenu);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = " 버거 주문 키오스크";
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBurger3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBurger2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBurger1).EndInit();
            grpOptions.ResumeLayout(false);
            grpOptions.PerformLayout();
            grpList.ResumeLayout(false);
            grpList.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grpMenu;
        private PictureBox picBurger1;
        private RadioButton rdoChickenBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoHamburger;
        private PictureBox picBurger3;
        private PictureBox picBurger2;
        private GroupBox grpOptions;
        private CheckBox chkSauce;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private CheckBox chkFries;
        private GroupBox grpList;
        private Label lblTotal;
        private ListBox lstOrder;
        private Button btnOrder;
        private Button btnReset;
    }
}
