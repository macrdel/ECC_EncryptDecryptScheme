using System;
using System.Globalization;
using System.Numerics;

namespace ECClasses
{
    public class ECurve
    {
        public ECurve(uint L)
        {
            switch (L)
            {
                case 192: // nistp192
                    {
                        P = BigInteger.Parse("000FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFF", NumberStyles.HexNumber);

                        A = BigInteger.Parse("D", NumberStyles.HexNumber);
                        B = BigInteger.Parse("0064210519E59C80E70FA7E9AB72243049FEB8DEECC146B9B1", NumberStyles.HexNumber);

						G = new EPoint(BigInteger.Parse("00188DA80EB03090F67CBF20EB43A18800F4FF0AFD82FF1012", NumberStyles.HexNumber), 
                            BigInteger.Parse("0007192B95FFC8DA78631011ED6B24CDD573F977A11E794811", NumberStyles.HexNumber), this);

                        N = BigInteger.Parse("000FFFFFFFFFFFFFFFFFFFFFFFF99DEF836146BC9B1B4D22831", NumberStyles.HexNumber);
                        H = 1;
                    }
                    break;
                case 256: // nistp256
                    {
                        P = BigInteger.Parse("000FFFFFFFF00000001000000000000000000000000FFFFFFFFFFFFFFFFFFFFFFFF", NumberStyles.HexNumber);

                        A = BigInteger.Parse("D", NumberStyles.HexNumber);
                        B = BigInteger.Parse("005AC635D8AA3A93E7B3EBBD55769886BC651D06B0CC53B0F63BCE3C3E27D2604B", NumberStyles.HexNumber);

						G = new EPoint(BigInteger.Parse("006B17D1F2E12C4247F8BCE6E563A440F277037D812DEB33A0F4A13945D898C296", NumberStyles.HexNumber), 
                            BigInteger.Parse("004FE342E2FE1A7F9B8EE7EB4A7C0F9E162BCE33576B315ECECBB6406837BF51F5", NumberStyles.HexNumber), this);

                        N = BigInteger.Parse("000FFFFFFFF00000000FFFFFFFFFFFFFFFFBCE6FAADA7179E84F3B9CAC2FC632551", NumberStyles.HexNumber);
                        H = 1;
                    }
                    break;
                case 384: // nistp384
                    {
                        P = BigInteger.Parse("000FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFF0000000000000000FFFFFFFF", NumberStyles.HexNumber);

                        A = BigInteger.Parse("D", NumberStyles.HexNumber);
                        B = BigInteger.Parse("00B3312FA7E23EE7E4988E056BE3F82D19181D9C6EFE8141120314088F5013875AC656398D8A2ED19D2A85C8EDD3EC2AEF", NumberStyles.HexNumber);

						G = new EPoint(BigInteger.Parse("00AA87CA22BE8B05378EB1C71EF320AD746E1D3B628BA79B9859F741E082542A385502F25DBF55296C3A545E3872760AB7", NumberStyles.HexNumber), 
                            BigInteger.Parse("003617DE4A96262C6F5D9E98BF9292DC29F8F41DBD289A147CE9DA3113B5F0B8C00A60B1CE1D7E819D7A431D7C90EA0E5F", NumberStyles.HexNumber), this);

                        N = BigInteger.Parse("000FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFC7634D81F4372DDF581A0DB248B0A77AECEC196ACCC52973", NumberStyles.HexNumber);
                        H = 1;
                    }
                    break;
                case 521: // nistp521
                    {
                        P = BigInteger.Parse("001FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", NumberStyles.HexNumber);

                        A = BigInteger.Parse("D", NumberStyles.HexNumber);
                        B = BigInteger.Parse("00051953EB9618E1C9A1F929A21A0B68540EEA2DA725B99B315F3B8B489918EF109E156193951EC7E937B1652C0BD3BB1BF073573DF883D2C34F1EF451FD46B503F00", NumberStyles.HexNumber);

						G = new EPoint(BigInteger.Parse("00C6858E06B70404E9CD9E3ECB662395B4429C648139053FB521F828AF606B4D3DBAA14B5E77EFE75928FE1DC127A2FFA8DE3348B3C1856A429BF97E7E31C2E5BD66", NumberStyles.HexNumber), 
                            BigInteger.Parse("0011839296A789A3BC0045C8A5FB42C7D1BD998F54449579B446817AFBD17273E662C97EE72995EF42640C550B9013FAD0761353C7086A272C24088BE94769FD16650", NumberStyles.HexNumber), this);


                        N = BigInteger.Parse("001FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFA51868783BF2F966B7FCC0148F709A5D03BB5C9B8899C47AEBB6FB71E91386409", NumberStyles.HexNumber);
                        H = 1;
                    }
                    break;
                default:
                    break;
            }
            Length = L;
        }

        public BigInteger P { get; private set; }  // коээфициенты
        public BigInteger A { get; private set; }
        public BigInteger B { get; private set; }
        public EPoint G { get; private set; } // базовая точка
        public BigInteger N { get; private set; } // порядок подгруппы
        public short H { get; private set; } // кофактор
        public uint Length { get; private set; }

        // проверка на принадлежность кривой
		private bool IsOnCurve(EPoint point) => EPoint.IsInfinityPoint(point) ? true : 
            ((BigInteger.Pow(point.Y, 2) - BigInteger.Pow(point.X, 3) - A * point.X - B) % P) == 0;

        public void CheckPoint(EPoint point, Exception exception)
        {
            if (!IsOnCurve(point))
                throw exception;
        }
    }
}
