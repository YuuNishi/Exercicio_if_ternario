Console.WriteLine("Digite uma nota");
float nota = float.Parse(Console.ReadLine());

if(nota >=8)
{
    Console.WriteLine("Aprovado");
}else if(nota>=5 && nota < 8)
{
    Console.WriteLine("Recuperacao");
}
else
{
    Console.WriteLine("Reprovado");
}
//////////////ternario
String situacao =nota >= 8 ? "Aprovado" : "Reprovado";
Console.WriteLine(situacao);