using System.Collections.Generic;
using System.Linq;

namespace MyServiceSecurity
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MyServiceWithCredential" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MyServiceWithCredential.svc or MyServiceWithCredential.svc.cs at the Solution Explorer and start debugging.
    public class MyServiceWithCredential : IMyServiceWithCredential
    {
        public List<CountryBE> GetListCountries(string filter)
        {
            List<CountryBE> countries = new List<CountryBE>();
            countries = Data.GetListCountry();

            if (!string.IsNullOrWhiteSpace(filter))            
                countries = countries.Where(cou => cou.Description.Contains(filter)).ToList();

            return countries;
       
        }
    }    


}
