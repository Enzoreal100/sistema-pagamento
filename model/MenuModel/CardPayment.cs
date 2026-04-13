using sistema_pagamento.Model;

namespace sistema_pagamento.Interfaces;

public class CardPayment : BasePayment
{
    public string CardNumber { get; set; }

    public CardPayment(decimal amount, string cardNumber) : base(amount)
    {
        CardNumber = cardNumber;
    }

    public override string ProcessPayment()
    {
        // Lógica de processamento do pagamento com cartão
        return $"Pagamento de {Amount} processado com cartão {CardNumber}";
    }
}