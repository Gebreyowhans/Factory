using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class NotificationServiceProvider
    {
        //Factory methond that return IUserNotifier

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
