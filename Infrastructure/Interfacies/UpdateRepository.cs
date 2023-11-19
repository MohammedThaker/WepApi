using Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfacies
{
    public class UpdateRepository<T> : IUpdateRepository<T> where T : class
    {
        protected LibraryDBContext dBContext;

        public UpdateRepository(LibraryDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public void Update(T entity)
        {


             dBContext.Set<T>().Update(entity);

        }
    }
}
