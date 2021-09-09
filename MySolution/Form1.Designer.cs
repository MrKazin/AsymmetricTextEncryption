namespace MySolution
{
    partial class Form1
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
            this.AdditionalInfo = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveParamsButton = new System.Windows.Forms.Button();
            this.generateRSAButton = new System.Windows.Forms.Button();
            this.PlainText = new System.Windows.Forms.TextBox();
            this.textGroup = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.loadPublicKey = new System.Windows.Forms.Button();
            this.EncryptText = new System.Windows.Forms.Button();
            this.encryptedTextGroup = new System.Windows.Forms.GroupBox();
            this.CipheredText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CipheredBytes = new System.Windows.Forms.TextBox();
            this.SaveCipheredText = new System.Windows.Forms.Button();
            this.LoadBothKeys = new System.Windows.Forms.Button();
            this.DecryptFile = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textGroup.SuspendLayout();
            this.encryptedTextGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdditionalInfo
            // 
            this.AdditionalInfo.Location = new System.Drawing.Point(6, 21);
            this.AdditionalInfo.Multiline = true;
            this.AdditionalInfo.Name = "AdditionalInfo";
            this.AdditionalInfo.ReadOnly = true;
            this.AdditionalInfo.Size = new System.Drawing.Size(971, 261);
            this.AdditionalInfo.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.ReadOnlyChecked = true;
            // 
            // saveParamsButton
            // 
            this.saveParamsButton.Enabled = false;
            this.saveParamsButton.Location = new System.Drawing.Point(122, 21);
            this.saveParamsButton.Name = "saveParamsButton";
            this.saveParamsButton.Size = new System.Drawing.Size(104, 30);
            this.saveParamsButton.TabIndex = 3;
            this.saveParamsButton.Text = "Save Keys";
            this.saveParamsButton.UseVisualStyleBackColor = true;
            this.saveParamsButton.Click += new System.EventHandler(this.saveParamsButton_Click);
            // 
            // generateRSAButton
            // 
            this.generateRSAButton.Location = new System.Drawing.Point(6, 21);
            this.generateRSAButton.Name = "generateRSAButton";
            this.generateRSAButton.Size = new System.Drawing.Size(110, 30);
            this.generateRSAButton.TabIndex = 6;
            this.generateRSAButton.Text = "Generate RSA";
            this.generateRSAButton.UseVisualStyleBackColor = true;
            this.generateRSAButton.Click += new System.EventHandler(this.generateRSAButton_Click);
            // 
            // PlainText
            // 
            this.PlainText.Location = new System.Drawing.Point(6, 21);
            this.PlainText.Multiline = true;
            this.PlainText.Name = "PlainText";
            this.PlainText.Size = new System.Drawing.Size(971, 48);
            this.PlainText.TabIndex = 4;
            // 
            // textGroup
            // 
            this.textGroup.Controls.Add(this.PlainText);
            this.textGroup.Location = new System.Drawing.Point(12, 389);
            this.textGroup.Name = "textGroup";
            this.textGroup.Size = new System.Drawing.Size(984, 81);
            this.textGroup.TabIndex = 7;
            this.textGroup.TabStop = false;
            this.textGroup.Text = "Text";
            // 
            // loadPublicKey
            // 
            this.loadPublicKey.Location = new System.Drawing.Point(6, 21);
            this.loadPublicKey.Name = "loadPublicKey";
            this.loadPublicKey.Size = new System.Drawing.Size(124, 30);
            this.loadPublicKey.TabIndex = 8;
            this.loadPublicKey.Text = "Load Public Key";
            this.loadPublicKey.UseVisualStyleBackColor = true;
            this.loadPublicKey.Click += new System.EventHandler(this.loadPublicKey_Click);
            // 
            // EncryptText
            // 
            this.EncryptText.Enabled = false;
            this.EncryptText.Location = new System.Drawing.Point(136, 21);
            this.EncryptText.Name = "EncryptText";
            this.EncryptText.Size = new System.Drawing.Size(104, 30);
            this.EncryptText.TabIndex = 9;
            this.EncryptText.Text = "Encrypt Text";
            this.EncryptText.UseVisualStyleBackColor = true;
            this.EncryptText.Click += new System.EventHandler(this.EncryptFile_Click);
            // 
            // encryptedTextGroup
            // 
            this.encryptedTextGroup.Controls.Add(this.CipheredText);
            this.encryptedTextGroup.Location = new System.Drawing.Point(12, 485);
            this.encryptedTextGroup.Name = "encryptedTextGroup";
            this.encryptedTextGroup.Size = new System.Drawing.Size(984, 81);
            this.encryptedTextGroup.TabIndex = 8;
            this.encryptedTextGroup.TabStop = false;
            this.encryptedTextGroup.Text = "Ciphered Text as Text String";
            // 
            // CipheredText
            // 
            this.CipheredText.Location = new System.Drawing.Point(6, 21);
            this.CipheredText.Multiline = true;
            this.CipheredText.Name = "CipheredText";
            this.CipheredText.ReadOnly = true;
            this.CipheredText.Size = new System.Drawing.Size(971, 48);
            this.CipheredText.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AdditionalInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 301);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CipheredBytes);
            this.groupBox2.Location = new System.Drawing.Point(12, 583);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 135);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ciphered Text as Byte Array";
            // 
            // CipheredBytes
            // 
            this.CipheredBytes.Location = new System.Drawing.Point(6, 21);
            this.CipheredBytes.Multiline = true;
            this.CipheredBytes.Name = "CipheredBytes";
            this.CipheredBytes.ReadOnly = true;
            this.CipheredBytes.Size = new System.Drawing.Size(971, 102);
            this.CipheredBytes.TabIndex = 4;
            // 
            // SaveCipheredText
            // 
            this.SaveCipheredText.Enabled = false;
            this.SaveCipheredText.Location = new System.Drawing.Point(246, 21);
            this.SaveCipheredText.Name = "SaveCipheredText";
            this.SaveCipheredText.Size = new System.Drawing.Size(211, 30);
            this.SaveCipheredText.TabIndex = 11;
            this.SaveCipheredText.Text = "Save Ciphered Text And Bytes";
            this.SaveCipheredText.UseVisualStyleBackColor = true;
            this.SaveCipheredText.Click += new System.EventHandler(this.SaveCipheredText_Click);
            // 
            // LoadBothKeys
            // 
            this.LoadBothKeys.Location = new System.Drawing.Point(6, 21);
            this.LoadBothKeys.Name = "LoadBothKeys";
            this.LoadBothKeys.Size = new System.Drawing.Size(155, 30);
            this.LoadBothKeys.TabIndex = 12;
            this.LoadBothKeys.Text = "Load Keys And Bytes";
            this.LoadBothKeys.UseVisualStyleBackColor = true;
            this.LoadBothKeys.Click += new System.EventHandler(this.LoadBothKeys_Click);
            // 
            // DecryptFile
            // 
            this.DecryptFile.Enabled = false;
            this.DecryptFile.Location = new System.Drawing.Point(167, 21);
            this.DecryptFile.Name = "DecryptFile";
            this.DecryptFile.Size = new System.Drawing.Size(96, 30);
            this.DecryptFile.TabIndex = 13;
            this.DecryptFile.Text = "Decrypt File";
            this.DecryptFile.UseVisualStyleBackColor = true;
            this.DecryptFile.Click += new System.EventHandler(this.DecryptFile_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.generateRSAButton);
            this.groupBox3.Controls.Add(this.saveParamsButton);
            this.groupBox3.Location = new System.Drawing.Point(18, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 64);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generate";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.loadPublicKey);
            this.groupBox4.Controls.Add(this.EncryptText);
            this.groupBox4.Controls.Add(this.SaveCipheredText);
            this.groupBox4.Location = new System.Drawing.Point(256, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(464, 64);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Encrypt";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LoadBothKeys);
            this.groupBox5.Controls.Add(this.DecryptFile);
            this.groupBox5.Location = new System.Drawing.Point(726, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(270, 64);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Decrypt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 728);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.encryptedTextGroup);
            this.Controls.Add(this.textGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.textGroup.ResumeLayout(false);
            this.textGroup.PerformLayout();
            this.encryptedTextGroup.ResumeLayout(false);
            this.encryptedTextGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox AdditionalInfo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button saveParamsButton;
        private System.Windows.Forms.Button generateRSAButton;
        private System.Windows.Forms.TextBox PlainText;
        private System.Windows.Forms.GroupBox textGroup;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button loadPublicKey;
        private System.Windows.Forms.Button EncryptText;
        private System.Windows.Forms.GroupBox encryptedTextGroup;
        private System.Windows.Forms.TextBox CipheredText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CipheredBytes;
        private System.Windows.Forms.Button SaveCipheredText;
        private System.Windows.Forms.Button LoadBothKeys;
        private System.Windows.Forms.Button DecryptFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

