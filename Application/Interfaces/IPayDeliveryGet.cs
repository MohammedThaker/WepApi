﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Request;
namespace Application.Interfaces
{ 
    public interface IPaydeliveryGet<T>: IPaymentByGet<T> where T : PayDelivery
    {

    }
}
