using Domain.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IBaseUnitOftWork : IDisposable
    {
         IGetRepositoryById<Customer> Customers { get; }
         IGetRepositoryById<Payment> GetPayments { get; }
        IAddRepository<Customer> AddCustomer { get; }
        IAddRepository<Payment> AddPayment { get; }
        IAddRepository<Order> AddOrder { get; }
        int Complete();
    }
}
