
namespace ProjCryptoSJ
{
    partial class CryptScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCryptPerso = new System.Windows.Forms.Button();
            this.btnDecryptPerso = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtReturn = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.Txt_to_crypt = new System.Windows.Forms.MaskedTextBox();
            this.Key = new System.Windows.Forms.MaskedTextBox();
            this.CryptedText = new System.Windows.Forms.MaskedTextBox();
            this.txtDecrypted = new System.Windows.Forms.MaskedTextBox();
            this.btnCryptNet = new System.Windows.Forms.Button();
            this.btnDecryptNet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCryptPerso
            // 
            this.btnCryptPerso.Location = new System.Drawing.Point(85, 327);
            this.btnCryptPerso.Name = "btnCryptPerso";
            this.btnCryptPerso.Size = new System.Drawing.Size(204, 102);
            this.btnCryptPerso.TabIndex = 0;
            this.btnCryptPerso.Text = "Cryptage perosnnel";
            this.btnCryptPerso.UseVisualStyleBackColor = true;
            // 
            // btnDecryptPerso
            // 
            this.btnDecryptPerso.Enabled = false;
            this.btnDecryptPerso.Location = new System.Drawing.Point(85, 435);
            this.btnDecryptPerso.Name = "btnDecryptPerso";
            this.btnDecryptPerso.Size = new System.Drawing.Size(204, 102);
            this.btnDecryptPerso.TabIndex = 1;
            this.btnDecryptPerso.Text = "Décryptage perosnnel";
            this.btnDecryptPerso.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(336, 62);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(676, 26);
            this.txtInput.TabIndex = 4;
            // 
            // txtReturn
            // 
            this.txtReturn.Location = new System.Drawing.Point(336, 785);
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.Size = new System.Drawing.Size(676, 26);
            this.txtReturn.TabIndex = 5;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(336, 435);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(676, 26);
            this.txtOutput.TabIndex = 6;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(487, 327);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(354, 26);
            this.txtKey.TabIndex = 7;
            // 
            // Txt_to_crypt
            // 
            this.Txt_to_crypt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_to_crypt.Location = new System.Drawing.Point(586, 30);
            this.Txt_to_crypt.Name = "Txt_to_crypt";
            this.Txt_to_crypt.ReadOnly = true;
            this.Txt_to_crypt.Size = new System.Drawing.Size(125, 19);
            this.Txt_to_crypt.TabIndex = 8;
            this.Txt_to_crypt.Text = "Texte à crypter";
            this.Txt_to_crypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Key
            // 
            this.Key.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Key.Location = new System.Drawing.Point(586, 295);
            this.Key.Name = "Key";
            this.Key.ReadOnly = true;
            this.Key.Size = new System.Drawing.Size(125, 19);
            this.Key.TabIndex = 9;
            this.Key.Text = "Clé";
            this.Key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CryptedText
            // 
            this.CryptedText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CryptedText.Location = new System.Drawing.Point(586, 403);
            this.CryptedText.Name = "CryptedText";
            this.CryptedText.ReadOnly = true;
            this.CryptedText.Size = new System.Drawing.Size(125, 19);
            this.CryptedText.TabIndex = 10;
            this.CryptedText.Text = "Texte crypté";
            this.CryptedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDecrypted.Location = new System.Drawing.Point(586, 753);
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.ReadOnly = true;
            this.txtDecrypted.Size = new System.Drawing.Size(125, 19);
            this.txtDecrypted.TabIndex = 11;
            this.txtDecrypted.Text = "Texte décrypté";
            this.txtDecrypted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCryptNet
            // 
            this.btnCryptNet.Location = new System.Drawing.Point(1083, 327);
            this.btnCryptNet.Name = "btnCryptNet";
            this.btnCryptNet.Size = new System.Drawing.Size(204, 102);
            this.btnCryptNet.TabIndex = 12;
            this.btnCryptNet.Text = "Cryptage .NET";
            this.btnCryptNet.UseVisualStyleBackColor = true;
            this.btnCryptNet.Click += new System.EventHandler(this.btnCryptNet_Click);
            // 
            // btnDecryptNet
            // 
            this.btnDecryptNet.Enabled = false;
            this.btnDecryptNet.Location = new System.Drawing.Point(1083, 435);
            this.btnDecryptNet.Name = "btnDecryptNet";
            this.btnDecryptNet.Size = new System.Drawing.Size(204, 102);
            this.btnDecryptNet.TabIndex = 13;
            this.btnDecryptNet.Text = "Décryptage .NET";
            this.btnDecryptNet.UseVisualStyleBackColor = true;
            this.btnDecryptNet.Click += new System.EventHandler(this.btnDecryptNet_Click);
            // 
            // CryptScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 896);
            this.Controls.Add(this.btnDecryptNet);
            this.Controls.Add(this.btnCryptNet);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.CryptedText);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.Txt_to_crypt);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtReturn);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnDecryptPerso);
            this.Controls.Add(this.btnCryptPerso);
            this.Name = "CryptScreen";
            this.Text = "Encrypt & Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCryptPerso;
        private System.Windows.Forms.Button btnDecryptPerso;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtReturn;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.MaskedTextBox Txt_to_crypt;
        private System.Windows.Forms.MaskedTextBox Key;
        private System.Windows.Forms.MaskedTextBox CryptedText;
        private System.Windows.Forms.MaskedTextBox txtDecrypted;
        private System.Windows.Forms.Button btnCryptNet;
        private System.Windows.Forms.Button btnDecryptNet;
    }
}

