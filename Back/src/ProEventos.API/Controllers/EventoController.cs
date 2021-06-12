using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
             new Evento(){
                EventoId = 1,
                Tema =  "Angular 11 e .NET 5",
                Local = "Araguaína",
                Lote = "1° Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
            },
            new Evento(){
                EventoId = 2,
                Tema =  "Novidades Angular 11 e .NET 5",
                Local = "Palmas",
                Lote = "2° Lote",
                QtdPessoas = 120,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "foto2.png"
            }
        };

        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Salvo Valores";
        }

        [HttpPut ("{id}")]
        public string Put(int id)
        {
            return $"Alterado Valores com ID = {id}";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Deletado Valores com ID = {id}";
        }
    }
}
