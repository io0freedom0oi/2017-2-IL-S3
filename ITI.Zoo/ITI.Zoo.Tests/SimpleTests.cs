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
            Zoo sut = new Zoo();

            Cat denis = sut.CreateCat("Denis");
            Cat albert = sut.CreateCat("Albert");

            Bird rene = sut.CreateBird("René");
            Bird yvon = sut.CreateBird("Yvon");

            Assert.That(denis.Name, Is.EqualTo("Denis"));
            Assert.That(albert.Name, Is.EqualTo("Albert"));
            Assert.That(rene.Name, Is.EqualTo("René"));
            Assert.That(yvon.Name, Is.EqualTo("Yvon"));

            Cat denis2 = sut.CreateCat("Denis");
            Bird rene2 = sut.CreateBird("René");

            Assert.That(denis, Is.SameAs(denis2));
            Assert.That(rene, Is.SameAs(rene2));
        }

        [Test]
        public void rename_animal()
        {
            Zoo zoo = new Zoo();
            Cat cat = zoo.CreateCat("Jean");
            Bird bird = zoo.CreateBird("Louise");

            cat.Name = "Denis";
            bird.Name = "Isabelle";

            Assert.That(cat.Name, Is.EqualTo("Denis"));
            Assert.That(bird.Name, Is.EqualTo("Isabelle"));

            Assert.That(zoo.CreateCat("Denis"), Is.SameAs(cat));
            Assert.That(zoo.CreateBird("Isabelle"), Is.SameAs(bird));
            Assert.That(zoo.CreateCat("Jean"), Is.Not.SameAs(cat));
            Assert.That(zoo.CreateBird("Louise"), Is.Not.SameAs(bird));
        }

        [Test]
        public void cannot_rename_an_animal_with_an_existing_name()
        {
            Zoo zoo = new Zoo();
            Cat jean = zoo.CreateCat("Jean");
            Cat julien = zoo.CreateCat("Julien");
            Bird louise = zoo.CreateBird("Louise");
            Bird fabien = zoo.CreateBird("Fabien");

            ArgumentException ex1 = Assert.Catch<ArgumentException>(() => jean.Name = "Julien");
            Assert.That(ex1.Message, Is.EqualTo("A cat with this name already exists."));

            ArgumentException ex2 = Assert.Catch<ArgumentException>(() => louise.Name = "Fabien");
            Assert.That(ex2.Message, Is.EqualTo("A bird with this name already exists."));
        }
    }
}
