using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.API.Models
{
    public class Evento
    {
          [Key]
        public int EventoId { get; set; }
        public string Local { get; set; }
        public string Tema { get; set; }
        public string DataEvento { get; set; }
        public int QtdePessoas { get; set; }
        public string Lote { get; set; }
        public string ImagemURL { get; set; }
    }
}