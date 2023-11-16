using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAddCustomers<T> where T : class
    { 
        public T Post(int entity);

    }
}
