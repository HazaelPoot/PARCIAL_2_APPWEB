using System;
using Microsoft.AspNetCore.Mvc;
using AlcoholemiaApp.Domain.Entities;
using AlcoholemiaApp.Domain.Interfaces;

namespace AlcoholemiaApp.Controller
{
    [Route("api/[controller]")]
    public class AlcoholController : ControllerBase
    {
        [HttpGet]
        [Route("{consumo}/{cantidad}/{mililitro}/{alcohol}/{peso}/{edad}")]
        public IActionResult CalcularConsumo( double cantidad, double mililitro, double alcohol, double peso, double edad)
        {
            var consumo = new Consumo();
            consumo.Calcular(cantidad, mililitro, alcohol, peso, edad);
            var resultado = consumo.RetornarResultados();
            return Ok($"Una persona de {edad} años con un peso de {peso} kg, durante la cena ingirio {cantidad} cervezas de {mililitro} ml con un {alcohol}° de alcohol: tiene una cantidad de {resultado}g/l de alcohol en la sangre");
        }
    }
}