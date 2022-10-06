class Gato:Vertebrado{
    public Gato(string n):base(n){}
        public override void hacerSonido(){
            Console.WriteLine($"{nombre}: MIAU..!");
        }
}