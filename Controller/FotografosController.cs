using CadastroFotografo.Context;
using CadastroFotografo.Model;
using Microsoft.AspNetCore.Mvc;

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

        public IEnumerable<Fotografo> Get()
        {
        }

    }
}

