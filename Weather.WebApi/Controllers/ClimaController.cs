using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServicioClima.Datos.Modelo;

namespace Weather.WebApi.Controllers
{
    public class ClimaController : ApiController
    {
        AmericaVirtual_WeatherEntities db = new AmericaVirtual_WeatherEntities();
        /// <summary>
        /// Obtiene el clima dada un pais y una ciudad
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<ClimaPorPaisCiudad> Get(int IdPais, int IdCiudad)
        {
            var listado = db.ClimaPorPaisCiudad.Where(x => x.IdCiudad == IdCiudad.ToString() && x.IdPais == IdPais).ToList();
            return listado;
        }
    }
}
