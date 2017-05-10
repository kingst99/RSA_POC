namespace RSA_POC
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_KeyGenerator = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_BCK = new System.Windows.Forms.TextBox();
            this.txt_BPK = new System.Windows.Forms.TextBox();
            this.btn_BKeyGenerate = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_ACK = new System.Windows.Forms.TextBox();
            this.txt_APK = new System.Windows.Forms.TextBox();
            this.btn_AKeyGenerate = new System.Windows.Forms.Button();
            this.txt_HashMethod = new System.Windows.Forms.TextBox();
            this.txt_KeyLength = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tab_Send = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_EncryptionData = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Encryption = new System.Windows.Forms.Button();
            this.txt_Content = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Signature = new System.Windows.Forms.TextBox();
            this.btn_GetSignature = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.tab_Receive = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Decryption = new System.Windows.Forms.Button();
            this.txt_DecryptContent = new System.Windows.Forms.TextBox();
            this.lab_VerifyResult = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_VerifySignature = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_A_Signature = new System.Windows.Forms.TextBox();
            this.txt_EncryptContent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_KeyGenerator.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tab_Send.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tab_Receive.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_KeyGenerator);
            this.tabControl1.Controls.Add(this.tab_Send);
            this.tabControl1.Controls.Add(this.tab_Receive);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1057, 746);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_KeyGenerator
            // 
            this.tab_KeyGenerator.Controls.Add(this.groupBox7);
            this.tab_KeyGenerator.Controls.Add(this.groupBox6);
            this.tab_KeyGenerator.Controls.Add(this.txt_HashMethod);
            this.tab_KeyGenerator.Controls.Add(this.txt_KeyLength);
            this.tab_KeyGenerator.Controls.Add(this.btn_Clear);
            this.tab_KeyGenerator.Controls.Add(this.label15);
            this.tab_KeyGenerator.Controls.Add(this.label3);
            this.tab_KeyGenerator.Location = new System.Drawing.Point(4, 28);
            this.tab_KeyGenerator.Name = "tab_KeyGenerator";
            this.tab_KeyGenerator.Padding = new System.Windows.Forms.Padding(3);
            this.tab_KeyGenerator.Size = new System.Drawing.Size(1049, 714);
            this.tab_KeyGenerator.TabIndex = 2;
            this.tab_KeyGenerator.Text = "產生金鑰";
            this.tab_KeyGenerator.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.txt_BCK);
            this.groupBox7.Controls.Add(this.txt_BPK);
            this.groupBox7.Controls.Add(this.btn_BKeyGenerate);
            this.groupBox7.Location = new System.Drawing.Point(20, 380);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1004, 224);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "產生乙方非對稱金鑰";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 18);
            this.label13.TabIndex = 8;
            this.label13.Text = "公鑰";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 18);
            this.label14.TabIndex = 9;
            this.label14.Text = "私鑰";
            // 
            // txt_BCK
            // 
            this.txt_BCK.Location = new System.Drawing.Point(113, 150);
            this.txt_BCK.Multiline = true;
            this.txt_BCK.Name = "txt_BCK";
            this.txt_BCK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_BCK.Size = new System.Drawing.Size(868, 50);
            this.txt_BCK.TabIndex = 6;
            // 
            // txt_BPK
            // 
            this.txt_BPK.Location = new System.Drawing.Point(113, 77);
            this.txt_BPK.Multiline = true;
            this.txt_BPK.Name = "txt_BPK";
            this.txt_BPK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_BPK.Size = new System.Drawing.Size(868, 50);
            this.txt_BPK.TabIndex = 7;
            // 
            // btn_BKeyGenerate
            // 
            this.btn_BKeyGenerate.Location = new System.Drawing.Point(450, 28);
            this.btn_BKeyGenerate.Name = "btn_BKeyGenerate";
            this.btn_BKeyGenerate.Size = new System.Drawing.Size(93, 29);
            this.btn_BKeyGenerate.TabIndex = 4;
            this.btn_BKeyGenerate.Text = "產生金鑰";
            this.btn_BKeyGenerate.UseVisualStyleBackColor = true;
            this.btn_BKeyGenerate.Click += new System.EventHandler(this.btn_BKeyGenerate_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.txt_ACK);
            this.groupBox6.Controls.Add(this.txt_APK);
            this.groupBox6.Controls.Add(this.btn_AKeyGenerate);
            this.groupBox6.Location = new System.Drawing.Point(20, 94);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1004, 223);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "產生甲方非對稱金鑰";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "公鑰";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 18);
            this.label12.TabIndex = 9;
            this.label12.Text = "私鑰";
            // 
            // txt_ACK
            // 
            this.txt_ACK.Location = new System.Drawing.Point(113, 150);
            this.txt_ACK.Multiline = true;
            this.txt_ACK.Name = "txt_ACK";
            this.txt_ACK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ACK.Size = new System.Drawing.Size(868, 50);
            this.txt_ACK.TabIndex = 6;
            // 
            // txt_APK
            // 
            this.txt_APK.Location = new System.Drawing.Point(113, 77);
            this.txt_APK.Multiline = true;
            this.txt_APK.Name = "txt_APK";
            this.txt_APK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_APK.Size = new System.Drawing.Size(868, 50);
            this.txt_APK.TabIndex = 7;
            // 
            // btn_AKeyGenerate
            // 
            this.btn_AKeyGenerate.Location = new System.Drawing.Point(450, 28);
            this.btn_AKeyGenerate.Name = "btn_AKeyGenerate";
            this.btn_AKeyGenerate.Size = new System.Drawing.Size(93, 29);
            this.btn_AKeyGenerate.TabIndex = 4;
            this.btn_AKeyGenerate.Text = "產生金鑰";
            this.btn_AKeyGenerate.UseVisualStyleBackColor = true;
            this.btn_AKeyGenerate.Click += new System.EventHandler(this.btn_AKeyGenerate_Click);
            // 
            // txt_HashMethod
            // 
            this.txt_HashMethod.Location = new System.Drawing.Point(421, 25);
            this.txt_HashMethod.Name = "txt_HashMethod";
            this.txt_HashMethod.ReadOnly = true;
            this.txt_HashMethod.Size = new System.Drawing.Size(127, 29);
            this.txt_HashMethod.TabIndex = 3;
            this.txt_HashMethod.Text = "SHA256";
            // 
            // txt_KeyLength
            // 
            this.txt_KeyLength.Location = new System.Drawing.Point(166, 25);
            this.txt_KeyLength.Name = "txt_KeyLength";
            this.txt_KeyLength.ReadOnly = true;
            this.txt_KeyLength.Size = new System.Drawing.Size(60, 29);
            this.txt_KeyLength.TabIndex = 3;
            this.txt_KeyLength.Text = "2048";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(470, 635);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(93, 29);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "清除";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(272, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 18);
            this.label15.TabIndex = 5;
            this.label15.Text = "簽章雜湊演算法";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "金鑰長度(bit)";
            // 
            // tab_Send
            // 
            this.tab_Send.Controls.Add(this.groupBox2);
            this.tab_Send.Controls.Add(this.txt_Content);
            this.tab_Send.Controls.Add(this.label4);
            this.tab_Send.Controls.Add(this.groupBox1);
            this.tab_Send.Controls.Add(this.btn_Send);
            this.tab_Send.Location = new System.Drawing.Point(4, 28);
            this.tab_Send.Name = "tab_Send";
            this.tab_Send.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Send.Size = new System.Drawing.Size(1049, 714);
            this.tab_Send.TabIndex = 0;
            this.tab_Send.Text = "傳送方";
            this.tab_Send.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_EncryptionData);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btn_Encryption);
            this.groupBox2.Location = new System.Drawing.Point(22, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1002, 224);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "加密";
            // 
            // txt_EncryptionData
            // 
            this.txt_EncryptionData.Location = new System.Drawing.Point(111, 95);
            this.txt_EncryptionData.Multiline = true;
            this.txt_EncryptionData.Name = "txt_EncryptionData";
            this.txt_EncryptionData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_EncryptionData.Size = new System.Drawing.Size(868, 100);
            this.txt_EncryptionData.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "加密內容";
            // 
            // btn_Encryption
            // 
            this.btn_Encryption.Location = new System.Drawing.Point(25, 40);
            this.btn_Encryption.Name = "btn_Encryption";
            this.btn_Encryption.Size = new System.Drawing.Size(400, 29);
            this.btn_Encryption.TabIndex = 2;
            this.btn_Encryption.Text = "使用接收方(乙方)公鑰加密要傳送的文件";
            this.btn_Encryption.UseVisualStyleBackColor = true;
            this.btn_Encryption.Click += new System.EventHandler(this.btn_Encryption_Click);
            // 
            // txt_Content
            // 
            this.txt_Content.Location = new System.Drawing.Point(85, 42);
            this.txt_Content.Multiline = true;
            this.txt_Content.Name = "txt_Content";
            this.txt_Content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Content.Size = new System.Drawing.Size(939, 100);
            this.txt_Content.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "文件";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Signature);
            this.groupBox1.Controls.Add(this.btn_GetSignature);
            this.groupBox1.Location = new System.Drawing.Point(22, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 168);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "加簽";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "電子簽章";
            // 
            // txt_Signature
            // 
            this.txt_Signature.Location = new System.Drawing.Point(111, 90);
            this.txt_Signature.Multiline = true;
            this.txt_Signature.Name = "txt_Signature";
            this.txt_Signature.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Signature.Size = new System.Drawing.Size(868, 50);
            this.txt_Signature.TabIndex = 0;
            // 
            // btn_GetSignature
            // 
            this.btn_GetSignature.Location = new System.Drawing.Point(25, 39);
            this.btn_GetSignature.Name = "btn_GetSignature";
            this.btn_GetSignature.Size = new System.Drawing.Size(400, 29);
            this.btn_GetSignature.TabIndex = 2;
            this.btn_GetSignature.Text = "使用我方(甲方)私鑰根據文件產生電子簽章";
            this.btn_GetSignature.UseVisualStyleBackColor = true;
            this.btn_GetSignature.Click += new System.EventHandler(this.btn_GetSignature_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(460, 642);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(110, 29);
            this.btn_Send.TabIndex = 2;
            this.btn_Send.Text = "傳送";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // tab_Receive
            // 
            this.tab_Receive.Controls.Add(this.groupBox4);
            this.tab_Receive.Controls.Add(this.groupBox3);
            this.tab_Receive.Location = new System.Drawing.Point(4, 28);
            this.tab_Receive.Name = "tab_Receive";
            this.tab_Receive.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Receive.Size = new System.Drawing.Size(1049, 714);
            this.tab_Receive.TabIndex = 1;
            this.tab_Receive.Text = "接收方";
            this.tab_Receive.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Decryption);
            this.groupBox4.Controls.Add(this.txt_DecryptContent);
            this.groupBox4.Controls.Add(this.lab_VerifyResult);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.btn_VerifySignature);
            this.groupBox4.Location = new System.Drawing.Point(22, 297);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1002, 400);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "私鑰解密";
            // 
            // btn_Decryption
            // 
            this.btn_Decryption.Location = new System.Drawing.Point(356, 43);
            this.btn_Decryption.Name = "btn_Decryption";
            this.btn_Decryption.Size = new System.Drawing.Size(350, 29);
            this.btn_Decryption.TabIndex = 2;
            this.btn_Decryption.Text = "使用我方(乙方)私鑰解密文件";
            this.btn_Decryption.UseVisualStyleBackColor = true;
            this.btn_Decryption.Click += new System.EventHandler(this.btn_Decryption_Click);
            // 
            // txt_DecryptContent
            // 
            this.txt_DecryptContent.Location = new System.Drawing.Point(111, 94);
            this.txt_DecryptContent.Multiline = true;
            this.txt_DecryptContent.Name = "txt_DecryptContent";
            this.txt_DecryptContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_DecryptContent.Size = new System.Drawing.Size(868, 100);
            this.txt_DecryptContent.TabIndex = 0;
            // 
            // lab_VerifyResult
            // 
            this.lab_VerifyResult.Location = new System.Drawing.Point(337, 299);
            this.lab_VerifyResult.Name = "lab_VerifyResult";
            this.lab_VerifyResult.Size = new System.Drawing.Size(389, 37);
            this.lab_VerifyResult.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "原始明文";
            // 
            // btn_VerifySignature
            // 
            this.btn_VerifySignature.Location = new System.Drawing.Point(351, 243);
            this.btn_VerifySignature.Name = "btn_VerifySignature";
            this.btn_VerifySignature.Size = new System.Drawing.Size(350, 29);
            this.btn_VerifySignature.TabIndex = 2;
            this.btn_VerifySignature.Text = "使用傳送方(甲方)公鑰驗證電子簽章";
            this.btn_VerifySignature.UseVisualStyleBackColor = true;
            this.btn_VerifySignature.Click += new System.EventHandler(this.btn_VerifySignature_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_A_Signature);
            this.groupBox3.Controls.Add(this.txt_EncryptContent);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(22, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1002, 248);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "接收的資料";
            // 
            // txt_A_Signature
            // 
            this.txt_A_Signature.Location = new System.Drawing.Point(111, 164);
            this.txt_A_Signature.Multiline = true;
            this.txt_A_Signature.Name = "txt_A_Signature";
            this.txt_A_Signature.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_A_Signature.Size = new System.Drawing.Size(868, 50);
            this.txt_A_Signature.TabIndex = 3;
            // 
            // txt_EncryptContent
            // 
            this.txt_EncryptContent.Location = new System.Drawing.Point(111, 39);
            this.txt_EncryptContent.Multiline = true;
            this.txt_EncryptContent.Name = "txt_EncryptContent";
            this.txt_EncryptContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_EncryptContent.Size = new System.Drawing.Size(868, 100);
            this.txt_EncryptContent.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "加密內容";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "電子簽章";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1075, 764);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "雙向RSA加簽與加密";
            this.tabControl1.ResumeLayout(false);
            this.tab_KeyGenerator.ResumeLayout(false);
            this.tab_KeyGenerator.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tab_Send.ResumeLayout(false);
            this.tab_Send.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_Receive.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Send;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_EncryptionData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Encryption;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Content;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Signature;
        private System.Windows.Forms.TabPage tab_Receive;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_A_Signature;
        private System.Windows.Forms.TextBox txt_EncryptContent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_VerifySignature;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabPage tab_KeyGenerator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_AKeyGenerate;
        private System.Windows.Forms.TextBox txt_KeyLength;
        private System.Windows.Forms.Button btn_Decryption;
        private System.Windows.Forms.TextBox txt_DecryptContent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_BCK;
        private System.Windows.Forms.TextBox txt_BPK;
        private System.Windows.Forms.Button btn_BKeyGenerate;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_ACK;
        private System.Windows.Forms.TextBox txt_APK;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txt_HashMethod;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lab_VerifyResult;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_GetSignature;
    }
}

