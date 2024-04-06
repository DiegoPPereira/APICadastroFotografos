using CadastroFotografo.Context;
using CadastroFotografo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadastroFotografo.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VisitasController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet("fotografos")]
        public ActionResult<IEnumerable<Visita>> GetVisitasFotografos()
        {
            var visitas = _context.Visitas.Include(v => v.Fotografo).ToList();
            return visitas;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Visita>> GetVisitas()
        {
            var visitas = _context.Visitas.ToList();
            if (visitas.Count == 0)
            {
                return NotFound("Nenhuma visita encontrada...");
            }
            return visitas;
        }

        [HttpGet("{id:int}", Name = "ObterVisitas")]
        public ActionResult<Visita> GetVisita(int id)
        {
            var visita = _context.Visitas.FirstOrDefault(f => f.VisitaId == id);

            if (visita is null)
            {
                return NotFound("Visita não encontrada...");
            }
            return visita;
        }
        [HttpPost]
        public ActionResult PostVisita(Visita visita)
        {
            if (visita is null)
            {
                return BadRequest();

            }
            _context.Visitas.Add(visita);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterVisita",
                new { id = visita.VisitaId }, visita);
        }
        [HttpPut("{id:int}")]
        public ActionResult PutVisita(int id, Visita visita)
        {
            if (id != visita.VisitaId)
            {
                return BadRequest();

            }

            _context.Entry(visita).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(visita);
        }
        [HttpDelete("{id:int}")]
        public ActionResult DeleteVisita(int id)
        {
            var Visita = _context.Visitas.FirstOrDefault(V => V.VisitaId == id);
            if (Visita is null)
            {
                return NotFound("Visita não Localizado...");
            }
            _context.Visitas.Remove(Visita);
            _context.SaveChanges();

            return Ok(Visita);
        }
    }
}