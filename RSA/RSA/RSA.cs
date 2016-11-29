using System.Numerics;

namespace RSA
{
	internal class RSA
	{
		private readonly int _d;
		private readonly int _e;
		private readonly int _n;
		private readonly int _p;
		private readonly int _q;

		public RSA(int p, int q, int e, int d)
		{
			_p = p;
			_q = q;
			_e = e;
			_d = d;
			_n = _p*_q;
		}

		public int Encrypt(int message)
		{
			var closeText = BigInteger.Pow(message, _e)%_n;
			return (int) closeText;
		}

		public int Decrypt(int message)
		{
			var openText = BigInteger.Pow(message, _d)%_n;
			return (int) openText;
		}
	}
}