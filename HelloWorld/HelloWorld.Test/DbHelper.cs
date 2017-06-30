using HelloWorld.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld.Test
{
    public static class DbHelper
    {
        public static List<UserType> GetMockUserType()
        {
            return new List<UserType>
            {
                new UserType { UserTypeId = 1, UserTypeDescription = "System", CreatedOn = DateTime.Now, CreatedByUserName = "System User" }
            };
        }

        public static List<User> GetMockUser()
        {
            var userType = GetMockUserType();
            return new List<User>
            {
                new User {FirstName = "Don", LastName = "Doe", UserTypeId = GetMockUserType().First().UserTypeId }
            };

        }
    }
}
