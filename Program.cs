string temperatura, rotacao, pressao;
Console.WriteLine("--- Luz De Advertencia ---\n");

Console.Write("Sensor de temperatura: ");
temperatura = Console.ReadLine()!;

Console.Write("Sensor de pressao: ");
pressao = Console.ReadLine()!;

Console.Write("Sensor de rotação: ");
rotacao = Console.ReadLine()!;

if (pressao == "A" && temperatura == "A" && rotacao == "D") 
{

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("A luz de advertencia esta ativada");

}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Luz de advertencia desativada");
}
Console.ResetColor();