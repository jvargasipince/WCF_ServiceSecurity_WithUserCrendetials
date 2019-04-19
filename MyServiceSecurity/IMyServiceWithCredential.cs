using System.Collections.Generic;
using System.ServiceModel;

namespace MyServiceSecurity
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMyServiceWithCredential" in both code and config file together.
    [ServiceContract]
    public interface IMyServiceWithCredential
    {
        [OperationContract]
        List<CountryBE> GetListCountries(string filter);

    }
}
