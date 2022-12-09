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
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
       
        public EventoController()
        {
            
        }
        public IEnumerable<Evento> _eventos = new Evento[]{
            new Evento(){
                EventoId =1,
                Tema = "Angular 11 e .NET 5",
                Local = "São Paulo",
                Lote = "1º Lote",
                QtdPessoas =250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemUrl ="foto.png"
            },
             new Evento(){
                EventoId =2,
                Tema = "Angular 13 e .NET 6",
                Local = "São Paulo",
                Lote = "1º Lote",
                QtdPessoas =350,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemUrl ="perfil.png"
            }
        };
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _eventos;
        }
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        { 
            return _eventos.Where(evento => evento.EventoId==id); 
        }
        
    }
}
