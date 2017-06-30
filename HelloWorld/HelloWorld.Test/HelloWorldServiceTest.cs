using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Data;
using System.Linq;
using HelloWorld.Data.Repository;
using Moq;
using HelloWorld.Domain.Services;

namespace HelloWorld.Test
{
    [TestClass]
    public class HelloWorldServiceTest
    {
        private Mock<IModelRepository> modelRepo;
        public HelloWorldServiceTest()
        {
            modelRepo = new Mock<IModelRepository>();
            modelRepo.Setup(m => m.Fetch<User>()).Returns(DbHelper.GetMockUser().AsQueryable());
            modelRepo.Setup(m => m.Fetch<UserType>()).Returns(DbHelper.GetMockUserType().AsQueryable());
        }
        [TestMethod]
        public void HelloWorldService_GetExistingUserByNameTest()
        {
            var userName = "Don";            
            HelloWorldService service = new HelloWorldService(modelRepo.Object);
            var response = service.HelloWorld(userName);
            Assert.IsTrue(response.Contains(userName));
        }

        [TestMethod]
        public void HelloWorldService_GetNoneExistingUserByNameTest()
        {
            var userName = "John";
            var invalidResponse = $"Hello World - user { userName} don't exists";          
            HelloWorldService service = new HelloWorldService(modelRepo.Object);
            var response = service.HelloWorld(userName);
            Assert.IsTrue(string.Compare(response, invalidResponse) == 0);
        }
    }    
}

