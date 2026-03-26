namespace FabricasRestaurantes
{
    public class RestauranteMexicano : RestauranteFactory
    {
        public override PlatoFuerte CrearPlatoFuerte() => new TacosCarneAsada();
        public override Bebida CrearBebida() => new AguaJamaica();
        public override Postre CrearPostre() => new PastelTresLeches();
    }

    class TacosCarneAsada : PlatoFuerte
    {
        public override string Servir() => "Tacos de carne asada";
        public override double Costo => 70;
    }

    class AguaJamaica : Bebida
    {
        public override string Servir() => "Agua de Jamaica";
    }

    class PastelTresLeches : Postre
    {
        public override string Servir() => "Pastel de tres leches";
    }
    public class Guacamole : PlatilloDecorador
    {
        public Guacamole(PlatoFuerte platillo) : base(platillo) { }
        public override double Costo => _platillo.Costo + 15;
        public override string Servir() => $"{_platillo.Servir()}, Guacamole";
    }
    public class ChileGuero : PlatilloDecorador
    {
        public ChileGuero(PlatoFuerte platillo) : base(platillo) { }
        public override double Costo => _platillo.Costo + 10;
        public override string Servir() => $"{_platillo.Servir()}, Chiles Gueros a la parrilla";
    }
    public class SalsaRoja : PlatilloDecorador
    {
        public SalsaRoja(PlatoFuerte platillo) : base(platillo) { }
        public override double Costo => _platillo.Costo + 5;
        public override string Servir() => $"{_platillo.Servir()}, Salsa Roja";
    }
} 