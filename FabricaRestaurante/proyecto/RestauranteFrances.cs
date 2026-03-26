namespace FabricasRestaurantes
{
    public class RestauranteFrances : RestauranteFactory
    {
        public override PlatoFuerte CrearPlatoFuerte() => new CoqAuVin();
        public override Bebida CrearBebida() => new Champan();
        public override Postre CrearPostre() => new CremeBrulee();
    }

    class CoqAuVin : PlatoFuerte
    {
        public override string Servir() => "Coq au Vin";
        public override double Costo => 130;
    }

    class Champan : Bebida
    {
        public override string Servir() => "Champán";
    }

    class CremeBrulee : Postre
    {
        public override string Servir() => "Crème Brûlée";
    }

    public class Champis : PlatilloDecorador
    {
        public Champis(PlatoFuerte platillo) : base(platillo) { }
        public override double Costo => _platillo.Costo + 20;
        public override string Servir() => $"{_platillo.Servir()}, Champiñones";
    }
    public class HierbasFinas : PlatilloDecorador
    {
        public HierbasFinas(PlatoFuerte platillo) : base(platillo) { }
        public override double Costo => _platillo.Costo + 12;
        public override string Servir() => $"{_platillo.Servir()}, HierbasFinas";
    }
    public class SalsaVino : PlatilloDecorador
    {
        public SalsaVino(PlatoFuerte platillo) : base(platillo) { }
        public override double Costo => _platillo.Costo + 28;
        public override string Servir() => $"{_platillo.Servir()}, Salsa de vino";
    }
}