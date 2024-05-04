using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change between Debug and Release to see the difference
            var notificationServiceProvider = new NotificationServiceProvider();
            var shippingService = new ShippingService(notificationServiceProvider);
            shippingService.ShipItem();
        }
    }
}