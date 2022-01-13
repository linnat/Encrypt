
namespace Encrypt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.MD5Salt_EncryptResult = new System.Windows.Forms.TextBox();
            this.MD5Salt_Encrypt = new System.Windows.Forms.Button();
            this.MD5_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SHA256Salt_EncryptResult = new System.Windows.Forms.TextBox();
            this.SHA256Salt_Encrypt = new System.Windows.Forms.Button();
            this.SHA256_Input = new System.Windows.Forms.TextBox();
            this.SHA1Salt_EncryptResult = new System.Windows.Forms.TextBox();
            this.SHA1Salt_Encrypt = new System.Windows.Forms.Button();
            this.SHA1_Input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MD5_EncryptResult = new System.Windows.Forms.TextBox();
            this.MD5_Encrypt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SHA256_EncryptResult = new System.Windows.Forms.TextBox();
            this.SHA256_Encrypt = new System.Windows.Forms.Button();
            this.SHA1_EncryptResult = new System.Windows.Forms.TextBox();
            this.SHA1_Encrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "MD5+Salt";
            // 
            // MD5Salt_EncryptResult
            // 
            this.MD5Salt_EncryptResult.Location = new System.Drawing.Point(339, 34);
            this.MD5Salt_EncryptResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MD5Salt_EncryptResult.Name = "MD5Salt_EncryptResult";
            this.MD5Salt_EncryptResult.ReadOnly = true;
            this.MD5Salt_EncryptResult.Size = new System.Drawing.Size(431, 27);
            this.MD5Salt_EncryptResult.TabIndex = 26;
            // 
            // MD5Salt_Encrypt
            // 
            this.MD5Salt_Encrypt.Location = new System.Drawing.Point(183, 34);
            this.MD5Salt_Encrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MD5Salt_Encrypt.Name = "MD5Salt_Encrypt";
            this.MD5Salt_Encrypt.Size = new System.Drawing.Size(123, 29);
            this.MD5Salt_Encrypt.TabIndex = 25;
            this.MD5Salt_Encrypt.Text = "加密";
            this.MD5Salt_Encrypt.UseVisualStyleBackColor = true;
            this.MD5Salt_Encrypt.Click += new System.EventHandler(this.MD5Salt_Encrypt_Click);
            // 
            // MD5_Input
            // 
            this.MD5_Input.Location = new System.Drawing.Point(15, 34);
            this.MD5_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MD5_Input.Name = "MD5_Input";
            this.MD5_Input.Size = new System.Drawing.Size(127, 27);
            this.MD5_Input.TabIndex = 24;
            this.MD5_Input.Text = "for MD5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "SHA 256+Salt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "SHA 1+Salt";
            // 
            // SHA256Salt_EncryptResult
            // 
            this.SHA256Salt_EncryptResult.Location = new System.Drawing.Point(339, 194);
            this.SHA256Salt_EncryptResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SHA256Salt_EncryptResult.Name = "SHA256Salt_EncryptResult";
            this.SHA256Salt_EncryptResult.ReadOnly = true;
            this.SHA256Salt_EncryptResult.Size = new System.Drawing.Size(431, 27);
            this.SHA256Salt_EncryptResult.TabIndex = 21;
            // 
            // SHA256Salt_Encrypt
            // 
            this.SHA256Salt_Encrypt.Location = new System.Drawing.Point(183, 194);
            this.SHA256Salt_Encrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SHA256Salt_Encrypt.Name = "SHA256Salt_Encrypt";
            this.SHA256Salt_Encrypt.Size = new System.Drawing.Size(123, 29);
            this.SHA256Salt_Encrypt.TabIndex = 20;
            this.SHA256Salt_Encrypt.Text = "加密";
            this.SHA256Salt_Encrypt.UseVisualStyleBackColor = true;
            this.SHA256Salt_Encrypt.Click += new System.EventHandler(this.SHA256Salt_Encrypt_Click);
            // 
            // SHA256_Input
            // 
            this.SHA256_Input.Location = new System.Drawing.Point(15, 194);
            this.SHA256_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SHA256_Input.Name = "SHA256_Input";
            this.SHA256_Input.Size = new System.Drawing.Size(127, 27);
            this.SHA256_Input.TabIndex = 19;
            this.SHA256_Input.Text = "for SHA 256";
            // 
            // SHA1Salt_EncryptResult
            // 
            this.SHA1Salt_EncryptResult.Location = new System.Drawing.Point(339, 111);
            this.SHA1Salt_EncryptResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SHA1Salt_EncryptResult.Name = "SHA1Salt_EncryptResult";
            this.SHA1Salt_EncryptResult.ReadOnly = true;
            this.SHA1Salt_EncryptResult.Size = new System.Drawing.Size(431, 27);
            this.SHA1Salt_EncryptResult.TabIndex = 18;
            // 
            // SHA1Salt_Encrypt
            // 
            this.SHA1Salt_Encrypt.Location = new System.Drawing.Point(183, 111);
            this.SHA1Salt_Encrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SHA1Salt_Encrypt.Name = "SHA1Salt_Encrypt";
            this.SHA1Salt_Encrypt.Size = new System.Drawing.Size(123, 29);
            this.SHA1Salt_Encrypt.TabIndex = 17;
            this.SHA1Salt_Encrypt.Text = "加密";
            this.SHA1Salt_Encrypt.UseVisualStyleBackColor = true;
            this.SHA1Salt_Encrypt.Click += new System.EventHandler(this.SHA1Salt_Encrypt_Click);
            // 
            // SHA1_Input
            // 
            this.SHA1_Input.Location = new System.Drawing.Point(15, 111);
            this.SHA1_Input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SHA1_Input.Name = "SHA1_Input";
            this.SHA1_Input.Size = new System.Drawing.Size(127, 27);
            this.SHA1_Input.TabIndex = 16;
            this.SHA1_Input.Text = "for SHA 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "MD5";
            // 
            // MD5_EncryptResult
            // 
            this.MD5_EncryptResult.Location = new System.Drawing.Point(339, 281);
            this.MD5_EncryptResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MD5_EncryptResult.Name = "MD5_EncryptResult";
            this.MD5_EncryptResult.ReadOnly = true;
            this.MD5_EncryptResult.Size = new System.Drawing.Size(431, 27);
            this.MD5_EncryptResult.TabIndex = 35;
            // 
            // MD5_Encrypt
            // 
            this.MD5_Encrypt.Location = new System.Drawing.Point(183, 281);
            this.MD5_Encrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MD5_Encrypt.Name = "MD5_Encrypt";
            this.MD5_Encrypt.Size = new System.Drawing.Size(123, 29);
            this.MD5_Encrypt.TabIndex = 34;
            this.MD5_Encrypt.Text = "加密";
            this.MD5_Encrypt.UseVisualStyleBackColor = true;
            this.MD5_Encrypt.Click += new System.EventHandler(this.MD5_Encrypt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 418);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "SHA 256";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 336);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "SHA 1";
            // 
            // SHA256_EncryptResult
            // 
            this.SHA256_EncryptResult.Location = new System.Drawing.Point(339, 441);
            this.SHA256_EncryptResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SHA256_EncryptResult.Name = "SHA256_EncryptResult";
            this.SHA256_EncryptResult.ReadOnly = true;
            this.SHA256_EncryptResult.Size = new System.Drawing.Size(431, 27);
            this.SHA256_EncryptResult.TabIndex = 31;
            // 
            // SHA256_Encrypt
            // 
            this.SHA256_Encrypt.Location = new System.Drawing.Point(183, 441);
            this.SHA256_Encrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SHA256_Encrypt.Name = "SHA256_Encrypt";
            this.SHA256_Encrypt.Size = new System.Drawing.Size(123, 29);
            this.SHA256_Encrypt.TabIndex = 30;
            this.SHA256_Encrypt.Text = "加密";
            this.SHA256_Encrypt.UseVisualStyleBackColor = true;
            this.SHA256_Encrypt.Click += new System.EventHandler(this.SHA256_Encrypt_Click);
            // 
            // SHA1_EncryptResult
            // 
            this.SHA1_EncryptResult.Location = new System.Drawing.Point(339, 358);
            this.SHA1_EncryptResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SHA1_EncryptResult.Name = "SHA1_EncryptResult";
            this.SHA1_EncryptResult.ReadOnly = true;
            this.SHA1_EncryptResult.Size = new System.Drawing.Size(431, 27);
            this.SHA1_EncryptResult.TabIndex = 29;
            // 
            // SHA1_Encrypt
            // 
            this.SHA1_Encrypt.Location = new System.Drawing.Point(183, 358);
            this.SHA1_Encrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SHA1_Encrypt.Name = "SHA1_Encrypt";
            this.SHA1_Encrypt.Size = new System.Drawing.Size(123, 29);
            this.SHA1_Encrypt.TabIndex = 28;
            this.SHA1_Encrypt.Text = "加密";
            this.SHA1_Encrypt.UseVisualStyleBackColor = true;
            this.SHA1_Encrypt.Click += new System.EventHandler(this.SHA1_Encrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 570);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MD5_EncryptResult);
            this.Controls.Add(this.MD5_Encrypt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SHA256_EncryptResult);
            this.Controls.Add(this.SHA256_Encrypt);
            this.Controls.Add(this.SHA1_EncryptResult);
            this.Controls.Add(this.SHA1_Encrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MD5Salt_EncryptResult);
            this.Controls.Add(this.MD5Salt_Encrypt);
            this.Controls.Add(this.MD5_Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SHA256Salt_EncryptResult);
            this.Controls.Add(this.SHA256Salt_Encrypt);
            this.Controls.Add(this.SHA256_Input);
            this.Controls.Add(this.SHA1Salt_EncryptResult);
            this.Controls.Add(this.SHA1Salt_Encrypt);
            this.Controls.Add(this.SHA1_Input);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MD5Salt_EncryptResult;
        private System.Windows.Forms.Button MD5Salt_Encrypt;
        private System.Windows.Forms.TextBox MD5_Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SHA256Salt_EncryptResult;
        private System.Windows.Forms.Button SHA256Salt_Encrypt;
        private System.Windows.Forms.TextBox SHA256_Input;
        private System.Windows.Forms.TextBox SHA1Salt_EncryptResult;
        private System.Windows.Forms.Button SHA1Salt_Encrypt;
        private System.Windows.Forms.TextBox SHA1_Input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MD5_EncryptResult;
        private System.Windows.Forms.Button MD5_Encrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SHA256_EncryptResult;
        private System.Windows.Forms.Button SHA256_Encrypt;
        private System.Windows.Forms.TextBox SHA1_EncryptResult;
        private System.Windows.Forms.Button SHA1_Encrypt;
    }
}

