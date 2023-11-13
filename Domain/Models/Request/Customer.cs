using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Request
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Phone]
        public string? Phone { get; set; }
        [Required]
        public string? Adress { get; set; }
        [Required]
        public DateTime Created { get; set; }

    }
    
}
