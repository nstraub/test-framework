using System.Linq;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace TestFramework.NUnit.Ninject.Moq.Tests
{
    [TestFixture]
    public class TestsForTests : TestsFor<Service>
    {
        [Test]
        public void AddInstance_adds_instances_to_auto_mocking_container()
        {
            // Arrange
            var class1 = new Class1();
            var class2 = new Class2();
            
            // Act
            AddInstance<IInterface>(class1);
            AddInstance<IInterface>(class2);

            var instances = GetAllMocks<IInterface>().ToList();

            // Assert
            instances.Should().HaveCount(2);

            instances.Should().Contain(class1);
            instances.Should().Contain(class2);
        }

        [Test]
        public void Default_mock_behaviour_is_loaded_from_static_config_class()
        {
            // Arrange
            
            // Act
            var mock = GetMock<IInterface>();

            // Assert
            mock.Behavior.Should().Be(MockBehavior.Default);
        }
    }

    public class Service { }

    public interface IInterface { }

    public class Class1 : IInterface { }
    public class Class2 : IInterface { }
}