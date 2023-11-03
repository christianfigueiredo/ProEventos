using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {          
        public IEnumerable<Evento> _evento = new Evento[]
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
