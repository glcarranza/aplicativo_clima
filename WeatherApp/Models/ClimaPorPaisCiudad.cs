using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherApp.Models
{
    public class ClimaPorPaisCiudad
    {

      
            public int IdClima { get; set; }
            public int IdPais { get; set; }
            public string IdCiudad { get; set; }
            public string Dia { get; set; }
            public string Temperatura_grados_c { get; set; }
            public string Temperatura_grados_f { get; set; }
            public string Prob_precip { get; set; }
            public string Humedad { get; set; }
            public string Viento { get; set; }
            public string Icono { get; set; }
     

    }
}