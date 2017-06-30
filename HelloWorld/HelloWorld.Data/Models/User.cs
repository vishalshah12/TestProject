using System;
using System.Collections.Generic;

namespace HelloWorld.Data
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserTypeId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedByUserName { get; set; }
    }

}
