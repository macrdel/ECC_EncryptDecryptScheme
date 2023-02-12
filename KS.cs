using System;
using System.Windows.Forms;

namespace ECCryptoSystem
{
    public partial class KeySize : Form
    {
        public KeysGen f57;

        public KeySize()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "256";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OK.Enabled = true;
        }

        private void OK3_Click(object sender, EventArgs e)
        {
            f57.size = UInt32.Parse(comboBox1.SelectedItem.ToString());
            Close();
        }
    }
}
