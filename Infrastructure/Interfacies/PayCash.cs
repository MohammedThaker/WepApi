using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Models;
using Domain.Models.Request;

namespace Infrastructure.Interfacies
{
    public class PayCash : PaymentBy, IPayCash
    {
        public PayCash(LibraryDBContext dBContext) : base(dBContext)
        {
        }

       
    }
}
