namespace Bank
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.CreateAccBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxBig = new System.Windows.Forms.TextBox();
            this.CtrditBox = new System.Windows.Forms.GroupBox();
            this.BtnToCredit = new System.Windows.Forms.Button();
            this.TimeToCredit = new System.Windows.Forms.TextBox();
            this.SumToCredit = new System.Windows.Forms.TextBox();
            this.IdToCredit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.GetMoneyBox = new System.Windows.Forms.GroupBox();
            this.TopUpBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IdToUp = new System.Windows.Forms.TextBox();
            this.MoneyToUp = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnToGetMoney = new System.Windows.Forms.Button();
            this.MoneyToMinus = new System.Windows.Forms.TextBox();
            this.IdToMinus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CreditBtn = new System.Windows.Forms.Button();
            this.GetStatysBtn = new System.Windows.Forms.Button();
            this.GetMoneyBtn = new System.Windows.Forms.Button();
            this.TopUpBtn = new System.Windows.Forms.Button();
            this.CreateCheckBtn = new System.Windows.Forms.Button();
            this.GetListOfChecksBtn = new System.Windows.Forms.Button();
            this.CreateBox = new System.Windows.Forms.GroupBox();
            this.BtnToCreate = new System.Windows.Forms.Button();
            this.MoneyToCreate = new System.Windows.Forms.TextBox();
            this.NameToCreate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.GroupBox();
            this.BtnToStatus = new System.Windows.Forms.Button();
            this.IdToStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.CtrditBox.SuspendLayout();
            this.GetMoneyBox.SuspendLayout();
            this.TopUpBox.SuspendLayout();
            this.CreateBox.SuspendLayout();
            this.StatusBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(169, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create bank account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type your first name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type your last name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(237, 86);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(192, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(237, 169);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(192, 20);
            this.textBoxLastName.TabIndex = 4;
            // 
            // CreateAccBtn
            // 
            this.CreateAccBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateAccBtn.Location = new System.Drawing.Point(185, 262);
            this.CreateAccBtn.Name = "CreateAccBtn";
            this.CreateAccBtn.Size = new System.Drawing.Size(110, 33);
            this.CreateAccBtn.TabIndex = 5;
            this.CreateAccBtn.Text = "Create";
            this.CreateAccBtn.UseVisualStyleBackColor = true;
            this.CreateAccBtn.Click += new System.EventHandler(this.CreateAccBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CreateAccBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Location = new System.Drawing.Point(142, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 404);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StatusBox);
            this.groupBox2.Controls.Add(this.textBoxBig);
            this.groupBox2.Controls.Add(this.TopUpBox);
            this.groupBox2.Controls.Add(this.CtrditBox);
            this.groupBox2.Controls.Add(this.GetMoneyBox);
            this.groupBox2.Controls.Add(this.CreditBtn);
            this.groupBox2.Controls.Add(this.GetStatysBtn);
            this.groupBox2.Controls.Add(this.GetMoneyBtn);
            this.groupBox2.Controls.Add(this.TopUpBtn);
            this.groupBox2.Controls.Add(this.CreateCheckBtn);
            this.groupBox2.Controls.Add(this.GetListOfChecksBtn);
            this.groupBox2.Controls.Add(this.CreateBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(30, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(698, 361);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // textBoxBig
            // 
            this.textBoxBig.Location = new System.Drawing.Point(189, 44);
            this.textBoxBig.Multiline = true;
            this.textBoxBig.Name = "textBoxBig";
            this.textBoxBig.Size = new System.Drawing.Size(479, 286);
            this.textBoxBig.TabIndex = 6;
            this.textBoxBig.TextChanged += new System.EventHandler(this.textBoxBig_TextChanged);
            // 
            // CtrditBox
            // 
            this.CtrditBox.Controls.Add(this.BtnToCredit);
            this.CtrditBox.Controls.Add(this.TimeToCredit);
            this.CtrditBox.Controls.Add(this.SumToCredit);
            this.CtrditBox.Controls.Add(this.IdToCredit);
            this.CtrditBox.Controls.Add(this.label13);
            this.CtrditBox.Controls.Add(this.label12);
            this.CtrditBox.Controls.Add(this.label11);
            this.CtrditBox.Location = new System.Drawing.Point(272, 55);
            this.CtrditBox.Name = "CtrditBox";
            this.CtrditBox.Size = new System.Drawing.Size(301, 182);
            this.CtrditBox.TabIndex = 10;
            this.CtrditBox.TabStop = false;
            this.CtrditBox.Visible = false;
            // 
            // BtnToCredit
            // 
            this.BtnToCredit.Location = new System.Drawing.Point(102, 125);
            this.BtnToCredit.Name = "BtnToCredit";
            this.BtnToCredit.Size = new System.Drawing.Size(75, 38);
            this.BtnToCredit.TabIndex = 6;
            this.BtnToCredit.Text = "Make";
            this.BtnToCredit.UseVisualStyleBackColor = true;
            this.BtnToCredit.Click += new System.EventHandler(this.BtnToCredit_Click);
            // 
            // TimeToCredit
            // 
            this.TimeToCredit.Location = new System.Drawing.Point(147, 96);
            this.TimeToCredit.Name = "TimeToCredit";
            this.TimeToCredit.Size = new System.Drawing.Size(100, 26);
            this.TimeToCredit.TabIndex = 5;
            // 
            // SumToCredit
            // 
            this.SumToCredit.Location = new System.Drawing.Point(147, 54);
            this.SumToCredit.Name = "SumToCredit";
            this.SumToCredit.Size = new System.Drawing.Size(100, 26);
            this.SumToCredit.TabIndex = 4;
            // 
            // IdToCredit
            // 
            this.IdToCredit.Location = new System.Drawing.Point(147, 14);
            this.IdToCredit.Name = "IdToCredit";
            this.IdToCredit.Size = new System.Drawing.Size(100, 26);
            this.IdToCredit.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Time in months";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Sum";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Id";
            // 
            // GetMoneyBox
            // 
            this.GetMoneyBox.Controls.Add(this.BtnToGetMoney);
            this.GetMoneyBox.Controls.Add(this.MoneyToMinus);
            this.GetMoneyBox.Controls.Add(this.IdToMinus);
            this.GetMoneyBox.Controls.Add(this.label9);
            this.GetMoneyBox.Controls.Add(this.label8);
            this.GetMoneyBox.Location = new System.Drawing.Point(328, 55);
            this.GetMoneyBox.Name = "GetMoneyBox";
            this.GetMoneyBox.Size = new System.Drawing.Size(200, 143);
            this.GetMoneyBox.TabIndex = 9;
            this.GetMoneyBox.TabStop = false;
            this.GetMoneyBox.Visible = false;
            // 
            // TopUpBox
            // 
            this.TopUpBox.Controls.Add(this.button1);
            this.TopUpBox.Controls.Add(this.textBox1);
            this.TopUpBox.Controls.Add(this.IdToUp);
            this.TopUpBox.Controls.Add(this.MoneyToUp);
            this.TopUpBox.Controls.Add(this.label10);
            this.TopUpBox.Location = new System.Drawing.Point(318, 55);
            this.TopUpBox.Name = "TopUpBox";
            this.TopUpBox.Size = new System.Drawing.Size(200, 137);
            this.TopUpBox.TabIndex = 10;
            this.TopUpBox.TabStop = false;
            this.TopUpBox.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 3;
            // 
            // IdToUp
            // 
            this.IdToUp.Location = new System.Drawing.Point(83, 17);
            this.IdToUp.Name = "IdToUp";
            this.IdToUp.Size = new System.Drawing.Size(100, 26);
            this.IdToUp.TabIndex = 2;
            // 
            // MoneyToUp
            // 
            this.MoneyToUp.AutoSize = true;
            this.MoneyToUp.Location = new System.Drawing.Point(6, 60);
            this.MoneyToUp.Name = "MoneyToUp";
            this.MoneyToUp.Size = new System.Drawing.Size(56, 20);
            this.MoneyToUp.TabIndex = 1;
            this.MoneyToUp.Text = "Money";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Id";
            // 
            // BtnToGetMoney
            // 
            this.BtnToGetMoney.Location = new System.Drawing.Point(54, 104);
            this.BtnToGetMoney.Name = "BtnToGetMoney";
            this.BtnToGetMoney.Size = new System.Drawing.Size(75, 33);
            this.BtnToGetMoney.TabIndex = 4;
            this.BtnToGetMoney.Text = "Get";
            this.BtnToGetMoney.UseVisualStyleBackColor = true;
            this.BtnToGetMoney.Click += new System.EventHandler(this.BtnToGetMoney_Click);
            // 
            // MoneyToMinus
            // 
            this.MoneyToMinus.Location = new System.Drawing.Point(69, 61);
            this.MoneyToMinus.Name = "MoneyToMinus";
            this.MoneyToMinus.Size = new System.Drawing.Size(100, 26);
            this.MoneyToMinus.TabIndex = 3;
            // 
            // IdToMinus
            // 
            this.IdToMinus.Location = new System.Drawing.Point(67, 18);
            this.IdToMinus.Name = "IdToMinus";
            this.IdToMinus.Size = new System.Drawing.Size(100, 26);
            this.IdToMinus.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Money";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Id";
            // 
            // CreditBtn
            // 
            this.CreditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreditBtn.Location = new System.Drawing.Point(6, 297);
            this.CreditBtn.Name = "CreditBtn";
            this.CreditBtn.Size = new System.Drawing.Size(150, 33);
            this.CreditBtn.TabIndex = 5;
            this.CreditBtn.Text = "Credit";
            this.CreditBtn.UseVisualStyleBackColor = true;
            this.CreditBtn.Click += new System.EventHandler(this.CreditBtn_Click);
            // 
            // GetStatysBtn
            // 
            this.GetStatysBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetStatysBtn.Location = new System.Drawing.Point(6, 244);
            this.GetStatysBtn.Name = "GetStatysBtn";
            this.GetStatysBtn.Size = new System.Drawing.Size(150, 33);
            this.GetStatysBtn.TabIndex = 4;
            this.GetStatysBtn.Text = "Get status";
            this.GetStatysBtn.UseVisualStyleBackColor = true;
            this.GetStatysBtn.Click += new System.EventHandler(this.GetStatysBtn_Click);
            // 
            // GetMoneyBtn
            // 
            this.GetMoneyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetMoneyBtn.Location = new System.Drawing.Point(6, 189);
            this.GetMoneyBtn.Name = "GetMoneyBtn";
            this.GetMoneyBtn.Size = new System.Drawing.Size(150, 33);
            this.GetMoneyBtn.TabIndex = 3;
            this.GetMoneyBtn.Text = "Get Money";
            this.GetMoneyBtn.UseVisualStyleBackColor = true;
            this.GetMoneyBtn.Click += new System.EventHandler(this.GetMoneyBtn_Click);
            // 
            // TopUpBtn
            // 
            this.TopUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopUpBtn.Location = new System.Drawing.Point(6, 140);
            this.TopUpBtn.Name = "TopUpBtn";
            this.TopUpBtn.Size = new System.Drawing.Size(150, 33);
            this.TopUpBtn.TabIndex = 2;
            this.TopUpBtn.Text = "Top up check";
            this.TopUpBtn.UseVisualStyleBackColor = true;
            this.TopUpBtn.Click += new System.EventHandler(this.TopUpBtn_Click);
            // 
            // CreateCheckBtn
            // 
            this.CreateCheckBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateCheckBtn.Location = new System.Drawing.Point(6, 84);
            this.CreateCheckBtn.Name = "CreateCheckBtn";
            this.CreateCheckBtn.Size = new System.Drawing.Size(150, 33);
            this.CreateCheckBtn.TabIndex = 1;
            this.CreateCheckBtn.Text = "Create a check";
            this.CreateCheckBtn.UseVisualStyleBackColor = true;
            this.CreateCheckBtn.Click += new System.EventHandler(this.CreateCheckBtn_Click);
            // 
            // GetListOfChecksBtn
            // 
            this.GetListOfChecksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetListOfChecksBtn.Location = new System.Drawing.Point(6, 32);
            this.GetListOfChecksBtn.Name = "GetListOfChecksBtn";
            this.GetListOfChecksBtn.Size = new System.Drawing.Size(150, 33);
            this.GetListOfChecksBtn.TabIndex = 0;
            this.GetListOfChecksBtn.Text = "Get list of checks";
            this.GetListOfChecksBtn.UseVisualStyleBackColor = true;
            this.GetListOfChecksBtn.Click += new System.EventHandler(this.GetListOfChecksBtn_Click);
            // 
            // CreateBox
            // 
            this.CreateBox.Controls.Add(this.BtnToCreate);
            this.CreateBox.Controls.Add(this.MoneyToCreate);
            this.CreateBox.Controls.Add(this.NameToCreate);
            this.CreateBox.Controls.Add(this.label6);
            this.CreateBox.Controls.Add(this.label5);
            this.CreateBox.Location = new System.Drawing.Point(283, 55);
            this.CreateBox.Name = "CreateBox";
            this.CreateBox.Size = new System.Drawing.Size(277, 118);
            this.CreateBox.TabIndex = 7;
            this.CreateBox.TabStop = false;
            this.CreateBox.Visible = false;
            // 
            // BtnToCreate
            // 
            this.BtnToCreate.Location = new System.Drawing.Point(84, 81);
            this.BtnToCreate.Name = "BtnToCreate";
            this.BtnToCreate.Size = new System.Drawing.Size(75, 31);
            this.BtnToCreate.TabIndex = 4;
            this.BtnToCreate.Text = "Create";
            this.BtnToCreate.UseVisualStyleBackColor = true;
            this.BtnToCreate.Click += new System.EventHandler(this.BtnToCreate_Click);
            // 
            // MoneyToCreate
            // 
            this.MoneyToCreate.Location = new System.Drawing.Point(97, 47);
            this.MoneyToCreate.Name = "MoneyToCreate";
            this.MoneyToCreate.Size = new System.Drawing.Size(100, 26);
            this.MoneyToCreate.TabIndex = 3;
            // 
            // NameToCreate
            // 
            this.NameToCreate.Location = new System.Drawing.Point(97, 10);
            this.NameToCreate.Name = "NameToCreate";
            this.NameToCreate.Size = new System.Drawing.Size(100, 26);
            this.NameToCreate.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Money";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name";
            // 
            // StatusBox
            // 
            this.StatusBox.Controls.Add(this.BtnToStatus);
            this.StatusBox.Controls.Add(this.IdToStatus);
            this.StatusBox.Controls.Add(this.label7);
            this.StatusBox.Location = new System.Drawing.Point(189, 63);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(225, 123);
            this.StatusBox.TabIndex = 8;
            this.StatusBox.TabStop = false;
            this.StatusBox.Visible = false;
            // 
            // BtnToStatus
            // 
            this.BtnToStatus.Location = new System.Drawing.Point(73, 87);
            this.BtnToStatus.Name = "BtnToStatus";
            this.BtnToStatus.Size = new System.Drawing.Size(75, 28);
            this.BtnToStatus.TabIndex = 2;
            this.BtnToStatus.Text = "Show";
            this.BtnToStatus.UseVisualStyleBackColor = true;
            this.BtnToStatus.Click += new System.EventHandler(this.BtnToStatus_Click);
            // 
            // IdToStatus
            // 
            this.IdToStatus.Location = new System.Drawing.Point(73, 40);
            this.IdToStatus.Name = "IdToStatus";
            this.IdToStatus.Size = new System.Drawing.Size(100, 26);
            this.IdToStatus.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Bank";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.CtrditBox.ResumeLayout(false);
            this.CtrditBox.PerformLayout();
            this.GetMoneyBox.ResumeLayout(false);
            this.GetMoneyBox.PerformLayout();
            this.TopUpBox.ResumeLayout(false);
            this.TopUpBox.PerformLayout();
            this.CreateBox.ResumeLayout(false);
            this.CreateBox.PerformLayout();
            this.StatusBox.ResumeLayout(false);
            this.StatusBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Button CreateAccBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CreateCheckBtn;
        private System.Windows.Forms.Button GetListOfChecksBtn;
        private System.Windows.Forms.Button TopUpBtn;
        private System.Windows.Forms.Button CreditBtn;
        private System.Windows.Forms.Button GetStatysBtn;
        private System.Windows.Forms.Button GetMoneyBtn;
        private System.Windows.Forms.GroupBox CreateBox;
        private System.Windows.Forms.Button BtnToCreate;
        private System.Windows.Forms.TextBox MoneyToCreate;
        private System.Windows.Forms.TextBox NameToCreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox StatusBox;
        private System.Windows.Forms.Button BtnToStatus;
        private System.Windows.Forms.TextBox IdToStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox GetMoneyBox;
        private System.Windows.Forms.Button BtnToGetMoney;
        private System.Windows.Forms.TextBox MoneyToMinus;
        private System.Windows.Forms.TextBox IdToMinus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxBig;
        private System.Windows.Forms.GroupBox TopUpBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox IdToUp;
        private System.Windows.Forms.Label MoneyToUp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox CtrditBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnToCredit;
        private System.Windows.Forms.TextBox TimeToCredit;
        private System.Windows.Forms.TextBox SumToCredit;
        private System.Windows.Forms.TextBox IdToCredit;
        private System.Windows.Forms.Label label13;
    }
}

