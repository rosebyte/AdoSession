﻿using NUnit.Framework;

namespace DbSession.Core.Tests
{
    [TestFixture]
    public class SqlParameterTests
    {
        [Test]
        public void ShouldConstructInstance()
        {
            var sut = new SqlParameter<int>("A", 2);

            Assert.That(sut.Value, Is.EqualTo(2));
            Assert.That(sut.Name, Is.EqualTo("A"));
            Assert.That(sut.Type, Is.EqualTo(typeof(int)));
        }
    }
}