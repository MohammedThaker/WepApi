using Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfacies
{
    public class AddRepository<T> : IAddRepository<T> where T : class
    {
        protected LibraryDBContext dBContext;

        public AddRepository(LibraryDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public T Add(T entity)
        {
            dBContext.Set<T>().Add(entity);
            return entity;
        }


    }
}
