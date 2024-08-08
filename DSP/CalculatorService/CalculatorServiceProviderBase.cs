using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.CalculatorService
{
    public abstract class CalculatorServiceProviderBase : ServiceProviderBase
    {
        public CalculatorSoap Proxy;
        public abstract int AddBalance(int balance1, int balance2);
    }
}
