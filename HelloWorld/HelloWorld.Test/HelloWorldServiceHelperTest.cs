using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Data;
using System.Linq;
using HelloWorld.Data.Repository;
using Moq;
using HelloWorld.Domain.Services;
using HelloWorld.Domain.Helper;

namespace HelloWorld.Test
{
    [TestClass]
    public class HelloWorldServiceHelperTest
    {
        private Mock<IModelRepository> modelRepo;
        public HelloWorldServiceHelperTest()
        {
            modelRepo = new Mock<IModelRepository>();
            modelRepo.Setup(m => m.Fetch<User>()).Returns(DbHelper.GetMockUser().AsQueryable());
            modelRepo.Setup(m => m.Fetch<UserType>()).Returns(DbHelper.GetMockUserType().AsQueryable());
        }
        [TestMethod]
        public void HelloWorldServiceHelper_GetExistingUserByNameTest()
        {
            var userName = "Don";
            var response = HelloWorldServiceHelper.GetMessageByFirstName(modelRepo.Object, userName);
            Assert.IsTrue(response.Contains(userName));
        }

        [TestMethod]
        public void HelloWorldServiceHelper_GetNoneExistingUserByNameTest()
        {
            var userName = "John";
            var invalidResponse = $"Hello World - user { userName} don't exists";
            var response = HelloWorldServiceHelper.GetMessageByFirstName(modelRepo.Object, userName);
            Assert.IsTrue(string.Compare(response, invalidResponse) == 0);
        }
    }
}

