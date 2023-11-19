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
    public class GetRepository<T> : IGetRepositoryById<T> where T : class
    {
        protected LibraryDBContext dBContext;

        public GetRepository(LibraryDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public IEnumerable<T> GetAll()
        {
            return dBContext.Set<T>().ToList();
        }
        
        public  T GetByIdi(int id)
        {
            return dBContext.Set<T>().Find(id);
        }
       


    }
}
