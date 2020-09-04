using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto.Infraestructure.Access
{
    public class BusAccess
    {
        public static List<Bus> ObtenerBuses()
        {

            using (var dbContextScope = new ViajesTerrestresEntities())
            {
                return dbContextScope.Bus.ToList();
            }
        }

        public static Bus ObtenerBus(int id)
        {

            using (var dbContextScope = new ViajesTerrestresEntities())
            {
                
                return dbContextScope.Bus.Where(x => x.BusId == id).FirstOrDefault();
            }
        }

        public static Bus ActualizarBus(Bus bus)
        {

            using (var dbContextScope = new ViajesTerrestresEntities())
            {

                var resultado = dbContextScope.Bus.Where(x => x.BusId == bus.BusId).FirstOrDefault();
                resultado.CapacidadActual = bus.CapacidadActual;
                dbContextScope.SaveChanges();
                return resultado;
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
