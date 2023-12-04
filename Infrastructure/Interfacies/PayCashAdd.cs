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
    public class PayCashAdd<T> : PaymentByAdd<T>, IPayCashAdd<T> where T : PaymentCash
    {
        public PayCashAdd(LibraryDBContext dBContext) : base(dBContext)
        {
        }

        public void Add(PayDelivery payCash)
        {
            throw new NotImplementedException();
        }
    }
}
