using sistema_pagamento.Interfaces;

namespace sistema_pagamento.Model;

public abstract class BasePayment : IPayment
{
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    
    public BasePayment(decimal amount)
    {
        Amount = amount;
        Date = DateTime.Now;
    }

    public abstract string ProcessPayment();
    public string ReciptEmission()
    {
        return $"Recibo: \nValor: {Amount} \nData: {Date:dd/MM/yyyy}";
    }
}