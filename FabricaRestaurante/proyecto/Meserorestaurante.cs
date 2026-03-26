using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricasRestaurantes
{
    class MeseroRestaurante : RestauranteBase
    {
        private string _nombreRestaurante;

        public MeseroRestaurante(string nombreRestaurante) : base(new ServicioMesa())
        {
            _nombreRestaurante = nombreRestaurante;
        }


        public MeseroRestaurante(string nombreRestaurante, IEstiloservicio estiloServicio) : base(estiloServicio)
        {
            _nombreRestaurante = nombreRestaurante;
        }

        public string NombreRestaurante()
        {
            return "Atendiendo en: Restaurante " + _nombreRestaurante;
        }
    }
}


