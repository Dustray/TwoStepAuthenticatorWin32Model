using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TwoStepAuthenticatorWin32Model
{
    static class AuthModel
    {

        public static class Server
        {
            private static string secretKey;//模拟服务端保存的密钥//应加密后存储在服务器中

            //验证密钥
            public static bool verifySecret(string userCode)
            {
                if (secretKey == null)
                {
                    throw new NullReferenceException("当前密钥为空！");
                }
                else
                {
                    var secret = secretKey;
                    var code = userCode;
                    var authenticator = new TwoStepsAuthenticator.TimeAuthenticator();
                    return authenticator.CheckCode(secret, code, "user特朗普");
                }
            }
            //生成密钥
            public static string generateSecretKey()
            {
                return TwoStepsAuthenticator.Authenticator.GenerateKey();
            }
            //保存密钥
            public static string saveSecretKey()
            {
                secretKey = generateSecretKey();
                return secretKey;
            }
            //保存密钥
            public static void saveSecretKey(string secret)
            {
                secretKey = secret;
            }
            //判断密钥是否为空
            public static bool checkIsSecretEmpty()
            {
                if (secretKey == null) return true;
                else return false;
            }
            //判断密钥是否为空
            public static void removeSecret()
            {
                if (secretKey != null)
                    secretKey = null;
            }
        }
        public static class Cilent
        {
            private static string secretKey;//模拟客户端保存的密钥//应加密后存储在客户端中

            //获取验证码
            public static string getCodeFromSecret()
            {
                if (secretKey == null)
                {
                    throw new NullReferenceException("当前密钥为空！");
                }
                else
                {
                    var authenticator = new TwoStepsAuthenticator.TimeAuthenticator();
                    return authenticator.GetCode(secretKey);
                }
            }

            //根据密钥获取验证码
            public static string getCodeFromSecret(string secret)
            {
                secretKey = secret;
                var authenticator = new TwoStepsAuthenticator.TimeAuthenticator();
                return authenticator.GetCode(secretKey);
            }

            //保存密钥
            public static void saveSecretKey(string secret)
            {
                secretKey = secret;
            }
            //判断密钥是否为空
            public static bool checkIsSecretEmpty()
            {
                if (secretKey == null) return true;
                else return false;
            }
        }
        //获取当前UNIX时间
        public static long GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds * 1000);
        }
        //设置计数器
        public static int SetCountTime()
        {
            //设置计数器
            long timeLong = (AuthModel.GetTimeStamp() / 1000);
            long timeLongAfter = (AuthModel.GetTimeStamp() / 1000 / 30) * 30;
            return 30 - (int)(timeLong - timeLongAfter) + 1;
        }
        //判断是否为Code格式
        public static bool isNumeric(string message)
        {
            if (message != "" && Regex.IsMatch(message, @"^\d{6}$"))
            {
                //成功
                return true;
            }
            else
            {
                //失败
                return false;
            }
        }
    }
}
