namespace TwoStepAuthenticatorWin32Model
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.resetSecret = new System.Windows.Forms.TabPage();
            this.serverRefreshNewSecretBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.serverSetNewSecretBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.serverGenerateNewSerectText = new System.Windows.Forms.TextBox();
            this.verificationSecret = new System.Windows.Forms.TabPage();
            this.serverVerifyCodeBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.serverVerifyCodeText = new System.Windows.Forms.TextBox();
            this.deleteSecret = new System.Windows.Forms.TabPage();
            this.serverDeleteCodeBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.serverDeleteCodeText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cilentTimerLab = new System.Windows.Forms.Label();
            this.cilentShowUserLab = new System.Windows.Forms.Label();
            this.cilentShowSecretLab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cilentAddSecretBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cilentAddSecretText = new System.Windows.Forms.TextBox();
            this.cilentPasteSecretBtn = new System.Windows.Forms.Button();
            this.cilentUserText = new System.Windows.Forms.TextBox();
            this.cilentSecretTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.serverGenerateNewSerectQR = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serverGenerateNewUserText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.resetSecret.SuspendLayout();
            this.verificationSecret.SuspendLayout();
            this.deleteSecret.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverGenerateNewSerectQR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(346, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "模拟服务端（网站）";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.resetSecret);
            this.tabControl1.Controls.Add(this.verificationSecret);
            this.tabControl1.Controls.Add(this.deleteSecret);
            this.tabControl1.Location = new System.Drawing.Point(4, 19);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(337, 267);
            this.tabControl1.TabIndex = 0;
            // 
            // resetSecret
            // 
            this.resetSecret.Controls.Add(this.serverGenerateNewUserText);
            this.resetSecret.Controls.Add(this.serverGenerateNewSerectText);
            this.resetSecret.Controls.Add(this.label4);
            this.resetSecret.Controls.Add(this.serverGenerateNewSerectQR);
            this.resetSecret.Controls.Add(this.serverRefreshNewSecretBtn);
            this.resetSecret.Controls.Add(this.label7);
            this.resetSecret.Controls.Add(this.serverSetNewSecretBtn);
            this.resetSecret.Controls.Add(this.label6);
            this.resetSecret.Location = new System.Drawing.Point(4, 22);
            this.resetSecret.Margin = new System.Windows.Forms.Padding(2);
            this.resetSecret.Name = "resetSecret";
            this.resetSecret.Padding = new System.Windows.Forms.Padding(2);
            this.resetSecret.Size = new System.Drawing.Size(329, 241);
            this.resetSecret.TabIndex = 0;
            this.resetSecret.Text = "重设密钥";
            this.resetSecret.UseVisualStyleBackColor = true;
            // 
            // serverRefreshNewSecretBtn
            // 
            this.serverRefreshNewSecretBtn.Location = new System.Drawing.Point(227, 6);
            this.serverRefreshNewSecretBtn.Margin = new System.Windows.Forms.Padding(2);
            this.serverRefreshNewSecretBtn.Name = "serverRefreshNewSecretBtn";
            this.serverRefreshNewSecretBtn.Size = new System.Drawing.Size(76, 26);
            this.serverRefreshNewSecretBtn.TabIndex = 4;
            this.serverRefreshNewSecretBtn.Text = "刷  新";
            this.serverRefreshNewSecretBtn.UseVisualStyleBackColor = true;
            this.serverRefreshNewSecretBtn.Click += new System.EventHandler(this.serverRefreshNewSecretBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 60);
            this.label7.TabIndex = 3;
            this.label7.Text = "请勿随意记录\r\n和保存此密钥；\r\n\r\n请勿将此密钥\r\n告诉任何人。";
            // 
            // serverSetNewSecretBtn
            // 
            this.serverSetNewSecretBtn.Location = new System.Drawing.Point(227, 68);
            this.serverSetNewSecretBtn.Margin = new System.Windows.Forms.Padding(2);
            this.serverSetNewSecretBtn.Name = "serverSetNewSecretBtn";
            this.serverSetNewSecretBtn.Size = new System.Drawing.Size(76, 27);
            this.serverSetNewSecretBtn.TabIndex = 2;
            this.serverSetNewSecretBtn.Text = "设为密钥";
            this.serverSetNewSecretBtn.UseVisualStyleBackColor = true;
            this.serverSetNewSecretBtn.Click += new System.EventHandler(this.serverSetNewSecretBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(11, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "密  钥：";
            // 
            // serverGenerateNewSerectText
            // 
            this.serverGenerateNewSerectText.Font = new System.Drawing.Font("宋体", 12F);
            this.serverGenerateNewSerectText.Location = new System.Drawing.Point(78, 38);
            this.serverGenerateNewSerectText.Margin = new System.Windows.Forms.Padding(2);
            this.serverGenerateNewSerectText.Name = "serverGenerateNewSerectText";
            this.serverGenerateNewSerectText.Size = new System.Drawing.Size(225, 26);
            this.serverGenerateNewSerectText.TabIndex = 0;
            // 
            // verificationSecret
            // 
            this.verificationSecret.Controls.Add(this.serverVerifyCodeBtn);
            this.verificationSecret.Controls.Add(this.label10);
            this.verificationSecret.Controls.Add(this.serverVerifyCodeText);
            this.verificationSecret.Location = new System.Drawing.Point(4, 22);
            this.verificationSecret.Margin = new System.Windows.Forms.Padding(2);
            this.verificationSecret.Name = "verificationSecret";
            this.verificationSecret.Padding = new System.Windows.Forms.Padding(2);
            this.verificationSecret.Size = new System.Drawing.Size(329, 241);
            this.verificationSecret.TabIndex = 1;
            this.verificationSecret.Text = "验证密钥";
            this.verificationSecret.UseVisualStyleBackColor = true;
            // 
            // serverVerifyCodeBtn
            // 
            this.serverVerifyCodeBtn.Location = new System.Drawing.Point(225, 123);
            this.serverVerifyCodeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.serverVerifyCodeBtn.Name = "serverVerifyCodeBtn";
            this.serverVerifyCodeBtn.Size = new System.Drawing.Size(77, 27);
            this.serverVerifyCodeBtn.TabIndex = 6;
            this.serverVerifyCodeBtn.Text = "验  证";
            this.serverVerifyCodeBtn.UseVisualStyleBackColor = true;
            this.serverVerifyCodeBtn.Click += new System.EventHandler(this.serverVerifyCodeBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F);
            this.label10.Location = new System.Drawing.Point(21, 59);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "验证码：";
            // 
            // serverVerifyCodeText
            // 
            this.serverVerifyCodeText.Font = new System.Drawing.Font("宋体", 12F);
            this.serverVerifyCodeText.Location = new System.Drawing.Point(24, 88);
            this.serverVerifyCodeText.Margin = new System.Windows.Forms.Padding(2);
            this.serverVerifyCodeText.Name = "serverVerifyCodeText";
            this.serverVerifyCodeText.Size = new System.Drawing.Size(279, 26);
            this.serverVerifyCodeText.TabIndex = 4;
            // 
            // deleteSecret
            // 
            this.deleteSecret.Controls.Add(this.serverDeleteCodeBtn);
            this.deleteSecret.Controls.Add(this.label12);
            this.deleteSecret.Controls.Add(this.serverDeleteCodeText);
            this.deleteSecret.Location = new System.Drawing.Point(4, 22);
            this.deleteSecret.Margin = new System.Windows.Forms.Padding(2);
            this.deleteSecret.Name = "deleteSecret";
            this.deleteSecret.Padding = new System.Windows.Forms.Padding(2);
            this.deleteSecret.Size = new System.Drawing.Size(329, 241);
            this.deleteSecret.TabIndex = 2;
            this.deleteSecret.Text = "删除密钥";
            this.deleteSecret.UseVisualStyleBackColor = true;
            // 
            // serverDeleteCodeBtn
            // 
            this.serverDeleteCodeBtn.Location = new System.Drawing.Point(225, 123);
            this.serverDeleteCodeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.serverDeleteCodeBtn.Name = "serverDeleteCodeBtn";
            this.serverDeleteCodeBtn.Size = new System.Drawing.Size(77, 27);
            this.serverDeleteCodeBtn.TabIndex = 10;
            this.serverDeleteCodeBtn.Text = "删  除";
            this.serverDeleteCodeBtn.UseVisualStyleBackColor = true;
            this.serverDeleteCodeBtn.Click += new System.EventHandler(this.serverDeleteCodeBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F);
            this.label12.Location = new System.Drawing.Point(21, 59);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "验证码：";
            // 
            // serverDeleteCodeText
            // 
            this.serverDeleteCodeText.Font = new System.Drawing.Font("宋体", 12F);
            this.serverDeleteCodeText.Location = new System.Drawing.Point(24, 88);
            this.serverDeleteCodeText.Margin = new System.Windows.Forms.Padding(2);
            this.serverDeleteCodeText.Name = "serverDeleteCodeText";
            this.serverDeleteCodeText.Size = new System.Drawing.Size(279, 26);
            this.serverDeleteCodeText.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cilentTimerLab);
            this.groupBox2.Controls.Add(this.cilentShowUserLab);
            this.groupBox2.Controls.Add(this.cilentShowSecretLab);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cilentAddSecretBtn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cilentAddSecretText);
            this.groupBox2.Controls.Add(this.cilentPasteSecretBtn);
            this.groupBox2.Controls.Add(this.cilentUserText);
            this.groupBox2.Location = new System.Drawing.Point(360, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(346, 296);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "模拟客户端（手机）";
            // 
            // cilentTimerLab
            // 
            this.cilentTimerLab.AutoSize = true;
            this.cilentTimerLab.Font = new System.Drawing.Font("宋体", 12F);
            this.cilentTimerLab.Location = new System.Drawing.Point(282, 248);
            this.cilentTimerLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cilentTimerLab.Name = "cilentTimerLab";
            this.cilentTimerLab.Size = new System.Drawing.Size(24, 16);
            this.cilentTimerLab.TabIndex = 9;
            this.cilentTimerLab.Text = "30";
            // 
            // cilentShowUserLab
            // 
            this.cilentShowUserLab.AutoSize = true;
            this.cilentShowUserLab.Font = new System.Drawing.Font("宋体", 15F);
            this.cilentShowUserLab.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cilentShowUserLab.Location = new System.Drawing.Point(45, 128);
            this.cilentShowUserLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cilentShowUserLab.Name = "cilentShowUserLab";
            this.cilentShowUserLab.Size = new System.Drawing.Size(159, 20);
            this.cilentShowUserLab.TabIndex = 8;
            this.cilentShowUserLab.Text = "12345678@qq.com";
            // 
            // cilentShowSecretLab
            // 
            this.cilentShowSecretLab.AutoSize = true;
            this.cilentShowSecretLab.Font = new System.Drawing.Font("宋体", 55F);
            this.cilentShowSecretLab.Location = new System.Drawing.Point(37, 152);
            this.cilentShowSecretLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cilentShowSecretLab.Name = "cilentShowSecretLab";
            this.cilentShowSecretLab.Size = new System.Drawing.Size(291, 74);
            this.cilentShowSecretLab.TabIndex = 7;
            this.cilentShowSecretLab.Text = "--- ---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(4, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "验证码：";
            // 
            // cilentAddSecretBtn
            // 
            this.cilentAddSecretBtn.Location = new System.Drawing.Point(268, 44);
            this.cilentAddSecretBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cilentAddSecretBtn.Name = "cilentAddSecretBtn";
            this.cilentAddSecretBtn.Size = new System.Drawing.Size(74, 20);
            this.cilentAddSecretBtn.TabIndex = 5;
            this.cilentAddSecretBtn.Text = "添加";
            this.cilentAddSecretBtn.UseVisualStyleBackColor = true;
            this.cilentAddSecretBtn.Click += new System.EventHandler(this.cilentAddSecretBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "密钥：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "账号：";
            // 
            // cilentAddSecretText
            // 
            this.cilentAddSecretText.Location = new System.Drawing.Point(49, 44);
            this.cilentAddSecretText.Margin = new System.Windows.Forms.Padding(2);
            this.cilentAddSecretText.Name = "cilentAddSecretText";
            this.cilentAddSecretText.Size = new System.Drawing.Size(216, 21);
            this.cilentAddSecretText.TabIndex = 2;
            // 
            // cilentPasteSecretBtn
            // 
            this.cilentPasteSecretBtn.Location = new System.Drawing.Point(268, 19);
            this.cilentPasteSecretBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cilentPasteSecretBtn.Name = "cilentPasteSecretBtn";
            this.cilentPasteSecretBtn.Size = new System.Drawing.Size(74, 20);
            this.cilentPasteSecretBtn.TabIndex = 1;
            this.cilentPasteSecretBtn.Text = "粘贴";
            this.cilentPasteSecretBtn.UseVisualStyleBackColor = true;
            this.cilentPasteSecretBtn.Click += new System.EventHandler(this.cilentPasteSecretBtn_Click);
            // 
            // cilentUserText
            // 
            this.cilentUserText.Location = new System.Drawing.Point(49, 19);
            this.cilentUserText.Margin = new System.Windows.Forms.Padding(2);
            this.cilentUserText.Name = "cilentUserText";
            this.cilentUserText.Size = new System.Drawing.Size(216, 21);
            this.cilentUserText.TabIndex = 0;
            // 
            // cilentSecretTimer
            // 
            this.cilentSecretTimer.Interval = 1000;
            this.cilentSecretTimer.Tick += new System.EventHandler(this.cilentSecretTimer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 319);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(716, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // serverGenerateNewSerectQR
            // 
            this.serverGenerateNewSerectQR.Location = new System.Drawing.Point(32, 72);
            this.serverGenerateNewSerectQR.Name = "serverGenerateNewSerectQR";
            this.serverGenerateNewSerectQR.Size = new System.Drawing.Size(163, 163);
            this.serverGenerateNewSerectQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.serverGenerateNewSerectQR.TabIndex = 5;
            this.serverGenerateNewSerectQR.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(11, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "用户名：";
            // 
            // serverGenerateNewUserText
            // 
            this.serverGenerateNewUserText.Font = new System.Drawing.Font("宋体", 12F);
            this.serverGenerateNewUserText.Location = new System.Drawing.Point(78, 6);
            this.serverGenerateNewUserText.Margin = new System.Windows.Forms.Padding(2);
            this.serverGenerateNewUserText.Name = "serverGenerateNewUserText";
            this.serverGenerateNewUserText.Size = new System.Drawing.Size(143, 26);
            this.serverGenerateNewUserText.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 341);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(732, 525);
            this.MinimumSize = new System.Drawing.Size(732, 380);
            this.Name = "Form1";
            this.Text = "两步验证（谷歌规则）";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.resetSecret.ResumeLayout(false);
            this.resetSecret.PerformLayout();
            this.verificationSecret.ResumeLayout(false);
            this.verificationSecret.PerformLayout();
            this.deleteSecret.ResumeLayout(false);
            this.deleteSecret.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverGenerateNewSerectQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage resetSecret;
        private System.Windows.Forms.TabPage verificationSecret;
        private System.Windows.Forms.TabPage deleteSecret;
        private System.Windows.Forms.TextBox cilentAddSecretText;
        private System.Windows.Forms.Button cilentPasteSecretBtn;
        private System.Windows.Forms.TextBox cilentUserText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cilentAddSecretBtn;
        private System.Windows.Forms.Label cilentShowSecretLab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cilentShowUserLab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button serverSetNewSecretBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox serverGenerateNewSerectText;
        private System.Windows.Forms.Label cilentTimerLab;
        private System.Windows.Forms.Button serverVerifyCodeBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox serverVerifyCodeText;
        private System.Windows.Forms.Button serverDeleteCodeBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox serverDeleteCodeText;
        private System.Windows.Forms.Button serverRefreshNewSecretBtn;
        private System.Windows.Forms.Timer cilentSecretTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox serverGenerateNewUserText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox serverGenerateNewSerectQR;
    }
}

