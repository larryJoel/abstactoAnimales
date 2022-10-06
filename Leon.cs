class Leon: Vertebrado{
    public Leon(string n):base(n){}
    public override void hacerSonido()
    {
        Console.WriteLine($"{nombre}: GRRRRRR...!");
    }
}