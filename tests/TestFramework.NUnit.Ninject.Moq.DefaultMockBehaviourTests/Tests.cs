using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace TestFramework.NUnit.Ninject.Moq.DefaultMockBehaviourTests
{
    [TestFixture]
    public class Tests : TestsFor<Service>
    {
        public static int TestFrameworkSetupCount { get; set; }
        
        [Test]
        public void Mock_behaviour_can_be_changed_in_static_config_class()
        {
            // Arrange
            // Default mock behaviour is set in the TestFrameworkSetup class.

            // Act
            var mock = GetMock<IInterface>();

            // Assert
            mock.Behavior.Should().Be(MockBehavior.Strict);
        }

        [Test]
        public void Test_framework_setup_is_only_called_once_on_a_setup_class()
        {
            // Arrange

            // Act
            SetUpKernel();
            SetUpKernel();
            
            // Assert
            TestFrameworkSetupCount.Should().Be(1);
        }
    }

    public class Service { }

    public interface IInterface { }
}
