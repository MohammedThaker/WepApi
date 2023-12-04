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
    public class PayDelivaryAdd<T> : PaymentByAdd<T>, IPayDelivaryAdd<T> where T : PayDelivery
    {
        public PayDelivaryAdd(LibraryDBContext dBContext) : base(dBContext)
        {
        }
    }
}
