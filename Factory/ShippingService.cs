using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ShippingService
    {
        NotificationServiceProvider _notificationService;

        public ShippingService(NotificationServiceProvider notificationServiceProvider)
        {

            _notificationService = notificationServiceProvider;
        }

        public void ShipItem()
        {
            _notificationService.GetUserNotifier().NotifyUser(1);
        }
    }
}
