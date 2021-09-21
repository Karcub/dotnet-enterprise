using dotnet_enterprise.Controllers;
using dotnet_enterprise.Interfaces;
using NUnit.Framework;
using NSubstitute;

namespace dotnet_enterprise_tests
{
    public class EventItemControllerTests
    
    {
        private IEventItemRepository _mockRepository;
        private EventItemsController _controller;

        [OneTimeSetUp]
        public void Setup()
        {
            _mockRepository = Substitute.For<IEventItemRepository>();
            _controller = new EventItemsController(_mockRepository);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}