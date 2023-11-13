using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public class ICustomerService :CustomerServices
    {
        private readonly CustomerServices  CustomerService;
        public ICustomerService(CustomerServices CustomerServices)
        {
            this.CustomerService = CustomerServices;
        }
        List<Domain.Models.Request.Customer> CustomerServices.GetAll()
        {
            return this.CustomerService.GetAll();
        }
       

    }
}
