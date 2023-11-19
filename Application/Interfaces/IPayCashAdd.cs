using Domain.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPayCashAdd<T> : IPaymentByAdd<T> where T : PaymentCash
    {
    }
}
