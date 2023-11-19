using Application.Interfaces;

namespace Infrastructure.Interfacies
{
    public class CashOnDeliveryPayment:IPaymentBy
    {
       


        

        public override void ProcessPayment(string name)
        {
            Console.WriteLine(name);
        }
    }
}
