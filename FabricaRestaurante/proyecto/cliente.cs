using FabricasRestaurantes;
using System;

namespace FabricasRestaurantes
{
    internal class FabricaRestaurantes
    {
        public static void ProbarConsola()
        {
            RestauranteFactory fabrica;


            fabrica = new RestauranteChino();
            PlatoFuerte plato = fabrica.CrearPlatoFuerte();
            Bebida bebida = fabrica.CrearBebida();
            Postre postre = fabrica.CrearPostre();
            Console.WriteLine($"Plato:  {plato.Servir()}");
            Console.WriteLine($"Bebida: {bebida.Servir()}");
            Console.WriteLine($"Postre: {postre.Servir()}");
            Console.WriteLine();


            fabrica = new RestauranteJapones();
            plato = fabrica.CrearPlatoFuerte();
            bebida = fabrica.CrearBebida();
            postre = fabrica.CrearPostre();
            Console.WriteLine($"Plato:  {plato.Servir()}");
            Console.WriteLine($"Bebida: {bebida.Servir()}");
            Console.WriteLine($"Postre: {postre.Servir()}");
            Console.WriteLine();


            fabrica = new RestauranteMexicano();
            plato = fabrica.CrearPlatoFuerte();
            bebida = fabrica.CrearBebida();
            postre = fabrica.CrearPostre();
            Console.WriteLine($"Plato:  {plato.Servir()}");
            Console.WriteLine($"Bebida: {bebida.Servir()}");
            Console.WriteLine($"Postre: {postre.Servir()}");
            Console.WriteLine();

            fabrica = new RestauranteItaliano();
            plato = fabrica.CrearPlatoFuerte();
            bebida = fabrica.CrearBebida();
            postre = fabrica.CrearPostre();
            Console.WriteLine($"Plato:  {plato.Servir()}");
            Console.WriteLine($"Bebida: {bebida.Servir()}");
            Console.WriteLine($"Postre: {postre.Servir()}");
            Console.WriteLine();


            fabrica = new RestauranteFrances();
            plato = fabrica.CrearPlatoFuerte();
            bebida = fabrica.CrearBebida();
            postre = fabrica.CrearPostre();
            Console.WriteLine($"Plato:  {plato.Servir()}");
            Console.WriteLine($"Bebida: {bebida.Servir()}");
            Console.WriteLine($"Postre: {postre.Servir()}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}