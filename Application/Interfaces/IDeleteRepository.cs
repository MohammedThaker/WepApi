using Domain.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IDeleteRepository< T> where T : class

    {

        public void RemoveById(T entity);
    }
}
