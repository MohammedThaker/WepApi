using Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfacies
{
    public class GetAllRepository<T>: IGetRepository<T> where T : class
    {
        protected LibraryDBContext dBContext;

        public GetAllRepository(LibraryDBContext dBContext)
        {
            this.dBContext = dBContext;
        }



       public IEnumerable<T> GetAll()
        {
            return dBContext.Set<T>().ToList();
        }
    }
}
