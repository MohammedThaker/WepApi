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
    public class PaymentRepos : IGetPayment
    {
        protected LibraryDBContext dBContext;
        public PaymentRepos(LibraryDBContext dBContext)
        {
            this.dBContext = dBContext;

        }

        public override IEnumerable<Payment> GetAll()
        {
            return dBContext.Set<Payment>().ToList();
        }
    }
}
