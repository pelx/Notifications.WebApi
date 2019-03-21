using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Notifications.WebApi.Controllers;
using Notifications.WebApi.Models;
using Notifications.WebApi.Services;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Notifications.Tests.Controllers
{
    [TestClass]
    public class NotificationsControllerTest
    {
        private Mock<INotificationService> _notificationService;
        private NotificationsController _controller;

        [TestInitialize]
        public void Init()
        {
            _notificationService = new Mock<INotificationService>();
            _controller = new NotificationsController(_notificationService.Object);
        }

        [TestMethod]
        public void Has_GetAll()
        {
            // arrange
            var controller = new NotificationsController(_notificationService.Object);
            // act
            var result = controller.GetAll();
            // assert
            result.Should().NotBeNull();
        }

        [TestMethod]
        public void Calls_INotificationService()
        {
            // arrange
            // act
            var result = _controller.GetAll();
            // assert
            _notificationService.Verify(mq => mq.QueryAll(), Times.Once);
        }

        [TestMethod]
        public void Has_SaveNotification_ReturnValue()
        {
            // arrange
            
            var notification = new Notification();
            // act
            var result = _controller.SaveNotification(notification);
            // assert
            result.Should().NotBeNull();
        }

        [TestMethod]
        public void Returns_503_If_INotificationService_Throws_Exception()
        {
            // arrange
            _notificationService.Setup(mq => mq.QueryAll()).Throws(new Exception("DB down"));
            // act
            var result = _controller.GetAll();
            //assert
            Assert.IsTrue(result is StatusCodeResult);
            var status = (StatusCodeResult)result;
            status.StatusCode.Should().Be((int)HttpStatusCode.ServiceUnavailable);
        }


        // 400 - bad request
        [TestMethod]
        public void Returns_400_If_RequiredFields_Missing()
        {
            // arrange
            var emptyNotification = new Notification();
            // act
            var result = _controller.SaveNotification(emptyNotification);
            //assert
            Assert.IsTrue(result is StatusCodeResult);
            var status = (StatusCodeResult)result;
            status.StatusCode.Should().Be((int)HttpStatusCode.BadRequest);
        }

    }
}
