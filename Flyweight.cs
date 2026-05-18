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

        class Red   : IColor
        {
            public void Print()
            {
                Console.WriteLine("RED");
            }
        }

        class Green : IColor
        {
            public void Print()
            {
                Console.WriteLine("GREEN");
            }
        }

        class Blue  : IColor
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
                        color = new Red();
                        colors.Add(RED, color);
                        break;
                    case GREEN:
                        color = new Green();
                        colors.Add(GREEN, color);       
                        break;
                    case BLUE:
                        color = new Blue();
                        colors.Add(BLUE, color);
                        break;

                    default:
                        throw new Exception("Invalid color");
                }

              
         
         
            }

            return color;

        }
        }

        public static void Main(string[] args)
        {
            ColorObjectFactory colorfactory = new ColorObjectFactory(); 
            IColor color1 = colorfactory.GetColor(RED);
            color1.Print();
            IColor color2 = colorfactory.GetColor(GREEN);           
            color2.Print();
            IColor color3 = colorfactory.GetColor(BLUE);     
            color3.Print();
            IColor color4 = colorfactory.GetColor(RED);
            color4.Print();

            int numberOfObjectsCreated = colorfactory.TotalObjectsCreated;
            Debug.Assert(numberOfObjectsCreated == 3, "Number of objects created should be 3");


        }

    }
}
