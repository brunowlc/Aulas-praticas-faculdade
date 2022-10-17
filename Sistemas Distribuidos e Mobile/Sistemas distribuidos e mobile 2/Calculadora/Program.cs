// dotnet new console -> comando para iniciar um projeto no terminal

int valor = 0;

Console.WriteLine("Tabuada");

try
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Digite um Numero: ");
    valor = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Os valores para a tabuada de " + valor + " sao: " );

    Console.WriteLine(valor + " x 0 = " + (valor * 0));
    Console.WriteLine(valor + " x 1 = " + (valor * 1));
    Console.WriteLine(valor + " x 2 = " + (valor * 2));
    Console.WriteLine(valor + " x 3 = " + (valor * 3));
    Console.WriteLine(valor + " x 4 = " + (valor * 4));
    Console.WriteLine(valor + " x 5 = " + (valor * 5));
    Console.WriteLine(valor + " x 6 = " + (valor * 6));
    Console.WriteLine(valor + " x 7 = " + (valor * 7));
    Console.WriteLine(valor + " x 8 = " + (valor * 8));
    Console.WriteLine(valor + " x 9 = " + (valor * 9));


}
catch(Exception ex)
{
    throw new Exception(ex.Message);
    //ou
    //Console.WriteLine("Oops! Digite apenas números. " + ex.Message);
}    
finally
{
    Console.WriteLine("Pressione qualquer tecla para sair...");
    Console.ReadKey();
}