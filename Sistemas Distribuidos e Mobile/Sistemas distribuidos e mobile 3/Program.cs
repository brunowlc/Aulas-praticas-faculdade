// criar um algorito para verificação de numeros impares ou pares.

int numeoroUm = 0;
int numeroDois = 0;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("### informa se o nomero é par ou impar");
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Digite um numero");

numeoroUm = Convert.ToInt32(Console.ReadLine());
numeroDois = numeoroUm % 2;

if (numeroDois == 1)
{
    Console.WriteLine("O numero digitado é Impar!");
}
else
{
    Console.WriteLine("O numero digitado é par!");
}
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();