using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
string input = Console.ReadLine();
string[] line = input.Split("; ");
double a = double.Parse(line[0]);
double b = double.Parse(line[1]);
double c = double.Parse(line[2]);
string typ = "";


if ((check(a, b, c)) == 0)
{
    Console.WriteLine("Błędne dane. Długości boków muszą być dodatnie!");
}
else if ((check(a, b, c)) == 1)
{
    Console.WriteLine("Błędne dane. Trójkąta nie można zbudować!");
}
else if ((check(a, b, c)) == 2)
{
    //obwód
    double obw = a + b + c;
    string obws = obw.ToString("0.00#");
    Console.WriteLine($"obwód = {obws}");
    //pole
    double s = (a + b + c) / 2;
    double p = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    p = Math.Round(p, 2);
    string pol = p.ToString("0.00#");
    Console.WriteLine($"pole = {pol}");
    //typ
    if (check1(a, b, c) == 0)
    {
        typ = "prostokątny";
    }
    else if (check1(a, b, c) == 1)
    {
        typ = "ostrokątny";
    }
    else if (check1(a, b, c) == 2)
    {
        typ = "rozwartokątny";
    }
    else
    {
        typ = "błędem w matrixie";
    }
    Console.WriteLine($"trójkąt jest {typ}");
    //równoramienny/równoboczny?
    if (a.Equals(b) && b.Equals(c) && c.Equals(a))
    {
        Console.WriteLine("trójkąt równoboczny");
    }
    else if (a.Equals(b) || b.Equals(c) || c.Equals(a))
    {
        Console.WriteLine("trójkąt równoramienny");
    }
}

static int check(double a, double b, double c)
{
    if(a <= 0 || b <= 0 || c <= 0)
    {
        return 0; //false
    }
    else if (a + b < c || a + c <= b || b + c <= a)
    {
        return 1; //false
    }
    else
    {
        return 2; //true
    }
}

static int check1(double a, double b, double c)
{
    if ((Math.Pow(a,2) == Math.Pow(b,2) + Math.Pow(c,2)) || (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2)) || (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2)))
    {
        return 0;
        //prostokątny
    }
    else if ((Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2)) || (Math.Pow(b, 2) > Math.Pow(a, 2) + Math.Pow(c, 2)) || (Math.Pow(c, 2) > Math.Pow(a, 2) + Math.Pow(b, 2)))
    {
        return 2;
        //rozwartokątny
    }
    else if ((Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2)) || (Math.Pow(b, 2) < Math.Pow(a, 2) + Math.Pow(c, 2)) || (Math.Pow(c, 2) < Math.Pow(a, 2) + Math.Pow(b, 2)))
    {
        return 1;
        //ostrokątny
    }
    else
    {
         return 3;
        //błąd w matrixie
    }
}