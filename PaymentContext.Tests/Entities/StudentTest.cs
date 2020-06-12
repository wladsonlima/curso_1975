using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Entities
{
    public class StudentTest
    {
        public void AdicionarAssinatura()
        {
            var name = new Name("Teste", "Teste");

            foreach (var notification in name.Notifications)
            {
                //otification.Message;
            }
        }
    }
}