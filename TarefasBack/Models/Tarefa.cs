using System;
using System.ComponentModel.DataAnnotations;

namespace TarefasBack.Models
{
    public class Tarefa 
    {

        public Guid id {get;set;}
        public Guid UsuarioId {get;set;}
        
        [Required]
        public string Nome {get;set;}
        public bool Concluida {get;set;}



    }


}