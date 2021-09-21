using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using dotnet_enterprise.Controllers;
using dotnet_enterprise.Interfaces;
using dotnet_enterprise.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Any;
using NUnit.Framework;
using NSubstitute;
using NUnit.Framework.Internal.Execution;

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
        public void GetEventItem_IfItemExist_ReturnItem()
        {
            var eventItem = new EventItem { Id = 1 };
            var eventTask = Task.Run(() => eventItem);

            _mockRepository.GetEventItem(1).Returns(eventTask);
            Assert.That(_controller.GetEventItem(1).Result.Value, Is.EqualTo(eventItem));
        }
        
        [Test]
        public void GetEventItem_IfItemDoesntExist_ReturnNull()
        {
            // var response = new HttpResponseMessage(HttpStatusCode.NotFound);
            // Assert.That(_controller.GetEventItem(123), Is.EqualTo(response));
            Assert.That(_controller.GetEventItem(1).Result.Value, Is.EqualTo(null));
        }
    }
}