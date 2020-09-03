using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto.Infraestructure
{
    class RutaAccess
    {
        public static List<Ruta> ObtenerRuta()
        {

            using (var dbContextScope = new ViajesTerrestresEntities())
            {
                return dbContextScope.Ruta.ToList();
            }
        }

        public static Ruta CrearRuta(Ruta ruta)
        {

            using (var dbContextScope = new ViajesTerrestresEntities())
            {
                var rutaIngresada = dbContextScope.Ruta.Add(ruta);
                dbContextScope.SaveChanges();
                return rutaIngresada;

            }
        }
    }
}
