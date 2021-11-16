using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amazonia.DAL.Modelo
{
    public abstract class Entidade
    {
        //[Key] // Desnecessário já que estamos optar por usar o mecanismo de convenção
        //[Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        //[MinLength(10)]
        [MaxLength(255)]
        public string Nome { get; set; }
    }
}
