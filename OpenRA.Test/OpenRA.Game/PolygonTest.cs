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
	public class PolygonTest
	{
		public void SetUp()
		{ }
		[TestCase(TestName = "Tests Polygon intersection")]
		public void TestPolygonInterstection()
		{
			Rectangle r1 = new Rectangle(new int2(2, 2), new Size(4, 4));
			Rectangle r2 = new Rectangle(new int2(2, 2), new Size(4, 4));
			Rectangle r3 = new Rectangle(new int2(25, 30), new Size(1, 1));

			Polygon p1 = new Polygon(r1);

			Assert.That(p1.IntersectsWith(r2),
				Is.EqualTo(true));

			Assert.That(p1.IntersectsWith(r3),
				Is.EqualTo(false));
		}

		[TestCase(TestName = "Tests if polygon contains position")]
		public void TestPolygonContains()
		{
			Rectangle r1 = new Rectangle(new int2(2, 2), new Size(4, 4));

			Polygon p1 = new Polygon(r1);

			Assert.That(p1.Contains(new int2(2, 2)),
				Is.EqualTo(true));

			Assert.That(p1.Contains(new int2(10, 10)),
				Is.EqualTo(false));
		}
	}
}
