/*
namespace MeuPrimeiroPrograma
{
    class MeuPrimeiroPrograma
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá mundo");
        }
    }
}
*/
Console.WriteLine("Qual é o seu nome?");
var nome = Console.ReadLine();
var dataHoraAtual = DateTime.Now.Date.ToString("dd/MM/yyyy");
var horaAtual = DateTime.Now.ToString("hh:mm:ss");
Console.WriteLine("Olá, " + nome + "! Hoje é: " + dataHoraAtual + " e são: " + horaAtual);
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey(); /*comando para finalizar o codigo se precionar uma tecla*/














