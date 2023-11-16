using Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfacies
{
    public class AddCustomer<T> : IAddCustomers<T> where T : class
    {
        protected LibraryDBContext dBContext;

        public AddCustomer(LibraryDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public T Post(int id)
        {
            
            return dBContext.Set<T>().Find(id);
        }
        

    }
}
