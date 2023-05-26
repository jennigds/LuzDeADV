Console.WriteLine("Simulador de Luz de Advertência\n");

Console.WriteLine("Digite A para \"ATIVADO\" e D para \"DESATIVADO\"\n");

Console.Write("Sensor de temperatura: ");

string temperatura = Console.ReadLine()!.Trim().Substring(0,1).ToUpper();

Console.Write("Sensor de pressão: ");
string pressao = Console.ReadLine()!.Trim().Substring(0,1).ToUpper();

Console.Write("Sensor de rotação: ");
string rotacao = Console.ReadLine()!.Trim().Substring(0,1).ToUpper();

bool sensorT, sensorP, sensorR, LuzADVW;

if (temperatura != "A" && temperatura != "D")
{

Console.WriteLine("Escreva apenas \"A\" ou \"D\"");
return;

}
sensorT = temperatura == "A";

if (pressao != "A" && pressao != "D")
{

Console.WriteLine("Escreva apenas \"A\" ou \"D\"");
return;

}
sensorP = pressao == "A";

if (rotacao != "A" && rotacao != "D")
{

Console.WriteLine("Escreva apenas \"A\" ou \"D\"");
return;

}
sensorR = rotacao == "A";

LuzADVW = sensorT && (sensorP || !sensorR);

Console.WriteLine($"\nA luz de advertência estará {(LuzADVW ? "ATIVADA" : "DESATIVADA")}.");