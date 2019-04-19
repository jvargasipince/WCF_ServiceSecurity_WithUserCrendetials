using System;

namespace TestSecurityWCF
{
   public  class Program
    {
        static void Main(string[] args)
        {

            using (var client = new SecurityService.MyServiceWithCredentialClient())
            {

                /*Add Credentials*/
                //client.ClientCredentials.UserName.UserName = "jvargas";
                //client.ClientCredentials.UserName.Password = "mypassword";

                var countries = client.GetListCountries(null);

                foreach (var country in countries)
                {
                    string message = string.Format("Id country {0} with Iso Code {1} and Description {2}",
                                                    country.IdCountry,
                                                    country.ISOCode,
                                                    country.Description);
                    Console.WriteLine(message);
                }

                Console.ReadLine();
            }
                 



        }
    }
}
