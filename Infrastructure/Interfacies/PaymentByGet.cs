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
    public class PaymentByGet<T> : IPaymentByGet<T> where T : Payment
    {
        protected LibraryDBContext dBContext;

        public PaymentByGet(LibraryDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
     public   IEnumerable<T> GetAll()
        {
            return dBContext.Set<T>().ToList();
        }
    }
}
   