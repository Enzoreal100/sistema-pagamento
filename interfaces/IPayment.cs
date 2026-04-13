namespace sistema_pagamento.Interfaces;

public interface IPayment
{
    string ProcessPayment();
    string ReciptEmission();
}