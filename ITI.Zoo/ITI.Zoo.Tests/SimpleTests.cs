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
        public void find_or_create_animals()
        {
            ZooContext sut = new ZooContext();

            Cat denis = sut.FindOrCreateCat("Denis");
            Cat albert = sut.FindOrCreateCat("Albert");

            Bird rene = sut.FindOrCreateBird("René");
            Bird yvon = sut.FindOrCreateBird("Yvon");

            Assert.That(denis.Name, Is.EqualTo("Denis"));
            Assert.That(albert.Name, Is.EqualTo("Albert"));
            Assert.That(rene.Name, Is.EqualTo("René"));
            Assert.That(yvon.Name, Is.EqualTo("Yvon"));

            Cat denis2 = sut.FindOrCreateCat("Denis");
            Bird rene2 = sut.FindOrCreateBird("René");

            Assert.That(denis, Is.SameAs(denis2));
            Assert.That(rene, Is.SameAs(rene2));
        }

        [Test]
        public void rename_animal()
        {
            ZooContext zoo = new ZooContext();
            Cat cat = zoo.FindOrCreateCat("Jean");
            Bird bird = zoo.FindOrCreateBird("Louise");

            cat.Name = "Denis";
            bird.Name = "Isabelle";

            Assert.That(cat.Name, Is.EqualTo("Denis"));
            Assert.That(bird.Name, Is.EqualTo("Isabelle"));

            Assert.That(zoo.FindOrCreateCat("Denis"), Is.SameAs(cat));
            Assert.That(zoo.FindOrCreateBird("Isabelle"), Is.SameAs(bird));
            Assert.That(zoo.FindOrCreateCat("Jean"), Is.Not.SameAs(cat));
            Assert.That(zoo.FindOrCreateBird("Louise"), Is.Not.SameAs(bird));
        }
    }
}
