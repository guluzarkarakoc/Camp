using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class RecourseManager
    {
        public void ToRecourse(ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Compute();
            loggerService.Log();
        }

        public void PreInformation(List<ICreditManager> credits)
        {
            throw new NotImplementedException();
        }

        public void ToRecourse(ICreditManager personalFinanceCredit)
        {
            throw new NotImplementedException();
        }
    }

    public void PreInformation(List<ICreditManager> credits)
    {
        foreach (var credit in credits)
        {
            credit.Compute();
        }
    }

}
