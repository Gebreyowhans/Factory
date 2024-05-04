using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class TestUserNotifier : IUserNotifier
    {
        public void NotifyUser(int userId)
        {
            Console.WriteLine($"Test notification to User {userId}");
        }
    }
}
