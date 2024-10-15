using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StefamJativa_Semana4_Progrmacion4.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        public string Nombre { get; set; }

        [Range(0,110)]
        public int Edad { get; set; }

        [EmailAddress]
        public string Correo { get; set; }
        public Carrera Carrera { get; set; }
        [ForeignKey("Carrera")]
        public int IdCarrera { get; set; }

    }
}
