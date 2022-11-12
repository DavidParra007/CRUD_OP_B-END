using Data;
using Data.Interface;
using Entities;
using Entities._Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProspectoController : Controller
    {
        private ICRUD<Prospecto> _crud;
        public ProspectoController() {
            Context c = new Context();
            _crud = new CRUD<Prospecto>(c);
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Prospecto/{id}")]
        public IActionResult get(int id)
        {
            if (id == 0) return BadRequest("No ProspectoId provided");
            Prospecto usuario = _crud.Get(id);
            return Ok(usuario);
        }
        [HttpPost("Prospecto/add")]
        public IActionResult add([FromBody] Prospecto ProspectoData)
        {
            Prospecto l = _crud.getLast();
            if (l != null)
            {
                ProspectoData.Id = l.Id + 1;
            }
            else
            {
                ProspectoData.Id = 1;
            }
            
            _crud.Add(ProspectoData);
            return Ok();
            //return Ok(l);
        }
        [HttpPut("Prospecto/update")]
        public IActionResult edit([FromBody] Prospecto ProspectoData)
        {
            _crud.Update(ProspectoData);
            return Ok();
        }
        [HttpGet("Prospecto/all")]
        public IActionResult All()
        {
            IEnumerable<Prospecto> r = _crud.All();
            return Ok(r);
        }
        public IActionResult getRange()
        {
            return Ok("Not implemented!!");
        }
        [HttpDelete("Prospecto/del/{id?}")]
        public IActionResult remove(int id)
        {
            _crud.Delete(id);
            return Ok("eres bien cuerdita");
        }
        /*
        [HttpGet("Prospecto/last")]
        public IActionResult get(int id)
        {
            if (id == 0) return BadRequest("No ProspectoId provided");
            Prospecto usuario = _crud.Get(id);
            return Ok(usuario);
        }*/

    }
}
