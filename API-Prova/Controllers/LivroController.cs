using System.Collections.Generic;
using API_Prova.Data;
using API_Prova.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace API_Prova.Controllers

{


    [ApiController]
    [Route("caminho/Livro")]

    public class LivroController : ControllerBase

    {
        
        private readonly DataContext _context;

        
        public LivroController(DataContext context) => _context = context;

        //POST/api/Livro/create

        [HttpPost]
        [Route("create")]


        public IActionResult Create([FromBody] Livro livro)
        {

            _context.Livros.Add( livro );
            _context.SaveChanges();
            return Created( "", livro );
            
        }

        //GET/api/Livro/list

        [HttpGet]
        [Route("list")]


        public List<Livro> list() => _context.Livros.ToList();
    }
}