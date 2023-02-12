using System.Linq;
using ECClasses;
using System.Security.Cryptography;
using System.Numerics;

namespace ECCryptoSystem
{
    public class RandomBigInt
    {
        // возращает большое рандомное целое
        public static BigInteger randomBigInteger(ECurve curve)
        {
            byte[] unsignedBytes = new byte[] { 0x00 };
            byte[] randomBytes = new byte[curve.Length / 8];

            RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
            randomNumberGenerator.GetBytes(randomBytes);

            byte[] positiveRandomBytes = randomBytes.Concat(unsignedBytes).ToArray();
            BigInteger randomValue = new BigInteger(positiveRandomBytes);
            BigInteger result;
            do
            {
                result = randomValue % curve.N;
            }
            while (result == 0);

            return result;
        }
    }
}
