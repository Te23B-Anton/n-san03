static void Hello32()
{
    for (int i = 0; i < 32; i++)
    {
        Console.WriteLine($"hello , world {i + 1}");
    }
}

static float Kvadrat(int num){
    return MathF.Pow(num, 2);
}

static void sigma(int num){
   Console.WriteLine(MathF.Pow(num , 2));

}

static float multi(int num){
    return 2*num;
}


System.Console.WriteLine(multi((int)Kvadrat(4)));

Console.ReadLine();