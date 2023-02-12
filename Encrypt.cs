// шифрование
using ECClasses;
using System;
using System.Numerics;
using System.Linq;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.IO;


namespace ECCryptoSystem
{
    public partial class Encryption : Form
    {
        public Encryption()
        {
            InitializeComponent();
        }

        private uint[] keysizes = new uint[4] { 192, 256, 384, 521}; // валидные размеры ключей

        private void File1_Click(object sender, EventArgs e)
        {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    InitialDirectory = @"D:\",
                    Title = "Найти",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "txt",
                    Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                    FilterIndex = 2,
                    RestoreDirectory = true //,

                    //ReadOnlyChecked = true,
                    //ShowReadOnly = true
                };

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {   
                    open_key.Text = openFileDialog1.FileName;
                }
        }

        private void open_key_TextChanged(object sender, EventArgs e)
        {
            //
            Crypt.Enabled = !string.IsNullOrEmpty(open_key.Text);
        }

        private void Crypt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(msg.Text))
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog()
                {
                    InitialDirectory = @"D:\",
                    Title = "Сохранить шифротекст",
                    CheckFileExists = false,
                    CheckPathExists = false,
                    DefaultExt = "txt",
                    Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                    FilterIndex = 2,
                    RestoreDirectory = true
                };

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    shifr.Text = saveFileDialog1.FileName;

                    try
                    {
                        string[] pubKeyStr = File.ReadAllText(open_key.Text).Split(' '); // читаем открытый ключ
                        (BigInteger x, BigInteger y) = (BigInteger.Parse(pubKeyStr[0]), BigInteger.Parse(pubKeyStr[1]));
                        int k = x.ToByteArray().Length * 8;
                        var size = keysizes.OrderBy(z => Math.Abs(z - k)).First();
                        
                        /* выбор кривой */
                        ECurve crv = new ECurve(size);
                        EPoint Qa = new EPoint(x, y, crv);

                        /* генерация случайного числа */
                        BigInteger r = RandomBigInt.randomBigInteger(crv);

                        /* вычисление rG */
                        EPoint rG = EPoint.ECMultiply(crv.G, r); 
                        /* вычисление S */
                        EPoint S = EPoint.ECMultiply(Qa, r);

                        /* преобразование текста сообщения m в число P */
                        byte[] m = Encoding.UTF8.GetBytes(msg.Text);
                        BigInteger P = new BigInteger(m);

                        /* вычисление шифротекста */
                        BigInteger Cm = (S.X + P) % crv.N;

                        /* запись шифротекстов */
                        File.WriteAllText(shifr.Text, Cm.ToString());
                        File.WriteAllText(shifr.Text.Replace(".", "RG."), rG.X.ToString() + " " + rG.Y.ToString());
                        
                        l2.Text = "Готово!";
                    }
                    catch (CryptographicException ex)
                    {
                        MessageBox.Show(ex.Message, "Окно будет закрыто...", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Окно будет закрыто...", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите сообщение!", "Wrong message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
