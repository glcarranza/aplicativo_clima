using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServicioClima.Datos.Modelo;

namespace Weather.WebApi.Controllers
{
    public class PaisController : ApiController
    {
        AmericaVirtual_WeatherEntities db = new AmericaVirtual_WeatherEntities();
        [HttpGet]
        public IEnumerable<Paises> Get()
        {
            var listado = db.Paises.ToList();
            return listado;
        }
    }
}
