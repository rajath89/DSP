using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP.CalculatorService
{
    public class CalculatorServiceProvider : CalculatorServiceProviderBase
    {
        public override int AddBalance(int balance1, int balance2)
        {
            int result = 0;
            CalculatorSoap proxy = null;
            try
            {
                proxy = base.CreateProxyInterface<CalculatorSoap>();
                result = proxy.Add(balance1, balance2);
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
