﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAddRepository<T> where T : class
    { 
       public T Add(T entity);

    }
}
