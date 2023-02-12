using System;
using System.Windows.Forms;

namespace ECCryptoSystem
{
    public partial class MainF : Form
    {
        public MainF()
        {
            InitializeComponent();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void генерацияКлючейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            KeysGen f7 = new KeysGen();
            f7.ShowDialog();
        }

        private void шифрованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Encryption f2 = new Encryption();
            f2.ShowDialog();
        }

        private void расшифрованиеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Decryption f6 = new Decryption();
            f6.ShowDialog();
        }
    }
}
