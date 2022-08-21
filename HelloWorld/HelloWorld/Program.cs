// See https://aka.ms/new-console-template for more information
short shortMin = short.MinValue;
short shortMax = short.MaxValue;

int intMin = int.MinValue;
int intMax = int.MaxValue;

long longMin = long.MinValue;
long longMax = long.MaxValue;

decimal decMin = decimal.MinValue;
decimal decMax = decimal.MaxValue;

double doubMin = double.MinValue;
double doubMax = double.MaxValue;

Console.WriteLine($"short min - max: {shortMin} - {shortMax}");
Console.WriteLine($"int min - max: {intMin} - {intMax}");
Console.WriteLine($"long min - max: {longMin} - {longMax}");
Console.WriteLine($"decimal min - max: {decMin} - {decMax}");
Console.WriteLine($"double min - max: {doubMin} - {doubMax}");

double d = short.MaxValue;
double sqr = Math.Pow(d,2.0);
Console.WriteLine(sqr);