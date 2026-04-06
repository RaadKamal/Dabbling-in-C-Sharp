using system;

namespace Builder{


    public interface IComputeBuilder
    {
        void SetMonitor();
        void SetMouse();
        void SetKeyboard(); 
        voud SetTower();
        voud SetPrinter();

        Computer GetComputer();

    }

    public class Computer
    {
        public string Monitor { get; set; }
        public string Mouse { get; set; }
        public string Keyboard { get; set; }
        public string Tower { get; set; }
        public string Printer { get; set; }

       
    }
    public class ComputerABuilder : IComputeBuilder
    {
         Computer _computer = new Computer();

        public void SetMonitor()
        {
            _computer.Monitor = "Dell 24 inch";
        }

        public void SetMouse()
        {
            _computer.Mouse = "Logitech Wireless Mouse";
        }

        public void SetKeyboard()
        {
            _computer.Keyboard = "Mechanical Keyboard";
        }

        public void SetTower()
        {
            _computer.Tower = "Custom Gaming Tower";
        }

        public void SetPrinter()
        {
            _computer.Printer = "HP LaserJet Pro";
        }

        public Computer GetComputer()
        {
            return _computer;
        }
    }

    public class ComputerBBuilder: IComputeBuilder
    {
         Computer _computer = new Computer();

        public void SetMonitor()
        {
            _computer.Monitor = "HP 27 inch";
        }

        public void SetMouse()
        {
            _computer.Mouse = "Microsoft Wireless Mouse";
        }

        public void SetKeyboard()
        {
            _computer.Keyboard = "Membrane Keyboard";
        }

        public void SetTower()
        {
            _computer.Tower = "Prebuilt Office Tower";
        }

        public void SetPrinter()
        {
            _computer.Printer = "Canon Inkjet Printer";
        }

        public Computer GetComputer()
        {
            return _computer;
        }
    }

    public class ComputerCreator

    {
       private IComputeBuilder computerBuilder;

        public ComputerCreator(IComputeBuilder builder)
        {
            this.computerBuilder = builder;
        }

        public Computer CreateComputer()
        {
            computerBuilder.SetMonitor();
            computerBuilder.SetMouse();
            computerBuilder.SetKeyboard();
            computerBuilder.SetTower();
            computerBuilder.SetPrinter();

            return computerBuilder.GetComputer();
        }

        public COmputer GetComputer()
        {
            return computerBuilder.GetComputer();
        }
    }
    class Example
    {
        publiv static void Main(string[] args)
        {
            ComputerCreator creatorA = new ComputerCreator(new ComputerABuilder());
            Computer computerA = creatorA.CreateComputer();

            Console.WriteLine("Computer A:");
            Console.WriteLine($"Monitor: {computerA.Monitor}");
            Console.WriteLine($"Mouse: {computerA.Mouse}");
            Console.WriteLine($"Keyboard: {computerA.Keyboard}");
            Console.WriteLine($"Tower: {computerA.Tower}");
            Console.WriteLine($"Printer: {computerA.Printer}");

            ComputerCreator creatorB = new ComputerCreator(new ComputerBBuilder());
            Computer computerB = creatorB.CreateComputer();

            Console.WriteLine("\nComputer B:");
            Console.WriteLine($"Monitor: {computerB.Monitor}");
            Console.WriteLine($"Mouse: {computerB.Mouse}");
            Console.WriteLine($"Keyboard: {computerB.Keyboard}");
            Console.WriteLine($"Tower: {computerB.Tower}");
            Console.WriteLine($"Printer: {computerB.Printer}");
        }

    }
}