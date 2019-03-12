// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using MessageLibrary;

namespace MessageLibrary.Test
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void CompareSameMessageObjects()
        {
            // Arrange
            BaseMessage obj1 = new BaseMessage();
            BaseMessage obj2 = obj1;
            obj2.Content = "Message 2 content";

            Assert.AreEqual(obj1, obj2);
        }

        [Test]
        public void CompareTwoObjectWithSameSettings()
        {
            BaseMessage obj1 = new BaseMessage() { Content = "Message 1" };
            BaseMessage obj2 = new BaseMessage() { Content = "Message 1" };

            Assert.AreEqual(obj1, obj2);
        }

        [Test]
        public void CompareTwoObjectWithDifferentSettings()
        {
            BaseMessage obj1 = new BaseMessage() { Content = "Message 1" };
            BaseMessage obj2 = new BaseMessage() { Content = "Message 2" };

            Assert.AreNotEqual(obj1, obj2);
        }
    }
}
