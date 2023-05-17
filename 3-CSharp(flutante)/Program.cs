class Programa
{
    static void Main(string[] args)
    {

        double salario;
        Console.WriteLine("...Qual o seu salário??... \n");
        //toDuble é para quando vai salvar alguma informação que vai ser tirada, assim converte em double.
        salario = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Environment.NewLine + "Seu salário é: " + salario + "\n");
        Console.WriteLine("...Tecle enter para fechar...");
        Console.ReadLine();
    }
}