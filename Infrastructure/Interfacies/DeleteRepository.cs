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
    public class DeleteRepository<T> : IDeleteRepository<T> where T : class
    {
        protected LibraryDBContext dBContext;

        public DeleteRepository(LibraryDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public void RemoveById(T entity)
        {
            dBContext.Set<T>().Remove(entity);
        }

      
    }
}
