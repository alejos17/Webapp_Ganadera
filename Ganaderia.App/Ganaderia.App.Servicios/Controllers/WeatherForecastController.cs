﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;

namespace Ganaderia.App.Servicios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static IRepositorioGanadero _repoGanadero= new RepositorioGanadero(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario= new RepositorioVeterinario(new Persistencia.AppContext());
        
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //Recepcion de informacion desde backend
        [HttpGet]
        public IEnumerable<Ganadero> Get()
        {
            var ganaderos = _repoGanadero.GetAllGanaderos();
            return ganaderos;

        }

        //Enviar datos al backend
        //Debe ser un unico POST por controllador que envie todo....
        [HttpPost]
        public ActionResult<string> Post(string metodo)
        {
            if (metodo.Equals("Agregar"))
            {
                
            } else if (metodo.Equals("Editar"))
            {
                
            }
            return Ok("Peticion recibida");
        }
    }
}
