using System;
using System.Diagnostics;


namespace  AbstractFactory
{
    //THE ABSTRACT FACTORY
    interface IMobile  //Abstract Factory interface
    {
        IAndroid GetAndroidPhone();
        IiOS GetIOSPhone();

    }
    
    //THE CONCRETE FACTORY
    class Samsung : IMobile //Implementing the IMobile interface
        {
            public IAndroid GetAndroidPhone()
            {
                return new SamsungGalaxy(); //Interface of a type of product object
            }

            public IiOS GetIOSPhone()
            {
                return new SamsungGuru(); //Interface of a type of product object
            }
        }

        

    //THE ABSTRACT PRODUCTS    

    interface IAndroid //Abstract Product interface
    {
        string GetModelDetails(); 
    }

    interface IiOS //Abstract Product interface
    {
        string GetModelDetails();
    }


    //THE CONCRETE PRODUCTS
    class SamsungGalaxy : IAndroid
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Galaxy - RAM: 2GB - Camera: 13MO"; //Implementin IAndroid interface
        }
    }

    class SamsungGuru: IiOS
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Guru - RAM: 1GB - Camera: 5MP"; //Implementing IiOS interface
        }
    }

    class MobileClient
    {
        IAndroid androidPhone;
        IiOS iosPhone;

        public MobileClient(IMobile mobileFactory)
        {
            androidPhone = mobileFactory.GetAndroidPhone(); //Creating Android phone using the factory
            iosPhone = mobileFactory.GetIOSPhone(); //Creating iOS phone using the factory
        }

        public string GetAndroidPhoneDetails()
        {
            return androidPhone.GetModelDetails(); //Getting details of the Android phone
        }

        public string GetIOSPhoneDetails()
        {
            return iosPhone.GetModelDetails(); //Getting details of the iOS phone
        }


    }

    class Example
    {
        public static void Main(string[] args)
        {
            IMobile samsungMobilephone = new Samsung(); //Creating a factory for Samsung phones
            MobileClient samsungclient = new MobileClient(samsungMobilephone); //Creating a client and passing the factory to it

            Console.WriteLine(samsungclient.GetAndroidPhoneDetails()); //Getting details of the Android phone
            Console.WriteLine(samsungclient.GetIOSPhoneDetails()); //Getting details of the iOS phone
        }
    }

}

