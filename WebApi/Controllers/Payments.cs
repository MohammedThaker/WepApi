using Application.Interfaces;
using Domain.Models;
using Domain.Models.Request;
using Infrastructure.Interfacies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/Customer/Payments")]
    [ApiController]
    public class Payments : ControllerBase
    {

        protected LibraryDBContext dBContext;
        public readonly IGetPayment payRepository;

        public Payments(LibraryDBContext dBContext, IGetPayment payRepository)
        {

            this.dBContext = dBContext;
            this.payRepository = payRepository;
        }


        [HttpGet]
        public IActionResult GetCus()
        {

            var Cust = payRepository.GetAll();
            if (Cust == null)
                return NotFound(" Invalid Costumer Id");
            return Ok(Cust);




        }









    }
}
