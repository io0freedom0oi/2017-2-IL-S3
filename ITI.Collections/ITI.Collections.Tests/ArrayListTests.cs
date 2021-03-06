﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ITI.Collections.Tests
{
    [TestFixture]
    public class ArrayListTests
    {
        [Test]
        public void add_and_get_value()
        {
            ArrayList<int> sut = new ArrayList<int>();

            sut.Add(1);
            sut.Add(2);
            sut.Add(3);
            sut.Add(4);

            Assert.That(sut.GetAt(0), Is.EqualTo(1));
            Assert.That(sut.GetAt(1), Is.EqualTo(2));
            Assert.That(sut.GetAt(2), Is.EqualTo(3));
            Assert.That(sut.GetAt(3), Is.EqualTo(4));
        }
    }
}
