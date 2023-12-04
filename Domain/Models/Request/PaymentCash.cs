using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Request
{
    public class PaymentCash:Payment
    {


        public string? Pcash{ get; set; }

    }
}
