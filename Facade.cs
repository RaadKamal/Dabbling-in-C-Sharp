using System.Diagnostics;
using System.Reflection.PortableExecutable;

namespace App
{
    class Facade
    {
        protected Subsystem1 subsystem1;
        protected Subsystem2 subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            this.subsystem1 = subsystem1;
            this.subsystem2 = subsystem2;
        }

        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += this.subsystem1.Operation1();
            result += this.subsystem2.Operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += this.subsystem1.Operation2();
            result += this.subsystem2.Operation2();
            return result;
        }


        public class Subsystem1
        {
           public string Operation1()
            {
                return "\t Subsystem1: Operation 1!\n";
            }

            public string Operation2()
            {
                return "\t Subsystem1: Operation 2!\n";
            }
        }

        public class Subsystem2
        {
            public string Operation1()
            {
                return "\t Subsystem2: Operation 1!\n";
            }

            public string Operation2()
            {
                return "\t Subsystem2: Operation 2!\n";
            }

    }

    class Client
        {
            public static void ClientCode(Facade Facade)
            {
                Debug.WriteLine(Facade.Operation());
            }
        }

    public void Main(string[] args)
    {
        Subsystem1 subsystem1 = new Subsystem1();
        Subsystem2 subsystem2 = new Subsystem2();
        Facade facade = new Facade(subsystem1, subsystem2);
        Client.ClientCode(facade);
    }

    }

}

    

