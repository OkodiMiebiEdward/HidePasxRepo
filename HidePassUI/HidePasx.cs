using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace HidePassUI
{
    public partial class HidePasx : Form
    {
        SymmetricAlgorithm desObj;
        Login loginPage = new Login();
        public HidePasx()
        {
            InitializeComponent();
            desObj = Rijndael.Create();
            DecryptionPasswordButton.Enabled = false;
           
        }
       
       

        string cipherData;
        byte[] chiperByte;
        byte[] plainBytes;
        byte[] plainKey;
     
        private void encryptPasswordButton_Click(object sender, EventArgs e)
        {
            if(passwordTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(passwordTextBox, "Please enter password to encrypt");               
            }
            else 
            {
                if (passwordTextBox.Text != "")
                {
                    errorProvider1.Icon = Properties.Resources.Ok;
                    cipherData = passwordTextBox.Text;
                    plainBytes = Encoding.ASCII.GetBytes(cipherData);
                    plainKey = Encoding.ASCII.GetBytes("0123456789abcdef");
                    desObj.Key = plainKey;
                    desObj.Mode = CipherMode.CBC;
                    desObj.Padding = PaddingMode.Zeros;
                    MemoryStream memoryStream = new MemoryStream();
                    CryptoStream crypto = new CryptoStream(memoryStream, desObj.CreateEncryptor(), CryptoStreamMode.Write);
                    
                    crypto.Write(plainBytes, 0, plainBytes.Length);
                    crypto.Close();
                    chiperByte = memoryStream.ToArray();
                    memoryStream.Close();

                    encryptedPasswordTextBox.Text = Encoding.ASCII.GetString(chiperByte);
                }
            }
        }

        private void savePasswordButton_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists("C://HidePasxDir"))
            {
                Directory.CreateDirectory("C://HidePasxDir");                   
            }

            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = "c:\\HidePasxDir";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string encriptedPass = encryptedPasswordTextBox.Text;
           
                string fileName = saveFileDialog1.FileName;
                using (StreamWriter writer = new StreamWriter(fileName))
                { writer.WriteLine(encriptedPass);
                  writer.WriteLine($"Your password is {passwordTextBox.Text}"); 
                }
                
            } 

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to close the program","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
       
        OpenFileDialog openFileDialog = new OpenFileDialog();
        private void getPasswordButton_Click(object sender, EventArgs e)
        {
          
            openFileDialog.InitialDirectory = "c:\\HidePasxDir";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                encryptedPasswordTextBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void DecryptionPasswordButton_Click(object sender, EventArgs e)
        {
          DialogResult dialogResult = MessageBox.Show("Do you have a decryption password?","Prompt",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(dialogResult == DialogResult.Yes)
            {
                decryptionPasswordTextBox.Enabled = true;
                try
                {

                    string conn = "datasource = localhost; port = 3306; username = root; password = root";
                    MySqlConnection myConn = new MySqlConnection(conn);
                    string query = "select * from depth.PassHolderTable where password = '" + this.decryptionPasswordTextBox.Text + "';";
                    MySqlCommand sqlCommand = new MySqlCommand(query, myConn);
                    MySqlDataReader dataReader;

                    myConn.Open();
                    dataReader = sqlCommand.ExecuteReader();
                    int count = 0;
                    while (dataReader.Read())
                    {
                        count += 1;
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("Decryption password is correct");

                        var encryptedData = chiperByte;


                       
                        using (var ms = new MemoryStream(chiperByte))
                        using (var cs = new CryptoStream(ms, desObj.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                        

                            var decryptedData = new byte[100000000];
                            int readBytes = cs.Read(decryptedData, 0, chiperByte.Length);
                            decryptedPasswordTextBox.Text = Encoding.ASCII.GetString(decryptedData);

                        }

                    }
                    else
                    {
                        MessageBox.Show("Decryption password wrong");
                    }
                      myConn.Close();
                }
                finally
                {

                }
               
            }
            else
            {
                MessageBox.Show("Please create a decryption password");
                loginPage.ShowDialog();
            }
        }

        private void createDecryptionPasswordButton_Click(object sender, EventArgs e)
        {

            var newPage = new Login();
            newPage.Show();
            createDecryptionPasswordButton.Enabled = false;

        }

        private void decryptionPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            DecryptionPasswordButton.Enabled = true;
        }

      

        private void clearButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = "";
            encryptedPasswordTextBox.Text = "";
            decryptionPasswordTextBox.Text = "";
            decryptedPasswordTextBox.Text = "";
        }

        public static void disableButton()
        {
            HidePasx hidePasx = new HidePasx();
            hidePasx.createDecryptionPasswordButton.Enabled = true;
        }

    }
}
