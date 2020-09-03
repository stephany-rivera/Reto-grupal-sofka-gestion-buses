using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto.Infraestructure
{
    class BusAccess
    {
        public static List<Bus> ObtenerBus()
        {

            using (var dbContextScope = new ViajesTerrestresEntities())
            {
                return dbContextScope.Bus.ToList();
            }
        }

        public static Bus CrearBus(Bus bus)
        {

            using (var dbContextScope = new ViajesTerrestresEntities())
            {
                var busIngresado = dbContextScope.Bus.Add(bus);
                dbContextScope.SaveChanges();
                return busIngresado;
            }
        }
    }
}
