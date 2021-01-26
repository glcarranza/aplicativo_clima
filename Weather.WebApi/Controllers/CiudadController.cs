using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServicioClima.Datos.Modelo;

namespace Weather.WebApi.Controllers
{
    public class CiudadController : ApiController
    {
        AmericaVirtual_WeatherEntities db = new AmericaVirtual_WeatherEntities();
        [HttpGet]
        public IEnumerable<Ciudades> Get(int IdPais)
        {
            var ciudades = db.Ciudades.Where(x => x.IdPais == IdPais).ToList();
            return ciudades;
        }
    }
}
