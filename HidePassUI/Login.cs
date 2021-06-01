using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HidePassUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*'; 
        }

        private void createDecryptionPasswordButton_Click(object sender, EventArgs e)
        {
            string conn = "datasource = localhost; port = 3306; username = root; password = root";
            MySqlConnection myConn = new MySqlConnection(conn);
            string query = "insert into depth.passholdertable (username,password) values(null,'" + this.passwordTextBox.Text + "');";
            MySqlCommand sqlCommand = new MySqlCommand(query, myConn);
            MySqlDataReader sqlDataReader;
            try
            {
                myConn.Open();
                sqlDataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Decryption Password created");
                while (sqlDataReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("close the application", "close",MessageBoxButtons.OK);
            if(dialog == DialogResult.OK)
            {
                HidePasx hidePasx = new HidePasx();
                HidePasx.disableButton();
            }

        }
    }
}
