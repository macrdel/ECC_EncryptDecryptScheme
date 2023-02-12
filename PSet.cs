using System;
using System.Windows.Forms;

namespace ECCryptoSystem
{
    public partial class PassSet : Form
    {
        public KeysGen f37;

        public PassSet()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (first.PasswordChar == '*')
            {
                first.PasswordChar = '\0';
                second.PasswordChar = '\0';
            }
            else
            {
                first.PasswordChar = '*';
                second.PasswordChar = '*';
            }
        }

        private void first_TextChanged(object sender, EventArgs e)
        {
            //
            OK1.Enabled = first.Text.Length > 2 && 
                first.Text.Length == second.Text.Length;
        }

        private void second_TextChanged(object sender, EventArgs e)
        {
            //
            OK1.Enabled = first.Text.Length > 2 &&
                first.Text.Length == second.Text.Length;
        }

        private void OK1_Click(object sender, EventArgs e)
        {
            if (first.Text == second.Text)
            {
                f37.pass = first.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Введенные пароли не совпадают!\n" +
                    "Попробуйте ещё раз...", "Wrong password",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
