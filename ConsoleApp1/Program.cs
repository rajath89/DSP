using DSP.CalculatorService;
using DSP.CountryInfoService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var calculatorService = new CalculatorService();

            //int res = calculatorService.Add(1, 2);
            //int res2 = calculatorService.Add(3, res);

            //Console.WriteLine(res);
            //Console.WriteLine(res2);

            var countryService = new CountryInfoService();
            var resp = countryService.CapitalCity(new CapitalCityRequest { Body = new CapitalCityRequestBody { sCountryISOCode = "IN"} });

            Console.WriteLine(resp.Body.CapitalCityResult);

            var resp2 = countryService.FullCountryInfo(new FullCountryInfoRequest { Body = new FullCountryInfoRequestBody { sCountryISOCode = "IN" } });

            Console.WriteLine(JsonConvert.SerializeObject(resp2,Formatting
                .Indented));

            /*
            New Delhi
            {
              "Body": {
                "FullCountryInfoResult": {
                  "sISOCode": "IN",
                  "sName": "India",
                  "sCapitalCity": "New Delhi",
                  "sPhoneCode": "91",
                  "sContinentCode": "AS",
                  "sCurrencyISOCode": "INR",
                  "sCountryFlag": "http://www.oorsprong.org/WebSamples.CountryInfo/Flags/India.jpg",
                  "Languages": [
                    {
                      "sISOCode": "hin",
                      "sName": "Hindi"
                    }
                  ]
                }
              }
            }
            */
        }
    }
}
