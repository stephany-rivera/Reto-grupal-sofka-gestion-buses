using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto.Infraestructure
{
    class MunicipioAccess
    {
        public static List<Municipio> ObtenerMunicipios()
        {

            using (var dbContextScope = new ViajesTerrestresEntities())
            {
                return dbContextScope.Municipio.ToList();
            }
        }

        public static Municipio CrearMunicipio(Municipio municipio)
        {

            using (var dbContextScope = new ViajesTerrestresEntities())
            {
                var municipioIngresado = dbContextScope.Municipio.Add(municipio);
                dbContextScope.SaveChanges();
                return municipioIngresado;
            }
        }
    }
}
