namespace FabricasRestaurantes
{
    public class RestauranteItaliano : RestauranteFactory
    {
        public override PlatoFuerte CrearPlatoFuerte() => new Pasta();
        public override Bebida CrearBebida() => new VinoTinto();
        public override Postre CrearPostre() => new Tiramisu();
    }

    class Pasta : PlatoFuerte
    {
        public override string Servir() => "Pasta";
        public override double Costo => 95;
    }

    class VinoTinto : Bebida
    {
        public override string Servir() => "Vino tinto";
    }

    class Tiramisu : Postre
    {
        public override string Servir() => "Tiramisú";
    }

    public class QuesoParmesano : PlatilloDecorador
    {
        public QuesoParmesano(PlatoFuerte platillo) : base(platillo) { }
        public override double Costo => _platillo.Costo + 18;
        public override string Servir() => $"{_platillo.Servir()}, Queso parmesano";
    }
    public class Albahaca : PlatilloDecorador
    {
        public Albahaca(PlatoFuerte platillo) : base(platillo) { }
        public override double Costo => _platillo.Costo + 7;
        public override string Servir() => $"{_platillo.Servir()}, Albahaca";
    }
    public class PepperoniExtra : PlatilloDecorador
    {
        public PepperoniExtra(PlatoFuerte platillo) : base(platillo) { }
        public override double Costo => _platillo.Costo + 22;
        public override string Servir() => $"{_platillo.Servir()}, Pepperoni extra";
    }
}