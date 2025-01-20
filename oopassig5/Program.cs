namespace oopassig5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            ICircle circle = new Circle(5);
            circle.DisplayShapeInfo();
            IRectangle rectangle = new Rectangle(1, 10);
            rectangle.DisplayShapeInfo();
            #endregion
            #region Q2
            IAuthenticationService authService = new BasicAuthenticationService();

            string username = "admin";
            string password = "password123";
            if (authService.AuthenticateUser(username, password))
            {
                Console.WriteLine($"User {username} authenticated successfully.");


                string role = "Admin";
                if (authService.AuthorizeUser(username, role))
                {
                    Console.WriteLine($"User {username} is authorized for the {role} role.");
                }
                else
                {
                    Console.WriteLine($"User {username} is not authorized for the {role} role.");
                }
            }
            else
            {
                Console.WriteLine($"Authentication failed for user {username}.");
            }

            #endregion
            #region Q3
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();
            emailService.SendNotification("email@example.com", "Hello via Email!");
            smsService.SendNotification("+1234567890", "Hello via SMS!");
            pushService.SendNotification("User123", "Hello via Push Notification!");

            #endregion

        }
    }
}
