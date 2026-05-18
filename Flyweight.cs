using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace Flyweight
{
    
    class Example
    {
        const string RED = "Red";
        const string GREEN = "Green";   
        const string BLUE = "Blue";

        interface IColor
        {
            void Print();

        }

        class RED   : IColor
        {
            public void Print()
            {
                Console.WriteLine("RED");
            }
        }

        class GREEN : IColor
        {
            public void Print()
            {
                Console.WriteLine("GREEN");
            }
        }

        class BLUE  : IColor
        {
            public void Print()
            {
                Console.WriteLine("BLUE");
            }
        }   

        class ColorObjectFactory
        {
            private Dictionary<string, IColor> colors = new Dictionary<string, IColor>();
            
            public int TotalObjectsCreated
            {
                get { return colors.Count; }
            }
        

        public IColor GetColor(string colorName)
        {

            IColor color = null;

            if (colors.ContainsKey(colorName))
            {
                color = colors[colorName];
            }
            else
            {
                switch (colorName)
                {
                    case RED:
                        color = new RED();
                        colors.Add(RED, color);
                        break;
                    case GREEN:
                        color = new GREEN();
                        colors.Add(GREEN, color);       
                        break;
                    case BLUE:
                        color = new BLUE();
                        colors.Add(BLUE, color);
                        break;

                    default:
                        throw new Exception("Invalid color");
                }

              
            }
        }

        public static void Main()
        {
            
        }

    }
}
