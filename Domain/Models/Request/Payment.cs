using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
    public  class Payment
    {


        [Key]
        public int PaymentId { get; set; }
        public string PaymentTypy { get; set; }


    }
}
