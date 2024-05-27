using System;
using System.Collections.Generic;
class Animal{
    public required string Name{get;set;}
    public required int Age{get;set;}
    public virtual void SayInfo(){
        Console.WriteLine($"Hi! My name is {Name} and my age is {Age}");
    }
    public virtual void MakeSound(){
        Console.WriteLine("This animal made a sound");
    }
}
class Comunist : Animal{
    public override void MakeSound()
    {
        Console.WriteLine("USSR is the besto country!");
    }
}
class Hamster : Animal{
    
    public override void MakeSound()
    {
        Console.WriteLine("Squeak-squeak");
    }
}
class Perrot : Animal{
    public override void MakeSound()
    {
        Console.WriteLine("Kesha is a good boy!");
    }
}
class Program
{
    static void Main(){

        List<Animal> animals = new List<Animal>{
            new Comunist{Name = "Joseph", Age = 46},
            new Hamster{Name = "Kesha", Age = 2},
            new Perrot{Name = "Nazar", Age = 8}
        };
        
        foreach(var a in animals){
            a.SayInfo();
            a.MakeSound();
            Console.WriteLine("");
        }

        Console.ReadKey();
    }
}