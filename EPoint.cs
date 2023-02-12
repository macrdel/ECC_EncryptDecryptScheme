using System;
using System.Numerics;

namespace ECClasses
{
    public class EPoint
    {
        public static EPoint InfinityPoint => null; // точка - нуль
        public static bool IsInfinityPoint(EPoint point) => point == InfinityPoint;

        public BigInteger X { get; set; }
        public BigInteger Y { get; set; }
        public ECurve Curve { get; set; }

        public EPoint(BigInteger x, BigInteger y, ECurve curve)
        {
            X = x;
            Y = y;

            Curve = curve;
        }

		// остаток при делении
		private static BigInteger Modulus(BigInteger value, BigInteger modulo)
		{
			BigInteger reminder = value % modulo;

			return reminder < 0 ? reminder += modulo : reminder;
		}

		// расширенный алгоритм Евклида
		// аналог деления только на эллиптических кривых
		private static BigInteger ModularInverse(BigInteger value, BigInteger modulo)
		{
			if (value == 0)
				throw new DivideByZeroException();

			if (value < 0)
				return modulo - ModularInverse(-value, modulo);

			BigInteger a = 0, oldA = 1;
			BigInteger r = modulo, oldR = value;

			while (r != 0)
			{
				BigInteger quotient = oldR / r;

				BigInteger prov = r;
				r = oldR - quotient * prov;
				oldR = prov;

				prov = a;
				a = oldA - quotient * prov;
				oldA = prov;
			}

			BigInteger gcd = oldR;
			BigInteger c = oldA;

			if (gcd != 1)
				throw new Exception($"GCD не равен 1, = {gcd}.");

			if (Modulus(value * c, modulo) != 1)
				throw new ArithmeticException("Modular inverse : последняя проверка провалена.");

			return Modulus(c, modulo);
		}

		// 'сложение' двух точек на эллиптической кривой
		private static EPoint ECAdd(EPoint first, EPoint second)
		{
			if (IsInfinityPoint(first))
				return second;

			if (IsInfinityPoint(second))
				return first;

			ECurve commonCurve;

			if (first.Curve == second.Curve)
				commonCurve = first.Curve;
			else
				throw new Exception("Используемые кривые не совпадают");

			commonCurve.CheckPoint(first, new Exception("Точка расположена вне кривой"));
			commonCurve.CheckPoint(second, new Exception("Точка расположена вне кривой"));

			BigInteger tmp;

			if (first.X == second.X)
			{
				if (first.Y != second.Y)
					return InfinityPoint;

				tmp = (3 * BigInteger.Pow(first.X, 2) + commonCurve.A) *
                    ModularInverse(2 * first.Y, commonCurve.P);
			}
			else
				tmp = (first.Y - second.Y) * ModularInverse(first.X - second.X, commonCurve.P);

			BigInteger newX = BigInteger.Pow(tmp, 2) - first.X - second.X;
			BigInteger newY = first.Y + tmp * (newX - first.X);
			EPoint result = new EPoint(Modulus(newX, commonCurve.P), 
				Modulus(-newY, commonCurve.P), commonCurve);

			return result;
		}

		// обратная величина
		private static EPoint Negate(EPoint point)
		{
			point.Curve.CheckPoint(point, new Exception("Точка расположена вне кривой"));

			if (IsInfinityPoint(point))
				return point;

			EPoint result = new EPoint(point.X, Modulus(-point.Y, point.Curve.P), point.Curve);

			result.Curve.CheckPoint(result, new Exception("Точка расположена вне кривой"));

			return result;
		}

		// самое важное - умножение точки на скаляр
		public static EPoint ECMultiply(EPoint point, BigInteger scalar)
		{
			if (IsInfinityPoint(point) || scalar % point.Curve.N == 0)
				return InfinityPoint;

			point.Curve.CheckPoint(point, new Exception("Точка расположена вне кривой"));

			if (scalar < 0)
				return ECMultiply(Negate(point), - scalar);

			EPoint result = InfinityPoint;
			EPoint addend = point;

			while (scalar != 0)
			{
				if ((scalar & 1) == 1)
					result = ECAdd(result, addend);

				addend = ECAdd(addend, addend);

				scalar >>= 1;
			}

			point.Curve.CheckPoint(result, new Exception("Точка расположена вне кривой"));

			return result;
		}

	}
}