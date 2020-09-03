using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto.Infraestructure
{
    class PasajeroAccess
    {
        public static List<Pasajero> ObtenerPasajeros()
        {

            using (var dbContextScope = new ViajesTerrestresEntities())
            {
                return dbContextScope.Pasajero.ToList();
            }
        }

        public static Pasajero CrearPasajero(Pasajero pasajero)
        {

            using (var dbContextScope = new ViajesTerrestresEntities())
            {
                var pasajeroIngresado = dbContextScope.Pasajero.Add(pasajero);
                dbContextScope.SaveChanges();
                return pasajeroIngresado;

            }
        }
    }
}
