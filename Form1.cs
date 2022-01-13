using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MD5Salt_Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // 建立一個MD5
                MD5 md5 = MD5.Create();
                // 鹽
                string salt = Guid.NewGuid().ToString();
                // 將字串轉為Byte[]
                byte[] inputAndSaltBytes = Encoding.UTF8.GetBytes(MD5_Input.Text + salt);
                // 進行MD5加密
                byte[] digestBytes = md5.ComputeHash(inputAndSaltBytes);
                // 把加密後的字串從Byte[]轉為字串，輸出結果
                MD5Salt_EncryptResult.Text = Convert.ToBase64String(digestBytes);
            }
            catch (Exception err)
            {
                MD5Salt_EncryptResult.Text = err.Message;
            }
        }

        private void SHA1Salt_Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // 建立一個SHA1
                HashAlgorithm sha1 = new SHA1Managed();
                // 鹽
                string salt = Guid.NewGuid().ToString();
                // 將字串轉為Byte[]
                byte[] inputAndSaltBytes = Encoding.UTF8.GetBytes(SHA1_Input.Text + salt);
                // 進行SHA1加密
                byte[] digestBytes = sha1.ComputeHash(inputAndSaltBytes);
                // 把加密後的字串從Byte[]轉為字串，輸出結果
                SHA1Salt_EncryptResult.Text = Convert.ToBase64String(digestBytes);
            }
            catch (Exception err)
            {
                SHA1Salt_EncryptResult.Text = err.Message;
            }
        }

        private void SHA256Salt_Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // 建立一個SHA256
                HashAlgorithm sha256 = new SHA256Managed();
                // 鹽
                string salt = Guid.NewGuid().ToString();
                // 將字串轉為Byte[]
                byte[] inputAndSaltBytes = Encoding.UTF8.GetBytes(SHA256_Input.Text + salt);
                // 進行SHA256加密
                byte[] digestBytes = sha256.ComputeHash(inputAndSaltBytes);
                // 把加密後的字串從Byte[]轉為字串，輸出結果
                SHA256Salt_EncryptResult.Text = Convert.ToBase64String(digestBytes);
            }
            catch (Exception err)
            {
                SHA256Salt_EncryptResult.Text = err.Message;
            }
        }

        private void MD5_Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // 建立一個MD5
                MD5 md5 = MD5.Create();
                // 將字串轉為Byte[]
                byte[] inputAndSaltBytes = Encoding.UTF8.GetBytes(MD5_Input.Text);
                // 進行MD5加密
                byte[] digestBytes = md5.ComputeHash(inputAndSaltBytes);
                // 把加密後的字串從Byte[]轉為字串，輸出結果
                MD5_EncryptResult.Text = Convert.ToBase64String(digestBytes);
            }
            catch (Exception err)
            {
                MD5_EncryptResult.Text = err.Message;
            }
        }

        private void SHA1_Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // 建立一個SHA1
                HashAlgorithm sha1 = new SHA1Managed();
                // 將字串轉為Byte[]
                byte[] inputAndSaltBytes = Encoding.UTF8.GetBytes(SHA1_Input.Text);
                // 進行SHA1加密
                byte[] digestBytes = sha1.ComputeHash(inputAndSaltBytes);
                // 把加密後的字串從Byte[]轉為字串，輸出結果
                SHA1_EncryptResult.Text = Convert.ToBase64String(digestBytes);
            }
            catch (Exception err)
            {
                SHA1_EncryptResult.Text = err.Message;
            }
        }

        private void SHA256_Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // 建立一個SHA256
                HashAlgorithm sha256 = new SHA256Managed();
                // 將字串轉為Byte[]
                byte[] inputAndSaltBytes = Encoding.UTF8.GetBytes(SHA256_Input.Text);
                // 進行SHA256加密
                byte[] digestBytes = sha256.ComputeHash(inputAndSaltBytes);
                // 把加密後的字串從Byte[]轉為字串，輸出結果
                SHA256_EncryptResult.Text = Convert.ToBase64String(digestBytes);
            }
            catch (Exception err)
            {
                SHA256_EncryptResult.Text = err.Message;
            }
        }
    }
}
