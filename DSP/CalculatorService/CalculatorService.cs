using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.CalculatorService
{
    public class CalculatorService : CalculatorSoap
    {
        private CalculatorServiceProviderBase _serviceProvider;

        public CalculatorService()
        {
            this._serviceProvider = ServiceProviderManager<CalculatorServiceProviderBase>.Provider;
            this._serviceProvider.Config = ServiceProviderManager<CalculatorServiceProviderBase>.ServiceConfig;
        }

        public int Add(int intA, int intB)
        {
            return this._serviceProvider.AddBalance(intA, intB);
        }

        public Task<int> AddAsync(int intA, int intB)
        {
            throw new NotImplementedException();
        }

        public int Divide(int intA, int intB)
        {
            throw new NotImplementedException();
        }

        public Task<int> DivideAsync(int intA, int intB)
        {
            throw new NotImplementedException();
        }

        public int Multiply(int intA, int intB)
        {
            throw new NotImplementedException();
        }

        public Task<int> MultiplyAsync(int intA, int intB)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int intA, int intB)
        {
            throw new NotImplementedException();
        }

        public Task<int> SubtractAsync(int intA, int intB)
        {
            throw new NotImplementedException();
        }
    }
}
