// See https://aka.ms/new-console-template for more information

float num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0;

 try
 {
    Console.WriteLine("->>> CALCULANDO A MÉDIA DOS VALORES <<<-");
    Console.WriteLine("Digite cinco valores e precione enter.");

    num1 = float.Parse(Console.ReadLine());
    num2 = float.Parse(Console.ReadLine());
    num3 = float.Parse(Console.ReadLine());
    num4 = float.Parse(Console.ReadLine());
    num5 = float.Parse(Console.ReadLine());

    Console.WriteLine("A média dos cinco numeros é: " + ((num1 + num2 + num3 + num4 + num5) /5));
 }
catch (Exception ex)
{
    Console.WriteLine("Ooops! Digite apenas numeros" + ex.Message);
}
finally
{
    Console.WriteLine("pressione qualquer tecla para sair...");
    Console.ReadKey();
}

