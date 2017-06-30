using System.Web.Http;
using HelloWorld.Data;
using HelloWorld.Data.Repository;
using HelloWorld.Domain.Helper;

namespace HelloWorld.Api.Controllers
{
    public class HelloWorldController : ApiController
    {
        private HelloWorldContext db = new HelloWorldContext();


        [Route("api/HelloWorld/firstName/{firstName}")]
        [HttpGet]
        public string HelloWorldUser(string firstName)
        {
            var _modelRepository = new ModelDbRepository(db);
            HelloWorldServiceHelper.Initialize(_modelRepository);
            return HelloWorldServiceHelper.GetMessageByFirstName(_modelRepository, firstName);
            
        }       
    }
}