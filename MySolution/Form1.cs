using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySolution
{
    public partial class Form1 : Form
    {
        RSACryptoServiceProvider rsa;

        RSAParameters rsaParamsExcludePrivate;
        RSAParameters rsaParamsIncludePrivate;

        string publicPrivateKeyXML;
        string publicOnlyKeyXML;
        string decryptFileText;

        OpenFileDialog openFileDialog;
        SaveFileDialog saveFileDialog;

        byte[] cipherbytes;

        public Form1()
        {
            InitializeComponent();
        }

        private void generateRSAButton_Click(object sender, EventArgs e)
        {
            //UI
            AdditionalInfo.Text = "";
            PlainText.Text = "";
            CipheredText.Text = "";
            CipheredBytes.Text = "";

            rsa = new RSACryptoServiceProvider();

            rsaParamsIncludePrivate = rsa.ExportParameters(true);
            rsaParamsExcludePrivate = rsa.ExportParameters(false);

            StringBuilder sb = new StringBuilder();
            sb.Append("P: ");
            for (int i = 0; i < rsaParamsIncludePrivate.P.Length; i++)
            {
                sb.Append(String.Format("{0,2:X2} ", rsaParamsIncludePrivate.P[i]));
            }
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            sb.Append("Q: ");
            for (int i = 0; i < rsaParamsIncludePrivate.Q.Length; i++)
            {
                sb.Append(String.Format("{0,2:X2} ", rsaParamsIncludePrivate.Q[i]));
            }
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            sb.Append("K: ");
            for (int i = 0; i < rsaParamsIncludePrivate.Exponent.Length; i++)
            {
                sb.Append(String.Format("{0,2:X2} ", rsaParamsIncludePrivate.Exponent[i]));
            }
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            sb.Append("k: ");
            for (int i = 0; i < rsaParamsIncludePrivate.D.Length; i++)
            {
                sb.Append(String.Format("{0,2:X2} ", rsaParamsIncludePrivate.D[i]));
            }
            AdditionalInfo.Text = sb.ToString();

            //UI
            saveParamsButton.Enabled = true;
            loadPublicKey.Enabled = false;
            LoadBothKeys.Enabled = false;
        }

        private void saveParamsButton_Click(object sender, EventArgs e)
        {
            publicPrivateKeyXML = rsa.ToXmlString(true);
            publicOnlyKeyXML = rsa.ToXmlString(false);

            saveFileDialog = new SaveFileDialog();
            //saveFileDialog.InitialDirectory = @"C:\Users\Main\Desktop\Информационная безопасность\Лабы\Лр3 Asymmetric";
            saveFileDialog.Filter = "XML files (*.xml)|*.xml|Text files (*.txt)|*.txt|All files (*.*)|*.*";

            MessageBox.Show("Choose Place For Public Key Only.");
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string publicOnlyKeyXMLName = saveFileDialog.FileName;
                System.IO.File.WriteAllText(publicOnlyKeyXMLName, publicOnlyKeyXML);

                MessageBox.Show("Choose Place For Both Keys.");
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string publicPrivateKeyXMLName = saveFileDialog.FileName;
                    System.IO.File.WriteAllText(publicPrivateKeyXMLName, publicPrivateKeyXML);
                }
                MessageBox.Show("Both Files Were Successfully Saved.");

                //UI
                loadPublicKey.Enabled = true;
                LoadBothKeys.Enabled = true;
            }
        }

        private void loadPublicKey_Click(object sender, EventArgs e)
        {
            //UI
            AdditionalInfo.Text = "";
            PlainText.Text = "";
            CipheredText.Text = "";
            CipheredBytes.Text = "";

            rsa = new RSACryptoServiceProvider();
            openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = @"C:\Users\Main\Desktop\Информационная безопасность\Лабы\Лр3 Asymmetric";
            openFileDialog.Filter = "XML files (*.xml)|*.xml";

            openFileDialog.Title = "Open Public Key File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = openFileDialog.FileName;
                    StreamReader reader = new StreamReader(fileName);
                    publicOnlyKeyXML = reader.ReadToEnd();
                    rsa.FromXmlString(publicOnlyKeyXML);
                    AdditionalInfo.Text = publicOnlyKeyXML;

                    //UI
                    EncryptText.Enabled = true;
                    generateRSAButton.Enabled = false;
                    LoadBothKeys.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void EncryptFile_Click(object sender, EventArgs e)
        {
            byte[] plainbutes = Encoding.UTF8.GetBytes(PlainText.Text);
            cipherbytes = rsa.Encrypt(plainbutes, false);


            CipheredText.Text = Encoding.UTF8.GetString(cipherbytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < cipherbytes.Length; i++)
            {
                sb.Append(String.Format("{0,2:X2} ", cipherbytes[i]));
            }
            CipheredBytes.Text = sb.ToString();

            //UI
            SaveCipheredText.Enabled = true;
        }

        private void SaveCipheredText_Click(object sender, EventArgs e)
        {
            saveFileDialog = new SaveFileDialog();
            //saveFileDialog.InitialDirectory = @"C:\Users\Main\Desktop\Информационная безопасность\Лабы\Лр3 Asymmetric";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            MessageBox.Show("Choose Place For Ciphered Text.");
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string cipheredTextName = saveFileDialog.FileName;
                System.IO.File.WriteAllText(cipheredTextName, CipheredText.Text);


                //saveFileDialog.InitialDirectory = @"C:\Users\Main\Desktop\Информационная безопасность\Лабы\Лр3 Asymmetric";
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                MessageBox.Show("Choose Place For Ciphered Bytes.");
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string cipheredBytesName = saveFileDialog.FileName;
                    System.IO.File.WriteAllBytes(cipheredBytesName, cipherbytes);
                }

                //UI
                EncryptText.Enabled = false;
                generateRSAButton.Enabled = true;
                LoadBothKeys.Enabled = true;
                SaveCipheredText.Enabled = false;
            }
        }

        private void LoadBothKeys_Click(object sender, EventArgs e)
        {
            //UI
            AdditionalInfo.Text = "";
            PlainText.Text = "";
            CipheredText.Text = "";
            CipheredBytes.Text = "";

            rsa = new RSACryptoServiceProvider();
            openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = @"C:\Users\Main\Desktop\Информационная безопасность\Лабы\Лр3 Asymmetric";
            openFileDialog.Filter = "XML files (*.xml)|*.xml";

            MessageBox.Show("Choose XML File With Both Keys.");
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = openFileDialog.FileName;
                    StreamReader reader = new StreamReader(fileName);
                    publicPrivateKeyXML = reader.ReadToEnd();
                    rsa.FromXmlString(publicPrivateKeyXML);
                    AdditionalInfo.Text = publicPrivateKeyXML;


                    MessageBox.Show("Choose File With Ciphered Bytes.");
                    //openFileDialog.InitialDirectory = @"C:\Users\Main\Desktop\Информационная безопасность\Лабы\Лр3 Asymmetric";
                    openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            string bytesFileName = openFileDialog.FileName;
                            cipherbytes = System.IO.File.ReadAllBytes(bytesFileName);

                            StringBuilder sb = new StringBuilder();
                            for (int i = 0; i < cipherbytes.Length; i++)
                            {
                                sb.Append(String.Format("{0,2:X2} ", cipherbytes[i]));
                            }
                            CipheredBytes.Text = sb.ToString();

                            //UI
                            DecryptFile.Enabled = true;
                            generateRSAButton.Enabled = false;
                            loadPublicKey.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void DecryptFile_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = @"C:\Users\Main\Desktop\Информационная безопасность\Лабы\Лр3 Asymmetric";
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            openFileDialog.Title = "Choose Ciphered Text File To Decrypt!";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = openFileDialog.FileName;
                    StreamReader reader = new StreamReader(fileName);
                    decryptFileText = reader.ReadToEnd();
                    CipheredText.Text = decryptFileText;

                    byte[] plainbutes = rsa.Decrypt(cipherbytes, false);

                    PlainText.Text = Encoding.UTF8.GetString(plainbutes);

                    //UI
                    generateRSAButton.Enabled = true;
                    loadPublicKey.Enabled = true;
                    DecryptFile.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
