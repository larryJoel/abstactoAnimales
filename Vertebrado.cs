abstract class Vertebrado: Animal{
    public Vertebrado(string n):base(n){}
    public override void camianr()
    {
        Console.WriteLine($"{nombre}: Guau...!");
    }
}