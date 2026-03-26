using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricasRestaurantes
{
    public abstract class PlatilloDecorador : PlatoFuerte
    {
        protected PlatoFuerte _platillo;

        public PlatilloDecorador(PlatoFuerte platillo)
        {
            _platillo = platillo;
        }

        public override string Servir() => _platillo.Servir();
        public override double Costo => _platillo.Costo;
    }
}
