using System;

namespace Bridge
{
    class Example
    {

        public abstract class Message
        {
            public ISender? Sender { get; set; }
            public string? Subject { get; set; }
            public string? Body { get; set; }
            public abstract void Send();
        }

        public class SystemMessage : Message
        {
            public override void Send()
            {
                if (Sender != null && Subject != null && Body != null)
                {
                    Sender.SendMessage(Subject, Body);
                }
            }
        }

        public class UserMessage: Message
        {

        public string? UserComments { get; set; }

        public override void Send()
        {
            if (Sender != null && Subject != null && Body != null && UserComments != null)
            {
                string fullbody = string.Format("{0}- User Comments: {1}", Body, UserComments);
                Sender.SendMessage(Subject, fullbody);
            }
        }
        }

        public interface ISender
        {
            void SendMessage(string subject, string body);
        }

        public class FacebookSender : ISender
        {
            public void SendMessage(string subject, string body)
            {
                Console.WriteLine("Facebook message sent with subject: {0} and body: {1}", subject, body);
            }
        }

        public class TwitterSender : ISender
        {
            public void SendMessage(string subject, string body)
            {
                Console.WriteLine("Twitter message sent with subject: {0} and body: {1}", subject, body);
            }
        }

        public class InstagramSender : ISender
        {
            public void SendMessage(string subject, string body)
            {
                Console.WriteLine("Instagram message sent with subject: {0} and body: {1}", subject, body);
            }
        }

        static void Main(string[] args)
        {
            ISender facebookSender = new FacebookSender();
            ISender twitterSender = new TwitterSender();
            ISender instagramSender = new InstagramSender();

            Message message = new SystemMessage ();

            message.Subject = "Test Message";
            message.Body = "This is a test message.";

            message.Sender = facebookSender;
            message.Send(); 

            message.Sender = twitterSender;
            message.Send();

            message.Sender = instagramSender;
            message.Send();

            UserMessage userMessage = new UserMessage();
            userMessage.Subject = "User Message";
            userMessage.Body = "This is a user message.";
            userMessage.UserComments = "This is a user comment.";

            userMessage.Sender = facebookSender;
            userMessage.Send();     

            Console.ReadKey();

        }
        }
    
}