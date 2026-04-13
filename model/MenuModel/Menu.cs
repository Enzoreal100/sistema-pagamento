using System.Diagnostics.Contracts;
using sistema_pagamento.Interfaces;

namespace sistema_pagamento.Model;

public static class Menu
{
    public static void StartMenu()
    {
        Console.WriteLine("========= SISTEMA DE PAGAMENTO ==============");

        decimal amount = GetPaymentAmount();

        Console.WriteLine("Selecione uma forma de pagamento:");
        // Print seleção de formas de pagamento
        
        while (true)
        {
            Console.WriteLine("1 - Cartão \n" +
                            "2 - Boleto \n" +
                            "3 - Sair \n");
            String userInput = Console.ReadLine();
            if(userInput == "1")
            {
                Console.WriteLine("\nMétodo escolhido: Cartão\n");
                string cardNumber = GetCardNumber();
                CardPayment cardPayment = new CardPayment(amount, cardNumber);
                Console.WriteLine(cardPayment.ProcessPayment());
                Console.WriteLine(cardPayment.ReciptEmission());
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Método escolhido: Boleto\n");
                string barCode = GetBilletBarCode();
                BilletPayment billetPayment = new BilletPayment(amount, barCode);
                Console.WriteLine(billetPayment.ProcessPayment());
                Console.WriteLine(billetPayment.ReciptEmission());
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Obrigado por utilizar!");
                break;
            }
            else
            {
                Console.WriteLine("Selecione uma das opções disponíveis");
                continue;
            }
        }
    }

    private static decimal GetPaymentAmount()
    {
        Console.WriteLine("Qual o valor do pagamento? \n");
        string amountInput = Console.ReadLine();
        if (decimal.TryParse(amountInput, out decimal amount) && amount > 0)
        {
            return amount;
        }
        else
        {
            Console.WriteLine("Valor inválido. Tente novamente.");
            return GetPaymentAmount();
        }
    }

    private static string GetCardNumber()
    {
        Console.WriteLine("Digite o número do cartão (apenas números): \n");
        string cardNumber = Console.ReadLine();
        if (!string.IsNullOrEmpty(cardNumber) && cardNumber.All(char.IsDigit))
        {
            return cardNumber;
        }
        else
        {
            Console.WriteLine("Número de cartão inválido. Tente novamente.");
            return GetCardNumber();
        }
    }

    private static string GetBilletBarCode()
    {
        Console.WriteLine("Digite o código de barras do boleto (apenas números): \n");
        string barCode = Console.ReadLine();
        if (!string.IsNullOrEmpty(barCode) && barCode.All(char.IsDigit))
        {
            return barCode;
        }
        else
        {
            Console.WriteLine("Código de barras inválido. Tente novamente.");
            return GetBilletBarCode();
        }
    }
}