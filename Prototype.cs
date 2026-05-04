using System;

namespace Pototype
{
    public class Person : ICloneable
    {
    public string Firstname { get; set; }
    public string LastName { get; set; }

    public object Clone()
    {
        return this.MemberwiseClone();

    }
    }
    
    class Example
    {

        public static void Main(string[] args)
        {
            Person p1 = new Person() { 
            Firstname = "John", 
            LastName = "Doe" 
            
        };

        Person p2 = p1.Clone() as Person; 
        


         }
    }

    }