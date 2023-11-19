using Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfacies
{
    public class CasPayment :   IPaymentBy
    {
       

        public override void ProcessPayment(string name) {

             
            Console.WriteLine(name);
        
        
        }

    }
    }

