Console.Clear();
int reavaliacao;


Console.WriteLine("=== Diabetes gestacional ===");

Console.WriteLine("Digite a sua quantidade de glicose...");

reavaliacao = Convert.ToInt32(Console.ReadLine());


if (reavaliacao < 92)
{
    Console.ForegroundColor = ConsoleColor.Blue;

    Console.Write("Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose");
}

if (reavaliacao < 126 && reavaliacao >= 92)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Compatível com Diabetes Gestacional");
}

if (reavaliacao >= 126)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Diabetes Mellitus na gravidez");
}

Console.ResetColor();
