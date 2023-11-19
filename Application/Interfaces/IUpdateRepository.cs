using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUpdateRepository <T> where T : class
    {
        public void Update(T entity);
    }
}
