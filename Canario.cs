class Canario:Vertebrado{
    public Canario(string n):base(n){}
    public override void hacerSonido()
    {
        Console.WriteLine($"{nombre}: PIO-PIO..!");
    }
}