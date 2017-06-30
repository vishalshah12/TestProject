using HelloWorld.Data;
using HelloWorld.Data.Repository;
using HelloWorld.Domain.Contract;
using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using HelloWorld.Domain.Helper;

namespace HelloWorld.Domain.Services
{

    public class HelloWorldService : IHelloWorldService
    {
        private IModelRepository _modelRepository;
        public HelloWorldService(IModelRepository modelRepository)
        {
            _modelRepository = modelRepository;
            HelloWorldServiceHelper.Initialize(_modelRepository);
        }

        public string HelloWorld(string firstName)
        {
            try
            {
                return HelloWorldServiceHelper.GetMessageByFirstName(_modelRepository, firstName);

            }
            catch (Exception ex)
            {
                //TODO: Log error
                return ex.Message;
            }

        }

        public List<User> GetAllUsers()
        {
            return (from u in _modelRepository.Fetch<User>()
                    select u).ToList();
        }

        //private void Initialize()
        //{


        //    var userTypes = (from ut in _modelRepository.Fetch<UserType>()
        //                     select ut).ToList();

        //    if (!userTypes.Any(u => u.UserTypeId == 1))
        //    {
        //        Trace.TraceInformation("Inserting UserType");
        //        var userTypeSystem = new UserType { UserTypeId = 1, UserTypeDescription = "System", CreatedOn = DateTime.Now, CreatedByUserName = "System User" };
        //        _modelRepository.Add(userTypeSystem);
        //    }
        //    if (!userTypes.Any(u => u.UserTypeId == 2))
        //    {
        //        Trace.TraceInformation("Inserting UserType");
        //        var userTypeBusiness = new UserType { UserTypeId = 2, UserTypeDescription = "Business", CreatedOn = DateTime.Now, CreatedByUserName = "System User" };
        //        _modelRepository.Add(userTypeBusiness);
        //    }

        //    _modelRepository.SaveChanges();

        //    userTypes = (from ut in _modelRepository.Fetch<UserType>()
        //                 select ut).ToList();

        //    var users = (from u in _modelRepository.Fetch<User>()
        //                 select u).ToList();
        //    if (!users.Any(u => u.UserId == 1))
        //    {
        //        Trace.TraceInformation("Inserting UserType");
        //        var userJohn = new User { UserId = 1, FirstName = "John", LastName = "Doe", CreatedByUserName = "System User", CreatedOn = DateTime.Now, UserTypeId = userTypes.FirstOrDefault().UserTypeId };
        //        _modelRepository.Add(userJohn);
        //    }
        //    if (!users.Any(u => u.UserId == 2))
        //    {
        //        Trace.TraceInformation("Inserting UserType");
        //        var userJane = new User { UserId = 2, FirstName = "Jane", LastName = "Doe", CreatedByUserName = "System User", CreatedOn = DateTime.Now, UserTypeId = userTypes.FirstOrDefault().UserTypeId };
        //        _modelRepository.Add(userJane);
        //    }

        //    _modelRepository.SaveChanges();

        //}
    }
}
