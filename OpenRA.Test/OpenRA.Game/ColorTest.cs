using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenRA.Primitives;

namespace OpenRA.Test.OpenRA.Game
{
	[TestFixture]
	public class ColorTest
	{
		public void SetUp()
		{ }

		[TestCase(TestName = "Tests Color operators")]
		public void TestColorOperators()
		{
			Assert.That(Color.Red == Color.Red,
				Is.EqualTo(true));
			Assert.That(Color.Red == Color.White,
				Is.EqualTo(false));

			Assert.That(Color.Red != Color.Red,
				Is.EqualTo(false));
			Assert.That(Color.Red != Color.White,
				Is.EqualTo(true));
		}

		[TestCase(TestName = "Tests if string is parasble as Color")]
		public void TestStringAsColorParseable()
		{
			Assert.That(Color.TryParse("aaa", out Color color),
				Is.EqualTo(false));
			Assert.That(Color.TryParse("FFFFFF", out Color color2),
				Is.EqualTo(true));
		}

		[TestCase(TestName = "Tests Equals")]
		public void TestEquals()
		{
			Assert.That(Color.Red.Equals(Color.White),
				Is.EqualTo(false));
			Assert.That(Color.Red.Equals(Color.Red),
				Is.EqualTo(true));
		}

		[TestCase(TestName = "Tests from aRGB conversion")]
		public void TestFromArgb()
		{
			Assert.That(Color.FromArgb(0xFFFFFF00),
				Is.EqualTo(Color.Yellow));
			Assert.That(Color.FromArgb(0xFFF5F5F5),
				Is.EqualTo(Color.WhiteSmoke));
			Assert.That(Color.FromArgb(0xFFFFFFFF),
				Is.EqualTo(Color.White));
		}

		[TestCase(TestName = "Tests from ahsl conversion")]
		public void TestFromAhsl()
		{
			Assert.That(Color.FromAhsl(255, 0, 0, 0),
				Is.EqualTo(Color.Black));
		}
	}
}
