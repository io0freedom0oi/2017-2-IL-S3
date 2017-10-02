using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ITI.Collections.Tests
{
    [TestFixture]
    public class DictionaryTests
    {
        [Test]
        public void SimpleTest()
        {
            Dictionary<string, Person> sut = new Dictionary<string, Person>();

            Person p1 = new Person("Toto", "Titi");
            sut.Add(p1.LastName, p1);

            Person p2 = new Person("Jean", "Robert");
            sut.Add(p2.LastName, p2);

            Person titi = sut["Titi"];
            Person robert = sut["Robert"];

            Assert.That(titi, Is.SameAs(p1));
            Assert.That(robert, Is.SameAs(p2));

            Person p3 = new Person("Tata", "Titi");
            sut["Titi"] = p3;

            Assert.That(titi, Is.Not.SameAs(sut["Titi"]));
            Assert.That(p3, Is.SameAs(sut["Titi"]));
        }
    }
}
