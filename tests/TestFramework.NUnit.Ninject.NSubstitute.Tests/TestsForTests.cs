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
            Action act = () => GetSubject();

            // Assert
            act.ShouldThrow<ArgumentNullException>().And.ParamName.Should().Be("fooService");
        }

        [Test]
        public void Example_setup_test()
        {
            // Arrange
            var expected = "expected result";

            SubstituteFor<IFooService>().DoFoo()
                                        .Returns(expected);

            // Act
            var actual = Subject.DoFoo();

            // Assert
            actual.Should().Be(expected);
        }

        [Test]
        public void Set_substitute_to_type_configures_kernel()
        {
            // Arrange
            Set.SubstituteFor<IFooService>().To<FooService>();

            // Act
            var substitute = SubstituteFor<IFooService>();

            // Assert
            substitute.Should().BeOfType<FooService>();
        }
    }
}
