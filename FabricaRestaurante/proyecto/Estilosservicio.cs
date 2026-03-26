using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricasRestaurantes
{
    class ServicioMesa : IEstiloservicio
    {
        public string PrepararMesa() => "Mesa preparada con mantel y cubiertos";
        public string ServirPlatillo() => "Platillo servido en mesa por el mesero";
        public string CobrarCuenta() => "Cuenta presentada en mesa";
    }
}

namespace FabricasRestaurantes
{
    class ServicioParaLlevar : IEstiloservicio
    {
        public string PrepararMesa() => "Empaque preparado para llevar";
        public string ServirPlatillo() => "Platillo empacado en contenedor";
        public string CobrarCuenta() => "Pago en caja antes de retirar";
    }
}

namespace FabricasRestaurantes
{
    class ServicioExpress : IEstiloservicio
    {
        public string PrepararMesa() => "Pedido registrado para entrega express";
        public string ServirPlatillo() => "Platillo entregado en puerta";
        public string CobrarCuenta() => "Pago procesado en línea";
    }
}



