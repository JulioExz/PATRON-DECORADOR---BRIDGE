using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricasRestaurantes
{
    public abstract class RestauranteBase
    {
        protected IEstiloservicio _estiloServicio;

        public RestauranteBase(IEstiloservicio estiloServicio)
        {
            _estiloServicio = estiloServicio;
        }

        public string PrepararMesa()
        {
            return _estiloServicio.PrepararMesa();
        }

        public string ServirPlatillo()
        {
            return _estiloServicio.ServirPlatillo();
        }

        public string CobrarCuenta()
        {
            return _estiloServicio.CobrarCuenta();
        }


        public void AsignarServicio(IEstiloservicio estiloServicio)
        {
            _estiloServicio = estiloServicio;
        }

        public IEstiloservicio ObtenerServicio()
        {
            return _estiloServicio;
        }
    }
}


