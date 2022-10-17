// objetivo, ler a matricula do alino

string curso = "CCO";
long matricula = long.Parse(DateTime.Now.Date.Year + DateTime.Now.ToString("ddMMyyyyHHmmss"));
string periodo = "1";
int quantidadeAlunos = 0;
int idade = 0;

Console.Write("O numero da matricula gerado é: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(matricula);

Console.ForegroundColor = ConsoleColor.White;
Console.Write(" para o curso de ");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(curso);

Console.ForegroundColor = ConsoleColor.White;
Console.Write(" para o periodo letivo ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(periodo);

Console.ForegroundColor = ConsoleColor.White;

int i = 0;
while(i <10)
{
    i = i + 1;
    Console.WriteLine("Digite a idade do aluno: ");
    idade = Convert.ToInt32(Console.ReadLine());

    if(idade >= 18)
    {
        quantidadeAlunos = quantidadeAlunos + 1;
    }
}
Console.WriteLine("Existem (" + quantidadeAlunos + ") alunos com idade maior que 18 anos.");


Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();