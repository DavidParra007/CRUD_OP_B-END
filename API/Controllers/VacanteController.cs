using Data;
using Data.Interface;
using Entities;
using Entities._Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class VacanteController : Controller
    {
        private ICRUD<Vacante> _crud;
        public VacanteController() {
            Context c = new Context();
            _crud = new CRUD<Vacante>(c);
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Vacante/{id}")]
        public IActionResult get(int id)
        {
            if (id == 0) return BadRequest("No VacanteId provided");
            Vacante usuario = _crud.Get(id);
            return Ok(usuario);
        }
        [HttpPost("Vacante/add")]
        public IActionResult add([FromBody] Vacante VacanteData)
        {
            Vacante l = _crud.getLast();
            if (l != null)
            {
                VacanteData.Id = l.Id + 1;
            }
            else
            {
                VacanteData.Id = 1;
            }

            _crud.Add(VacanteData);
            return Ok();
        }
        [HttpPut("Vacante/update")]
        public IActionResult edit([FromBody] Vacante VacanteData)
        {
            _crud.Update(VacanteData);
            return Ok();
        }
        [HttpGet("Vacante/all")]
        public IActionResult All()
        {
            IEnumerable<Vacante> r = _crud.All();
            return Ok(r);
        }
        public IActionResult getRange()
        {
            return Ok("Not implemented!!");
        }
        [HttpDelete("Vacante/{id?}")]
        public IActionResult remove(int id)
        {
            _crud.Delete(id);
            return Ok();
        }

    }
}
