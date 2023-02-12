// расшифрование
using ECClasses;
using System;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Numerics;
using System.Text;



namespace ECCryptoSystem
{
    public partial class Decryption : Form
    {
        public string pass;
        private string[] key_with_sign;

        public Decryption()
        {
            InitializeComponent();
            pass = "";
        }

        private void file1_Click(object sender, EventArgs e)
        {
            //
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
                shifr1.Text = openFileDialog1.FileName;
            }
        }

        private byte[] DecryptPrivateKey(string filename)
        {
            /* создание объекта для исходного (зашифрованного) файлового потока */
            FileStream finStream = new FileStream(filename, FileMode.Open);
            // создание буфера для случайной примеси
            byte[] salt = new byte[8];
            // чтение случайной примеси из начала зашифрованного файла
            finStream.Read(salt, 0, 8);

            Rfc2898DeriveBytes cryptoKey = new Rfc2898DeriveBytes(pass, salt, 1000, HashAlgorithmName.SHA256);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.Key = cryptoKey.GetBytes(32);
            aes.Mode = CipherMode.ECB;
            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, null);

            CryptoStream CrStream = new CryptoStream(finStream, decryptor,
                                        CryptoStreamMode.Read);
            byte[] bytes = new byte[finStream.Length - 8];
            // задание количества непрочитанных байт
            int n = (int)(finStream.Length) - 8;
            // ввод данных из исходного файла
            n = CrStream.Read(bytes, 0, n);
            // запись расшифрованного
            // foutStream.Write(bytes, 0, n);
            // очистка памяти с конфиденциальными данными
            aes.Clear();
            // закрытие потока
            CrStream.Close();
            // закрытие исходного файла
            finStream.Close();
            return bytes;
        }

        private void file2_Click(object sender, EventArgs e)
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
                PassEnterAndCheck f4 = new PassEnterAndCheck();
                f4.f62 = this;
                f4.ShowDialog();

                pr_key.Text = openFileDialog1.FileName;

                try
                {
                    /* расшифрование закрытого ключа */
                    key_with_sign = Encoding.Unicode.GetString(DecryptPrivateKey(pr_key.Text)).Split(' ');
                    /* проверка корректности введенной парольной фразы */
                    if (key_with_sign[0] == "SpecSignature")
                    { /* */
                        MessageBox.Show("Введенная парольная фраза корректна!", 
                            "");
                    }
                    else
                    {
                        MessageBox.Show("Введенная парольная фраза неверна!!!", 
                            "Окно будет закрыто...", 
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        Close();
                    }
                }
                catch (CryptographicException)
                {
                    MessageBox.Show("Введенная парольная фраза неверна!!!", "Окно будет закрыто...", MessageBoxButtons.OK,
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

        private void shifr1_TextChanged(object sender, EventArgs e)
        {
            //
            decrypt.Enabled = !string.IsNullOrEmpty(pr_key.Text) && 
                !string.IsNullOrEmpty(shifr1.Text);
        }

        private void pr_key_TextChanged(object sender, EventArgs e)
        {
            //
            decrypt.Enabled = !string.IsNullOrEmpty(pr_key.Text) &&
                !string.IsNullOrEmpty(shifr1.Text);
        }


        private byte[] DecryptMessage(string filename)
        {
            string Cmff = File.ReadAllText(filename); 
            
            string[] RGpoint = File.ReadAllText(filename.Replace(".", "RG.")).Split(' '); // считываем rG

            (BigInteger RGx, BigInteger RGy) = (BigInteger.Parse(RGpoint[0]), BigInteger.Parse(RGpoint[1]));

            BigInteger privKey = BigInteger.Parse(key_with_sign[2]);

            /* crv, Cm, rG */
            ECurve crv = new ECurve(UInt32.Parse(key_with_sign[1]));

            BigInteger Cm = BigInteger.Parse(Cmff);

            EPoint rG = new EPoint(RGx, RGy, crv);
            
            /* восстанавливается S */
            EPoint S = EPoint.ECMultiply(rG, privKey);

            /* восстанавливается P */
            BigInteger P = (Cm - S.X) % crv.N;

            /* P в текст msg */
            return P.ToByteArray();
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                msg1.Text = Encoding.UTF8.GetString(DecryptMessage(shifr1.Text));
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
}
