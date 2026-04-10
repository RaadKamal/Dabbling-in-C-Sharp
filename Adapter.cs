using System;

namespace Adapter
{
    // Target interface
    class Example
    {
        class Adaptee
        {
            public string GetRequest()
            {
                return "Return from the client";
            }
        }

        public interface Itarget
        {
            string Request();
        }

        class Adapter : Itarget
        {
            private readonly Adaptee adaptee;

            public Adapter(Adaptee adaptee)
            {
                this.adaptee = adaptee;
            }

            public string Request()
            {
                return $"This is '{this.adaptee.GetRequest()}'";
            }
        }

        static void Main (string[] args)
        {
            Adaptee adaptee = new Adaptee();
            Itarget target = new Adapter(adaptee);
            
            // Replaced Debug.WriteLine with Console.WriteLine to see it in the terminal
            Console.WriteLine(target.Request()); 
        }
    }
}