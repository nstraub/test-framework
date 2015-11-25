using NUnit.Framework;

namespace TestFramework.NUnit.Ninject.Moq.Example.TestFramework
{
    [TestFixture]
    public class MyTests : TestsFor<MyFoo>
    {
        [Test]
        public void Test1()
        {
            // Arrange
            // setup the mock
            var barMock = GetMock<IBar>();
            barMock.Setup(mock => mock.GetContent()).Returns("mocked Content");

            // Act
            Subject.DoStuff(); // The Subject property gets the real MyFoo with a mocked IBar injected into it
                               // this will print "mocked Content", because the mocked object is called

            // Assert
            barMock.VerifyAll();
        }
    }
}
