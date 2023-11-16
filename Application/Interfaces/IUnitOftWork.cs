using Domain.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUnitOftWork : IDisposable
    {
         ICustomerRepository<Customer> Customers { get; }
         ICustomerRepository<Payment> Payments { get; } 
         int Complete();
    }
}
