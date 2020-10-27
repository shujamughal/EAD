using System;

namespace Lecture24
{
    delegate void PublishMessageDel(string msg);

    class Publisher {

        //public PublishMessageDel publishMessageObj = null;
        public event PublishMessageDel publishevent = null;

        public void PublishMessage(string msg) {

            publishevent.Invoke(msg);
        }
    }
    //subscribers
    class SendViaEmailSubscriber {

        public void Subscribe(Publisher p) {

            p.publishevent += SendMessage;
        }
        private void SendMessage(string msg) {

            Console.WriteLine($"Send to Email {msg}");
        }
    
    
    }

    class SendViaMobileSubscriber {

        public void Subscribe(Publisher p)
        {
            p.publishevent += SendMessage;
            
            
        }
        private void SendMessage(string msg) {
            Console.WriteLine($"Send to Mobile {msg}");
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisherObj = new Publisher();
            SendViaEmailSubscriber emailObj = new SendViaEmailSubscriber();
            SendViaMobileSubscriber mobObj = new SendViaMobileSubscriber();

            emailObj.Subscribe(publisherObj);
            mobObj.Subscribe(publisherObj);
            //publisherObj.publishMessageObj = emailObj.SendMessage;
            //publisherObj.publishMessageObj += mobObj.SendMessage;
            
            publisherObj.PublishMessage("Hello, You have a new notification");
                
        }
    }
}
