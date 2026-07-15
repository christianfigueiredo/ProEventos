using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventosController : ControllerBase
{   
    private readonly DbContexto _contexto;

    public EventosController(DbContexto contexto)
    {
        _contexto = contexto;
    }

    /* public IEnumerable<Evento> _evento = new Evento [] 
        {
            new Evento(){
            EventoId = 1,
            Tema = "Angular e .Net 5",
            Local = "Belo Horizonte",
            Lote = "1 Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(3).ToString(),
            ImagemURL = "foto.png"
            },
            new Evento(){
             EventoId = 2,
            Tema = "Angular e .Net 5",
            Local = "Rio de Janeiro",
            Lote = "1 Lote",
            QtdPessoas = 150,
            DataEvento = DateTime.Now.AddDays(10).ToString(),
            ImagemURL = "foto2.png"
        }

        }; */

    [HttpGet]
    public IEnumerable<Evento>  GetEventos()
    {
        return _contexto.Eventos!;               
       
    }

    [HttpGet("{id}")]
   public Evento  GetById(int id)
    {
        return _contexto.Eventos!.First(evento => evento.EventoId == id);
       
    }

    [HttpPost]
    public string Post()
    {
        return "Exemplo de Post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Exemplo de Put {id}";
    }

     [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Exemplo de Delete {id}";
    }
}
