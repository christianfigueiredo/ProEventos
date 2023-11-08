using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.Domain;
using ProEventos.Persistence;
using ProEventos.Persistence.Contextos;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {          
        // retorno de ss de forma estatica

       /*  public IEnumerable<Evento> _evento = new Evento[]
            {
                new Evento()
                {
                    EventoId = 1,
                    Tema = "Angular 11 e .NET 6",
                    Local = "Belo Horizonte",
                    Lote = "1o Lote",
                    QtdPessoas = 250,
                    Telefone = "12345678",
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemURL = "foto.png"
                },
                new Evento()
                {
                    EventoId = 2,
                    Tema = "Angular e suas novidades",
                    Local = "São Paulo",
                    Lote = "2o Lote",
                    QtdPessoas = 350,
                    Telefone = "12345678",
                    DataEvento = DateTime.Now.AddDays(3).ToString(),
                    ImagemURL = "foto2.png"
                },

                new Evento()
                {
                    EventoId = 3,
                    Tema = "Angular e suas novidades",
                    Local = "São Paulo",
                    Lote = "3o Lote",
                    QtdPessoas = 450,
                    Telefone = "12345678",
                    DataEvento = DateTime.Now.AddDays(4).ToString(),
                    ImagemURL = "foto3.png"
                }

            }; */
        
        private readonly ProEventosContext _context;
        public EventosController(ProEventosContext context)
        {
           _context = context;
        }
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;           
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.Id == id);           
        }
        [HttpPost]
        public string Post()
        {
            return "Exemplo Post";
           
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo Put com id = {id}";
           
        }

         [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo Delete com id = {id}";
           
        }
    }
}
