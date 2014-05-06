using System;
using FluentAssertions;
using NSubstitute;
using NUnit.Framework;

namespace TestFramework.NUnit.Ninject.NSubstitute.Tests
{
    [TestFixture]
    public class TestsForTests : TestsFor<Service>
    {
        [Test]
        public void Example_constructor_test()
        {
            // Arrange
            Set.SubstituteFor<IFooService>().ToNull();

            // Act
            Action act = () => GetService();

            // Assert
            act.ShouldThrow<ArgumentNullException>().And.ParamName.Should().Be("fooService");
        }

        [Test]
        public void Example_setup_test()
        {
            // Arrange
            var service = GetService();
            var expected = "expected result";

            SubstituteFor<IFooService>().DoFoo()
                                        .Returns(expected);

            // Act
            var actual = service.DoFoo();

            // Assert
            actual.Should().Be(expected);
        }
    }
}
