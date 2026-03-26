namespace FabricasRestaurantes
{
    public class RestauranteJapones : RestauranteFactory
    {
        public override PlatoFuerte CrearPlatoFuerte() => new Ramen();
        public override Bebida CrearBebida() => new Sake();
        public override Postre CrearPostre() => new Dango();
    }

    class Ramen : PlatoFuerte
    {
        public override string Servir() => "Ramen";
        public override double Costo => 90;
    }

    class Sake : Bebida
    {
        public override string Servir() => "Sake";
    }

    class Dango : Postre
    {
        public override string Servir() => "Dango";
    }

    public class HuevoCocido : PlatilloDecorador
    {
        public HuevoCocido(PlatoFuerte platillo) : base(platillo) { }
        public override double Costo => _platillo.Costo + 10;
        public override string Servir() => $"{_platillo.Servir()}, HuevoCocido";
    }
    public class ChasuPork : PlatilloDecorador
    {
        public ChasuPork(PlatoFuerte platillo) : base(platillo) { }
        public override double Costo => _platillo.Costo + 25;
        public override string Servir() => $"{_platillo.Servir()}, ChasuPork";
    }
    public class Nori : PlatilloDecorador
    {
        public Nori(PlatoFuerte platillo) : base(platillo) { }
        public override double Costo => _platillo.Costo + 8;
        public override string Servir() => $"{_platillo.Servir()}, Nori";
    }
}