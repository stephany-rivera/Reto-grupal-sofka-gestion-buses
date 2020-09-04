using AutoMapper;
using Reto.Infraestructure;
using Reto.Services.Models;

namespace Reto.Services.Utilities
{
    public static class ConfigAutomapper
    {
        public static IMapper mapper { get; set; }
        public static void Config()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MunicipioModel, Municipio>();

                //INVERSO				
                cfg.CreateMap<Municipio, MunicipioModel>();

            });
            mapper = config.CreateMapper();
        }
    }
}
