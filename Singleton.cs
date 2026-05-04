using System; // Fixed: Added semicolon

namespace Singleton
{
   class Singleton
   {
    private static Singleton instance;

    protected Singleton()
    {
    }
    
    public static Singleton Instance
    {
        get // Fixed: Added 'get' keyword
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
   } 

   class Example
   {
       // You can put your test code in here later
   }
}