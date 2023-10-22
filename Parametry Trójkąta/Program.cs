string input = Console.ReadLine();
string[] line = input.Split("; ");
int a = int.Parse(line[0]);
int b = int.Parse(line[1]);
int c = int.Parse(line[2]);


if(a < 0 || b <0 || c < 0)
{
    Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
}
else
{
    Console.WriteLine(line[0]);
    Console.WriteLine(line[1]);
    Console.WriteLine(line[2]);
}