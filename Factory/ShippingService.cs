using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ShippingService
    {
        NotificationServiceProvider _serviceProvider;
        public ShippingService(NotificationServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void ShipItem()
        {
            _serviceProvider.GetUserNotifier().NotifyUser(1);
        }
    }
}
