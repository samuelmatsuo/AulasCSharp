class Programa
{
    static void Main(string[] args)
    {
        Random ran = new Random();
        int tentativas = 0;
        int palpites = 0;
        int numAleatorio = ran.Next(1,101);

        Console.WriteLine("Adivinhe um número de 1 a 100!");

        while(palpites != numAleatorio)
        {
            Console.WriteLine("Chute um número aleátorio");
            palpites = Convert.ToInt32(Console.ReadLine());
            tentativas++;
            if (palpites > numAleatorio)
            {
                Console.WriteLine("O número é mais baixo!");
            }
            else if (palpites < numAleatorio)
            {
                Console.WriteLine("O número é mais alto!");
            }
        }
        Console.WriteLine("Parabéns você ganhou!! \nO número sorteado é o " + numAleatorio + "\nvocê tentou " + tentativas + " vezes");
    }
}