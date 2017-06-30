using System.Data.Entity;

namespace HelloWorld.Data
{
    public class HelloWorldContext : DbContext
    {        
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }     
    }
}
