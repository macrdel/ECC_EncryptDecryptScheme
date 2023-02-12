// генерация
using System;
using System.IO;
using System.Windows.Forms;
using System.Numerics;
using System.Text;
using System.Security.Cryptography;
using ECClasses;

namespace ECCryptoSystem
{
    public partial class KeysGen : Form
    {
        public uint size;
        public string pass;

        public KeysGen()
        {
            InitializeComponent();
            size = 0;
            pass = "";
        }

        private BigInteger GeneratePrivateKey(ECurve c)
        {
            return RandomBigInt.randomBigInteger(c);
        }

        private void EncryptPrivateKey(BigInteger PrivKey, string filename)
        { // шифрование закрытого ключа
            byte[] key_data = Encoding.Unicode.GetBytes(PrivKey.ToString());
            byte[] code_data = Encoding.Unicode.GetBytes("SpecSignature " + size + " "); // сигнатура (для проверки правильности введенной парольной фразы)
            byte[] keyPlusCode_data = new byte[key_data.Length + code_data.Length];
            code_data.CopyTo(keyPlusCode_data, 0);
            key_data.CopyTo(keyPlusCode_data, code_data.Length);

            Rfc2898DeriveBytes cryptoKey = new Rfc2898DeriveBytes(pass, 8, 1000, HashAlgorithmName.SHA256);
            byte[] salt = cryptoKey.Salt; // криптографический ключ строится на основе парольной фразы и хэш-алгоритма

            AesCryptoServiceProvider aes = new AesCryptoServiceProvider(); // используемый для шифрования симметричный алгоритм
            aes.Key = cryptoKey.GetBytes(32);
            aes.Mode = CipherMode.ECB; 
            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, null);

            FileStream foutStream = new FileStream(filename, FileMode.Create);
            foutStream.Write(salt, 0, 8); // запись соли в начало файла
            CryptoStream CrStream = new CryptoStream(foutStream, encryptor,
                CryptoStreamMode.Write);

            CrStream.Write(keyPlusCode_data, 0, keyPlusCode_data.Length);
            // очистка памяти с конфиденциальными данными
            aes.Clear();
            // закрытие потока шифрования
            CrStream.Close();
            // закрытие файлов
            foutStream.Close();
        }

        private EPoint GeneratePublicKey(EPoint e, BigInteger PrivKey)
        {
            return EPoint.ECMultiply(e, PrivKey);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                /* выбор кривой */
                ECurve crv = new ECurve(size);
                /* генерация закрытого ключа */
                BigInteger privKey = GeneratePrivateKey(crv);
                /* вычисление открытого ключа */
                EPoint pubKey = GeneratePublicKey(crv.G, privKey);
                /* шифрование закрытого ключа */
                EncryptPrivateKey(privKey, private_key.Text);
                /* запись открытого ключа */
                File.WriteAllText(open_key.Text, pubKey.X.ToString() + " " + pubKey.Y.ToString());

                private_key.Text = open_key.Text = "";
                l1.Text = "Готово!";
                Save.Enabled = false;
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

        private void sz_Click(object sender, EventArgs e)
        {
            //
            Save.Enabled = false;

            KeySize f5 = new KeySize();
            f5.f57 = this;

            if (f5.ShowDialog() == DialogResult.Cancel) {
                Save.Enabled = true;
            }
        }

        private void file2_Click(object sender, EventArgs e)
        {
            //
            SaveFileDialog saveFileDialog1 = new SaveFileDialog()
            {
                InitialDirectory = @"D:\",
                Title = "Создать файл приватного ключа",
                CheckFileExists = false,
                CheckPathExists = false,
                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PassSet f3 = new PassSet();
                f3.f37 = this;
                f3.ShowDialog();
                //
                private_key.Text = saveFileDialog1.FileName;
            }
        }

        private void File1_Click(object sender, EventArgs e)
        {
            //
            SaveFileDialog saveFileDialog1 = new SaveFileDialog()
            {
                InitialDirectory = @"D:\",
                Title = "Создать файл открытого ключа",
                CheckFileExists = false,
                CheckPathExists = false,
                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                open_key.Text = saveFileDialog1.FileName;
            }
        }

        private void open_key_TextChanged(object sender, EventArgs e)
        {
            //
            sz.Enabled = !string.IsNullOrEmpty(open_key.Text) &&
                !string.IsNullOrEmpty(private_key.Text);
        }

        private void private_key_TextChanged(object sender, EventArgs e)
        {
            //
            sz.Enabled = !string.IsNullOrEmpty(open_key.Text) &&
                !string.IsNullOrEmpty(private_key.Text);
        }
    }
}
