using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factory pattern to provide an object encapsulating an action that the code needed to perform

            /* The code to decide the type notifcation as well as the implementation of the notification is completly separted from the shiping code that
            only needs to know from a user perspective that a user shoyld be notfiied   */

            // Change between Debug and Release to see the difference
            var notificationServiceProvider = new NotificationServiceProvider();

            var shipingService = new ShippingService(notificationServiceProvider);
            shipingService.ShipItem();
        }
    }
}