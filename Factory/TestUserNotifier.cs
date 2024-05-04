using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class TestUserNotifier : IUserNotifier
    {
        public void NotifyUser(int id)
        {
            Console.WriteLine($"Pretending to notify user {id}.");
        }
    }
}
