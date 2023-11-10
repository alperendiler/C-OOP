using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        //Method Injection
        public void MakeAApplication(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach  (var loggerService in loggerServices) { loggerService.Log(); }   
        }

        public void GivePreliminaryCreditInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            { credit.Calculate(); }
        }




    }
}
