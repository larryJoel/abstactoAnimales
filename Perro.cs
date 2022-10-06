class Perro: Vertebrado{
    public Perro(string n):base(n){}
    public override void hacerSonido()
    {
        Console.WriteLine($"{nombre}: GUAU...!");
    }
    public override void camianr()
    {
        Console.WriteLine($"{nombre}: caminando.....");
    }
}