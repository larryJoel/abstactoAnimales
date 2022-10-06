abstract class Animal{
    protected string nombre;
    public Animal(string n)=>nombre=n;
    public abstract void hacerSonido();
    public abstract void camianr();
    public void comer()=> Console.WriteLine($"{nombre}: comiendo...");
}