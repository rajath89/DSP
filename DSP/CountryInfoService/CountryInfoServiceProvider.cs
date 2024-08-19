using DSP.CalculatorService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.CountryInfoService
{
    public class CountryInfoServiceProvider : CountryInfoServiceProviderBase
    {
        public override CapitalCityResponse CapitalCity(CapitalCityRequest request)
        {
            CapitalCityResponse result = null;
            CountryInfoServiceSoapType proxy = null;
            try
            {
                proxy = base.CreateProxyInterface<CountryInfoServiceSoapType>();
                result = proxy.CapitalCity(request);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                base.DisposeProxy(proxy);
            }

            return result;
        }

        public override FullCountryInfoResponse FullCountryInfo(FullCountryInfoRequest request)
        {
            FullCountryInfoResponse result = null;

            CountryInfoServiceSoapType proxy = null;
            try
            {
                proxy = base.CreateProxyInterface<CountryInfoServiceSoapType>();
                result = proxy.FullCountryInfo(request);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                base.DisposeProxy(proxy);
            }

            return result;
        }
    }
}
