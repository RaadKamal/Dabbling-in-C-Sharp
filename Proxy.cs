

namespace Proxy
{
    
    class Example
    {
        
        
        public interface IInformation
        {
            int GetInformation();
        }

        public class SecretInformation : IInformation
        {
            public int GetInformation()
            {
                Random Code = new Random();
                return Code.Next(0,99999);
            }
        }
        public class Proxy
        {
            IInformation secretInfo;

            public int GetSecretInfo( bool hasSecurityClearance= false)
            {
                if (hasSecurityClearance)
                {
                    secretInfo = new SecretInformation();
                    return secretInfo.GetInformation();
                }
                else
                {
                    return -1;
                }
               
            }
        }
        public static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            int info = proxy.GetSecretInfo(true);
            Console.WriteLine($"Secret Information: {info}");
        }

    }

}