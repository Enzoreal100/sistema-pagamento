using sistema_pagamento.Interfaces;

namespace sistema_pagamento.Model;

public static class Menu
{
    public static void StartMenu()
    {
        Console.WriteLine("========= SISTEMA DE PAGAMENTO ==============");
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
                CardPayment cardPayment = new CardPayment(100.00m, "1234-5678-9012-3456");
                Console.WriteLine(cardPayment.ProcessPayment());
                Console.WriteLine(cardPayment.ReciptEmission());
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Método escolhido: Boleto\n");
                // chama metodo pagamento boleto
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
}