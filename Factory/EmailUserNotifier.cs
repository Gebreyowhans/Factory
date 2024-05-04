using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class EmailUserNotifier : IUserNotifier
    {
        public void NotifyUser(int userId)
        {
            Console.WriteLine($"Notified User {userId} by email");
        }
    }
}
