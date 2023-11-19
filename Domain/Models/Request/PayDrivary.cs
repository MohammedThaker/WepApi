
using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Request
{
    public class PayDrivary:Payment
    {


        public int DPaymentId { get; set; }
        public string DPaymentTypy { get; set; }

    }
}
