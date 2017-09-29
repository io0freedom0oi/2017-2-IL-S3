using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ITI.Collections.Tests
{
    [TestFixture]
    public class SimpleTests
    {
        [Test]
        public void ShouldPass()
        {

        }

        [Test]
        public void ShouldFail()
        {
            Assert.That(3, Is.EqualTo(25));
        }
    }
}
