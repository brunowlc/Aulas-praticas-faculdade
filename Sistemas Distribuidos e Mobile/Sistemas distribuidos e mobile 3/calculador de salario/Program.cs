// objetivo, calcular um salario reajustavel.

double salario, novoSalario = 0;

Console.WriteLine("Reajuste Salarial");

for(int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite um salario: ");
    salario = Convert.ToDouble(Console.ReadLine());

    if(salario <= 1215)
    {
        novoSalario = salario * 1.50;
    }
    else
    {
        novoSalario = salario + ((salario * 30)/100);
    }
    Console.WriteLine("O valor do salario com reajuste é de: " + novoSalario); 
       
}

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();
