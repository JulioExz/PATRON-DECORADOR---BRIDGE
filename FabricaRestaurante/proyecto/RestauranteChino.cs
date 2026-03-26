namespace FabricasRestaurantes
{
    public class RestauranteChino : RestauranteFactory
    {
        public override PlatoFuerte CrearPlatoFuerte() => new ChowMein();
        public override Bebida CrearBebida() => new TeJazmin();
        public override Postre CrearPostre() => new RollitoDulce();
    }

    class ChowMein : PlatoFuerte
    {
        public override string Servir() => "Chow Mein";
        public override double Costo => 85;
    }

    class TeJazmin : Bebida
    {
        public override string Servir() => "Té Jazmín";
    }

    class RollitoDulce : Postre
    {
        public override string Servir() => "Rollito dulce con nieve";
    }

    public class SalsaSoya : PlatilloDecorador
    {
        public SalsaSoya(PlatoFuerte platillo) : base(platillo) { }
        public override double Costo => _platillo.Costo + 10;
        public override string Servir() => $"{_platillo.Servir()}, Salsa Soya";
    }
    public class Pollo : PlatilloDecorador
    {
        public Pollo(PlatoFuerte platillo) : base(platillo) { }
        public override double Costo => _platillo.Costo + 40;
        public override string Servir() => $"{_platillo.Servir()}, Pollo";
    }
    public class Camaron : PlatilloDecorador
    {
        public Camaron(PlatoFuerte platillo) : base(platillo) { }
        public override double Costo => _platillo.Costo + 60;
        public override string Servir() => $"{_platillo.Servir()}, Camaron";
    }
}