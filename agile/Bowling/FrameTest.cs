using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace agile.Bowling
{
    [TestFixture]
    public class FrameTest
    {
        [Test]
        public void TestScoreNoThrows()
        {
           var frame = new Frame();
            Assert.AreEqual(0, frame.Score);
        }

        [Test]
        public void TestAddOneThrow()
        {
            var frame = new Frame();
            frame.Add(5);
            Assert.AreEqual(5, frame.Score);
        }
    }
}
