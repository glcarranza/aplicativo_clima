using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherApp.Models
{
    public class ClimaVista
    {
        public List<Paises> PaisesList { get; set; }
        public List<Ciudades> CiudadesList { get; set; }
        public List<ClimaPorPaisCiudad> ClimaList { get; set; }
    }
}