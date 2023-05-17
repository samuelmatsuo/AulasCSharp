using System;
    class Programa {
    static void Main(string[] args)
    {
        int idade = 0;
        Console.WriteLine("...Qual a sua idade?...");
        idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A sua idade é: " + idade);

        Console.WriteLine("...Tecle enter para fechar...");
        Console.ReadLine();
    }
}