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
            String userInput = "";
            Console.WriteLine("1 - Cartão \n" +
                            "2 - Boleto \n" +
                            "3 - Sair \n");
            userInput = Console.ReadLine();
            if(userInput == "1")
            {
                Console.WriteLine("\nMétodo escolhido: Cartão\n");
                // chama metodo pagamento cartao
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Método escolhido: Cartão");
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