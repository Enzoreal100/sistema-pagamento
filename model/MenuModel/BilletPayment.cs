namespace sistema_pagamento.Model;

public class BilletPayment : BasePayment
{
    public string BarCode { get; set; }

    public BilletPayment(decimal amount, string barCode) : base(amount)
    {
        BarCode = barCode;
    }

    public override string ProcessPayment()
    {
        // Lógica de processamento do pagamento com boleto
        return $"Pagamento de {Amount} processado com boleto {BarCode}";
    }
}