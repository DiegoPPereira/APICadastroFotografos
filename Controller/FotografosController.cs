using CadastroFotografo.Context;
using CadastroFotografo.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CadastroFotografo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FotografosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FotografosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Fotografo>> GetFotografos()
        {
            var fotografos = _context.Fotografos.ToList();
            if (fotografos.Count == 0)
            {
                return NotFound("Fotografos não encontrados...");
            }
            return fotografos;
        }

        [HttpGet("{id:int}", Name = "ObterFotofrafo")]
        public ActionResult<Fotografo> GetFotografo(int id)
        {
            var fotografo = _context.Fotografos.FirstOrDefault(f => f.FotografoId == id);

            if (fotografo is null)
            {
                return NotFound("Fotografo não encontrado...");
            }
            return fotografo;
        }

        [HttpPost]
        public ActionResult PostFotografo(Fotografo fotografo)
        {
            if (fotografo is null)
            {
                return BadRequest();

            }
            _context.Fotografos.Add(fotografo);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterFotofrafo",
                new { id = fotografo.FotografoId }, fotografo);
        }
        [HttpPut("{id:int}")]
        public ActionResult PutFotografo(int id, Fotografo fotografo)
        {
            if (id != fotografo.FotografoId)
            {
                return BadRequest();

            }

            _context.Entry(fotografo).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(fotografo);
        }
        [HttpDelete("{id:int}")]
        public ActionResult DeleteFotografo(int id)
        {
            var Fotografo = _context.Fotografos.FirstOrDefault(f => f.FotografoId == id);
            if (Fotografo is null)
            {
                return NotFound("Fotografo não Localizado...");
            }
            _context.Fotografos.Remove(Fotografo);
            _context.SaveChanges();

            return Ok(Fotografo);
        }
       
    }
         
}
