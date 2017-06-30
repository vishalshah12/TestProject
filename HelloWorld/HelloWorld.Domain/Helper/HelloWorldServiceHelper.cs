using HelloWorld.Data;
using HelloWorld.Data.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Domain.Helper
{
    public static class HelloWorldServiceHelper
    {
        public static void Initialize(IModelRepository modelRepository)
        {
            var userTypes = (from ut in modelRepository.Fetch<UserType>()
                             select ut).ToList();

            if (!userTypes.Any(u => u.UserTypeId == 1))
            {
                Trace.TraceInformation("Inserting UserType");
                var userTypeSystem = new UserType { UserTypeId = 1, UserTypeDescription = "System", CreatedOn = DateTime.Now, CreatedByUserName = "System User" };
                modelRepository.Add(userTypeSystem);
            }
            if (!userTypes.Any(u => u.UserTypeId == 2))
            {
                Trace.TraceInformation("Inserting UserType");
                var userTypeBusiness = new UserType { UserTypeId = 2, UserTypeDescription = "Business", CreatedOn = DateTime.Now, CreatedByUserName = "System User" };
                modelRepository.Add(userTypeBusiness);
            }

            modelRepository.SaveChanges();

            userTypes = (from ut in modelRepository.Fetch<UserType>()
                         select ut).ToList();

            var users = (from u in modelRepository.Fetch<User>()
                         select u).ToList();
            if (!users.Any(u => u.UserId == 1))
            {
                Trace.TraceInformation("Inserting UserType");
                var userJohn = new User { UserId = 1, FirstName = "John", LastName = "Doe", CreatedByUserName = "System User", CreatedOn = DateTime.Now, UserTypeId = userTypes.FirstOrDefault().UserTypeId };
                modelRepository.Add(userJohn);
            }
            if (!users.Any(u => u.UserId == 2))
            {
                Trace.TraceInformation("Inserting UserType");
                var userJane = new User { UserId = 2, FirstName = "Jane", LastName = "Doe", CreatedByUserName = "System User", CreatedOn = DateTime.Now, UserTypeId = userTypes.FirstOrDefault().UserTypeId };
                modelRepository.Add(userJane);
            }

            modelRepository.SaveChanges();
        }

        public static string GetMessageByFirstName(IModelRepository modelRepository, string firstName)
        {
            if (string.IsNullOrEmpty(firstName)) return "";
            var user = (from u in modelRepository.Fetch<User>()
                        join ut in modelRepository.Fetch<UserType>() on u.UserTypeId equals ut.UserTypeId
                        where u.FirstName == firstName
                        select new
                        {
                            FirstName = u.FirstName,
                            LastName = u.LastName,
                            UserType = ut.UserTypeDescription
                        }).FirstOrDefault();
            if (user == null)
                return $"Hello World - user {firstName} don't exists";
            return $"Hello {user.FirstName}, {user.LastName} - you are a {user.UserType} user";
        }
    }
}
