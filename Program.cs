using Classe_Carro;
using System.Runtime.CompilerServices;

Carro carro = new Carro("z3","bmw",2020,"sedan","azul",2000,201325,2,true,true);

if (carro.EmitirSonidoBocina())
{
    Console.WriteLine("La bocina esta sonando");
}
else
{
    Console.WriteLine("La bocina no esta sonando");
}

if (carro.TieneEjes(4))
{
    Console.WriteLine("tiene 4 ejes");
}
else
{
    Console.WriteLine("no tiene 4 ejes");
}

if (carro.EstaAndando())
{
    Console.WriteLine("El auto esta en marcha");
}
else
{
    Console.WriteLine("El auto esta parado");
}