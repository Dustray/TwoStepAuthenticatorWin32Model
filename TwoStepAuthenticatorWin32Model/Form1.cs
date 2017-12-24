using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


//This program powered by TwoStepsAuthenticator ：https://github.com/glacasa/TwoStepsAuthenticator

namespace TwoStepAuthenticatorWin32Model
{
    public partial class Form1 : Form
    {
        private static int Count = 30;
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
                string se = AuthModel.Cilent.getCodeFromSecret();
                cilentShowSecretLab.Text = se.Insert(3," ");
                //设置计数器
                Count = AuthModel.SetCountTime();
            }
            else
            {
                MessageBox.Show("客户端：密钥不合法。");
            }

            if (cilentUserText.Text == "")
            {
                cilentShowUserLab.Text = "Trump@usa.com";
            }
            else
            {
                cilentShowUserLab.Text = cilentUserText.Text;
            }
        }



        private void cilentSecretTimer_Tick(object sender, EventArgs e)
        {
             //计数器归零重设验证码
            if (Count == 0)
            {
                string se = AuthModel.Cilent.getCodeFromSecret();
                cilentShowSecretLab.Text = se.Insert(3, " ");
                Count = 30;
            }

            cilentTimerLab.Text = "" + Count--;
        }

        private void serverVerifyCodeBtn_Click(object sender, EventArgs e)
        {
            string code = serverVerifyCodeText.Text.ToString();
            if (AuthModel.Server.checkIsSecretEmpty())
            {
                MessageBox.Show("当前未开启两步验证。");
            }
            else if(AuthModel.isNumeric(code))
            {
                if (AuthModel.Server.verifySecret(code))
                {
                    //验证成功
                    MessageBox.Show("验证成功！");
                }
                else
                {
                    //验证失败
                    MessageBox.Show("验证码错误！");
                }
            }
            else
            {
                MessageBox.Show("输入格式不正确");
            }
        }

        private void serverDeleteCodeBtn_Click(object sender, EventArgs e)
        {
            string code = serverDeleteCodeText.Text.ToString();
            if (AuthModel.Server.checkIsSecretEmpty())
            {
                MessageBox.Show("当前未开启两步验证。");
            }
            else if (AuthModel.isNumeric(code))
            {
                if (AuthModel.Server.verifySecret(code))
                {
                    //验证成功
                    AuthModel.Server.removeSecret();
                    MessageBox.Show("验证成功,两步验证已关闭！");
                }
                else
                {
                    //验证失败
                    MessageBox.Show("验证码错误！");
                }
            }
            else
            {
                MessageBox.Show("输入格式不正确");
            }
        }
    }
}
