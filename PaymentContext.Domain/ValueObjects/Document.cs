using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;
            
            AddNotifications(new Contract()
                .Requires()
                .IsTrue(Validate(),"Document.Number", "Documento Inválido")
            );
        }

        public string Number { get; private set; }
        private EDocumentType Type { get; }

        private bool Validate()
        {
            if (Type == EDocumentType.CNPJ && Number.Length == 14)
            {
                //51617211000109
                return true;
            }

            if (Type == EDocumentType.CPF && Number.Length == 11)
            {
                return true;
            }

            return false;
        }
    }
}