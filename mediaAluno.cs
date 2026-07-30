Console.WriteLine("Média de notas dos alunos!");
Console.WriteLine();
Console.Write("Digite a primeira nota: ");
double nota1 = double.Parse(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
double nota2 = double.Parse(Console.ReadLine());

Console.Write("Digite a terceira nota: ");
double nota3 = double.Parse(Console.ReadLine());

Console.Write("Digite a quarta nota: ");
double nota4 = double.Parse(Console.ReadLine());

double media = CalcularMedia(nota1,nota2,nota3,nota4);


static double CalcularMedia(double nota1, double nota2, double nota3, double nota4)
{
    return (nota1 + nota2 + nota3 + nota4) / 4;
}

if (media < 5.0)
{
    Console.WriteLine("Infelizmente o aluno foi reprovado.");
}
else
{
    Console.WriteLine("Parabéns o aluno foi aprovado.");
}

Console.WriteLine($"A média deste aluno é: {media}");
