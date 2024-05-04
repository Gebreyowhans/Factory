using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class NotificationServiceProvider
    {
        public IUserNotifier GetUserNotifier()
        {
#if DEBUG
            return new TestUserNotifier();
#else
            return new EmailUserNotifier();
#endif
        }
    }
}
