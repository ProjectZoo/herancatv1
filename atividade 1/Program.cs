namespace atividade_1;

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        Homem homem = new Homem();
        Cao cao = new Cao();
        Gato gato = new Gato();
        
        Console.WriteLine(animal.Fala());  
        Console.WriteLine(homem.Fala());
        Console.WriteLine(cao.Fala()); 
        Console.WriteLine(gato.Fala()); 
    }
}
