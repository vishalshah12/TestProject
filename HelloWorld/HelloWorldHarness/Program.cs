using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var name = string.Empty;
            var client1 = new HelloWorldService.HelloWorldServiceClient();
            var allUsers = client1.GetAllUsers();
            var validUsers = "Current Users in System\n";
            //For testing purpose - print all user's first name
            if(allUsers != null)
            {
                allUsers.ToList().ForEach(u =>
                {
                    validUsers += $"First Name = {u.FirstName}\n";
                });
            }
            
            Console.WriteLine(validUsers);
            while (!(name=Console.ReadLine()).Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                if (string.IsNullOrEmpty(name))
                    Console.WriteLine("No name provided");
                else
                {
                    var client = new HelloWorldService.HelloWorldServiceClient();
                    Console.WriteLine(client.HelloWorld(name));
                    Console.WriteLine("type 'exit' to close application or enter another name");
                }
            }

            Environment.Exit(0);
        }
    }
}
