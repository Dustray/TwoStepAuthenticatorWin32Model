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
            this.label7 = new System.Windows.Forms.Label();
            this.serverSetNewSecretBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.serverGenerateNewSerectText = new System.Windows.Forms.TextBox();
            this.verificationSecret = new System.Windows.Forms.TabPage();
            this.deleteSecret = new System.Windows.Forms.TabPage();
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
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.serverRefreshNewSecretBtn = new System.Windows.Forms.Button();
            this.cilentSecretTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.resetSecret.SuspendLayout();
            this.verificationSecret.SuspendLayout();
            this.deleteSecret.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(346, 320);
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(337, 267);
            this.tabControl1.TabIndex = 0;
            // 
            // resetSecret
            // 
            this.resetSecret.Controls.Add(this.serverRefreshNewSecretBtn);
            this.resetSecret.Controls.Add(this.label7);
            this.resetSecret.Controls.Add(this.serverSetNewSecretBtn);
            this.resetSecret.Controls.Add(this.label6);
            this.resetSecret.Controls.Add(this.serverGenerateNewSerectText);
            this.resetSecret.Location = new System.Drawing.Point(4, 22);
            this.resetSecret.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resetSecret.Name = "resetSecret";
            this.resetSecret.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resetSecret.Size = new System.Drawing.Size(329, 241);
            this.resetSecret.TabIndex = 0;
            this.resetSecret.Text = "重设密钥";
            this.resetSecret.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "请勿随意记录和保存此密钥；\r\n请勿将此密钥告诉任何人。";
            // 
            // serverSetNewSecretBtn
            // 
            this.serverSetNewSecretBtn.Location = new System.Drawing.Point(225, 123);
            this.serverSetNewSecretBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serverSetNewSecretBtn.Name = "serverSetNewSecretBtn";
            this.serverSetNewSecretBtn.Size = new System.Drawing.Size(77, 27);
            this.serverSetNewSecretBtn.TabIndex = 2;
            this.serverSetNewSecretBtn.Text = "设为密钥";
            this.serverSetNewSecretBtn.UseVisualStyleBackColor = true;
            this.serverSetNewSecretBtn.Click += new System.EventHandler(this.serverSetNewSecretBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(21, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "密钥：";
            // 
            // serverGenerateNewSerectText
            // 
            this.serverGenerateNewSerectText.Font = new System.Drawing.Font("宋体", 12F);
            this.serverGenerateNewSerectText.Location = new System.Drawing.Point(24, 88);
            this.serverGenerateNewSerectText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.serverGenerateNewSerectText.Name = "serverGenerateNewSerectText";
            this.serverGenerateNewSerectText.Size = new System.Drawing.Size(279, 26);
            this.serverGenerateNewSerectText.TabIndex = 0;
            // 
            // verificationSecret
            // 
            this.verificationSecret.Controls.Add(this.label9);
            this.verificationSecret.Controls.Add(this.button4);
            this.verificationSecret.Controls.Add(this.label10);
            this.verificationSecret.Controls.Add(this.textBox4);
            this.verificationSecret.Location = new System.Drawing.Point(4, 22);
            this.verificationSecret.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.verificationSecret.Name = "verificationSecret";
            this.verificationSecret.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.verificationSecret.Size = new System.Drawing.Size(329, 241);
            this.verificationSecret.TabIndex = 1;
            this.verificationSecret.Text = "验证密钥";
            this.verificationSecret.UseVisualStyleBackColor = true;
            // 
            // deleteSecret
            // 
            this.deleteSecret.Controls.Add(this.label11);
            this.deleteSecret.Controls.Add(this.button5);
            this.deleteSecret.Controls.Add(this.label12);
            this.deleteSecret.Controls.Add(this.textBox5);
            this.deleteSecret.Location = new System.Drawing.Point(4, 22);
            this.deleteSecret.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteSecret.Name = "deleteSecret";
            this.deleteSecret.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteSecret.Size = new System.Drawing.Size(329, 241);
            this.deleteSecret.TabIndex = 2;
            this.deleteSecret.Text = "删除密钥";
            this.deleteSecret.UseVisualStyleBackColor = true;
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
            this.groupBox2.Location = new System.Drawing.Point(357, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(346, 320);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "模拟客户端（手机）";
            // 
            // cilentTimerLab
            // 
            this.cilentTimerLab.AutoSize = true;
            this.cilentTimerLab.Font = new System.Drawing.Font("宋体", 12F);
            this.cilentTimerLab.Location = new System.Drawing.Point(282, 258);
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
            this.cilentShowUserLab.Location = new System.Drawing.Point(45, 138);
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
            this.cilentShowSecretLab.Location = new System.Drawing.Point(37, 162);
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
            this.label3.Location = new System.Drawing.Point(4, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "验证码：";
            // 
            // cilentAddSecretBtn
            // 
            this.cilentAddSecretBtn.Location = new System.Drawing.Point(268, 44);
            this.cilentAddSecretBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.cilentAddSecretText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cilentAddSecretText.Name = "cilentAddSecretText";
            this.cilentAddSecretText.Size = new System.Drawing.Size(216, 21);
            this.cilentAddSecretText.TabIndex = 2;
            // 
            // cilentPasteSecretBtn
            // 
            this.cilentPasteSecretBtn.Location = new System.Drawing.Point(268, 19);
            this.cilentPasteSecretBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.cilentUserText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cilentUserText.Name = "cilentUserText";
            this.cilentUserText.Size = new System.Drawing.Size(216, 21);
            this.cilentUserText.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 129);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "验证状态：";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(225, 123);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 27);
            this.button4.TabIndex = 6;
            this.button4.Text = "验  证";
            this.button4.UseVisualStyleBackColor = true;
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
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox4.Location = new System.Drawing.Point(24, 88);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(279, 26);
            this.textBox4.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 129);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "密钥状态：";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(225, 123);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 27);
            this.button5.TabIndex = 10;
            this.button5.Text = "删  除";
            this.button5.UseVisualStyleBackColor = true;
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
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox5.Location = new System.Drawing.Point(24, 88);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(279, 26);
            this.textBox5.TabIndex = 8;
            // 
            // serverRefreshNewSecretBtn
            // 
            this.serverRefreshNewSecretBtn.Location = new System.Drawing.Point(225, 57);
            this.serverRefreshNewSecretBtn.Margin = new System.Windows.Forms.Padding(2);
            this.serverRefreshNewSecretBtn.Name = "serverRefreshNewSecretBtn";
            this.serverRefreshNewSecretBtn.Size = new System.Drawing.Size(77, 25);
            this.serverRefreshNewSecretBtn.TabIndex = 4;
            this.serverRefreshNewSecretBtn.Text = "刷  新";
            this.serverRefreshNewSecretBtn.UseVisualStyleBackColor = true;
            this.serverRefreshNewSecretBtn.Click += new System.EventHandler(this.serverRefreshNewSecretBtn_Click);
            // 
            // cilentSecretTimer
            // 
            this.cilentSecretTimer.Enabled = true;
            this.cilentSecretTimer.Interval = 1000;
            this.cilentSecretTimer.Tick += new System.EventHandler(this.cilentSecretTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 341);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button serverRefreshNewSecretBtn;
        private System.Windows.Forms.Timer cilentSecretTimer;
    }
}

