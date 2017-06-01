using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace RSA_POC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 產生金鑰

        private void btn_AKeyGenerate_Click(object sender, EventArgs e)
        {
            string HashMethod = txt_HashMethod.Text;

            int KeyLength = Convert.ToInt16(txt_KeyLength.Text);

            //CspParameters cp = new CspParameters();
            //cp.KeyContainerName = "MyKeyContainerName";

            //RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(cp);
            //RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(KeyLength, cp);

            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(KeyLength);
            txt_APK.Text = RSA.ToXmlString(true);
            txt_ACK.Text = RSA.ToXmlString(false);
        }

        private void btn_BKeyGenerate_Click(object sender, EventArgs e)
        {
            string HashMethod = txt_HashMethod.Text;

            int KeyLength = Convert.ToInt16(txt_KeyLength.Text);

            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(KeyLength);
            txt_BPK.Text = RSA.ToXmlString(true);
            txt_BCK.Text = RSA.ToXmlString(false);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_APK.Text = string.Empty;
            txt_ACK.Text = string.Empty;
            txt_BPK.Text = string.Empty;
            txt_BCK.Text = string.Empty;
            txt_Content.Text = string.Empty;
            txt_Signature.Text = string.Empty;
            txt_EncryptionData.Text = string.Empty;
            txt_DecryptContent.Text = string.Empty;
            txt_A_Signature.Text = string.Empty;
            lab_VerifyResult.Text = string.Empty;
        }

        #endregion

        #region 傳送方
        private void btn_GetSignature_Click(object sender, EventArgs e)
        {
            try
            {
                RSACryptoServiceProvider Private_RSA = new RSACryptoServiceProvider();
                Private_RSA.FromXmlString(txt_APK.Text);

                string Content = txt_Content.Text;
                byte[] bytes = Encoding.UTF8.GetBytes(Content);
                byte[] signature = Private_RSA.SignData(bytes, new SHA256CryptoServiceProvider());

                txt_Signature.Text = Convert.ToBase64String(signature);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Get signature error occur");
            }
        }
        private void btn_Encryption_Click(object sender, EventArgs e)
        {
            try
            {
                string Content = txt_Content.Text;
                byte[] bytes = Encoding.UTF8.GetBytes(Content);

                RSACryptoServiceProvider B_Public_RSA = new RSACryptoServiceProvider();
                B_Public_RSA.FromXmlString(txt_BCK.Text);

                txt_EncryptionData.Text = Convert.ToBase64String(B_Public_RSA.Encrypt(bytes, false));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption error occur");
            }

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            lab_VerifyResult.Text = string.Empty;

            txt_EncryptContent.Text = txt_EncryptionData.Text;
            txt_A_Signature.Text = txt_Signature.Text;

            txt_DecryptContent.Text = string.Empty;
            tabControl1.SelectedIndex = 2;
        }
        #endregion

        #region 接收方
        private void btn_Decryption_Click(object sender, EventArgs e)
        {
            txt_DecryptContent.Text = string.Empty;
            try
            {
                RSACryptoServiceProvider B_Private_RSA = new RSACryptoServiceProvider();
                B_Private_RSA.FromXmlString(txt_BPK.Text);

                string Content = txt_EncryptContent.Text;
                byte[] bytes = Convert.FromBase64String(Content);

                bytes = B_Private_RSA.Decrypt(bytes, false);
                txt_DecryptContent.Text = Encoding.UTF8.GetString(bytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Decryption error occur");
            }
        }

        private void btn_VerifySignature_Click(object sender, EventArgs e)
        {
            try
            {
                RSACryptoServiceProvider A_Public_RSA = new RSACryptoServiceProvider();
                A_Public_RSA.FromXmlString(txt_ACK.Text);

                byte[] signature = Convert.FromBase64String(txt_A_Signature.Text);

                string Content = txt_DecryptContent.Text;
                byte[] bytes = Encoding.UTF8.GetBytes(Content);

                //呼叫 VerifyData 方法, 驗證本文與簽章是否相符
                if (A_Public_RSA.VerifyData(bytes, new SHA256CryptoServiceProvider(), signature))
                {
                    lab_VerifyResult.ForeColor = Color.Green;
                    lab_VerifyResult.Text = "Verify successful";
                }
                else
                {
                    lab_VerifyResult.ForeColor = Color.Red;
                    lab_VerifyResult.Text = "Verify failed";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verify signature error occur");
            }
        }
        #endregion

        #region AES Tool
        /// <summary>
        /// 使用AES 256 加密
        /// </summary>
        /// <param name="source">本文</param>
        /// <param name="key">因為是256 所以你密碼必須為32英文字=32*8=256</param>
        /// <param name="iv">IV為128 所以為 16 * 8= 128</param>
        /// <returns></returns>
        private void btn_AES_Enc_Click(object sender, EventArgs e)
        {
            var key = txt_AES_Key.Text;
            var iv = txt_AES_IV.Text;

            byte[] sourceBytes = Encoding.UTF8.GetBytes(txt_AES_Conten.Text);
            var aes = new RijndaelManaged();

            if (cb_Key_Base64.Checked)
            {
                aes.Key = Convert.FromBase64String(key);
            }
            else
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
            }

            if (cb_IV_Base64.Checked)
            {
                aes.IV = Convert.FromBase64String(iv);
            }
            else
            {
                aes.IV = Encoding.UTF8.GetBytes(iv);
            }


            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            ICryptoTransform transform = aes.CreateEncryptor();

            txt_AES_EncContent.Text = Convert.ToBase64String(transform.TransformFinalBlock(sourceBytes, 0, sourceBytes.Length));
        }
        /// <summary>
        /// 使用AES 256 解密
        /// </summary>
        /// <param name="encryptData">Base64的加密後的字串</param>
        /// <param name="key">因為是256 所以你密碼必須為32英文字=32*8=256</param>
        /// <param name="iv">IV為128 所以為 16 * 8= 128</param>
        /// <returns></returns>
        private void btn_AES_Dec_Click(object sender, EventArgs e)
        {
            var key = txt_AES_Key.Text;
            var iv = txt_AES_IV.Text;

            var encryptBytes = Convert.FromBase64String(txt_AES_EncContent.Text);
            var aes = new RijndaelManaged();

            if (cb_Key_Base64.Checked)
            {
                aes.Key = Convert.FromBase64String(key);
            }
            else
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
            }

            if (cb_IV_Base64.Checked)
            {
                aes.IV = Convert.FromBase64String(iv);
            }
            else
            {
                aes.IV = Encoding.UTF8.GetBytes(iv);
            }

            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            ICryptoTransform transform = aes.CreateDecryptor();

            txt_AES_DecContent.Text = Encoding.UTF8.GetString(transform.TransformFinalBlock(encryptBytes, 0, encryptBytes.Length));
        }
        #endregion

        private void btn_AES_KeyGenerate_Click(object sender, EventArgs e)
        {
            byte[] Key = new byte[32];
            byte[] IV = new byte[16];

            using (AesCryptoServiceProvider csp = new AesCryptoServiceProvider())
            {
                IV = csp.IV;
                Key = csp.Key;

                txt_AES_IV.Text = Convert.ToBase64String(IV);
                txt_AES_Key.Text = Convert.ToBase64String(Key);
            }
        }
    }
}
