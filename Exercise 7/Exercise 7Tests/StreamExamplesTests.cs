using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise_7.Tests
{
    [TestClass()]
    public class StreamExamplesTests
    {
        [TestMethod()]
        public void FooExampleTest()
        {
            StreamExamples.FileExample();
            Assert.IsTrue(true);
        }
    }
}