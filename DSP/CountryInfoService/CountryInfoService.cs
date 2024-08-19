using DSP.CalculatorService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.CountryInfoService
{
    public class CountryInfoService : CountryInfoServiceSoapType
    {

        private CountryInfoServiceProviderBase _serviceProvider;
        public CountryInfoService()
        {
            this._serviceProvider = ServiceProviderManager<CountryInfoServiceProviderBase>.Provider;
            this._serviceProvider.Config = ServiceProviderManager<CountryInfoServiceProviderBase>.ServiceConfig;
        }


        public CapitalCityResponse CapitalCity(CapitalCityRequest request)
        {
            return this._serviceProvider.CapitalCity(request);
        }

        public FullCountryInfoResponse FullCountryInfo(FullCountryInfoRequest request)
        {
            return this._serviceProvider.FullCountryInfo(request);
        }

        public Task<CapitalCityResponse> CapitalCityAsync(CapitalCityRequest request)
        {
            throw new NotImplementedException();
        }

        public CountriesUsingCurrencyResponse CountriesUsingCurrency(CountriesUsingCurrencyRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CountriesUsingCurrencyResponse> CountriesUsingCurrencyAsync(CountriesUsingCurrencyRequest request)
        {
            throw new NotImplementedException();
        }

        public CountryCurrencyResponse CountryCurrency(CountryCurrencyRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CountryCurrencyResponse> CountryCurrencyAsync(CountryCurrencyRequest request)
        {
            throw new NotImplementedException();
        }

        public CountryFlagResponse CountryFlag(CountryFlagRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CountryFlagResponse> CountryFlagAsync(CountryFlagRequest request)
        {
            throw new NotImplementedException();
        }

        public CountryIntPhoneCodeResponse CountryIntPhoneCode(CountryIntPhoneCodeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CountryIntPhoneCodeResponse> CountryIntPhoneCodeAsync(CountryIntPhoneCodeRequest request)
        {
            throw new NotImplementedException();
        }

        public CountryISOCodeResponse CountryISOCode(CountryISOCodeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CountryISOCodeResponse> CountryISOCodeAsync(CountryISOCodeRequest request)
        {
            throw new NotImplementedException();
        }

        public CountryNameResponse CountryName(CountryNameRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CountryNameResponse> CountryNameAsync(CountryNameRequest request)
        {
            throw new NotImplementedException();
        }

        public CurrencyNameResponse CurrencyName(CurrencyNameRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CurrencyNameResponse> CurrencyNameAsync(CurrencyNameRequest request)
        {
            throw new NotImplementedException();
        }

        public FullCountryInfoAllCountriesResponse FullCountryInfoAllCountries(FullCountryInfoAllCountriesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<FullCountryInfoAllCountriesResponse> FullCountryInfoAllCountriesAsync(FullCountryInfoAllCountriesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<FullCountryInfoResponse> FullCountryInfoAsync(FullCountryInfoRequest request)
        {
            throw new NotImplementedException();
        }

        public LanguageISOCodeResponse LanguageISOCode(LanguageISOCodeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<LanguageISOCodeResponse> LanguageISOCodeAsync(LanguageISOCodeRequest request)
        {
            throw new NotImplementedException();
        }

        public LanguageNameResponse LanguageName(LanguageNameRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<LanguageNameResponse> LanguageNameAsync(LanguageNameRequest request)
        {
            throw new NotImplementedException();
        }

        public ListOfContinentsByCodeResponse ListOfContinentsByCode(ListOfContinentsByCodeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ListOfContinentsByCodeResponse> ListOfContinentsByCodeAsync(ListOfContinentsByCodeRequest request)
        {
            throw new NotImplementedException();
        }

        public ListOfContinentsByNameResponse ListOfContinentsByName(ListOfContinentsByNameRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ListOfContinentsByNameResponse> ListOfContinentsByNameAsync(ListOfContinentsByNameRequest request)
        {
            throw new NotImplementedException();
        }

        public ListOfCountryNamesByCodeResponse ListOfCountryNamesByCode(ListOfCountryNamesByCodeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ListOfCountryNamesByCodeResponse> ListOfCountryNamesByCodeAsync(ListOfCountryNamesByCodeRequest request)
        {
            throw new NotImplementedException();
        }

        public ListOfCountryNamesByNameResponse ListOfCountryNamesByName(ListOfCountryNamesByNameRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ListOfCountryNamesByNameResponse> ListOfCountryNamesByNameAsync(ListOfCountryNamesByNameRequest request)
        {
            throw new NotImplementedException();
        }

        public ListOfCountryNamesGroupedByContinentResponse ListOfCountryNamesGroupedByContinent(ListOfCountryNamesGroupedByContinentRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ListOfCountryNamesGroupedByContinentResponse> ListOfCountryNamesGroupedByContinentAsync(ListOfCountryNamesGroupedByContinentRequest request)
        {
            throw new NotImplementedException();
        }

        public ListOfCurrenciesByCodeResponse ListOfCurrenciesByCode(ListOfCurrenciesByCodeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ListOfCurrenciesByCodeResponse> ListOfCurrenciesByCodeAsync(ListOfCurrenciesByCodeRequest request)
        {
            throw new NotImplementedException();
        }

        public ListOfCurrenciesByNameResponse ListOfCurrenciesByName(ListOfCurrenciesByNameRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ListOfCurrenciesByNameResponse> ListOfCurrenciesByNameAsync(ListOfCurrenciesByNameRequest request)
        {
            throw new NotImplementedException();
        }

        public ListOfLanguagesByCodeResponse ListOfLanguagesByCode(ListOfLanguagesByCodeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ListOfLanguagesByCodeResponse> ListOfLanguagesByCodeAsync(ListOfLanguagesByCodeRequest request)
        {
            throw new NotImplementedException();
        }

        public ListOfLanguagesByNameResponse ListOfLanguagesByName(ListOfLanguagesByNameRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ListOfLanguagesByNameResponse> ListOfLanguagesByNameAsync(ListOfLanguagesByNameRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
