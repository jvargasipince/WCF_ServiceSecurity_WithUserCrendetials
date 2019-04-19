using System.Collections.Generic;

namespace MyServiceSecurity
{
    public static class Data
    {

        public static List<CountryBE> GetListCountry()
        {

            return new List<CountryBE>()
            {
                new CountryBE(){ IdCountry = 1, ISOCode = "PE", Description="Peru"},
                new CountryBE(){ IdCountry = 2, ISOCode = "CO", Description="Colombia"},
                new CountryBE(){ IdCountry = 3, ISOCode = "AR", Description="Argentina"},
                new CountryBE(){ IdCountry = 4, ISOCode = "BR", Description="Brasil"}
            };

        }

    }

    public class CountryBE
    {
        public int IdCountry { get; set; }
        public string ISOCode { get; set; }
        public string Description { get; set; }
    }



}