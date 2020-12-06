using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenRA.FileSystem;

namespace OpenRA.Test
{
	[TestFixture]
	public class FolderTest
	{
		Folder testFolder;
		[SetUp]
		public void SetUp()
		{
			testFolder = new Folder("C:/Users/PC/Desktop/openRaTest/");
		}

		[TestCase(TestName = "Tests contains function")]
		public void TestContains()
		{
			Assert.That(testFolder.Contains("test.txt"),
				Is.EqualTo(true));
			Assert.That(testFolder.Contains("adawd.txt"),
				Is.EqualTo(false));
		}

		[TestCase(TestName = "Tests obtaining file stream")]
		public void TestGetStream()
		{
			Assert.That(testFolder.Contains("test.txt"),
				Is.EqualTo(true));
			Assert.That(testFolder.Contains("adawd.txt"),
				Is.EqualTo(false));
		}
	}
}
