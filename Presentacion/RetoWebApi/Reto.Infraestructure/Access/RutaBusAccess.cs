using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto.Infraestructure
{
    class RutaBusAccess
    {
        public static List<RutaBus> ObtenerRutaBus()
        {

            using (var dbContextScope = new ViajesTerrestresEntities())
            {
                return dbContextScope.RutaBus.ToList();
            }
        }

        public static RutaBus CrearRutaBus(RutaBus rutaBus)
        {

            using (var dbContextScope = new ViajesTerrestresEntities())
            {
                var rutaBusIngresado = dbContextScope.RutaBus.Add(rutaBus);
                dbContextScope.SaveChanges();
                return rutaBusIngresado;
            }
        }
    }
}
