using Application.Interfaces;
using Domain.Models;
using Domain.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfacies
{
    public class PaymentBy : IPaymentBy
    {
        protected LibraryDBContext dBContext;

        public PaymentBy(LibraryDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public IEnumerable<Payment> GetAll()
        {
            return dBContext.Set<Payment>().ToList();
        }

       
    }
}
   