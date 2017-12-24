using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//This program powered by TwoStepsAuthenticator ：https://github.com/glacasa/TwoStepsAuthenticator

namespace TwoStepAuthenticatorWin32Model
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        private void serverRefreshNewSecretBtn_Click(object sender, EventArgs e)
        {
            serverGenerateNewSerectText.Text = AuthModel.Server.generateSecretKey();
        }
        //服务端保存新密钥
        private void serverSetNewSecretBtn_Click(object sender, EventArgs e)
        {
            if (serverGenerateNewSerectText.Text != ""&& serverGenerateNewSerectText.Text.Length>10)
            {
                AuthModel.Server.saveSecretKey(serverGenerateNewSerectText.Text);
            }else if(serverGenerateNewSerectText.Text == "")
            {
                serverGenerateNewSerectText.Text=AuthModel.Server.saveSecretKey();
            }
            else
            {
                MessageBox.Show("服务端：密钥不合法。");
            }
        }
        //客户端快捷粘贴
        private void cilentPasteSecretBtn_Click(object sender, EventArgs e)
        {
            if (serverGenerateNewSerectText.Text != "" && serverGenerateNewSerectText.Text.Length > 10)
            {
                cilentAddSecretText.Text = serverGenerateNewSerectText.Text;
            }
            else
            {
                MessageBox.Show("客户端：粘贴失败，来自服务端的密钥不合法。");
            }
        }
        //客户端保存密钥
        private void cilentAddSecretBtn_Click(object sender, EventArgs e)
        {
            if (cilentAddSecretText.Text != "" && cilentAddSecretText.Text.Length > 10)
            {
                AuthModel.Cilent.saveSecretKey(cilentAddSecretText.Text);
                cilentShowSecretLab.Text = AuthModel.Cilent.getCodeFromSecret();
            }
            else
            {
                MessageBox.Show("客户端：密钥不合法。");
            }
        }

        private void cilentSecretTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
