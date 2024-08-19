using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.CountryInfoService
{
    public abstract class CountryInfoServiceProviderBase : ServiceProviderBase
    {
        public CountryInfoServiceSoapType Proxy;

        public abstract CapitalCityResponse CapitalCity(CapitalCityRequest request);

        public abstract FullCountryInfoResponse FullCountryInfo(FullCountryInfoRequest request);
    }
}
