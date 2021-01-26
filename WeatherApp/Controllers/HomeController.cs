using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using WeatherApp.Models;
using System.Web.Configuration;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetPaises()
        {
            string urlServicio = WebConfigurationManager.AppSettings["urlServicio"];
            var result = DAL.DataAccess.setConnection(urlServicio, "api/Pais");
            var listaPaises = JsonConvert.DeserializeObject<List<Paises>>(result);
            return Json(listaPaises, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetCiudades(int idPais)
        {
            string urlServicio = WebConfigurationManager.AppSettings["urlServicio"];
            var result = DAL.DataAccess.setConnection(urlServicio, "api/Ciudad?IdPais=" + idPais);
            var listaCiudades = JsonConvert.DeserializeObject<List<Ciudades>>(result);
            return Json(listaCiudades, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetClimaPorPaisCiudad(int idPais, int idCiudad)
        {
            string urlServicio = WebConfigurationManager.AppSettings["urlServicio"];
            var result = DAL.DataAccess.setConnection(urlServicio, "api/Clima?IdPais=" + idPais + "&IdCiudad=" + idCiudad);
            var listaCiudades = JsonConvert.DeserializeObject<List<ClimaPorPaisCiudad>>(result);
            return Json(listaCiudades, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}