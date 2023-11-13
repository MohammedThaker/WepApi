using Application.Interfaces;
using Domain.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfacies
{
    public interface ICustomerRepository : CustomerRepository<Customer>
    {
    }
}
