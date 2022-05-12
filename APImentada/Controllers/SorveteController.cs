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
    public class SorveteController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<InformacaoSorvete> Get()
        {
            List<InformacaoSorvete> saboresSorvetes = new List<InformacaoSorvete>();
            saboresSorvetes.Add(new InformacaoSorvete() { Sabor = "Baunilha", Doce = true, Gostoso = true, Vencido = false });
            saboresSorvetes.Add(new InformacaoSorvete() { Sabor = "Chocolate", Doce = true, Gostoso = true, Vencido = true });
            saboresSorvetes.Add(new InformacaoSorvete() { Sabor = "Napolitano", Doce = true, Gostoso = false, Vencido = true });
            saboresSorvetes.Add(new InformacaoSorvete() { Sabor = "Coco", Doce = true, Gostoso = true, Vencido = true });
            saboresSorvetes.Add(new InformacaoSorvete() { Sabor = "Vegano", Doce = false, Gostoso = false, Vencido = true });
            saboresSorvetes.Add(new InformacaoSorvete() { Sabor = "Avelã", Doce = true, Gostoso = true, Vencido = false });
            saboresSorvetes.Add(new InformacaoSorvete() { Sabor = "Amendoim", Doce = true, Gostoso = true, Vencido = false });
            saboresSorvetes.Add(new InformacaoSorvete() { Sabor = "Creme", Doce = true, Gostoso = true, Vencido = false });
            saboresSorvetes.Add(new InformacaoSorvete() { Sabor = "Morango", Doce = true, Gostoso = false, Vencido = false });
            saboresSorvetes.Add(new InformacaoSorvete() { Sabor = "Abacaxi com Uva Passas", Doce = true, Gostoso = false, Vencido = false });
            saboresSorvetes.Add(new InformacaoSorvete() { Sabor = "Limão", Doce = true, Gostoso = true, Vencido = false });

            return saboresSorvetes.AsEnumerable();


            //string[] sabores = new string[] { "Baunilha", "Chocolate", "Napolitano", "Coco", "Vegano", "Avelã", "Amendoim", "Creme", "Morango", "Abacaxi com Uva Passas", "Limão" };
            //return sabores.AsEnumerable();
        }
    }
}
