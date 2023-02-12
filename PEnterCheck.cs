using System;
using System.Windows.Forms;

namespace ECCryptoSystem
{
    public partial class PassEnterAndCheck : Form
    {
        public Decryption f62;

        public PassEnterAndCheck()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (passW.PasswordChar == '*')
                passW.PasswordChar = '\0';
            else
                passW.PasswordChar = '*';
        }

        private void OK2_Click(object sender, EventArgs e)
        {
            f62.pass = passW.Text;
            Close();
        }

        private void passW_TextChanged(object sender, EventArgs e)
        {
            OK2.Enabled = passW.Text.Length > 2;
        }
    }
}
