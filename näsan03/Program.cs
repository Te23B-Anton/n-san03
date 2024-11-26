using System.Globalization;


string[] namn = ["Sigma boy", "fortnite", "Wow man", "Anton"];

System.Console.WriteLine(GetChoice(namn));






static void Hello32()
{
    for (int i = 0; i < 32; i++)
    {
        Console.WriteLine($"hello , world {i + 1}");
    }
}

static float Kvadrat(int num)
{
    return MathF.Pow(num, 2);
}

static void sigma(int num)
{
    Console.WriteLine(MathF.Pow(num, 2));

}

static float multi(int num)
{
    return 2 * num;
}


string GetChoice(string[] nice)
{
    for (int i = 0; i < nice.Length; i++)
    {
        System.Console.WriteLine($"{i + 1}. {nice[i]}");
    
    }
    int num ;
    while (!int.TryParse(Console.ReadLine(), out num) || num <  1 || num > nice.Length)
    {
        System.Console.WriteLine("Skriv ett giltigt nummer!");
    }
    return nice[num - 1];
}

Console.ReadLine();