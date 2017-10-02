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

        [Test]
        public void cannot_rename_an_animal_with_an_existing_name()
        {
            ZooContext zoo = new ZooContext();
            Cat jean = zoo.FindOrCreateCat("Jean");
            Cat julien = zoo.FindOrCreateCat("Julien");
            Bird louise = zoo.FindOrCreateBird("Louise");
            Bird fabien = zoo.FindOrCreateBird("Fabien");

            ArgumentException ex1 = Assert.Catch<ArgumentException>(() => jean.Name = "Julien");
            Assert.That(ex1.Message, Is.EqualTo("A cat with this name already exists."));

            ArgumentException ex2 = Assert.Catch<ArgumentException>(() => louise.Name = "Fabien");
            Assert.That(ex2.Message, Is.EqualTo("A bird with this name already exists."));
        }
    }
}
