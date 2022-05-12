using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APImentada.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BebidaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<InformacaoBebida> Get()
        {
            List<InformacaoBebida> saboresBebida = new List<InformacaoBebida>();
            saboresBebida.Add(new InformacaoBebida() {tipo = "cerveja", marca = "brahma", sabor = "trigo", leve = true, alcoolica = true, escura = false });
            saboresBebida.Add(new InformacaoBebida() {tipo = "whisky", marca = "Royal Salute", sabor = "amadeirado", leve = false, alcoolica = true, escura = true });
            saboresBebida.Add(new InformacaoBebida() {tipo = "refrigerante", marca = "pepsi", sabor = "doce", leve = true, alcoolica = false, escura = true });
            saboresBebida.Add(new InformacaoBebida() {tipo = "vodka", marca = "absolut", sabor = "Coco", leve = false, alcoolica = true, escura = false });
            saboresBebida.Add(new InformacaoBebida() {tipo = "cerveja", marca = "heineken", sabor = "milho", leve = false, alcoolica = true, escura = false });
            saboresBebida.Add(new InformacaoBebida() {tipo = "rum", marca = "montilla", sabor = "Avelã", leve = true, alcoolica = true, escura = true });
            saboresBebida.Add(new InformacaoBebida() {tipo = "cha", marca = "leao", sabor = "Amendoim", leve = true, alcoolica = false, escura = true });
            saboresBebida.Add(new InformacaoBebida() {tipo = "whisky", marca = "chivas", sabor = "amargo", leve = false, alcoolica = true, escura = true });
            saboresBebida.Add(new InformacaoBebida() {tipo = "agua", marca = "h2o", sabor = "limao", leve = true, alcoolica = false, escura = false });
            saboresBebida.Add(new InformacaoBebida() {tipo = "suco", marca = "maguary", sabor = "Abacaxi com Uva Passas", leve = true, alcoolica = false, escura = false });
            saboresBebida.Add(new InformacaoBebida() {tipo = "cachaca", marca = "pirassununga", sabor = "Limão", leve = false, alcoolica = true, escura = false });

            return saboresBebida.AsEnumerable();


            //string[] sabores = new string[] { "Baunilha", "Chocolate", "Napolitano", "Coco", "Vegano", "Avelã", "Amendoim", "Creme", "Morango", "Abacaxi com Uva Passas", "Limão" };
            //return sabores.AsEnumerable();
        }
    }
}
