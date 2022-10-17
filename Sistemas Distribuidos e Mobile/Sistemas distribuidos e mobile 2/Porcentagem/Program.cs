// See https://aka.ms/new-console-template for more information

string nomeProduto = string.Empty;
float valor, porcentagem;


Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("### calcularador de porcentagem ###");

 try
 {
    Console.WriteLine("Digite o nome do produto: ");
    nomeProduto = Console.ReadLine();
    
    Console.WriteLine("Digie o valor do produto: ");
    valor = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite a porcentagem: ");
    porcentagem = float.Parse(Console.ReadLine());
    Console.WriteLine("\n");
   
    Console.WriteLine("Produto: " + nomeProduto);
    Console.WriteLine("Valor R$ = " + valor);
    Console.WriteLine("Desconto R$ = " + ((valor*porcentagem)/100));
    Console.WriteLine("Total a pagar R$ = " + (valor-(valor*porcentagem)/100));
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

