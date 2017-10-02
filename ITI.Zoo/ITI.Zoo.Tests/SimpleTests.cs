using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ITI.Zoo.Tests
{
    [TestFixture]
    public class SimpleTests
    {
        [Test]
        public void create_animals()
        {
            ZooContext sut = new ZooContext();

            sut.CreateCat("Denis");
            sut.CreateCat("Albert");

            sut.CreateBird("René");
            sut.CreateBird("Yvon");

            Cat denis = sut.FindCatByName("Denis");
            Cat albert = sut.FindCatByName("Albert");

            Bird rene = sut.FindBirdByName("René");
            Bird yvon = sut.FindBirdByName("Yvon");

            Assert.That(denis.Name, Is.EqualTo("Denis"));
            Assert.That(albert.Name, Is.EqualTo("Albert"));
            Assert.That(rene.Name, Is.EqualTo("René"));
            Assert.That(yvon.Name, Is.EqualTo("Yvon"));
        }
    }
}
