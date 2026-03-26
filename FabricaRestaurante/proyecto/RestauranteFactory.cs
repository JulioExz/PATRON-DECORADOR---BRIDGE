namespace FabricasRestaurantes
{
    
    public abstract class RestauranteFactory
    {
        public abstract PlatoFuerte CrearPlatoFuerte();
        public abstract Bebida CrearBebida();
        public abstract Postre CrearPostre();
    }

    
    public abstract class PlatoFuerte
    {
        public abstract string Servir();
        public abstract double Costo { get; }
    }

    public abstract class Bebida
    {
        public abstract string Servir();
    }

    public abstract class Postre
    {
        public abstract string Servir();
    }
}