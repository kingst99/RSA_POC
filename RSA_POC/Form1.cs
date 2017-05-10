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

using System.Security.Cryptography.X509Certificates;

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
            //TextBox txt_HashMethod = (TextBox)tabControl1.GetControl(0).Controls.Find("txt_HashMethod", true).FirstOrDefault();
            string HashMethod = txt_HashMethod.Text;

            //TextBox txt_KeyLength = (TextBox)tabControl1.GetControl(0).Controls.Find("txt_KeyLength", true).FirstOrDefault();
            int KeyLength = Convert.ToInt16(txt_KeyLength.Text);

            //TextBox txt_APK = (TextBox)tabControl1.GetControl(0).Controls.Find("txt_APK", true).FirstOrDefault();

            CspParameters cp = new CspParameters();
            cp.KeyContainerName = "MyKeyContainerName";

            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(KeyLength, cp);
            txt_APK.Text = RSA.ToXmlString(true);
            txt_ACK.Text = RSA.ToXmlString(false);

            //RSACryptoServiceProvider Private_RSA = new RSACryptoServiceProvider();
            //Private_RSA.FromXmlString(txt_APK.Text);
            //string APK = Private_RSA.ToXmlString(true);
            //RSAParameters Private_RSAKeyInfo = Private_RSA.ExportParameters(true);
            //byte[] Content = Private_RSAKeyInfo.Exponent;

            //RSACryptoServiceProvider Public_RSA = new RSACryptoServiceProvider();
            //Public_RSA.FromXmlString(txt_ACK.Text);
            //string APK2 = Private_RSA.ToXmlString(true);
            //string ACK = Private_RSA.ToXmlString(false);
            //RSAParameters Public_RSAKeyInfo = Public_RSA.ExportParameters(false);
            //byte[] Content2 = Public_RSAKeyInfo.Exponent;            
        }

        private void btn_BKeyGenerate_Click(object sender, EventArgs e)
        {
            //TextBox txt_HashMethod = (TextBox)tabControl1.GetControl(0).Controls.Find("txt_HashMethod", true).FirstOrDefault();
            string HashMethod = txt_HashMethod.Text;

            //TextBox txt_KeyLength = (TextBox)tabControl1.GetControl(0).Controls.Find("txt_KeyLength", true).FirstOrDefault();
            int KeyLength = Convert.ToInt16(txt_KeyLength.Text);

            //TextBox txt_BPK = (TextBox)tabControl1.GetControl(0).Controls.Find("txt_BPK", true).FirstOrDefault();

            CspParameters cp = new CspParameters();
            cp.KeyContainerName = "MyKeyContainerName";

            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(KeyLength, cp);
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
            catch(Exception ex)
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

                // 4) 呼叫 VerifyData 方法, 驗證本文與簽章是否相符
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
        
    }
}
