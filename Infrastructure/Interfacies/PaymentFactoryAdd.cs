using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfacies
{
    public class PaymentFactoryAdd
    {

        public readonly IAddUnitOfWork unitOftWork;
        public PaymentFactoryAdd(IAddUnitOfWork unitOftWork)
        {
            this.unitOftWork = unitOftWork;

        }

        public void GetPaymentBay(string pay)
        {
            
        }








    }
}
